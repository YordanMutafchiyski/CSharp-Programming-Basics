using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        double weightOnMoon = 0.17 * weight;
        Console.WriteLine(weightOnMoon);
    }
}

