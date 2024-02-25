using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program3
    {
        public static void Main(string[] args)
        {
            try
            {
                InputConverter inputconverter = new InputConverter();
                CalculatorEngine Calculate = new CalculatorEngine();

                double FirstNumber = inputconverter.ConvertIntoNumeric(Console.ReadLine());
                double SecondNumber = inputconverter.ConvertIntoNumeric(Console.ReadLine());
                string Operator = Console.ReadLine();

                double result = Calculate.calculate(Operator, FirstNumber, SecondNumber);
                Console.WriteLine(result);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
