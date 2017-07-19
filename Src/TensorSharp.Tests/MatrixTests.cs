﻿namespace TensorSharp.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void CreateIntegerMatrix()
        {
            var matrix = new Matrix<int>(2, 3);

            Assert.AreEqual(2, matrix.Rank);
            Assert.IsNotNull(matrix.Shape);
            Assert.IsTrue(matrix.Shape.SequenceEqual(new int[] { 2, 3 }));
        }
    }
}
