using System;

public class Class1
{
	public Class1()
	{
        int n = int.Parse(Console.ReadLine());


        int sum = 0;
        int number = 1;
        int odd = 0;

        while (n != odd)
        {
            if (number % 2 == 0)
            {
                number++;
                continue;
            }

            sum += number;
            Console.WriteLine(number);

            number++;
            odd++;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
