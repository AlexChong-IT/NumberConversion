using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    class BinaryConverter{
        public static void Main(string[] args)
        {
            Greeting();
   
        }

        // Method for calc
        public static void Greeting()
        {
            Console.WriteLine($"Welcome to my Binary calculator");
            Console.WriteLine($"First write the number to convert!");
            
            // User input var
            string inputNumber = Console.ReadLine();
            // string typeOfConversion = Console.ReadLine();

            //Convert input to int
            int numberOne = Convert.ToInt32(inputNumber);
            
            // Initial check for exponent
            double maxExponent = Math.Log2(numberOne);
            int roundedResult = Convert.ToInt32(Math.Floor(maxExponent));
            Console.WriteLine($"The highest exponent is {roundedResult}");
            
        }


    }
}

