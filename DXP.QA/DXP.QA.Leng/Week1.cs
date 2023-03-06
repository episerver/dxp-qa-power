namespace DXP.QA.Leng
{    
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
