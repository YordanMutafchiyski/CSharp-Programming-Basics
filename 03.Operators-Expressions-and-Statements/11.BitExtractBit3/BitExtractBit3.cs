using System;

class BitExtractBit3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightp = n >> p;
        int bit = nRightp & 1;
        Console.WriteLine(bit);
    }
}

