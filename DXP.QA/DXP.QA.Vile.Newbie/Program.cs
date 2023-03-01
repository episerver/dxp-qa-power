using DXP.QA.Vile.Newbie.Vile.Day001.DataType;
using DXP.QA.Vile.Newbie.Vile.Day002.Static;
using DXP.QA.Vile.Newbie.Vile.Day003.Variable;
using DXP.QA.Vile.Newbie.Vile.Day005.Loop;

namespace Vile
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //DAY 001:
            //data type Int, string, bool
            var day1 = new DataType();
            day1.printInfo();
            // DAY 002:
            // Static
            SecondClass secondclass = new SecondClass();
            secondclass.printInfo();
            
            // DAY 003:
            // Variable, sử dụng $
            //Cách cũ
            // GiangVien giangvien = new GiangVien(111, "Viet Le", "165 Thai Ha", "Toan", "Hinh Giai Tich"); 
            //Cách mới
            var giangVien = new GiangVien(111, "Viet Le", "165 Thai Ha", "Toan", "Dai so gia tu", "Emond LAngte");
            giangVien.printInfo();
            // Phân biệt public vs private: ở GiangVien khai báo là private thì ở đây tịt ko refer được
            //Console.WriteLine(giangVien.khoa); ==> lỗi vì field khoa là private
            Console.WriteLine(giangVien.test); // ==> OK vì test field là public

            //Day004: naming convention

            //DAY005: IF WHILE FOR LIST ARRAY
            var sv = new SinhVien("T01", "Viet Le", 1985);
            //var sinhVien = new List<SinhVien>{}
        }
    }
}