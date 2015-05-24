using System;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int height = (n * 3) - (n / 2);

        Console.WriteLine("{0}*{0}", new string('.', (3 * n - 1) / 2));
        for (int i = 0; i < n / 2 + 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (3 * n - 1) / 2 - 1 - i), new string('.', 1 + i * 2));

        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - 4 - 2 * i), new string('.', n + 6 + 4 * i));

        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                new string('.', n - 4 - 2 * i),
                new string('.', 1 + 2 * i),
                new string('.', n));
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i),
                new string('.', n + 2 * i));
        }
        Console.WriteLine(new string('*', 3 * n));
        
    }
}

