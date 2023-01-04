using System;

namespace IT213_Unit_7
{
    class Program
    {
        //Main is the entry point for the code
        static void Main(string[] args)
        {
            //variables and values
            //temp1
            double temp1 = 35.5;
            double tempF = fahrenheit(temp1);
            weatherStatement(tempF);
            //temp2
            double temp2 = 30.5;
            tempF = fahrenheit(temp2);
            weatherStatement(tempF);
            //temp3
            double temp3 = 22.2;
            tempF = fahrenheit(temp3);
            weatherStatement(tempF);
            //temp4
            double temp4 = 16.1;
            tempF = fahrenheit(temp4);
            weatherStatement(tempF);
            //temp5
            double temp5 = 7.3;
            tempF = fahrenheit(temp5);
            weatherStatement(tempF);
            //temp6
            double temp6 = -1;
            tempF = fahrenheit(temp6);
            weatherStatement(tempF);

            Console.Read();
        } //end main

        //function to display F version of C temps

        public static double fahrenheit(double myTemp)
        {
            Console.Write("The temperature is " + myTemp + " C or ");
            double tempF = (9.0 / 5.0 * myTemp +32); //Temp conversion calculation
            tempF = Math.Round(tempF, 1);//Round to nearest single decimal
            Console.WriteLine(tempF + " F. ");
            return tempF;
        } //end F method
        
        public static void weatherStatment(double tempF) //part that provides temp warnings
        {
            if (tempF >= 95)
            {
                console.WriteLine("A heat advisory has been issued.");
            }
            else if (tempF >= 85)
            {
                console.WriteLine("Pleasant but warm.");
            }
            else if (tempF >= 70)
            {
                console.WriteLine("Very pleasant weather today.");
            }
            else if (tempF >= 50)
            {
                console.WriteLine("Pleasant but cool.");
            }
            else if (tempF >= 33)
            {
                Console.WriteLine("Cold weather.");
            }
            else
            {
                Console.WriteLine("A freeze warning has been issued.");
            }
        }
    }
}