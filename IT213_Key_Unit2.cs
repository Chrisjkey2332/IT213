using System;

namespace IT213_Key_Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Section 1 of Assignment 2

            //Portion for variable declarations
            int firstNumber;
            int secondNumber;

            //Part for user to input the numbers

            Console.WriteLine("Enter first integer: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //Comparison section

            if (firstNumber == secondNumber)
                Console.WriteLine("{0} = {1}", firstNumber, secondNumber);
            if (firstNumber != secondNumber)
                Console.WriteLine("{0} <> {1}", firstNumber, secondNumber);
            if (firstNumber < secondNumber)
                Console.WriteLine("{0} < {1}", firstNumber, secondNumber);
            if (firstNumber > secondNumber)
                Console.WriteLine("{0} > {1}", firstNumber, secondNumber);
            if (firstNumber >= secondNumber)
                Console.WriteLine("{0} >= {1}", firstNumber, secondNumber);
            if (firstNumber <= secondNumber)
                Console.WriteLine("{0} <= {1}", firstNumber, secondNumber);


            //Section 2 of Assignment 2

            //Variable Declaration

            double grade;
            

            //Spot for user to enter grade

            Console.WriteLine("Enter your grade to see if you passed: ");
            grade = Convert.ToInt32(Console.ReadLine());

            //pass if/else

            if (grade >= 60)
                Console.WriteLine("Congratulations, you passed!");
            else
                Console.WriteLine("Sorry, you failed.");

            //Section 3 of Assignment 2

            //Variable Declaration

            int month;

            //User input for month

            Console.WriteLine("Enter the number of the month: ");
            month = Convert.ToInt32(Console.ReadLine());

            //Month finder

            if (month == 1)
            {
                Console.WriteLine("The month is January.");
            }
            else if (month == 2)
            {
                Console.WriteLine("The month is February.");
            }
            else if (month == 3)
            {
                Console.WriteLine("The month is March.");
            }
            else if (month == 4)
            {
                Console.WriteLine("The month is April.");
            }
            else if (month == 5)
            {
                Console.WriteLine("The month is May.");
            }
            else if (month == 6)
            {
                Console.WriteLine("The month is June.");
            }
            else if (month == 7)
            {
                Console.WriteLine("The month is July.");
            }
            else if (month == 8)
            {
                Console.WriteLine("The month is August.");
            }
            else if (month == 9)
            {
                Console.WriteLine("The month is September.");
            }
            else if (month == 10)
            {
                Console.WriteLine("The month is October.");
            }
            else if (month == 11)
            {
                Console.WriteLine("The month is November.");
            }
            else if (month == 12)
            {
                Console.WriteLine("The month is December.");
            }
            else
                Console.WriteLine("Invalid Month.");

            //Section 4 of Assignment 2

            //Variable declaration

            int day;

            //Request user to select day

            Console.WriteLine("Enter the number of the day of the week: ");
            day = Convert.ToInt32(Console.ReadLine());

            //Week Switch

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Teusday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
            Console.Read();
        }
    }
}
