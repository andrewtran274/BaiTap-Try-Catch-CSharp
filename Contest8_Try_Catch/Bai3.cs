using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Viết một chương trình yêu cầu người dùng nhập một chuỗi. Nếu chuỗi nhập
//vào là rỗng, gây ra một ngoại lệ và xử lý ngoại lệ đó.

namespace Contest8_Try_Catch
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Chuoi: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new Exception("Chuoi Nhap Khong Duoc Rong~!");
                }
                Console.WriteLine("Chuoi vua nhap: " + input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
