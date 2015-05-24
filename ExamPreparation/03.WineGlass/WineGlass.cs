using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 12)
        {
            Console.WriteLine("\\{0}/", new string('*', n));
            Console.WriteLine(".\\{0}/.", new string('*', n - 2));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("");
            }
        }
        else if (n < 12)
        {
            Console.WriteLine("\\{0}/", new string('*', n));
            Console.WriteLine(".\\{0}/.", new string('*', n - 2));
        }

    }
}

