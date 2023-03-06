﻿namespace Leng.Week1
{
    class Program
    {
        static void Main(string[] args, int v)
        {
            SinhVien sv = new SinhVien();
            sv.DiemToan = 1;
            sv.DiemVan = 2;
            sv.HoTen = "AB CD";
            sv.TrungBinh();

            Array numSv = new int []{ 1,2,3,4,5,6,7,8,9,10};

            foreach (var i in numSv)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i);
                }

            }


        }
    }
    class SinhVien
    {
        private double diemToan;
        private double diemVan;


        public double getDiemToan { get; set; }
        public double getDiemVan { get; set; }

        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public string? HoTen { get; set; }

        public void TrungBinh()
        {
            double TB = (DiemToan + DiemVan) / 2;
            Console.WriteLine($"Sinh vien {HoTen} co diem TB: {TB}");
        }
    }
}
