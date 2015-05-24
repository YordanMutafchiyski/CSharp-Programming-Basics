using System;
using System.Threading;

class SumOf5Numbers
{
    static void Main()
    {
        string number = Console.ReadLine();
        string[] splitNumbers = number.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum =sum + double.Parse (splitNumbers[i]);
        }
        Console.WriteLine(sum);
        
    }
}

