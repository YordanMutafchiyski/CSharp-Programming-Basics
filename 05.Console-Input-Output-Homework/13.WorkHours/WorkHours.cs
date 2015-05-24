using System;

class WorkHours
{
    static void Main()
    {
//       You are asked to calculate whether Lelia Vanche can finish a project on time. You will be given the number of hours required to finish the project, the days that Lelia Vanche has available for working (mind that she goes to biking in 10% of this time) and her average productivity during the given period. Assume that a normal work day for Lelia Vanche has 12 hours. Note that only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).
//Input
//Input data should be read from the console. 
//•	The number h (the required work hours to finish the project) is on the first input line.
//•	The number d (the days available to finish the project) is on the second input line.
//•	The number p (the productivity in percent) is on the third input line.



        int requiredWorkHours = int.Parse(Console.ReadLine());
        int daysAvailable = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());
        double bikeTime = 0.1 * daysAvailable;

        double workTimeHours = (((daysAvailable - bikeTime) * 12) * productivity) / 100;
     
        if (workTimeHours < requiredWorkHours)
        {
            Console.WriteLine("No");
            int difference = requiredWorkHours - (int) workTimeHours;
            Console.WriteLine(-difference);
        }
        else if (workTimeHours >= requiredWorkHours)
        {
            Console.WriteLine("Yes");
            int difference1 =(int) workTimeHours - requiredWorkHours;
            Console.WriteLine(difference1);
        }

    }
}

