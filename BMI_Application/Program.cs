using System;

class BMICalculator
{
    static void Main()
    {
        Console.WriteLine("BMI Calculator");

        // Input height in meters
        Console.Write("Enter your height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Input weight in kilograms
        Console.Write("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Calculate BMI
        double bmi = CalculateBMI(height, weight);
        bmi = Math.Abs(bmi);

        // Display BMI and corresponding category
        Console.WriteLine($"Your BMI is: {bmi:F2}");
        DisplayBMICategory(bmi);

        Console.ReadLine(); // Pause to keep the console window open
    }

    static double CalculateBMI(double height, double weight)
    {
        // BMI formula: weight (kg) / (height (m))^2
        return weight / (height * height);
    }

    static void DisplayBMICategory(double bmi)
    {
        Console.Write("BMI Category: ");

        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Normal Weight");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}