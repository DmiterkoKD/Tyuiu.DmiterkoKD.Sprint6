using Tyuiu.DmiterkoKD.Sprint6.Task6.V10.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task6.V10.Test
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
            string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}