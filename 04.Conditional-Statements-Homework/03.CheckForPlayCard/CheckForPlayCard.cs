using System;

class CheckForPlayCard
{
    static void Main()
    {
        string Card = Console.ReadLine();
        int value;
        if (Card == "A" || Card == "K" || Card == "Q" || Card == "J")
        {
            Console.WriteLine("Yes");
        }
        value = Convert.ToInt32(Card);
        if (value <= 10 && value >= 1)
        {
            Console.WriteLine("Yes");

        }
        else
        {
            Console.WriteLine("No");
        }
       



    }
}

