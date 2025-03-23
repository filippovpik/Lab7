namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 3)); // Вывод: 6
            Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75
            Console.ReadKey();
        }

        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}
