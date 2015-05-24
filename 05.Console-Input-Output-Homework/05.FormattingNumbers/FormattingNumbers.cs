using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(a, 2).PadLeft(10,'0');
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X} |{1}| {2,10:F2}||{3,-10:F3}| ", a, binary, b, c);

    }
}

 