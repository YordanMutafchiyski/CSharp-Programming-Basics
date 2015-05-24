using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool outOfRectangle = x > 1 || x < 6 && y > -1 || y < 2;

        if (isInCircle && outOfRectangle)
        {
            Console.WriteLine("yes");
        }
        else if (x==0 && y==0)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("no");
        }
        
    }
}

