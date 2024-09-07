using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFigure.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFigure.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetHalfPerTest_MustReturnCorrectValue()
        {
            var triangle = new Triangle(new Parameters.Line(3), new Parameters.Line(4), new Parameters.Line(2));
            Assert.IsTrue(4.5 == triangle.HalfPer);        
        }

        [TestMethod()]
        public void GetAreaTest_MustReturnCorrectValue()
        {
            var triangle = new Triangle(new Parameters.Line(3), new Parameters.Line(4), new Parameters.Line(2));
            Assert.IsTrue(2.9 == triangle.GetArea());
        }
    }
}