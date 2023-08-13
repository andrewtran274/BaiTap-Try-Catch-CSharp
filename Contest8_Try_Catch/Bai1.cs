using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết một phương thức cho phép người dùng nhập một số nguyên dương. Nếu người dùng nhập số âm hoặc
//không phải là số, đưa ra thông báo lỗi.

namespace Contest8_Try_Catch
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Mot So Nguyen Duong: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0) throw new Exception("So Khong Hop Le! (Khong The Am)");
                Console.WriteLine($"So vua Nhap la: {n}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
