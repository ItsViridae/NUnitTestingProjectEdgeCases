using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestHomework00.Core.Tests.Common
{
    public static class TestHelpers
    {
        public static void ShouldBeGreaterThan(this int actual, int expected)
        {
            Assert.Greater(actual, expected);
        }
        public static void ShouldBeLessThan(this int actual, int expected)
        {
            Assert.Less(actual, expected);
        }
        public static void ShouldBeGreaterThan(this double actual, double expected)
        {
            Assert.Greater(actual, expected);
        }
        public static void ShouldBeLessThan(this double actual, double expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBe(this int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe(this int actual, int expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBe(this double actual, double expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe(this double actual, double expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBe(this decimal actual, decimal expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe(this decimal actual, decimal expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBe(this string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe(this string actual, string expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBe(this float actual, float expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe(this float actual, float expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBe(this bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe(this bool actual, bool expected)
        {
            Assert.AreNotEqual(expected, actual);
        }
    }
}
