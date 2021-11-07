using System;
using System.Collections.Generic;

namespace Logic
{
    public class Calculator
    {

		private delegate double OperationDelegate(double x, double y); // delegate
		private Dictionary<string, OperationDelegate> _operations; // event

        public Calculator()
		{
			_operations =
				new Dictionary<string, OperationDelegate>
				{
					{ "+", this.DoAddition },
					{ "-", this.DoSubtraction },
					{ "*", this.DoMultiplication },
					{ "/", this.DoDivision },
				};
		}

		public double PerformOperation(string op, double x, double y)
		{
			if (!_operations.ContainsKey(op))
				throw new ArgumentException(string.Format($"Operation {op} is invalid"), "op");
			return _operations[op](x, y);
		}

		private double DoDivision(double x, double y) { return x / y; }
		private double DoMultiplication(double x, double y) { return x * y; }
		private double DoSubtraction(double x, double y) { return x - y; }
		private double DoAddition(double x, double y) { return x + y; }


	}
}
