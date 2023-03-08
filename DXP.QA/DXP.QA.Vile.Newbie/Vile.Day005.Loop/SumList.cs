using System;
namespace DXP.QA.Vile.Newbie.Vile.Day005.Loop
{
	public class SumList
	{
        private static int tongLe;

        public static int SumUsingForAndIf(List<int> numbers)
		{
            tongLe = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    tongLe = tongLe + numbers[i];

                }
            }
            return tongLe;
        }
        public static int SumUsingForeachAndIf(List<int> numbers)
        {
            tongLe = 0;
            var j = 0;
            foreach (var number in numbers)
            {
                if (j % 2 != 0)
                {
                    tongLe = tongLe + number;
                }
                j++;
            }
            return tongLe;

        }
        public static int SumUsingWhileAndIf(List<int> numbers)
        {
            var j = 0;
            tongLe = 0;
            while (j <= numbers.Count())
            {
                if (j % 2 != 0)
                {
                    tongLe = tongLe + numbers[j];

                }
                j++;
            }
            return tongLe;
        }
        public static int SumUsingWhileAndWhile(List<int> numbers)
        {
            var j = 0;
            tongLe = 0;
            while (j <= numbers.Count())
            {
                while (j % 2 != 0)
                {
                    tongLe = tongLe + numbers[j];
                    break;
                }
                j++;
            }
            return tongLe;
        }
        public void printInfo(List<int> daySo)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Tinh tong cac so chan trong LIST bang 4 cach:");
            Console.WriteLine($"Tinh Tong cac so chan (su dung for + if clause): {SumList.SumUsingForAndIf(daySo)}");
            Console.WriteLine($"Tinh Tong cac so chan (su dung foreach + if clause): {SumList.SumUsingForeachAndIf(daySo)}");
            Console.WriteLine($"Tinh Tong cac so chan (su dung while + if clause): {SumList.SumUsingWhileAndIf(daySo)}");
            Console.WriteLine($"Tinh Tong cac so chan (su dung while + while clause): {SumList.SumUsingWhileAndWhile(daySo)}");
            Console.WriteLine("Nhap phim bat ky de thoat");
            Console.WriteLine("*****************************");
            Console.ReadKey();
        }

    }
}

