using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class DataTypesProgram{
        static void Main(string[] args){
            string apples;
            double applePrice;
            int convertedPrice;

            Console.Write("Enter the pieces of apple: ");
            apples = Console.ReadLine();

            Console.Write($"Enter the total price of {apples} apple(s): ");
            applePrice = Convert.ToDouble(Console.ReadLine());

            convertedPrice = (int) applePrice;

            Console.WriteLine($"The value of the orginal price is {Convert.ToString(applePrice)}");

            Console.WriteLine($"The value of the converted price is {Convert.ToString((convertedPrice))}");
        }
    }
}
