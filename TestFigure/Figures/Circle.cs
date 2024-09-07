using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFigure.Parameters;

namespace TestFigure.Figures
{
    public class Circle : Figure
    {
        private const double PI = Math.PI;
        public double Rad;

        //public Point pointZero;
        
        //здесь могут быть линии по координатам
        public Circle(Line line) 
        {
            Rad = line.Length;
        }

        public override double GetArea()
        {
            if ( Rad < 0 ) 
            throw new ArgumentException();

            return PI * (double)Math.Pow(Rad,2);
        }
    }
}
