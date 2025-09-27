
using Tyuiu.AlbornozJ.Sprint1.Task2.V1.Lib;

namespace Tyuiu.AlbornozJ.Sprint1.Task2.V1.Test
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
            int x = 100;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(62.150, res);
        }
    }
}