using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// application to prompt the user for a regular 
//expression and then prompt for some input to match
namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // define and assign a default expression
            string defaultpattern = @"[a-z].*\d|\d.*[a-z]";

            // prompt for user defined
            string userExpression = "";
            string userInput = "";

            
           do
           {

            Console.WriteLine("The default expression checks for at least one digit.");
            Console.Write("Enter a regular expression ( Or press ENTER to use the default): ");
            userExpression = Console.ReadLine();


            if (userExpression == "")
            {

                Console.WriteLine("Enter");
                userExpression = defaultpattern;

            }


            Console.Write("Enter some input: ");
            userInput = Console.ReadLine();

            Console.Write("{0} matches {1}?  ", userInput, userExpression);

            Console.WriteLine(IsMatch(userInput, userExpression));

            Console.WriteLine("Press ESC to end or any key to try again.");
            // pause
           }
           while (Console.ReadKey(true).Key != ConsoleKey.Escape);

          
        }
        
        // Method to return match true or false
        static public bool IsMatch(string UserInput, string pattern)
        {
            Regex reg = new Regex(pattern);
            return reg.IsMatch(UserInput);
        }
    }
}
