
using Tyuiu.AlbornozJ.Sprint1.Task3.V0.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task3.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}