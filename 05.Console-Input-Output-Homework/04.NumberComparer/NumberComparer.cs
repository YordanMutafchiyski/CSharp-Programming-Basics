using System;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a>b)
        {
            Console.WriteLine(a);
        }
        else if (b>a)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine("a=b");
        }
    }
}

