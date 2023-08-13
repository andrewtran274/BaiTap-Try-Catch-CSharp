using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết một chương trình yêu cầu người dùng nhập một chuỗi. Nếu chuỗi nhập vào chứa các ký tự đặc biệt,
//ném một ngoại lệ và xử lý ngoại lệ.

namespace Contest8_Try_Catch
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Chuoi: ");
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!char.IsLetterOrDigit(input[i]))
                    {
                        throw new FormatException("Chuoi Khong Hop Le!");
                    }

                }
                Console.WriteLine("Chuoi Hop Le!");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
