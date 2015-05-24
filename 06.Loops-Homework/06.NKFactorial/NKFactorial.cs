using System;

class NKFactorial
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;
        int NKDivisible = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = n; i > k; i--)
            {
                
                NKDivisible *= i;

            }
            Console.WriteLine(NKDivisible);

        }
    }
}

