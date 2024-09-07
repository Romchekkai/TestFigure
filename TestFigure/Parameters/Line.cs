using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFigure.Parameters
{
    /// <summary>
    /// Класс представляющий объект линия, с одним свойством длинна, можно расширить добавив логику работы с координатами
    /// </summary>
    public class Line
    {
        public double Length;

        public Line(double length)
        {
            Length = length;
        }
    }
}
