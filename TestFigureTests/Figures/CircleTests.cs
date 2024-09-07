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
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTestGetAreaTest_MustReturnCorrectValue()
        {
            var circle = new Circle(new Parameters.Line(5));
            Assert.IsNotNull(circle);
            var area = Math.Round(circle.GetArea(),1);
            Assert.IsTrue(area.Equals(78.5));
        }
    }
}