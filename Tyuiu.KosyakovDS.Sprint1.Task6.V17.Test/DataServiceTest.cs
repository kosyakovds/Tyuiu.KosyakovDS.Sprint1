using Tyuiu.KosyakovDS.Sprint1.Task6.V17.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "КосяковвокясоК";
            Assert.AreEqual(true, ds.CheckPalindrome(value));
        }
    }
}
