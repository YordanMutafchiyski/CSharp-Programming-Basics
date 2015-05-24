using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int center = n / 2;

        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        for (int i = 0; i < n - 2; i++)
        {
            char middleSymbol = ' ';
            if (i==(n-2)/2)
            {
                middleSymbol = '|';
            }
            // Console.Write("{0}{1}{0}",new string('*',2 * n),new string(' ',n));
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(middleSymbol,n));
            //Console.Write("{0}*{1}*",new string(' ',n),new string ('/',n*2-2));
        }

        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
    }
}
