using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class PetarsGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        

        ulong sum = 0;
        ulong  remainder = 1;

        for (ulong i = startNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else if (i % 5 != 0)
            {
                remainder = i % 5;
                sum += remainder;
            }
        }
        if (sum % 2 == 0)
        {
            ulong firstdigit;
            if (sum < 10)
            {
                firstdigit = sum; string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 100){


                firstdigit = sum / 10;
                string replacedstar = Regex.Replace(sum.ToString(),firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 1000)
            {
                firstdigit = sum / 100;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 10000)
            {
                firstdigit = sum / 1000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 100000)
            {
                firstdigit = sum / 10000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 1000000)
            {
                firstdigit = sum / 100000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 10000000)
            {
                firstdigit = sum / 1000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 100000000)
            {
                firstdigit = sum / 10000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 1000000000)
            {
                firstdigit = sum / 100000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 10000000000)
            {
                firstdigit = sum / 1000000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum<10000000000)
            {
                firstdigit = sum / 10000000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum<100000000000)
            {
                firstdigit = sum / 100000000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
            else if (sum < 1000000000000)
            {
                firstdigit = sum / 1000000000000;
                string replacedstar = Regex.Replace(sum.ToString(), firstdigit.ToString(), replacement);
                Console.WriteLine(replacedstar);
            }
           
        }
        else if (sum % 2 != 0)
        {
            ulong lastDigit = sum % 10;
            ulong number=lastDigit;
            

            string replacedstar = Regex.Replace(sum.ToString(),number.ToString(), replacement);
            

            Console.WriteLine(replacedstar);
            
        }
        


    }
}

