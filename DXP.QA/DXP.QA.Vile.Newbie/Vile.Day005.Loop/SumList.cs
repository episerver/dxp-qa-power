using System;
namespace DXP.QA.Vile.Newbie.Vile.Day005.Loop
{
	public class SumList
	{
        private int tongLe;

        public int sumUsingForAndIf(List<int> numbers)
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
        public int sumUsingForeachAndIf(List<int> numbers)
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
        public int sumUsingWhileAndIf(List<int> numbers)
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
        public int sumUsingWhileAndWhile(List<int> numbers)
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
    }
}

