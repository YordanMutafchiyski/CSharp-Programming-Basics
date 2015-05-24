using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicSum = int.Parse(Console.ReadLine());

        bool hasMagicSum = false;

        for (DateTime i = new DateTime(startYear, 01, 01); 
            i <=new DateTime(endYear, 12, 31);
            i=i.AddDays(1))
        {
            int currentMagicSum = 0;
            string dateAsString=i.ToString("ddMMyyyy");
           
            for (int j = 0; j < dateAsString.Length; j++)
            {
                int startDigit = int.Parse(dateAsString[j].ToString());

                for (int k = j + 1; k < dateAsString.Length; k++)
                {
                    int currentDigit = int.Parse(dateAsString[k].ToString());
                    currentMagicSum += startDigit * currentDigit;
                }
            }
            if (currentMagicSum == magicSum)
            {
                hasMagicSum = true;
                Console.WriteLine(i.ToString("dd-MM-yyyy"));
            }
            
        }
        if (!hasMagicSum)
        {
            Console.WriteLine("No");
        }
    }
}
