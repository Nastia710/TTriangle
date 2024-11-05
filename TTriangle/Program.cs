namespace labTTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину сторони а:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину сторони b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину сторони c:");
            double c = double.Parse(Console.ReadLine());

            TTriangle triangle = new TTriangle (a, b, c);

            Console.WriteLine($"Периметр трикутника: {triangle.GetPerimeter()}");

            Console.WriteLine($"Площа трикутника: {triangle.GetArea()}");

        }
    }
}