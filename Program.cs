using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Please enter the grade you expect to get in ISM 4300 ...");
            /*
              Use the try catch block to validate user input
              If the user provides band input, the catch block
            will handle the error and a message will be displayed.
            */
            try
            {

                // This variable will gather the user input
                string input = Console.ReadLine();
                /*
                  This variable will  be used to store sales
                after the input variable is parsed to decimal
                */
                decimal grades = decimal.Parse(input);

                if (grades >= 90 & grades <= 100) 
                {
                    Console.WriteLine("Your expected grade is an A.");
                    
                }
                else if (grades >= 80 & grades < 90)
                {
                    Console.WriteLine("Your expected grade is a B.");
                }
                else if (grades >= 70 & grades < 80)
                {
                    Console.WriteLine("Your expected grade is a C.");
                }
                else if (grades >= 60 & grades < 70)
                {
                    Console.WriteLine("Your expected grade is a D.");
                }
                else if (grades <= 50)
                {
                    Console.WriteLine("Your expected grade is a F.");
                }
                else
                { 
                }
               
                
            }
            catch
            {

            }
        }
    }
}
