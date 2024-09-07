using TestFigure.Figures;

namespace TestFigure
{
    public class AreaGetter<T> where T : Figure
    {
        
        /// <summary>
        /// Передаем любую фигуру в параметр Т площадь которой мы хотим найти 
        /// </summary>
        public T Figure { get; set; }
        public AreaGetter(T figure) 
        {
            this.Figure = figure;
        }
        /// <summary>
        /// Функция нахождения площади переданной фигуры
        /// </summary>
        /// <returns> double Area</returns>
        public double GetArea()
        {
            return this.Figure.GetArea();
        }
    }
}
