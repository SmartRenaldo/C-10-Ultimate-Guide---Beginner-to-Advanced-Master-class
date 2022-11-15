public class Assignment5
{
    static void Main()
    {
        int height_in_inches = 75;
        double height_in_cm = height_in_inches * 2.54;
        string result = null;

        if (height_in_cm < 150)
            result = "Dwarf";
        else if (height_in_cm >= 150 && height_in_cm <= 165)
            result = "Average height";
        else if (height_in_cm > 165 && height_in_cm <= 195)
            result = "Tall";
        else
            result = "Abnormal height";

        System.Console.WriteLine(result);
        System.Console.ReadKey();
    }
}
