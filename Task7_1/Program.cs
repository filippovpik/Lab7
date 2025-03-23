using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 3;
            int b1 = 4;
            double c1 = Math.Sqrt(a1 * a1 + b1 * b1);

            int a2 = 1;
            int b2 = 1;
            double c2 = Math.Sqrt(a2 * a2 + b2 * b2);

            double s1 = Square(a1, b1, c1);
            double s2 = Square(a2, b2, c2);


            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                Console.WriteLine("Площадь второго треугольника больше");

            Console.ReadKey();
        }

        static double Square(double a1, double b1, double c1)
        {
            double p = 0.5 * (a1 + b1 + c1);
            double s = Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1));
            return s;
        }
    }
}
