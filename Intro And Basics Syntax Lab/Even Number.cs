﻿using System;

public class Class1
{
    public Class1()
    {
        int number = int.Parse(Console.ReadLine());

        while (true)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
            }
            else
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
                break;
            }
            number = int.Parse(Console.ReadLine());
        }
    }
}

