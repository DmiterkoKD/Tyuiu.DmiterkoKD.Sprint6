using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DmiterkoKD.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
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
                y = ((Math.Cos(x)) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x;
                if (x == -1)
                    value[count] = 0;
                else
                    value[count] = Math.Round(y,2);
                count++;
            }
            return value;
        }
    }

}
