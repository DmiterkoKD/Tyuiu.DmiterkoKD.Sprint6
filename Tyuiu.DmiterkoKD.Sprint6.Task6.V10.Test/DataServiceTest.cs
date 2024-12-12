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
            string resStr = "www dsdsdw ww";
            string line = "www dsdsdw dsdsdsd ww";
            string[] words = line.Split(' ');
            string res = "";

            foreach (string word in words)
            {
                if (word.Contains("w"))
                {
                    res += word + " ";
                }
            }
            res = res.TrimEnd();
            Assert.AreEqual(resStr, res);
        }
    }
}