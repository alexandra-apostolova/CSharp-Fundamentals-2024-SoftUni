using System;

public class Class1
{
    public Class1()
    {
        int hoursInput = int.Parse(Console.ReadLine());
        int minutesInput = int.Parse(Console.ReadLine());

        int timeInMinutes = minutesInput + (hoursInput * 60);

        int finalTime = timeInMinutes + 30;

        int hours = finalTime / 60;
        int minutes = finalTime % 60;

        if (hours >= 24)
            hours = 0;

        Console.WriteLine($"{hours}:{minutes:d2}");
    }
}


