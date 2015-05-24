using System;
using System.Numerics;

class CalculateFormula
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int m = n - k;

        BigInteger nkDivisible = 1;
        //int m = n - k;
        BigInteger mFactorial = 1;
        if (1 < k && k < n && n < 100)
        {
            for (int i = n; i > k; i--)
            {
                nkDivisible *= i;

                //Console.WriteLine(nkDivisible/mFactorial);
            }
            for (int j = 1; j <= m; j++)
            {
                mFactorial *= j;
            }
            Console.WriteLine(nkDivisible / mFactorial); 
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        
    }
}

