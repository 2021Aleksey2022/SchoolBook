using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    /// <summary>
    /// Кортежи
    /// </summary>
    struct Point
    {
        // Поля структуры.
        public int X;
        public int Y;

        // Специальный конструктор,
        public Point(int Xpos, int YPos)
        {
            X = Xpos;
            Y = YPos;
        }
        public (int XPos, int YPos) Deconstruct() => (X, Y);
    }
    class Program
    {
        static void Main(string[] args)
        {

            //var samples = FillTheseValues();
            //Console.WriteLine($"Int is: {samples.a}");
            //Console.WriteLine($"Stnng is: {samples.b}");
            //Console.WriteLine($"Boolean is: {samples.с}");
            //=================================================
            //var (first, _, last) = SplitNames("Philip F Japikse");
            //Console.WriteLine($"{first} : {last}");
            //=====================================================
            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is: { pointValues.XPos}") ;
            Console.WriteLine($"Y is: { pointValues.YPos}");
            Console.ReadLine();
        }
        public void DeclaringTuples()
        {
            (string, int, char) values1 = ("a", 5, 'b');
            var values = ("a", 5, 'b');
            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");
            Console.WriteLine("====================================");

            Console.WriteLine("=> Inferred Tuple Names1");
            var foo = new { Propl = "first", Prop2 = "second" };
            var bar = (foo.Propl, foo.Prop2);
            Console.WriteLine($"{bar.Propl};{bar.Prop2}");
        }

        //Объявление кортежа, вместо параметров.
        static (int a, string b, bool с) FillTheseValues()
        {            
            return (9, "Enjoy your string.", true);
        }

        //Объявление кортежа и параметра.
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            // Действия, необходимые для расщепления полного имени,
            return ("Philip", "F", "Japikse");
        }

    }
}
