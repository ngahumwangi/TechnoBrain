using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Exercise02;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string numeric_input = "";

            Console.Write("Please enter a numeric Input:  ");
           
                numeric_input = Console.ReadLine();
                decimal value = numeric_input.extendBigInt(numeric_input);
            
            // Output the word equivalent of the input          
                Console.WriteLine(NumbersToWord.Towards(value));
            Console.ReadKey();
        }
    }
}
