using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesAndReferncesTypes
{
    struct Point
    {
        // Поля структуры.
        public int X;
        public int Y;

        // Специальный конструктор.
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
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
    struct PointRef
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
            ValueTypeContainingRefType();
            Console.ReadLine();
        }
        // Присваивание двух внутренних типов значений дает
        // в результате две независимые переменные в стеке.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;

            // Вывести значения обеих переменных Point.
            p1.Desplay();
            p2.Desplay();

            //Изменить pl.X и снова вывести значения переменных.Значение р2.Х не изменилось.
            p1.X = 100;
            Console.WriteLine("\n=> Changed pl.X\n");
            p1.Desplay();
            p2.Desplay();
        }
        static void ValueTypeContainingRefType()
        {
            // Создать первую переменную Rectangle.
            Console.WriteLine("-> Creating rl");
            Ractangle r1 = new Ractangle("First Ract", 10, 10, 50, 50);

            // Присвоить новой переменной Rectangle переменную rl.
            Console.WriteLine("-> Assigning r2 to rl");
            Ractangle r2 = r1;

            // Изменить некоторые значения в r2.
            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.infoString = "This is new info!";
            r2.RectBottom = 4444;
            // Вывести значения из обеих переменных Rectangle,
            r1.Display();
            r2.Display();
        }
    }
    struct Ractangle
    {
        // Структура Rectangle содержит член ссылочного типа.
        public Shapeinfo RectInfo;
        public int RectTop, RectLeft, RectBottom, RectRight;
        public Ractangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new Shapeinfo(info);
            RectTop = top;
            RectBottom = bottom;
            RectLeft = left;
            RectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " + "Left = {3}, Right = {4} ",
                RectInfo.infoString, RectTop, RectBottom, RectLeft, RectRight);
        }
    }
    class Shapeinfo
    {
        public string infoString;

        
        public Shapeinfo(string info)
        {
            infoString = info;
        }
        

    }
}
