﻿using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] actual = Generator.Generate<int>(1, 1, (a, b) => b + a).Take(10).ToArray();

            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] actual = Generator.Generate<int>(1, 2, (a, b) => b * 2).Take(10).ToArray();

            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            string[] actual = Generator.Generate<double>(1.0, 2.0, (a, b) => b + a / b).Select(d => string.Format("{0:.##############}", d)).Take(10).ToArray();

            double[] result = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            string[] expected = result.Select(d => string.Format("{0:.##############}", d)).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}