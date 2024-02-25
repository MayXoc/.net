using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InputConverter
    {
       public double ConvertIntoNumeric(string input)
        {
            double convertedNumber;
            if (!double.TryParse(input, out convertedNumber)) throw new ArgumentException("Numeric value expected");
            return convertedNumber;
        } 
    }
    class CalculatorEngine
    {
        public double calculate(string Operator,double firstNumber,double secondNumber) 
        {
            double result;
            switch (Operator.ToLower())
            {
                case "+":
                case "add":
                    return firstNumber + secondNumber;
                    break;
                case "sub":
                case "-":
                    return firstNumber + secondNumber;
                    break;
                case "multiply":
                case "*":
                    return firstNumber + secondNumber;
                    break;
                case "divide":
                case "/":
                    return firstNumber + secondNumber;
                    break;
                default:
                    throw new ArgumentException("Given Opreator not recognised");
                    break;
            }

            return result;
        }
    }
}
