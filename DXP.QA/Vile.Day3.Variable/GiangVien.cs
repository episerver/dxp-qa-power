using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vile.Day3.Variable
{
    class GiangVien : NhanVien
    {
        private string khoa { get; set; }
        private string chuyenmon { get; set; }
        public string test { set; get; }
        public GiangVien(int MANV, string HOTEN, string DIACHI, string KHOA, string CHUYENMON, string TEST)
            : base(MANV, HOTEN, DIACHI)
        {
            //this.chuyenmon = CHUYENMON; 
            chuyenmon = CHUYENMON;
            this.khoa = KHOA;
            this.test = TEST;
        }
        public override void printInfo()
        {
            Console.WriteLine($"Ma nhan vien: " + this.mavn
            + '\n' + "Ho ten: " + this.hoten
            + '\n' + "Dia chi: " + this.diachi
            + '\n' + "Khoa: " + khoa
            //+ "Chuyen mon: " + chuyenmon
            + '\n' + "Chuyen mon: " + chuyenmon
            );
            // Su dung $
            Console.WriteLine($"Ma nhan vien: {this.mavn}");
            Console.ReadKey();
        }
    }
}
