using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will calculate BMI using height and weight.
    /// </summary>
    /// <author>
    /// Student Aadhi version 0.1
    /// </author>

        

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the BMI Calculator - by Aadhi.");

        Console.Write("Hello, Please enter your name...");
        string fname = Console.ReadLine();

        Console.Write($"Hi {fname}, now let's calculate your BMI.");
        Console.Write(" Please enter your weight (KG's): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height (M's): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double BMI = weight / (height * height);
        Console.WriteLine($"Your BMI is {BMI:F2}");

        if (BMI < 18.5)
            Console.WriteLine($"Your BMI of {BMI:F2} means you're underweight, {fname}.");
        else if (BMI >= 18.5 && BMI <= 24.9)
            Console.WriteLine($"Your BMI of {BMI:F2} is normal - keep it up!, {fname}.");
        else if (BMI >= 25 && BMI <= 29.9)
            Console.WriteLine($"Your BMI of {BMI:F2} means you're overweight, {fname}.");
        else
            Console.WriteLine($"Your BMI f {BMI:F2} is unfortunately obese, {fname}.");


        Console.Write("For further information on maintaining your health please visit the NHS Website." +
            "visit www.nhs.uk");

    }
    }
}