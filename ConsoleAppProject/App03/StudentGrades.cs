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
        public const int Percentage = 100;

        /// Properties

        public string [] Students { get; set; }
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
     choice - Console.ReadLine();
        
        if (choice == "1")
        {
            Console.WriteLine("Please select from list");
            OutputMarks();
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
        Console.WriteLine("Please type a Mark for each Student");
        Console.WriteLine("------------------------------------");

        int i = 0;
        foreach (var student in Students)
        {
            int mark = (int)ConsoleHelper.InputNumber(
                $" Enter {student}'s Mark > ", MIN, MAX);

                Marks [i] = mark;
                i++;

            
        };

        Console.WriteLine();
    }
    public void OutputMarks()
    {
        throw new NotImplementedException();
    }
    public Grades ConvertToGrade(int mark)
    {
        if (mark >= LowestGradeF && mark < LowestGradeD - 1)
        return Grades.F;
        if (mark >= LowestGradeD && mark < LowestGradeC - 1)
        else return Grades.D;
        if (mark >= LowestGradeC && mark < LowestGradeB - 1)
        return Grades.C;
        if (mark >= LowestGradeB && mark < LowestA - 1)
        else return Grades.B;
        if (mark >= lowestGradeA && mark <= maxMark)
        return Grades.A;

        else return Grades.X;
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

    private void OutputStatistics()
    {
        Console.WriteLine(" Grade Stats");
        Console.WriteLine("-------------");
        Console.WriteLine($" Minimum Mark is {Minimum}");
        Console.WriteLine($" Maximum Mark is {Maximum}");
        Console.WriteLine($" Mean Mark is {Mean}");

    }

    public void CalculateGradeProfile()
    {
        F = F / Students.Length;
        D = D / Students.Length;
        C = C /
        B = B /
        A = A /

        for (int i = 0; i < GradeProfile.Length; i++)
        {
            GradeProfile[i] = 0;
        }

        foreach (int mark in Marks)
        {
            Grades grade = ConvertToGrade(mark);
            GradeProfile[(int) grade]++;
        }

        OutputGradeProfile();
    }

    private void OutputGradeProfile()
    {

        Console.WriteLine(" Grade Profile");
        Console.WriteLine("---------------");

        Grades grade = Grades.F;
        foreach (int count in GradeProfile)
        {
            int percentage = count * Percentage / Marks.Length;
            Console.WriteLine($" Grade {grade}: Count {count}({percentage}%)");
            grade++;
        }

        Console.WriteLine();
    }

   

}