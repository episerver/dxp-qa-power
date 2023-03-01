using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXP.QA.Vile.Newbie.Vile.Day003.Variable
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
            khoa = KHOA;
            test = TEST;
        }
        public override void printInfo()
        {
            Console.WriteLine($"Ma nhan vien: " + masv
            + '\n' + "Ho ten: " + hoten
            + '\n' + "Dia chi: " + diachi
            + '\n' + "Khoa: " + khoa
            //+ "Chuyen mon: " + chuyenmon
            + '\n' + "Chuyen mon: " + chuyenmon
            );
            // Su dung $
            Console.WriteLine($"Ma nhan vien: {masv}");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++ End of day 3 ++++++++++++++++++++++++++++++++++++++");
            Console.ReadKey();

        }
    }
}
