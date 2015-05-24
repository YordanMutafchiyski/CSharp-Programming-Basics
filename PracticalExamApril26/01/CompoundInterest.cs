using System;

class CompoundInterest
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        double BankLoan = n * (Math.Pow((1 + i), n));
        double FriendLoan = n * (Math.Pow(((1 + f)), n));

        if (BankLoan < FriendLoan)
        {
            Console.WriteLine("{0:F2} Bank", BankLoan);
        }
        else if (FriendLoan < BankLoan)
        {
            Console.WriteLine("{0:F2} Friend",FriendLoan);
        }


    }
}

