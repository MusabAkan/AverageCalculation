using AverageCalculation;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Fibonacci aralığı girin: ");
            int depth = int.Parse(Console.ReadLine());

            if (depth <= default(int))
            {
                Console.WriteLine("Geçersiz aralık değeri. Pozitif bir tamsayı girin.");
                return;
            }

            Fibonacci fibonacci = new (depth);
            fibonacci.GenerateSequence();
            double average = fibonacci.CalculateAverage();

            Console.WriteLine($"Fibonacci serisi: {string.Join(", ", fibonacci.Sequence)}");
            Console.WriteLine($"Ortalama: {average:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş. Bir tamsayı girin.");
        }
    }
}