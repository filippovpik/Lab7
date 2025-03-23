namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            PrintNumbers(numbers); // Вывод: 1 2 3 4 5
            PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
            Console.ReadKey();
        }

        static void PrintNumbers(int[] array, bool f = false)
        {
            if (!f)
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i]);
            }
            else
            {
                for (int i = array.Length; i > 0; i--)
                    Console.Write(array[i - 1]);
            }
            Console.WriteLine();
        }
    }
}

