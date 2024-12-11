using Tyuiu.DmiterkoKD.Sprint6.Task4.V25.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task4.V25.Test
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
            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] value;
            value = new double[len];

            value[0] = 4.67;
            value[1] = 0.43;
            value[2] = -8.26;
            value[3] = -9.87;
            value[4] = -3.98;
            value[5] = 1;
            value[6] = 0.02;
            value[7] = -1.87;
            value[8] = 3.74;
            value[9] = 16.43;
            value[10] = 24.67;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, value);
        }
    }
}