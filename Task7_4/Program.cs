namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int maxNumber = FindMax(77, 25, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number
            Console.ReadKey();
        }

        static int FindMax(params int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}

