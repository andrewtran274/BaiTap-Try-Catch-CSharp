using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết một ứng dụng cho phép người dùng nhập tuổi của họ. Nếu tuổi
//là số âm, ném một ngoại lệ và xử lý ngoại lệ.

namespace Contest8_Try_Catch
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Ten: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap Tuoi: ");
                int age = int.Parse(Console.ReadLine());
                if (age < 0) throw new Exception("Tuoi Khong The Am (-) !");
                Console.WriteLine($"Name: {name} - Age: {age}");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
