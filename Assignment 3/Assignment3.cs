using System;

public class Assignment3
{
    static void Main(string[] args)
    {
        int number = 6792;
        decimal decimal_number = number; 

        int previous_thousand = number / 1000 * 1000;

        decimal last_three_digits_a = decimal_number / 1000;
        decimal last_three_digits_b = number / 1000;

        decimal last_three_digits = (last_three_digits_a - last_three_digits_b) * 1000; 

        int rounding_value = (last_three_digits >= 500)? 1000 : 0;
        
        int is_less_than_five_hundred = (number < 500)? 1000 : 0;

        int nearest_thousand = previous_thousand + rounding_value + is_less_than_five_hundred;
        System.Console.WriteLine(nearest_thousand);
        System.Console.ReadKey();
    }
}