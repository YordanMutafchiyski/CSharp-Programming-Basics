using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int n = 7;
        int thirdDigit = (a / 100) % 10;
        if (thirdDigit == n)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        
    }
}

