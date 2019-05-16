﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No3.Solution.Delegate.Tests
{
    [TestFixture]
    public class TestDelegateCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };
        Calculator calculator = new Calculator();

        [Test]
        public void Test_AverageByMean()
        {
            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, AverageMethodFactory.Get(AveragingMethod.Mean));

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, AverageMethodFactory.Get(AveragingMethod.Median));

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
