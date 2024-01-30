using System;

public class Program
{
    // Define an enum named DaysOfWeek
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main()
    {
        // Declare a variable of type DaysOfWeek
        DaysOfWeek myDay = DaysOfWeek.Monday;

        // Output the value of myDay
        Console.WriteLine("Today is: " + myDay);

        // Output the integer value of myDay (Enums are internally represented as integers)
        Console.WriteLine("Enum value: " + (int)myDay);
    }
}
