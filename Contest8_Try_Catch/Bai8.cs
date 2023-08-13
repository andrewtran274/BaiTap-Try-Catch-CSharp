using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết một chương trình quản lý danh sách học sinh. Nếu người dùng cố gắng nhập điểm không hợp lệ
//(nằm ngoài khoảng từ 0 đến 10), ném một ngoại lệ và xử lý ngoại lệ.

namespace Contest8_Try_Catch
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
    }
    internal class Bai8
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            try
            {
                while (true)
                {
                    Console.WriteLine("Nhap Ten Sinh Vien: ");
                    string name = Console.ReadLine();

                    if (name.ToLower() == "exit")
                    {
                        break;
                    }
                    Console.WriteLine("Nhap Diem (0 <= Score <= 10): ");
                    double score = double.Parse(Console.ReadLine());
                    if(score < 0 || score > 10)
                    {
                        throw new Exception("Diem Khong Hop Le!");
                    }
                    list.Add(new Student { Name = name, Score = score });
                }
                Console.WriteLine("Danh Sach Sinh Vien: ");
                foreach (var student in list)
                {
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Score: {student.Score}");
                }
            }catch (FormatException e) {
                Console.WriteLine(e.Message);
            }catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
