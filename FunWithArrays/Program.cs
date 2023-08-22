using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun With Arrays");
           
            
            Console.ReadLine();
        }
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation");
            // Создать массив int, содержащий 3 элемента с индексами 0, 1, 2.
            // Создать и заполнить массив из трех целочисленных значений.
            int[] myInt = new int[3];
            myInt[0] = 100;
            myInt[1] = 200;
            myInt[2] = 300;
            // Вывести все значения.
            foreach (int i in myInt)
                Console.WriteLine(i);
            Console.WriteLine();

            // Создать массив string, содержащий 100 элементов с индексами 0-99.
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }
        static void Arraylnitialization()
        {
            Console.WriteLine("=> Array Initialization");
            // Синтаксис инициализации массива с использованием ключевого слова new.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            Console.ReadLine();

            // Синтаксис инициализации массива без использования ключевого слова new.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            Console.ReadLine();

            // Инициализация массива с применением ключевого слова new и указанием размера.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.ReadLine();
        }
        static void DeclarelmplicitArrays()
        {
            //неявное приведение локальных массивов(обязательное использование слова new)
            Console.WriteLine("=>  Implicit Array Initialization.");

            // Переменная а на самом деле имеет тип int[].
            var a = new[] { 1, 10, 10, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            Console.ReadLine();

            // Переменная b на самом деле имеет тип double.
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is b: {0}", b.ToString());
            Console.ReadLine();

            // Переменная с на самом деле имеет тип string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is c: {0}", c.ToString());
            Console.ReadLine();

        }
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array Of Objects");
            // Массив объектов может содержать все что угодно.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Вывести тип и значение каждого элемента в массиве.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }
        static void RectMultidimensionalArray()
        {
            {
                Console.WriteLine("=> Rectangular multidimensional array.");
                // Прямоугольный многомерный массив.
                int[,] myMatrix;
                myMatrix = new int[3, 4];

                // Заполнить массив (3 * 4) .
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        myMatrix[i, j] = i * j;
                    }
                }
                // Вывести содержимое массива (3 * 4) .
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(myMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged Multidimensional array");
            // Зубчатый многомерный массив (т.е. массив массивов).
            // Здесь мы имеем массив из 5 разных массивов.
            int[][] myJagArray = new int[5][];

            // Создать зубчатый массив.
            for(int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }
            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintArray(int[] mylnts)
        {
            // Метод принимает на вход массив и выводит на консоль 
            for(int i = 0; i < mylnts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, mylnts[i]);
            }
            Console.WriteLine();
        }
       static string[] GetStringArray()
       {
            string[] theStrings = { "hello", "From", "GetStringArray" };            
            //Console.WriteLine("theStrings:  {0}\t {1}\t {2}", theStrings);
            return theStrings;
       }
        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Передать массив в качестве параметра.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Получить массив как возвращаемое значение,
            string[] strs = GetStringArray();
            foreach(string s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
        static void SystemArrayFunctionality()
        {
            //Статические методы Reverse() и Clear()

            Console.WriteLine("=> Working with System.Array.");
            // Инициализировать элементы при запуске.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Вывести имена в порядке их объявления.
            Console.WriteLine("-> Here is the array");
            for(int i = 0; i < gothicBands.Length; i++)
            {
                // Вывести имя.
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            // Обратить порядок следования элементов...
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            // ... и вывести их.
            for(int i = 0; i < gothicBands.Length; i++)
            {
                // Вывести имя.
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            // Удалить все элементы кроме первого.
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for(int i = 0; i < gothicBands.Length; i++)
            {
                // Вывести имя.
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }

    }
}
