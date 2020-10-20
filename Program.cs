using System;
using System.Text;

namespace GiaiPhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phương trình bậc nhất aX + b = 0");
            Console.Write("Xin hãy nhập giá trị a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Xin hãy nhập giá trị b: ");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương Trình Có Vô Số Nghiệm!");
                }
                else
                {
                    Console.WriteLine("Phương Trình Vô Nghiệm!");
                }
            }
            else
            {
                Console.WriteLine("Phương Trình Có Nghiệm X = {0}", -b / a);
            }
        }
    }
}
