﻿using System;
namespace DXP.QA.Vile.Newbie.Vile.Common
{
	public abstract class So
	{
        public static bool SoChan(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
        public abstract void printInfo();
        public So()
		{
		}
	}
}

