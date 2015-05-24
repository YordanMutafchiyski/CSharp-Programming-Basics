using System;

class NumbersIntervalDividableGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                //Console.WriteLine(i);

                counter = counter + 1;
            }
        }
        Console.WriteLine(counter);
    }
}

