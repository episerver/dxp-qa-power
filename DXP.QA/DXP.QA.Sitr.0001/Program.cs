using System;
using System.Threading;

namespace DXP.QA.Sitr._0001
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Call a public property from class A
            var a = new A();
            Console.WriteLine("Get value from class A");
            Console.Write(a.X);
            Console.Write("\n");
            //Call a inheritted property from class D ?????
            Thread.Sleep(2000);

            var d = new D();
            Console.Write(d.Y);
            Console.Write("\n");
            d.Print();
            Console.Write("\n");

            //Call a static function does not need to initial a value
            Thread.Sleep(2000);

            E.Displayday("Monday");
            Console.Write("\n");
        }
    }

    class A
    {
        public int X { get; set; } = 1;
        void Write()
        {
            Console.Write(X);
        }
    }

    class C
    {
        public string Y = "I'm from class C";
        public void Write()
        {
            Console.Write(Y);
        }
    }

    //Class D inherit from class C
    class D : C
    {
        public void Print()
        {
            Console.Write("I'm from class D");
        }
    }

    class E
    {
        public static void Displayday(string day)
        {
            var showday = "Today is " + day;
            Console.Write(showday);
        }
    }
}