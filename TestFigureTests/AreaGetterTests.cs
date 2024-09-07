using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFigure.Figures;

namespace TestFigure.Tests
{
    [TestClass()]
    public class AreaGetterTests
    {
        [TestMethod()]
        public void GetAreaTest_MustReturnCorrectTriangleArea()
        {
            var areaGetter = new AreaGetter<Triangle>(new Triangle(new Parameters.Line(3), new Parameters.Line(4), new Parameters.Line(2)));
            Assert.IsTrue(areaGetter.GetArea().Equals(2.9));
        }
        public void GetAreaTest_MustReturnCorrectCircleArea()
        {
            var areaGetter = new AreaGetter<Circle>(new Circle(new Parameters.Line(5)));
            Assert.IsTrue(areaGetter.GetArea().Equals(78.5));
        }
    }
}