

using Tyuiu.AlbornozJ.Sprint1.Task5.V7.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 180;
            DataService ds = new DataService();
            int res = ds.AngleToHoursMinutes(f);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
