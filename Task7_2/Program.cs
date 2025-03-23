namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double volume;
            double surfaceArea;

            CalcCube(a, out volume, out surfaceArea);
            

            Console.WriteLine($"Объем куба: {volume}"); // Объем куба
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); // Площадь поверхности куба
            Console.ReadKey();
        }

        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = edgeLength * edgeLength * edgeLength;
            surfaceArea = edgeLength * edgeLength * 6;
        }
    }
}
