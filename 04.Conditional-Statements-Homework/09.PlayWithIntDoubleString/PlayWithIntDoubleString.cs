using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int\n2 --> double\n3 --> string");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1: int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n+1);
                break;
            case 2: double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b+1);break;
            case 3: string word = Console.ReadLine(); 
                Console.WriteLine(word + "*");break;

            default:
                break;
        }

    }
}

