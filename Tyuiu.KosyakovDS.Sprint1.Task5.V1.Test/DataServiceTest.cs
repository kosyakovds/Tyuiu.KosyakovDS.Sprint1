using Tyuiu.KosyakovDS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double y1 = 2;
            double x2 = 5;
            double y2 = 6;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(5, res);
        }
    }
}