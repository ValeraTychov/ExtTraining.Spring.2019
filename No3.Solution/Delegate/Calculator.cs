using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.Delegate
{
    public delegate double CalcMethod(List<double> values);

    public class Calculator
    {
        public double CalculateAverage(List<double> values, CalcMethod method)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            if (method == null)
            {
                throw new ArgumentException("Invalid method value");
            }

            return method(values);
        }
    }
}
