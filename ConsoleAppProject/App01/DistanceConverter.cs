using System;

namespace ConsoleAppProject.App01
{
    
    
    
   public class DistanceConverter

    {
        public const int FEET_IN_MILES = 5280;
        public const double  METRES_TO_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";
        private double fromDistance;
        private double toDistance;
        private string fromUnit;
        private string toUnit;

    
        public void ConvertDistance()
        {

            Console.WriteLine(" =================================================");
            Console.WriteLine("    Distance converter application ");
            Console.WriteLine("       by Aadhi                                  ");
            Console.WriteLine(" =================================================");

           fromUnit = SelectUnit("Please select from distance unit >");
           toUnit = SelectUnit ("Please select the to distance unit >");
            
            Console.WriteLine($"Converting {fromUnit} To {toUnit}");
            
            fromDistance = InputDistance($"Please enter number of {fromUnit} >");
            CalculateDistance(); 
            OutputDistance(fromDistance, toUnit, toDistance, toUnit);
            
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

              if(fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }

              if(fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_TO_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_TO_MILES;
            }

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
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            return ExecuteChoice(choice);

        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

    }
    
}
