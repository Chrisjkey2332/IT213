using System;

namespace IT213_Key_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            string address = "101 N. Main Street";
            string city = "AnyTown";
            string state = "TX";
            string zip = "11111";
            int unitsTaken = 19;
            const double pricePerUnit = 100.50;
            const double discountedPrice = 150;

            int unitsTakenFormula = Convert.ToInt32(unitsTaken);
            unitsTaken++;

            double tuition = pricePerUnit * unitsTakenFormula;
            double discountedTuition = tuition - discountedPrice;
            double monthlyCost = discountedTuition / 12;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip: " + zip);
            Console.WriteLine("The number of units take is: " + unitsTaken);
            Console.WriteLine("The tuition before discount is: " + pricePerUnit);
            Console.WriteLine(String.Format("The tuition before discount is {0:C}", tuition));
            Console.WriteLine(String.Format("The tuition after discount is {0:C}", discountedTuition));
            Console.WriteLine(String.Format("Your monthly payment is :  {0:C}", monthlyCost));

            Console.Read();
        }   
    }
}