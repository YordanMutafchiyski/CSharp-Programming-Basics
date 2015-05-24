using System;


class CurrencyCheck
{
    static void Main()
    {
        decimal r = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal e = decimal.Parse(Console.ReadLine());
        decimal levaB = decimal.Parse(Console.ReadLine());
        decimal levaM = decimal.Parse(Console.ReadLine());

        r = r / 100 * 3.5M;
        d = d * 1.5M;
        e = e * 1.95M;
        levaB = levaB / 2M;


    }
}

