using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXP.QA.Vile.Newbie.Vile.Day005.Loop
{
    public class SinhVien
    {
        protected string MaSv { get; set; }
        protected string HoTen { get; set; }
        protected int NamSinh { get; set; }
        public SinhVien(string maSv, string hoTen, int namSinh)
        {
            MaSv = maSv;
            HoTen = hoTen;
            NamSinh = namSinh;
        }


    }
}
