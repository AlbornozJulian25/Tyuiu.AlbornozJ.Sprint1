


using Tyuiu.AlbornozJ.Sprint1.Task6.V16.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет! Как ты?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
