using Tyuiu.DmiterkoKD.Sprint6.Task0.V28.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task0.V28.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 169.89;
            Assert.AreEqual(res, wait);
        }
    }
}