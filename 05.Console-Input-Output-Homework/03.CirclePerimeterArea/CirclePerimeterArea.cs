using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double C = Math.PI * 2 * r;
        Console.WriteLine("The perimeter of the circle:{0:F2}",C);
        double areaCircle = Math.Pow(r, 2) * Math.PI;
        Console.WriteLine("The Area of the circle is:{0:F2}",areaCircle);
    }
}

