using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Methods * ****\n");
            double[] data = { 4.0, 3.2, 5.7 };
            double average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            Console.ReadLine();
        }
        //По умолчанию аргументы передаются по значению.
        static int Add(int x, int y)
        {
            int ans = x + y;
            // Вызывающий код не увидит эти изменения,
            // т.к. модифицируется копия исходных данных,
            x = 10000;
            y = 88888;
            Console.WriteLine(ans);
            // Передать две переменные по значению,
            x = 9; y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            return ans;
            
        }
        // Возвращение множества выходных параметров,
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }
        // Ссылочные параметры.
        public static void SwapStnngs(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        // Возвращает значение по позиции в массиве.
        public static string SimpleReturn(string[] strArray, int position)
        {
            return strArray[position];
        }
        // Возвращение среднего из некоторого количества значений double,
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if(values.Length == 0)
            {
                return sum;
            }
            for(int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }
            



    }
}
