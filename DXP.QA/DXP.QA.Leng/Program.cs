using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXP.QA.Leng;

namespace DXP.QA.Leng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.DiemToan = 1;
            sv.DiemVan = 2;
            sv.HoTen = "AB CD";
            sv.TrungBinh();
            
            Week2 week2 = new Week2();
            week2.SumSinhVien();
        }
    }
}