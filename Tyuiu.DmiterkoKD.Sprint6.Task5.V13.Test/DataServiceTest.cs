using Tyuiu.DmiterkoKD.Sprint6.Task5.V13.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task5.V13.Test
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
            string p = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask5V13.txt";

            double[] res = ds.LoadFromDataFile(p);
            double[] wait = { -13, -19, -9.82, -9.71, 3.36, 0.48, 4.13, -0.11, -17.36, -12, -12.35 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}