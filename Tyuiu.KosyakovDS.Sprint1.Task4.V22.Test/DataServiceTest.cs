using Tyuiu.KosyakovDS.Sprint1.Task4.V22.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.021, res);
        }
    }
}