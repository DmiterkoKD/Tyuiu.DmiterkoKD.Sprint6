using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DmiterkoKD.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] value;
            value = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 14 * x;
                if (3*x + 1.2 == 0)
                    value[count] = 0;
                else
                    value[count] = Math.Round(y, 2);
                count++;
            }
            return value;
        }
    }
}
