
using Tyuiu.AlbornozJ.Sprint1.Task2.V0.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task2.V0.Test
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
            int x = 2;
            var res = ds.Sqr(x);
            Assert.AreEqual(4, res);
        }
    }
}