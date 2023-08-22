using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct Point
    {
        // Поля структуры.
        public int X;
        public int Y;

        // Добавить 1 к позиции (X, Y).
        public void Increment()
        {
            X++;
            Y++;
        }
        // Вычесть 1 из позиции (X, Y) .
        public void Decrement()
        {
            X--;
            Y--;
        }
        // Отобразить текущую позицию.
        public void Desplay()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** a First Look at Structures *****\n");
            // Создать начальную переменную типа Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Desplay();

            // Скорректировать значения X и Y.
            myPoint.Increment();
            myPoint.Desplay();
            Console.WriteLine("===============");
            myPoint.Decrement();
            myPoint.Desplay();
            // Установить для всех полей стандартные значения,
            // используя стандартный конструктор.
            Point p1 = new Point();
            p1.Desplay();
            Console.ReadLine();
        }
    }  
}
