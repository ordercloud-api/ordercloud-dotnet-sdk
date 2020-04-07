using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderCloud.SDK
{
	public class FilterExpressionException : Exception
	{
		public FilterExpressionException(Expression exp, string message) : base($"Invalid list filter expression. {message}") {
			Expression = exp.ToString();
		}

		public string Expression { get; }
	}

	public static class FilterExpressionErrorMessages
	{
		public const string LEFT_MUST_BE_PROPERTY = "Left side of binary expression must be a single property, i.e. x.foo == 10.";
		public const string RIGHT_MUST_BE_VALUE = "Right side of binary expression must evaluate to a constant value.";
		public const string UNSUPPORTED_OR_CLAUSE = "|| operator can only be used with checks against the same property, i.e. x.foo == 1 || x.foo == 2.";
		public const string UNSUPPORTED_EXPRESSION = "Expressions can only contain property comparisons with ==, !=, <, >, <=, >=, and &&. || is supported only when testing for multiple values of the same property.";
	}
}
