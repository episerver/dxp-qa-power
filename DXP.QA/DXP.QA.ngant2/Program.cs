// Sum of all odd element on a collection

using System;
namespace OddNumber
{ 
    class SumOfOddNumber
    {
        class Odd
        {
            public int SumOfOddNumberIfFor(int[] array) 
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2!=0)
                    {
                        sum += array[i];
                    }
                }
                return sum;
            }
            public int SumOfOddNumberIfWhile(int[] array)
            {
                int sum = 0;
                int i = 0;
                while (i < array.Length)
                {                   
                    if (array[i] % 2 != 0)
                    {
                        sum += array[i];
                    }
                    i++;
                }
                return sum;
            }
            public int SumOfOddNumberIfForeach(int[] array)
            {
                int sum = 0;
                foreach (int item in array)
                {
                    
                    if (item%2!=0)
                    {
                        sum += item;
                    }
                }
                return sum;
            }
 /*           public int SumOfOddNumberWhileWhile(int[] array)
            {
                int sum = 0;
                int i = 0;
                while(i < array.Length)
                {
                    while (array[i] % 2 == 1)
                    {
                        Console.WriteLine(array[i]);
                        sum += array[i];
                       
                    }
                    i++;
                }
                return sum;
            }*/
        }

        static void Main(string[] args)
        {
            Odd odd = new Odd();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var array2 = new List<int>() { 2, 3, 4, 5, 6, 7, 8 ,9, 10, 11};
            Console.WriteLine("Sum of all odd If-For = " + odd.SumOfOddNumberIfFor(array));
            Console.WriteLine("Sum of all odd If-While = " + Convert.ToInt32(odd.SumOfOddNumberIfWhile(array)));
            Console.WriteLine("Sum of all odd If-Foreach = " + odd.SumOfOddNumberIfForeach(array));
            //Console.WriteLine("Sum of all odd While-While = " + odd.SumOfOddNumberWhileWhile(array));
        }
    } 
}

