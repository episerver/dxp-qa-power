using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXP.QA.Leng
{
    class Week2
    {
            
        public void SumSinhVien()
        {
            int[] sumSV = new int[] {1,2,3,4,5,6,7,8,9,10};

            int total = 0;
            foreach (var i in sumSV)
            {
                if(i % 2 ==0)
                    total += i;
            }
            Console.WriteLine(total);
        }
     
    }
}
