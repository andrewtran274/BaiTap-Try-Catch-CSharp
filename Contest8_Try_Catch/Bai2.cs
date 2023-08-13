using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tạo một lớp để thực hiện phép chia hai số nguyên. Nếu người dùng
//cố gắng chia cho 0, đưa ra thông báo lỗi.

namespace Contest8_Try_Catch
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Nhap 1 So Nguyen A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap 1 So Nguyen B: ");
                int b = int.Parse(Console.ReadLine());

                if(b == 0)
                {
                    throw new DivideByZeroException("Khong The Chia cho 0!");
                }
                double res = (double)a / b;

                Console.WriteLine($"{a}/{b} = {res}");
            }catch(FormatException)
            {
                Console.WriteLine("Dinh Dang Khong Hop Le!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception)
            {
                Console.WriteLine("Loi Khong Xac Dinh!");
            }
        }
    }
}
