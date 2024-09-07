using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFigure.Parameters;

namespace TestFigure.Figures
{
    public class Triangle : Figure
    {

        /// <summary>
        /// Треугольник имеет 3 стороны
        /// </summary>
        public Line Side1 { get; set; }
        public Line Side2 { get; set; }
        public Line Side3 { get; set; }

        /// <summary>
        /// Свойство отражающее половину периметра по трем сторонам треугольника
        /// </summary>
        public double HalfPer;
        public Triangle(Line line1,Line line2, Line line3) 
        {
            if (!CreateTriangle(line1, line2, line3))
                throw new ArgumentException();
            Side1 = line1;
            Side2 = line2;
            Side3 = line3;
            HalfPer = GetHalfPer();
        }

        private bool CreateTriangle(Line side1, Line side2, Line side3)
        {

            if (side1.Length > (side2.Length + side3.Length))
                return false;
            if (side2.Length > (side1.Length + side3.Length))
                return false;
            if (side3.Length > (side1.Length + side2.Length))
                return false;

            return true;
        }

        /// <summary>
        /// Метод для нахождения половины периметра треугольника
        /// </summary>
        /// <returns> double Half Perimetr</returns>
        /// <exception cref="ArgumentException"></exception>
        private double GetHalfPer()
        {
            if(Side1.Length <0 && Side2.Length<0 && Side3.Length<0)
                throw new ArgumentException();

            return (Side1.Length+ Side2.Length + Side3.Length)/2;
        }

        /// <summary>
        /// Квадратный корень из p*(p-s1)*(p-s2)*(p-s3)
        /// </summary>
        /// <returns> TriangleArea</returns>
        public override double GetArea()
        {

            var area = Math.Sqrt(HalfPer*(HalfPer- Side1.Length)*(HalfPer- Side2.Length)*(HalfPer- Side3.Length));

            return Math.Round(area,1);
        }
    }
}
