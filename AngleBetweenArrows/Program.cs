using System;

class Program
{
    private static int hours;
    private static int minutes;


    static int calculate(double hours, double minutes)
    {


        if (minutes == 60)
        {
            minutes = 0;
            hours += 1;
            if (hours > 12)
                hours = hours - 12;
        }
        if (hours == 12)
            hours = 0;


        // calculate the angle between hour hand and minute hand 
        int calc_angle = (int)Math.Abs(5 * ((6 * hours) - (1.1 * minutes)));


        // this checks if angle is > 180

        if (calc_angle > 180)
        {
            calc_angle = 360 - calc_angle;
        }


        return calc_angle;
    }


    public static void Main()
    {

        Console.WriteLine("Enter hours: ");

        hours = int.Parse(Console.ReadLine());
        if (hours < 0 || hours > 12)
        {
            Console.Write("Enter valid input for hours ");
            return;
        }
        Console.WriteLine("Enter minutes: ");
        minutes = int.Parse(Console.ReadLine());
        if (minutes < 0 || minutes > 60)
        {
            Console.Write("Enter valid input for minutes ");
            return;
        }

        Console.WriteLine("Calculated angle is:" + calculate(hours, minutes) + "°");


    }
}