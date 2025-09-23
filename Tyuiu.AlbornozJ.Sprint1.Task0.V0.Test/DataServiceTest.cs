
using Tyuiu.AlbornozJ.Sprint1.Task0.V0.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task0.V0.Test
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
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}