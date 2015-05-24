using System;

class star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            string outerDots = new string('.', n - i);
            
            if (i == 0)
            {
                Console.WriteLine(outerDots + "*" + outerDots);
            }
            else
            {
                string innerDots = new string('.', 2 * i - 1);
                Console.WriteLine(outerDots + "*" + innerDots + "*" + outerDots);
            }
            
        }
        string arm = new string('*', n / 2 + 1);
        string innerDotsForArm = new string('.', n - 1);

        Console.WriteLine("{0}{1}{2}",arm ,innerDotsForArm,arm);
        for (int i = 1; i < n / 2 ; i++)
        {
            string outerMiddleDots = ('.',i);
            //string=
        }
    }
}

