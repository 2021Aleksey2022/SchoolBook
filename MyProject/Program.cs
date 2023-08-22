using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchOnEnumExample();
            Console.ReadKey();
        }


       


        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse: ");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                // Преобразование потерпело неудачу
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
            Console.WriteLine();
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // Этот конструктор принимает год, месяц и день.
            DateTime dt = new DateTime(2015, 10, 17);
            // Какой это день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Сейчас месяц декабрь.
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // Этот конструктор принимает часы, минуты и секунды.
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            // Значение firstName.
            Console.WriteLine("Value of firstName: {0}", firstName);
            // Длина firstname.
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            // firstName в верхнем регистре.
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            // firstName в нижнем регистре.
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            // Содержит ли firstName букву у?
            Console.WriteLine("firstName contains the letter у?:{0}", firstName.Contains("y"));
            // firstName после замены.
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            
            Console.WriteLine();
        }
        public void ReverseOfNumber()
        {
            int[] a = { 5, 3, 1, 4, 2 };
            int i = 0;
            while (i < a.Length - 1)
            {
                if (a[i] >= a[i + 1])
                {
                    int tmp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tmp;
                    i = 0;
                }
                else
                {
                    i++;
                }

            }
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }

            Console.ReadLine();


            Console.WriteLine("========================================");

            int x = 4;
            int y = 5;
            int z;
            Console.WriteLine($" x ={x}, y={y}");

            z = x;
            x = y;
            y = z;
            Console.WriteLine($" x ={x}, y={y}");
            Console.ReadLine();
        }
        private static void ExecutelfElseUsingConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters"
                : "string is not greater than 0 characters");
            Console.WriteLine();
        }
        // Переход на основе числового значения,
        static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");
            // Выберите предпочитаемый язык:
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Хороший выбор. C# - замечательный язык.");
                    break;
                case 2:
                    Console.WriteLine("VB: ООП, многопоточность и многое другое!");
                    break;
                default:
                    Console.WriteLine("Хорошо, удачи с этим!");
                    break;
            }
        }
        static void SwitchOnEnumExample()
        {
            Console.Write("Ввведите любимый день недели: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Недопустимое входное значение!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Футбол!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Еще один день, еще один доллар.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Во всяком случае, не понедельник.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Хороший денек.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Почти пятница...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Да, пятница рулит!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Действительно великолепный день.");
                    break;              
            }
            Console.WriteLine();
        }




    }
}
