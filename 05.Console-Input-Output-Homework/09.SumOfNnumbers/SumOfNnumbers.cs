using System;

class SumOfNnumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int k = int.Parse(Console.ReadLine());
            sum = sum + k;
        }
        Console.WriteLine(sum);
    }
}

