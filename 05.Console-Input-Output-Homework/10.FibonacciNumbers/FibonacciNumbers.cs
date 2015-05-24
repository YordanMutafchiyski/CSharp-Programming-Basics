using System;


class FibonacciNumbers
{
    static void Main()
    {
//        Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. Examples:
//n	comments
//1	0
//3	0 1 1
//10	0 1 1 2 3 5 8 13 21 34
        int n = int.Parse(Console.ReadLine());
        int numberFibonacci1 = 0;
        int numberFibonacci2 = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(numberFibonacci1 + " ");
            int nextNumberInFibonacci = numberFibonacci1;
            numberFibonacci1 = numberFibonacci2;
            numberFibonacci2 = nextNumberInFibonacci + numberFibonacci1;
        }

    }
}

