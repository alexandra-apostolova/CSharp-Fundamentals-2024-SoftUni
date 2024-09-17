using System;

public class Class1
{
    public Class1()
    {

        string countryName = Console.ReadLine();


        switch (countryName)
        {
            case "England":
            case "USA":
                Console.WriteLine("English");
                break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                Console.WriteLine("Spanish");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}

