using System.ComponentModel.DataAnnotations;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DmiterkoKD.Sprint6.Task5.V13.Lib
{   
    public class DataService : ISprint6Task5V13
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            // Сначала считываем количество строк в файле
        using (StreamReader rd = new StreamReader(path))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    len++;
                }
            }

            // Создаем массив для хранения чисел
            double[] nums = new double[len];
            int index = 0;

            // Считываем данные из файла
            using (StreamReader rd = new StreamReader(path))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    nums[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            // Фильтруем массив, оставляя только значения от -∞ до 10
            nums = nums.Where(val => val < 10).ToArray();
            return nums;
        }
    }
}
