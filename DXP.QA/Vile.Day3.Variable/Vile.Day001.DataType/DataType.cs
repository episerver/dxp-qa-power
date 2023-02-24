using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vile.newbie.Vile.Day001.DataType
{
    using System;
    class DataType
    {
        public void printInfo()
        {
            Console.WriteLine("Hello World!");
            var x = 4;
            Console.WriteLine(x);
            Console.WriteLine("************************");
            // Dùng string list
            string[] cities = new string[3] { "Mumbai", "London", "New York" };
            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);
            Console.WriteLine("************************");
            // dùng biến int  + vòng for
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            Console.WriteLine("************************");
            // Dùng foreach
            foreach (var c in cities)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("************************");
            //Dùng biến Bool
            bool t = false;
            Console.WriteLine("Equal to London..................");
            foreach (var c in cities)
            {
                if (c == "London")
                {
                    t = true;
                    if (t)
                    {
                        Console.WriteLine(c);
                    }
                    t = false;
                }
            }
            Console.WriteLine("Contains o..................");
            foreach (var c in cities)
            {

                if (c.Contains("o"))
                {
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("Start with M..................");
            foreach (var c in cities)
            {
                if (c.StartsWith("M"))
                {
                    Console.WriteLine(c);
                }
            }
            // dùng biến Int
            Console.WriteLine("Max value of Int: " + int.MaxValue);
            Console.WriteLine("Min value of Int: " + int.MinValue);
            Console.WriteLine("Max value of Int16: " + Int16.MaxValue);
            Console.WriteLine("Min value of Int16: " + Int16.MinValue);
            Console.WriteLine("Max value of Int32: " + Int32.MaxValue);
            Console.WriteLine("Min value of Int32: " + Int32.MinValue);
            Console.WriteLine("Max value of Int64: " + Int64.MaxValue);
            Console.WriteLine("Min value of Int64: " + Int64.MinValue);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++ End of day 1 ++++++++++++++++++++++++++++++++++++++");
            Console.ReadKey();

        }

    }
}
