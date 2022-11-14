using System;

public class Assignment2
{
    static void Main()
    {
        int feet = 5, inches = 7;
        int total = (feet * 12) + inches;
        double centimeters = total * 2.54;

        System.Console.WriteLine(centimeters);
        System.Console.ReadKey();
    }
}