using System;

class FourDigitNumber
{
    static void Main()
    {
        int abcd = int.Parse(Console.ReadLine());
        int a = (abcd / 1000) % 10;
        int b = (abcd / 100) % 10;
        int c = (abcd / 10) % 10;
        int d = (abcd % 10);
        //Console.WriteLine(a);
        int sumFourDigits = a + b + c + d;
        Console.WriteLine(sumFourDigits);
        Console.WriteLine("The reversed number is  {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("The last digit in front {0}{1}{2}{3}",d,a,b,c);
        Console.WriteLine("Exchange second and third digit:{0}{1}{2}{3} ",a,c,b,d);

    }
}

