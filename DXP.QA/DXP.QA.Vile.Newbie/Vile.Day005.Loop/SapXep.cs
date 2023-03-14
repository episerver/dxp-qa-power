using System;
using DXP.QA.Vile.Newbie.Vile.Common;
namespace DXP.QA.Vile.Newbie.Vile.Day005.Loop
{
	public class SapXep : So
	{
		public static int[]? DaySo;
		public static int[] TangDan(int[] DaySo)
		{
			var tg = 0;
			for (int i = 0; i <= DaySo.Length - 2; i++)
			{
				for (int j = i + 1; j <= DaySo.Length - 1; j++)
				{
					if (DaySo[i] > DaySo[j])
					{
						tg = DaySo[i];
						DaySo[i] = DaySo[j];
						DaySo[j] = tg;
					}

				}
			}
			return DaySo;
		}
		public override void  printInfo()
		{
			Console.WriteLine("Day so ban dau:");
			for (int i = 0; i < DaySo.Length; i++)
				Console.Write($"{DaySo[i]}; ");
			Console.WriteLine();
            Console.WriteLine("Day so da sap xep:");
            for (int i = 0; i < DaySo.Length; i++)
                Console.Write($"{TangDan(DaySo)[i]}; ");

        }
        public SapXep()
		{
		}
	}
}

