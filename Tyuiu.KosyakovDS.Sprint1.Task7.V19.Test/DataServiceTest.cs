using Tyuiu.KosyakovDS.Sprint1.Task7.V19.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(-5.159, res);
        }
    }
}