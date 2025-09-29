using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosyakovDS.Sprint1.Task2.V26.Lib
{
    public class DataService : ISprint1Task2V26
    {
        public int CalculateMinutesSinceStart(int value, int valueTwo)
        {
            int x = value;
            int y = valueTwo;
            return x * 60 + y;
        }
    }
}
