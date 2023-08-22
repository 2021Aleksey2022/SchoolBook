using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;
        // Конструкторы.
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name = {0}, Age = {1}", personName, personAge);
        }
        static void Main(string[] args)
        {
            // Передача ссылочных типов по значению.
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);

            Console.WriteLine("\nBefore by value call, Person is:"); // перед вызовом
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:"); // после вызова
            fred.Display();
            Console.WriteLine("========================================================");
            Console.WriteLine();
            Console.WriteLine("***** Passing Person object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by ref call, Person is:"); // перед вызовом
            mel.Display();

            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call, Person is:"); // после вызова
            mel.Display();
            Console.ReadLine();
        }
        static void SendAPersonByReference(ref Person p)
        {
            // Изменить некоторые данные в р.
            p.personAge = 555;
            // р теперь указывает на новый объект в куче!
            p = new Person("Nikki", 999);
        }

        static void SendAPersonByValue(Person p)
        {
            // Изменить значение возраста в р?
            p.personAge = 99;

            // Увидит ли вызывающий код это изменение?
            p = new Person("Nikki", 99);
        }

    }
}
