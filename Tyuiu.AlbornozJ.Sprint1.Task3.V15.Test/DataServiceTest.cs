

using Tyuiu.AlbornozJ.Sprint1.Task3.V15.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 60;
            double v2 = 80;
            double S = 100;
            double T = 2;
            double wait = 380;
            double res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(wait, res);
        }
    }
}
