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
        /// Constants
        
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        /// Properties

        public string [] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
        {
            "Kain","Maze","Chloe","Dan","Amenadiel",
            "Linda", "Trixie", "Lucy", "Aadhi",
            "Uthman"
        };

        GradeProfile = new int [(int)Grade.A + 1];
        Marks = new int[StudentGrades.Length];
        }
        
    
    }
    public void InputMarks()
    {
        throw new NotImplementedException();
    }
    public void OutputMarks()
    {
        throw new NotImplementedException();
    }
    public Grades ConvertToGrade(int mark)
    {
        if (mark >= 0 && mark < LowestGradeD)
        {
            return Grades.F;
        }
        else return Grades.D;
    }
    public void CalculateMean()
    {
        // Arrange 

        int [] statsMarks = new int []
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        StudentGrades.Marks = statsMarks;

        double expectedMean = 55.0;

        // Act

        StudentGrades.CalculateStats();

        // Assert

        
        Assert.AreEqual(expectedMean, studentGrades.Mean);
    }
    public void CalculateStats()
    {
        Minimum = Marks[0];
        Maximum = Marks[0];

        double total = 0;

        foreach(int mark in Marks)
        {
            if (mark > Maximum) Maximum = mark;
            if (mark < Minimum) Minimum = mark;
            total += mark;
        }

        Mean = total / Marks.Length;
    }
    public void CalculateGradeProfile()
    {
        for (int i = 0; i < GradeProfile.Length; i++)
        {
            GradeProfile[i] = 0;
        }

        foreach (int mark in Marks)
        {
            Grades grade = ConvertToGrade(mark);
            GradeProfile[(int) grade]++;
        }
    }

   
}
