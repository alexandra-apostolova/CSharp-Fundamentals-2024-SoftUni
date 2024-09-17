using System;

public class Class1
{
	public Class1()
	{
        string typeDay = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        int price = 0;
        bool isValid = true;

        if (age >= 0 && age <= 18)
        {
            switch (typeDay)
            {
                case "Weekday":
                    price = 12;
                    break;
                case "Weekend":
                    price = 15;
                    break;
                case "Holiday":
                    price = 5;
                    break;
            }
        }
        else if (age > 18 && age <= 64)
        {
            switch (typeDay)
            {
                case "Weekday":
                    price = 18;
                    break;
                case "Weekend":
                    price = 20;
                    break;
                case "Holiday":
                    price = 12;
                    break;
            }
        }
        else if (age > 64 && age <= 122)
        {
            switch (typeDay)
            {
                case "Weekday":
                    price = 12;
                    break;
                case "Weekend":
                    price = 15;
                    break;
                case "Holiday":
                    price = 10;
                    break;
            }
        }
        else
        {
            isValid = false;
            Console.WriteLine("Error!");
        }

        if (isValid)
        {
            Console.WriteLine($"{price}$");
        }
    }
}
