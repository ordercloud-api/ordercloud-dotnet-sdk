using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderCloud.SDK
{
	/// <summary>
	/// An object used to fluently build a set of optional parameters to send in a GET request against a list endpoint.
	/// </summary>
	public class ListOptionsBuilder<T>
	{
		private readonly ListOptions _opts = new ListOptions();
		private readonly List<string> _searchOn = new List<string>();
		private readonly List<string> _sortBy = new List<string>();

		/// <summary>
		/// Specify a word or phrase to search for.
		/// </summary>
		public ListOptionsBuilder<T> SearchFor(string phrase) {
			_opts.Search = phrase;
			return this;
		}

		/// <summary>
		/// Add one or more properties to apply the search phrase.
		/// </summary>
		public ListOptionsBuilder<T> SearchOn(params Expression<Func<T, object>>[] properties) {
			_searchOn.AddRange(properties.Select(p => GetPropertyInfo(p.Body).Name));
			return this;
		}

		/// <summary>
		/// Add one or more properties to sort by.
		/// </summary>
		public ListOptionsBuilder<T> SortBy(params Expression<Func<T, object>>[] properties) {
			_sortBy.AddRange(properties.Select(p => GetPropertyInfo(p.Body).Name));
			return this;
		}

		/// <summary>
		/// Add one or more properties to sort by in descending order.
		/// </summary>
		public ListOptionsBuilder<T> SortByReverse(params Expression<Func<T, object>>[] properties) {
			_sortBy.AddRange(properties.Select(p => "!" + GetPropertyInfo(p.Body).Name));
			return this;
		}

		/// <summary>
		/// Specify which page of results to return. 1-based.
		/// </summary>
		public ListOptionsBuilder<T> Page(int page) {
			_opts.Page = page;
			return this;
		}

		/// <summary>
		/// Specify number of items per page. Default: 20, max: 100.
		/// </summary>
		public ListOptionsBuilder<T> PageSize(int size) {
			_opts.PageSize = size;
			return this;
		}

		/// <summary>
		/// Add a filter expression. Can contain operators such as ==, &lt;, &gt;, etc. Left side of expression must specify a property, right side
		/// must evaluate a value. i.e. order => order.Subtotal > 100
		/// </summary>
		public ListOptionsBuilder<T> AddFilter(Expression<Func<T, bool>> predicate) {
			foreach (var kv in ParseFilters(predicate.Body))
				_opts.Filters.Add(kv);
			return this;
		}

		public ListOptions Build() {
			if (_searchOn.Any())
				_opts.SearchOn = string.Join(",", _searchOn);
			if (_sortBy.Any())
				_opts.SortBy = string.Join(",", _sortBy);
			return _opts;
		}

		private PropertyInfo GetPropertyInfo(Expression exp) {
			if (exp is UnaryExpression ue)
				exp = ue.Operand;

			if (exp is MemberExpression me && me.Member is PropertyInfo pi)
				return pi;

			return null;
		}

		private IEnumerable<KeyValuePair<string, string>> ParseFilters(Expression exp) {
			switch (exp.NodeType) {
				case ExpressionType.And:
				case ExpressionType.AndAlso:
					foreach (var kv in ParseFilters((exp as BinaryExpression).Left))
						yield return kv;
					foreach (var kv in ParseFilters((exp as BinaryExpression).Right))
						yield return kv;
					break;
				case ExpressionType.Or:
				case ExpressionType.OrElse:
					var kv1 = ParseFilters((exp as BinaryExpression).Left);
					var kv2 = ParseFilters((exp as BinaryExpression).Right);
					var keys = kv1.Concat(kv2).Select(kv => kv.Key).Distinct().ToList();

					if (keys.Count > 1)
						throw new FilterExpressionException(exp, FilterExpressionErrorMessages.UNSUPPORTED_OR_CLAUSE);

					var value = string.Join("|", kv1.Concat(kv2).Select(kv => kv.Value).Distinct());
					yield return new KeyValuePair<string, string>(keys[0], value);
					break;
				case ExpressionType.MemberAccess:
					var prop = GetPropertyInfo(exp);
					if (prop == null)
						throw new FilterExpressionException(exp, FilterExpressionErrorMessages.LEFT_MUST_BE_PROPERTY);
					var key = string.Join(".", ((MemberExpression)exp).ToString().Split('.').Skip(1));

					yield return new KeyValuePair<string, string>(key, "true");
					break;
				case ExpressionType.Not:
					var inner = ParseFilters(((UnaryExpression)exp).Operand).ToList();
					if (inner.Count != 1)
						throw new FilterExpressionException(exp, FilterExpressionErrorMessages.UNSUPPORTED_EXPRESSION);
					yield return new KeyValuePair<string, string>(inner[0].Key, Negate(inner[0].Value));
					break;
				default:
					yield return GetFilterKV(exp as BinaryExpression);
					break;
			}
		}

		private string Negate(string value) =>
			(value == null) ? "*" :
			value.StartsWith("!") ? value.TrimStart('!') :
			"!" + value;

		private KeyValuePair<string, string> GetFilterKV(BinaryExpression exp) {
			var prop = GetPropertyInfo(exp.Left);
			if (prop == null)
				throw new FilterExpressionException(exp.Left, FilterExpressionErrorMessages.LEFT_MUST_BE_PROPERTY);
			var key = string.Join(".", ((MemberExpression)exp.Left).ToString().Split('.').Skip(1));

			var prefix = GetFilterValuePrefix(exp);

			object value = null;
			try {
				value = Expression.Lambda(exp.Right).Compile().DynamicInvoke();
			}
			catch (InvalidOperationException) {
				throw new FilterExpressionException(exp.Right, FilterExpressionErrorMessages.RIGHT_MUST_BE_VALUE);
			}
			
			return new KeyValuePair<string, string>(key, $"{prefix}{value}");
		}

		private string GetFilterValuePrefix(BinaryExpression exp) {
			switch (exp.NodeType) {
				case ExpressionType.Equal: return "";
				case ExpressionType.LessThan: return "<";
				case ExpressionType.GreaterThan: return ">";
				case ExpressionType.GreaterThanOrEqual: return "!<";
				case ExpressionType.LessThanOrEqual: return "!>";
				case ExpressionType.NotEqual: return "!";
				default: throw new FilterExpressionException(exp, FilterExpressionErrorMessages.UNSUPPORTED_EXPRESSION);
			}
		}
	}
}
