using System;
using System.Collections.Generic;

class Tables
{
    static void Main()
    {
        //Gosho is very good table maker. He has 4 bundles full of table legs. Every bundle holds packets. 
        //The first bundle holds packets with 1 leg, 
        //the second bundle holds packets with 2 legs and the other 2 bundles hold packets with 3 and 4 legs respectively. 
        //Example: (bundle3 = 5 packets * 3 legs = 15 legs).
        //He also has T amount of table tops and N amount of tables that need to be made. 
        //Your task is to calculate how many tables can Goshko make and whether he has made more, 
        //less or equal amount of the needed tables. 
        //Every table is made from 4 legs and 1 table top.  
        //Check the examples below to understand your task better.

        int bundle1 = int.Parse(Console.ReadLine());
        int bundle2 = int.Parse(Console.ReadLine());
        int bundle3 = int.Parse(Console.ReadLine());
        int bundle4 = int.Parse(Console.ReadLine());
        int tableTops = int.Parse(Console.ReadLine());
        int tablesToBeMade = int.Parse(Console.ReadLine());

        int bundle1Legs = bundle1 * 1;
        int bundle2Legs = bundle2 * 2;
        int bundle3Legs = bundle3 * 3;
        int bundle4Legs = bundle4 * 4;

        int sumLegs = bundle1Legs + bundle2Legs + bundle3Legs + bundle4Legs;
        int tablePossible = Math.Min(tableTops, sumLegs / 4);
        if (tablePossible == tablesToBeMade)
        {
            Console.WriteLine("Just enough tables made: {0}",tablesToBeMade);
        }
        else if (tablePossible>tablesToBeMade)
        {
            Console.WriteLine("more: {0}",tablePossible-tablesToBeMade);
            Console.WriteLine("table tops left: {0}, legs left: {1}",tablePossible-tablesToBeMade,sumLegs-4*tablesToBeMade);
        }
        else  
        {
            Console.WriteLine("less: {0}",tablePossible-tablesToBeMade);
            Console.WriteLine("tops needed");
        }



    }
}
