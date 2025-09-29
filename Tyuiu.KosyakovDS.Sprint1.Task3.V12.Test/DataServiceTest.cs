using Tyuiu.KosyakovDS.Sprint1.Task3.V12.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 4;
            double res = ds.TriangleArea(x, y);
            Assert.AreEqual(10, res);
        }
    }
}