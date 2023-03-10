using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{

[TestClass]
public class StudentGradesTest
{
    private readonly StudentGrades converter = new StudentGrades();
    
    [TestMethod]
    public void TestConvert0ToGradeF()
    {
        //Arrange

        Grades expectedGrade = Grades.F;

        //Action

        Grades actualGrade = converter.convertToGrade(0);
        
        // Assert

        Assert.AreEqual (expectedGrade, actualGrade);


    }
}


}