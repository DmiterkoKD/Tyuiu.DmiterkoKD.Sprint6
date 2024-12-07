using Tyuiu.DmiterkoKD.Sprint6.Task1.V29.Lib;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            int len = ds.GetMassFunction(start, end).Length;

            double[] value;
            value = new double[len];



            value = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("+     X     +    f(X)   +");
            Console.WriteLine("+-----------+-----------+");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1,5:f2}    |", start, value[i]);
                start++;
            }
            Console.WriteLine("+-----------+-----------+");

        }
    }
}
