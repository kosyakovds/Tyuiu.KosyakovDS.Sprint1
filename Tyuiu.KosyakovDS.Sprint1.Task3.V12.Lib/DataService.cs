using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosyakovDS.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double lengthCathetus1, double lengthCathetus2)
        {
            double x = lengthCathetus1;
            double y = lengthCathetus2;
            return Math.Round((x * y) / 2, 3);
        }
    }
}
