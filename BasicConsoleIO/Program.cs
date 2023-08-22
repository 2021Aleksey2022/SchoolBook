using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Basic Console I/O****");
            GetUserData();
            Console.ReadLine();
        }
        static void GetUserData()
        {
            //Получитть информацию об имени и возрасте
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            //Изменить цвет переднего плана
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Вывести полученную информацию на консоль
            Console.WriteLine("Hello {0} You are {1} years old", userName, userAge);

            //Восстоновить предыдущий цвет переднего плана
            Console.ForegroundColor = prevColor;
        }     
    }
}
