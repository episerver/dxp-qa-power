using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXP.QA.Vile.Newbie.Vile.Day003.Variable
{
    public abstract class NhanVien
    //abstract class NhanVien
    //class NhanVien
    {
        protected int masv { get; set; }
        protected string hoten { get; set; }
        protected string diachi { get; set; }
        public NhanVien(int MANV, string HOTEN, string DIACHI)
        {
            //this.mavn = MANV;
            masv = MANV;
            hoten = HOTEN;
            diachi = DIACHI;
        }
        public abstract void printInfo();
        //public void printInfo();
    }
}
