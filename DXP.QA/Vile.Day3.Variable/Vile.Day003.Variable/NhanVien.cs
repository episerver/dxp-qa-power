using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vile
{
    public abstract class NhanVien
    //abstract class NhanVien
    //class NhanVien
    {
        protected int mavn { get; set; }
        protected string hoten { get; set; }
        protected string diachi { get; set; }
        public NhanVien(int MANV, string HOTEN, string DIACHI)
        {
            //this.mavn = MANV;
            mavn = MANV;
            hoten = HOTEN;
            diachi = DIACHI;
        }
        public abstract void printInfo();
        //public void printInfo();
    }
}
