using System;

namespace IT213_Key_Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 3 Section 1
            //*********************************************************

            //Integer input
            int gradeTotal;
            int gradeCount;
            int grade;
            int gradeAverage;

            //integer declarations
            gradeTotal = 0;
            gradeCount = 1;

            //This wierd comment
            Console.WriteLine("**** Assignment 3: Section 1 - While Loop to Average Grades ****\n");

            //Loop part
            while (gradeCount <= 10)
            {
                Console.WriteLine("Enter another grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                gradeTotal = gradeTotal + grade;
                gradeCount = gradeCount + 1;
            }

            //The math part
            gradeAverage = gradeTotal / 10;

            //After all math is done
            Console.WriteLine("Total of all 10 grades is {0}", gradeTotal);
            Console.WriteLine("The class average is " + gradeAverage);

            //*********************************************************
            //****Assignment 3 Section 2
            //*********************************************************

            //Create nested loop set comment
            Console.WriteLine("\n\n**** Assignment 3: Section 2 - Nested For Loops ****\n");

            //outer loop
            for (int k = 5; k >= 1; k--)
            {
                //inner loop
                for (int i = 0; i <= 10; i += 2)
                {
                    Console.WriteLine("k = {0} i = {1}", k, i);
                }
            }

            //*********************************************************
            //****Assignment 3 Section 3
            //*********************************************************

            //Set value for integers
            int numberEntered = 0;
            int numberTotal = 0;

            //Wierd comment again
            Console.WriteLine("\n\n**** Assignment 3: Section 3 - While Loop With Sentinel ****\n");

            //Keep prompting user to enter numbers
            while (numberEntered != -1)
            {
                Console.WriteLine("Enter a positive number to be added to the total or -1 to end.");
                numberEntered = Convert.ToInt32(Console.ReadLine());
                if (numberEntered != -1)
                {
                    numberTotal = numberTotal + numberEntered;
                }
            }
            Console.WriteLine("The sum of all numbers entered is " + numberTotal);
            Console.Read();
        }
    }
}