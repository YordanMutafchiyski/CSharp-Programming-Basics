using System;

class NumberNotDivisibleBy3And7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool result;
        for (int i = 0; i <= n; i++)
        {
            result = ((i % 3 != 0) && (i % 7 != 0));
            if (result)
            {
                Console.WriteLine(i);
            }  
            

        }

    }
}

