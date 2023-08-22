using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {    
                Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();
            // Получить значение int из "базы данных".
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of ' i' is: {0}", i.Value);  // вывод значения переменной i
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined.");  // значение переменной i не определено
            }
            // Получить значение bool из "базы данных".
            bool? b = dr.GetBoolFromDatabase();
            if(b != null)
            {
                Console.WriteLine("Value of ’b' is: {0}", b.Value);  // вывод значения переменной b
            }
            else
            {
                Console.WriteLine("Value of ’b’ is undefined.");  // значение переменной b не определено
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine();

            // Если значение, возвращаемое из GetlntFromDatabase(), равно
            // null, то присвоить локальной переменной значение 100.
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            // Более длинный код, в котором не используется синтаксис ??.
            int? moreData = dr.GetIntFromDatabase();
            if (!moreData.HasValue)
            {
                moreData = 100;
            }
            Console.WriteLine("Value of moreData: {0}", moreData);
            Console.ReadLine();
        }
        static void LocalNullableVanables()
        {
            // Определить несколько локальных переменных, допускающих null.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char?  nullableChar = 'a';
            int?[] arrayOfNullablelnts = new int?[10];
            Console.WriteLine($"Int: {nullableInt}, Double: {nullableDouble}, Bool: {nullableBool}" +
                $"Char: {nullableChar}");

        }
        static void LocalNullableVariablesUsingNullable()
        {
            // Определить несколько типов, допускающих null, с применением Nullable<T>.
            Nullable<int> nullablelnt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullablelnts = new Nullable<int>[10];
        }
    }
    class DatabaseReader
    {
        // Поле данных типа, допускающего null.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Обратите внимание на возвращаемый тип, допускающий null.
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        // Обратите внимание на возвращаемый тип, допускающий null.
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }

    }
}
