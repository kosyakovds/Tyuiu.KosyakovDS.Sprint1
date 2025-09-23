using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosyakovDS.Sprint1.Task1.V23.Lib
{
    public class DataService : ISprint1Task1V23
    {
        public double Calculate(double x, double a)
        {
            double res = (x * Math.PI) / (2 * a);
            return res;
        }
    }
}
