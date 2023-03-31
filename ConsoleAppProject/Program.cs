using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject

{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// 22136681 Aadhi Ravichandran
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static StudentGrades grades = new StudentGrades();
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading( "Welcome to Aadhi's CO453");

            string[] choices = {"Distance Converter", "BMI Calculator",
            "Student Marks", " Social Network"};

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            DistanceConverter converter = new DistanceConverter();
            
            
            converter.ConvertDistance();
           
    
        }
    }
}
