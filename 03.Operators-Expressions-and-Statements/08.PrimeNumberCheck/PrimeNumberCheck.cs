using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if ((n % 2 != 0) || (n == 2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

