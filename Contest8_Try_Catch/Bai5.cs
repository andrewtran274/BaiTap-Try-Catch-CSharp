using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tạo một lớp để thực hiện phép chia một số nguyên cho một số nguyên khác.
//Nếu kết quả có dư, ném một ngoại lệ và xử lý ngoại lệ.

namespace Contest8_Try_Catch
{
    internal class Bai5
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap So Nguyen A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap So Nguyen B: ");
                int b = int.Parse(Console.ReadLine());

                if(b == 0)
                {
                    throw new DivideByZeroException("Khong the chia cho 0!");
                }
                if(a % b != 0)
                {
                    throw new Exception("Ket Qua Co Du!");
                }

                Console.WriteLine($"Ket Qua: {a / b}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Dinh Dang Gia Tri Nhap Vao Khong Dung!");
            }catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
