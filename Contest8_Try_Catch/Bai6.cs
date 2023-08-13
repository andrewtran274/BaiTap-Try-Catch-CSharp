using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Xây dựng một chương trình yêu cầu người dùng nhập tên một tệp. Nếu tên tệp không hợp lệ (ví dụ: chứa ký tự đặc biệt),
//ném một ngoại lệ và xử lý ngoại lệ.

namespace Contest8_Try_Catch
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Ten: ");
                string input = Console.ReadLine();

                for(int i = 0; i < input.Length; i++)
                {
                    if (!char.IsLetter(input[i]))
                    {
                        throw new FormatException("Ten Khong Hop Le!");
                    }
                   
                }
                Console.WriteLine("Ten Hop Le!");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
