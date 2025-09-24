
using Tyuiu.AlbornozJ.Sprint1.Task1.V0.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task1.V0.Test
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
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}