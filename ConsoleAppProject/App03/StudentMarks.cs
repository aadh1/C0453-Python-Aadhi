using System;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Calculator!");
            Console.WriteLine("Aadhi - 22136681 - Student Grade Calculator");

            string[] names = new string[10];
            int[] marks = new int[10];

            // Provide input marks value for all students.

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the name of student number {0}: ", i + 1);
                names[i] = Console.ReadLine();

                Console.Write("Enter the marks of student number {0}: ", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
            }

            while (true)
            {
                // Menu choice for user.


                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Search student");
                Console.WriteLine("2. Update student marks");
                Console.WriteLine("3. Display class average");
                Console.WriteLine("4. Display student's mark percentage");
                Console.WriteLine("5. Exit");

                // get menu choice from admin.
                Console.Write("Select your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Search for a student & display marks, percentage and grade.

                    Console.Write("Enter the name of the student : ");
                    string searchName = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (names[i].ToLower() == searchName.ToLower())
                        {
                            Console.WriteLine("{0} has {1} marks", names[i], marks[i]);

                            // Give an outline for the students marks.

                            if (marks[i] >= 70 && marks[i] <= 100)
                            {
                                Console.WriteLine("Grade: A (First Class)");
                            }
                            else if (marks[i] >= 60 && marks[i] <= 69)
                            {
                                Console.WriteLine("Grade: B (Upper Second Class)");
                            }
                            else if (marks[i] >= 50 && marks[i] <= 59)
                            {
                                Console.WriteLine("Grade: Lower Second Class");
                            }
                            else if (marks[i] >= 40 && marks[i] <= 49)
                            {
                                Console.WriteLine("Grade: D (Third Class)");
                            }
                            else
                            {
                                Console.WriteLine("Grade: F (Fail)");
                            }

                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Sorry. That student can't be found. Please try again.");
                    }
                }
                else if (choice == 2)
                {
                    // Update student's marks
                    Console.Write("Enter type the student name you want to update: ");
                    string updateName = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (names[i].ToLower() == updateName.ToLower())
                        {
                            Console.Write("Enter new marks for student number {0}: ", names[i]);
                            marks[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("{0}'s marks have been changed to {1} for student number {0}.", names[i], marks[i]);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Sorry. That student can't be found. Please try again.");
                    }
                }
                else if (choice == 3)
                {
                    // Display class average
                    int totalMarks = 0;
                    for (int i = 0; i < 10; i++)
                    {
                    }
                }
            }
        }
    }
}