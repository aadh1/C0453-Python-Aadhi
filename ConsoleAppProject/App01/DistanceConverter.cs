using System;

namespace ConsoleAppProject.App01
{
    
    
    
   public class DistanceConverter

    {
        public const int MILES_TO_FEET = 52800;
        public const double  METRES_TO_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";
        private double fromDistance;
        private double toDistance;
        private string fromUnit;
        private string toUnit;
        private double miles;
        private double feet;
        private double metres;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
        public void ConvertDistance()
        {
           fromUnit = SelectUnit("Please select from distance unit >");
           toUnit = SelectUnit ("Please select the to distance unit")
            OutputHeading($"Converting {fromUnit} To {toUnit}");
            
            miles = InputDistance($"Please enter number of {fromUnit} >");
            //CalculateFeet();
            OutputDistance(fromDistance, toUnit, toDistance, toUnit);
        }

        private void OutputHeading(string v)
        {
            throw new NotImplementedException();
        }

        private string SelectUnit(string v)
        {
            throw new NotImplementedException();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            
            feet = InputDistance("Please enter number of feet >");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");
            
            miles = InputDistance("Please enter number of miles >");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        private void OutputDistance(double miles, string v1, object metres, string v2)
        {
            throw new NotImplementedException();
        }

        private double InputDistance(String prompt)
        {
           Console.Write(prompt);
           string value = Console.ReadLine();
           return Convert.ToDouble(value);

        }

       
        private void OutputDistance(double fromDistance, string fromUnit,
        double toDistance, string toUnit)
        {
            Console.WriteLine($"{fromDistance} {fromUnit}" +
            $"is {toDistance} {toUnit}");
        }
       

    }
    private void OutputHeading(String prompt)
    {
         Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    Distance converter application ");
            Console.WriteLine("       by Aadhi                                  ");
            Console.WriteLine(" =================================================");
           
            Console.WriteLine(prompt);
            Console.WriteLine();
    }   
}
