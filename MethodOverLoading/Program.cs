using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    // Код С#.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 10));
            Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
            Console.WriteLine(Add(4.5, 6.5));
            Console.ReadLine();
        }
        // Перегруженный метод Add().
        static int Add(int x, int y)
        {
             return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x , long y)
        {
            return x + y;
        }
    }
}
