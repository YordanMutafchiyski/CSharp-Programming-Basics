using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());

            max = Math.Max(max,numbers);
            min = Math.Min(min, numbers);

            sum += numbers;

            
        }

        avg = sum / n;
        Console.WriteLine("Max: {0}",max);
        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Avg: {0:F2}", avg);
    }
}

