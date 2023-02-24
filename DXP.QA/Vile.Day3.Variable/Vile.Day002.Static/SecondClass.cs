using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vile
{
    public class SecondClass
    {
        static public void Func()
        {
            Console.WriteLine("Hello World from class 1");
        }
        public void printInfo()
        {
            // hàm Func ở trong class 1 không phải static nên được gọi sau khi khởi tạo như sau:
            FirstClass obj = new FirstClass();
            obj.Func();
            // Hàm Func ở trong class 2 là static nên cần khởi tạo, mà gọi luôn thông qua tên class như sau:
            SecondClass.Func();

            // Nếu khởi tạo class thì không truy xuất đến hàm static thông qua khởi tạo, ví dụ:
            SecondClass obj2 = new SecondClass();
            // lỗi nếu gọi vì khi hàm là static thì gọi bằng [tên class].[tên hàm] obj2.Func();
            //obj2.Func();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++ End of day 2 ++++++++++++++++++++++++++++++++++++++");
            Console.ReadKey();

        }

    }
}
