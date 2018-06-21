using System;
using TrianglesSorterApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_TrianglesSorterApp
{
    [TestClass]
    public class Test_TrianglesSorter
    {
        public TrianglesSorter tr;

        [TestMethod]
        public void InitializeTriangle()
        {
            tr = new TrianglesSorter();
            tr.a = 4.5;
            tr.b = 5;
            tr.c = 6;
        }

        [TestMethod]
        public void Test_Area()
        {
            int expectedResult = 11;
            InitializeTriangle();

            Assert.AreEqual(expectedResult, (int)tr.Area());
        }
               
    }
}
