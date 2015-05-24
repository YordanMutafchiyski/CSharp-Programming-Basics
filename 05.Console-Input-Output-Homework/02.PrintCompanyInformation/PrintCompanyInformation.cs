using System;
class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = "Software University";
        string companyAddress = "26 V. Kanchev, Sofia";
        string phoneNumber = "+359 899 55 55 92";
        string fax = "(no fax)";
        string website = "http://softuni.bg";
        string managerFirstName = "Svetlin";
        string managerLastName = "Nakov";
        int managerAge = 25;
        string managerPhone = "+359 2 981 981";
        Console.WriteLine("{0}\nAddress:{1}\nTel.{2}\nFax-{3}\nWeb Site: {4}\nManager:{5} {6}(age:{7}, tel.{8})", 
            companyName,companyAddress,phoneNumber,fax,website,managerFirstName,managerLastName,managerAge,managerPhone);

        //Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)
    }
}

