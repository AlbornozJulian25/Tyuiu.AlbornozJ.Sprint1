
using Tyuiu.AlbornozJ.Sprint1.Task4.V15.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 2017.144;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
