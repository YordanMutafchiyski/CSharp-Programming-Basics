using System;

class CompoundSolution
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());

        double f = double.Parse(Console.ReadLine());

        double bankMoney = p * (Math.Pow(1 + i, n));
        double friendMoney = p * (1 + f);

        if (bankMoney < friendMoney)
        {
            Console.WriteLine("{0:F2} Bank", bankMoney);
        }
        else if (friendMoney < bankMoney)
        {
            Console.WriteLine("{0:F2} Friend", friendMoney);
        }

    }
}

