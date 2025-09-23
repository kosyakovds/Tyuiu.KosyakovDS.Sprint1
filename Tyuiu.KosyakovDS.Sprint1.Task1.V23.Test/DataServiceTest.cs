using Tyuiu.KosyakovDS.Sprint1.Task1.V23.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double a = 1.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(((2 * Math.PI) / (2 * 1)), res);
        }
    }
}
