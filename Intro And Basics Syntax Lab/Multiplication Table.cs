using System;

public class Class1
{
	public Class1()
	{
        int number = int.Parse(Console.ReadLine());


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} X {i} = {number * i}");
        }
    }
}
