using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A = First Class  : 70-100
    /// Grade B = Upper Second : 60-69
    /// Grade C = Lower Second : 50-59
    /// Grade D = Third Class  : 40-49
    /// Grade F = Fail         : 0-39
    /// </summary>

    public class StudentGrades
    {
        public const int FIRSTCLASS = 70;
        public const int UPPERSECONDCLASS = 60;
        public const int LOWERSECONDCLASS = 50;
        public const int THIRDCLASS = 40;
        public const int FAIL = 0;

        /// Constants
        
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public const int MIN = 0;
        public const int MAX = 100;

        /// Properties

        public string [] Students { get; set; }
        public int[] Counts = new int [5];
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Total { get; set; }

       

        public StudentGrades()
        {
            Students = new string[]
            {
            "Kain","Maze","Chloe","Dan","Amenadiel",
            "Linda", "Trixie", "Lucy", "Aadhi",
            "Uthman"
            };

        GradeProfile = new int [(int)Grades.A + 1];
        Marks = new int[Students.Length];
        }
        public void Run()
        {
            DisplayMenu();

        }
    
    }
    public void DisplayMenu()
    {
     Console.WriteLine("1. Input Marks");
     Console.WriteLine("2. Ouput Grades");
     Console.WriteLine("3. Output Statistics");
     Console.WriteLine("4. Output Grade Profile");
     string choice;

    Console.WriteLine("\t");
     Console.WriteLine("Answer :");
     choice = Console.ReadLine();
        
        if (choice == "1")
        {
            Console.WriteLine("Please select from list");
            InputMarks();
        }
        else if (choice == "2")
        {
            Console.WriteLine(" Please select from list");
            OutputMarks();
        }
        if (choice == "3")
        {
            Console.WriteLine("Please select from list");
            OutputStatistics();
        }
        else if (choice == "4")
        {
            Console.WriteLine(" Please select from list");
            OutputGradeProfile();
        }
        else if (choice == "5")
        {
            Environment.Exit(0);
        }
    }

    public void InputMarks()
    {
        for (int i = 0; i < Students.Length; i++)
        {
            bool validInput = false;
            int mark = 0;
            while (!validInput)
            {
                Console.WriteLine("Enter mark... '{ Student[i]}' :");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out mark))
                {
                    Console.WriteLine("error");
                }
                else if (mark > 100 || mark < 0)
                {
                    Console.WriteLine("error!");
                }
                else
                {
                    validInput = true;
                }
                Marks[i] = mark;
            }
            DisplayMenu();
        }
    }
    public void OutputMarks()
    {
        Console.WriteLine("Names".PadRight(5) + "Marks".PadRight(12) + "Grade");
        Console.WriteLine("-----".PadRight(5) + "-----".PadRight(12) + "-----");
        int students = 0;
        for (int i = 0; i < Marks.Length; i++)
        {
            int mark = Marks[i];
            Grades grades = ConvertMarktoGrade(mark);
            Console.WriteLine($"{Students[i]}".PadRight(5));
            Console.WriteLine($"{Marks[i]}".PadRight(6));
            Console.WriteLine($"{grades}");
            students++;

            Console.WriteLine($"Here are the {students}" + " students. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();


        }
    }
    public Grades ConvertMarktoGrade(int mark)
    {
        if (mark < 40)
        {
            return Grades.F;
        }
        else if (mark > 39 && mark < 50)
        {
            return Grades.D;
        }
        else if (mark < 49 && mark < 60)
        {
            return Grades.C;
        }
        else if (mark > 59 && mark < 70)
        {
            return Grades.B;
        }
        else if (mark > 69)
        {
            return Grades.A;
        }
        else return Grades.F;
    }

    public Grades ConvertToGrade(int mark)
    {
        if (mark >= 0 && < LowestMarkD)
        {
            return Grades.F;
        }
        else if (mark >= 0 &&  mark < LowestMarkC)
        {
            return Grades.D;
        }
        else if (mark >= 0 && mark < LowestMarkB)
        {
            return Grades.C;
        }
        else if (mark >= 0 &&  mark < LowestMarkA)
        {
            return Grades.B;
        }
        else if (mark >= 0 &&  mark < HighestMark)
        {
            return Grades.A;
        }
        return Grades.X;

    }
    public void CalculateMinMax()
    {
        Minimum = Marks[0];
        Maximum = Marks[100];

        foreach (int mark in Marks)
        {
            if (mark > Maximum)
            {
                Maximum = mark;
            }
            else if (mark < Minimum)
            {
                Minimum = mark;
            }
        }
    }
    public void CalculateMean()
    {
      foreach ( int mark in Marks)
      {
        if (mark > Maximum) { Maximum = mark;}

        if (mark < Minimum) { Minimum = mark;}
        Total += mark;
      }
      double Mean = (double)Total / Students.Length;
    }
    

    public void OutputStatistics()
    {
      CalculateMean();
      CalculateMinMax();
      Console.WriteLine($"Mean Mark: {Mean}\nMinimum Mark: {Minimum}\nMaximum Mark: {Maximum}");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Click a key");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.ReadKey();
      DisplayMenu();
    }


    public void OutputGradeProfile()
    {

        CalculateGradeProfile()
        int total = Counts.Sum();

        Console.WriteLine($" A (First Class > There's {Counts[0]} students within this range, which are {(double)Counts[0] / total:P}2");
        Console.WriteLine($" B (Upper Second Class > There's {Counts[1]} students within this range, which are {(double)Counts[1] / total:P}2");
        Console.WriteLine($" C (Lower Second Class > There's {Counts[2]} students within this range, which are {(double)Counts[1] / total:P}2");
        Console.WriteLine($" D (Third Class > There's {Counts[3]} students within this range, which are {(double)Counts[3] / total:P}2");
        Console.WriteLine($" F (Fail > There's {Counts[4]} students within this range, which are {(double)Counts[4] / total:P}2");

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Click a key");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        DisplayMenu();


        
    }

   

}