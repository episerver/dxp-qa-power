using System;
using System.Threading;

namespace DXP.QA.Sitr._0001
{
    class HangHoa
    {
        static void Main(string[] args)
        {
            //Call a public property from class MauSacHangHoa
            var mauSac = new MauSacHangHoa();
            Console.WriteLine("Hien thi mau sac cho hang hoa");
            Console.Write(mauSac.MauSac);
            Console.Write("\n\n");
            Thread.Sleep(2000);

            //Call a inheritted property from class TenVietTat
            var tenVietTat = new TenVietTat();
            Console.Write(tenVietTat.TenHang);
            Console.Write("\n");
            tenVietTat.Print();
            Console.Write("\n");
            Thread.Sleep(2000);

            //Call a static function does not need to initial a value
            ChungLoaiHangHoa.Displayday("Thuc pham an lien");
        }
    }

    class MauSacHangHoa
    {
        public string MauSac { get; set; } = "Mau hong";
        void Write()
        {
            Console.Write(MauSac);
        }
    }

    class TenHangHoa
    {
        public string TenHang = "Mi tom";
        public void Write()
        {
            Console.Write(TenHang);
        }
    }

    //Class TenVietTat inherit from class TenHangHoa
    class TenVietTat : TenHangHoa
    {
        public void Print()
        {
            Console.Write("Ten viet tat la Mitom");
        }
    }

    class ChungLoaiHangHoa
    {
        public static void Displayday(string chungLoai)
        {
            Console.Write($"Chung loai hang hoa la: {chungLoai}");
        }
    }
}