using System;

class FunWithMatrics
{
    static void Main()
    {
        string dayOfTheWeek = Console.ReadLine();
        int quantity1 = int.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        int quantity2 = int.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        int quantity3 = int.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();
        double priceBanana = 1.80;
        double priceCucumber = 2.75;
        double priceTomato = 3.20;
        double priceOrange = 1.60;
        double priceApple = 0.86;
        switch (dayOfTheWeek)
        {
            case "Tuesday": priceBanana -= 0.2 * priceBanana;
                priceOrange -= 0.2 * priceOrange;
                priceApple -= 0.2 * priceOrange;
                priceTomato -= 0.2 * priceTomato;
                break;
            default:
                break;
        }
            priceBanana -= 0.2 * priceBanana;
            priceOrange -= 0.2 * priceOrange;
            priceApple -= 0.2 * priceApple;
            priceTomato -= 0.2 * priceTomato;
        
        
            priceCucumber -= 0.2 * priceCucumber;
        
       
        
            priceBanana -= 0.1 * priceBanana;
            priceOrange -= 0.1 * priceOrange;
            priceApple -= 0.1 * priceOrange;
            priceTomato -= 0.1 * priceTomato;
            priceCucumber -= 0.1 * priceCucumber;
        
        
        
            priceBanana -= 0.05 * priceBanana;
            priceOrange -= 0.05 * priceOrange;
            priceApple -= 0.05 * priceOrange;
            priceTomato -= 0.05 * priceTomato;
            priceCucumber -= 0.05 * priceCucumber;
        
        


        //        The local fruit market offers fruits and vegetables with the following standard price list:
        //•	banana  1.80
        //•	cucumber  2.75
        //•	tomato  3.20
        //•	orange  1.60
        //•	apple  0.86	The market owner decided to introduce the following discounts:
        //•	Friday  10% off for all products
        //•	Sunday  5% off for all products
        //•	Tuesday  20% off for fruits
        //•	Wednesday  10% off for vegetables
        //•	Thursday  30% off for bananas


    }
}

