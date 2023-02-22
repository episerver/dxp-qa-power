namespace Vile.Day3.Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cách cũ
            // GiangVien giangvien = new GiangVien(111, "Viet Le", "165 Thai Ha", "Toan", "Hinh Giai Tich"); 
            //Cách mới
            var giangVien = new GiangVien(111, "Viet Le", "165 Thai Ha", "Toan", "Hinh Giai Tich", "abc 1234567890");
            giangVien.printInfo();
            // Phân biệt public vs private: ở GiangVien khai báo là private thì ở đây tịt ko refer được
            Console.WriteLine(giangVien.test);
        }
    }
}