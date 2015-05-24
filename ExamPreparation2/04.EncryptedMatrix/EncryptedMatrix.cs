using System;

class EncryptedMatrix
{
    static void Main()
    {
        string text = Console.ReadLine();
        string slash = Console.ReadLine();
        int[] array = new int[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            int asciiLastDigit = text[i] % 10;
            array[i] = asciiLastDigit;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                array[i] *= array[i];
            }
            else
            {
                if (i - 1 > 0)
                {
                    array[i] += array[i - 1];
                }
                if (i < array.Length-1)
                {
                    
                }
            }
        }
        Console.WriteLine();
    }
}

