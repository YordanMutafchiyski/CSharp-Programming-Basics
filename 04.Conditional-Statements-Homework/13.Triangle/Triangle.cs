using System;

class Triangle
{
    static void Main()
    {
//        You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: 
//        A(Ax, Ay), B(Bx,  By), C(Cx, Cy). Write a program to check if these three points can form a triangle. 
//        Then calculate the area of this triangle. 
//            To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:
//D= √(〖〖(x〗_2-x_1)〗^2+〖〖(y〗_2-y_1)〗^2 )  




        double Ax = double.Parse(Console.ReadLine());
        double Ay = double.Parse(Console.ReadLine());
        double Bx = double.Parse(Console.ReadLine());
        double By = double.Parse(Console.ReadLine());
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());
       // double perimeterHalf = (sideC + sideA + sideB) / 2;


        double sideA = Math.Sqrt(Math.Pow((Bx - Cx), 2) + (Math.Pow((By - Cy), 2)));
        double sideB = Math.Sqrt(Math.Pow((Cx - Ax), 2) + (Math.Pow((Cy - Ay), 2)));
        double sideC = Math.Sqrt(Math.Pow((Ax - Bx), 2) + (Math.Pow((Ay - By), 2)));

        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double areaTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

        if (sideA+sideB> sideC && sideA+sideC > sideB && sideB+sideC > sideA)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}",areaTriangle);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}",sideC);
        }
        

    }
}

