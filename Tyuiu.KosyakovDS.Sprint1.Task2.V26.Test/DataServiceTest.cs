using Tyuiu.KosyakovDS.Sprint1.Task2.V26.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 10;
            int res = ds.CalculateMinutesSinceStart(x, y);
            Assert.AreEqual(130, res);
        }
    }
}