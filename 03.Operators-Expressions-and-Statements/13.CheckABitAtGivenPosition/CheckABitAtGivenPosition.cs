using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int nRightp = n >> p;
        int bit = nRightp & 1;
        if (bit == 1)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        
    }
}

