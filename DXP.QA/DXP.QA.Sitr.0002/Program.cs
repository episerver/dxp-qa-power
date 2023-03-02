using System;
using System.Collections;
using System.Collections.Generic;

namespace DXP.QA.Sitr._0002
{
    class UseSyntax
    {
        static void Main(string[] args)
        {
            var daySo1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int tongLeFor = 0;
            int tongLeForeach = 0;

            //If...for
            for (int i = 0; i < daySo1.Length; i++)
            {
                if (daySo1[i] % 2 != 0) 
                {
            
                    tongLeFor+= daySo1[i];
                }
            }
            Console.WriteLine($"Tong cua cac so le trong day la {tongLeFor}");


            //If...foreach
            foreach (var soNguyen in daySo1)
            {
            if (soNguyen%2 !=0)
                {
                    tongLeForeach += soNguyen;
                }    
            }
            Console.WriteLine($"Tong cua cac so le trong day la {tongLeForeach}");

            var daySo2 = new List<int>() { 11, 14, 17, 20, 22,24, 25, 28, 30, 35 };
            int t = 0;
            int d = 0;
            int tongLeIfWhile = 0;
            int tongLe = 0;

            //if...while
            while (t< daySo2.Count)
            {
                if (daySo2[t] %2 !=0)
                { 
                    tongLeIfWhile+= daySo2[t]; 
                }
                t += 1;
            }
            Console.WriteLine($"Tong cua cac so le trong day la {tongLeIfWhile}");

            //while...while
            while (d < daySo2.Count)
            {
                while (daySo2[d] % 2 != 0)
                {
                    tongLe += daySo2[d];
                    break;
                }
                d += 1;
            }
            Console.WriteLine($"Tong cua cac so le trong day la {tongLe}");
        }
    }
}
