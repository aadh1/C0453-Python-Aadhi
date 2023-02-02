using System;

namespace ConsoleAppProject.App01
{
    public class NewBaseType
    {
        public void Run()
        {
            //step 1 - inputting the feet

            Console.WriteLine("Enter the number of miles :");
            string input = Console.ReadLine();
            int feet = Convert.ToInt32(input);
            Console.WriteLine(feet);

            //step 2 - covert feet to miles

            int miles = feet / 5280;

            //Step 3 - Output

            Console.WriteLine(feet + "feet is" + miles + "miles.");
        }
    }

     
    public class  DistanceConvertor: NewBaseType
    {
        public void Run()
        {

        }
    }
}
