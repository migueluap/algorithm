using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void twoNumberSumTest()
        {
            // Arrange
            int[] arrayInput = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;

            // Act
            int[] arrayActual = Program.twoNumberSum(arrayInput, targetSum);

            // Assert
            int[] arrayExpected = { -1, 11 };
            Assert.AreEqual(arrayExpected, arrayActual);
        }
    }
}