using System;
namespace DXP.QA.Vile.Newbie.Vile.Day005.Loop
{
	

	public class SumArray
	{
        private static int tongChan;
        public int sumUsingForAndIf(int[] numbers)
		{
			tongChan = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] % 2 == 0)
					tongChan = tongChan + numbers[i];
			}
			return tongChan;
		}

		public int sumUsingForeachAndIf(int[] numbers)
		{
			tongChan = 0;
			foreach (var number in numbers)
			{
				if (number % 2 == 0)
					tongChan = tongChan + number;
			}
			return tongChan;
		}

		public int sumUsingWhileAndIf(int[] numbers)
		{
			tongChan = 0;
			var j = 0;
			while (j < numbers.Length)
			{
				if (numbers[j] % 2 == 0)
					tongChan = tongChan + numbers[j];
				j++;
			}
			return tongChan;
		}

		public int sumUsingWhileAndWhile(int[] numbers)
		{
			tongChan = 0;
			var j = 0;
			while (j <numbers.Length)
			{
				while (numbers[j] % 2 ==0)
				{
					tongChan = tongChan + numbers[j];
					break;
                }
				j++;	
			}
			return tongChan;
		}
		
	}
}

