namespace Tyuiu.DmiterkoKD.Sprint6.Task7.V20.Test
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
            string path = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask7V20.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}