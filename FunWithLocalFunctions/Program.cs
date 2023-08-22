using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLocalFunctions
{
    // Специальное перечисление,
    // Значения элементов в перечислении не обязательно должны быть
    // последовательными!

    enum EmpType
    {
        Manager = 10,       //0
        Grunt = 1,         //1
        Contractor = 100,    //2
        VicePresident = 9  //3
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создать переменную типа ЕтрТуре.
            EmpType e2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            //Выполнить здесь проверку достоверности
            return x + y;
        }
        static int AddWrapper(int x, int y)
        {
            // Выполнить здесь проверку достоверности
            return Add();
            int Add()
            {
                return x + y;
            }
        }
        // Перечисления как параметры,
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("Не желаете ли взамен фондовые опционы");
                break;
                case EmpType.Grunt:
                    Console.WriteLine("Вы должно быть шутите....");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("Вы уже получаете вполне достаточно");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Очень хорошо сэр");
                    break;
            }
        }
        // Этот метод выводит детали любого перечисления,
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type : {0}", Enum.GetUnderlyingType(e.GetType()));

            // Получить все пары "имя-значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Вывести строковое имя и ассоциированное значение,
            // используя флаг формата D 
            for(int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name : {0}, Value : {0:D}", enumData.GetValue(i));
            }
        }

    }
}
