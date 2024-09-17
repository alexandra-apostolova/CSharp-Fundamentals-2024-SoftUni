using System;

public class Class1
{
	public Class1()
	{
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());


        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
    }
}
