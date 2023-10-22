namespace AverageCalculation
{
    class Fibonacci
    {
        public int Depth { get; set; }
        public int[] Sequence { get; set; }

        public Fibonacci(int depth)
        {
            Depth = depth;
            Sequence = new int[Depth];
        }

        public void GenerateSequence()
        {
            int a = default(int), b = 1;
            for (int i = default(int); i < Depth; i++)
            {
                Sequence[i] = a;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }

        public double CalculateAverage()
        {
            if (Depth == default(int))
                return default(int);
            int sum = default(int);
            foreach (int number in Sequence)
                sum += number;
            return (double)sum / Depth;
        }
    }
}
