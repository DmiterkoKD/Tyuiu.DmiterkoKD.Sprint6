using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DmiterkoKD.Sprint6.Task4.V25.Lib
{
    public class DataService : ISprint6Task4V25
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
                y = Math.Cos(x) + 2*x - 3*x* Math.Sin(x);
                value[count] = Math.Round(y, 2);                
                count++;
            }
            return value;
        }
    }
}
