using System;
using System.Text;

namespace GiaiPhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b;
            Console.WriteLine("Phương trình aX + b = 0");
            Console.Write("Xin hãy nhập giá trị a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Xin hãy nhập giá trị b: ");
            b = double.Parse(Console.ReadLine());
            if (a != 0 && b != 0)
            {
                Console.WriteLine("Nghiệm của phương trình: X = " + -b / a);
            }
            else if (a != 0 && b == 0)
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Nghiệm của phương trình: X = " + -b);
            }
            else
            {
                Console.WriteLine("X có vô số nghiệm!");
            }
        }
    }
}
