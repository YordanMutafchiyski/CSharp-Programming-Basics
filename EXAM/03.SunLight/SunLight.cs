using System;

class SunLight
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());


        Console.WriteLine("{0}*{0}", new string('.', (n * 3) / 2));
        int dotsMiddle = n + (n / 2 - 2);
        int dotsOuter=1;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.',dotsOuter),new string('.',dotsMiddle));
            dotsMiddle-=1;
            dotsOuter++;
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        //Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        Console.WriteLine("{0}", new string('*', 3 * n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        for (int i = 0; i < n - 1; i++)
        {
            dotsMiddle += 1;
            dotsOuter--;
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsOuter), new string('.', dotsMiddle));
            //dotsMiddle += 1;
            //dotsOuter--;
        }

        Console.WriteLine("{0}*{0}", new string('.', (n * 3) / 2));


        

    }
}
