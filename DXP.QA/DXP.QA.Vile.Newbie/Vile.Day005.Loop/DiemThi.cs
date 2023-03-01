using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXP.QA.Vile.Newbie.Vile.Day005.Loop
{
    internal class DiemThi
    {
        protected string MaMon { get; set; }
        protected string MaSv { get; set; }
        protected float Diem { get; set; }
        public DiemThi(string maMon, string maSv, float diem)
        {
            MaMon = maMon;
            MaSv = maSv;
            Diem = diem;
        }
    }
}
