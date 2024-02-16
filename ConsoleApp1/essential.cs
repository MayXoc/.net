using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    //****Practice program 


    /* public class SalesAnalysis
    {
        // readonly to store the list of items sold.
        public readonly List<string> ItemsSold;
 
        // const to represent the separator character.
        public const char Separator = ':';
 
        public SalesAnalysis(List<string> itemsSold)
        {
            ItemsSold = itemsSold;
        }
 
        public double ComputeTotalIncome()
        {
            // Handle null or empty list.
            if (ItemsSold == null || !ItemsSold.Any()) return 0;
 
            double totalIncome = 0;
 
            // Iterate through prices. (Lesson: Foreach Loop)
            foreach (var item in ItemsSold)
            {
                // Variables, expressions and operators. (Lessons: Variables, Expressions and Operators)
                var itemParts = item.Split(Separator);
 
                // Check if the item format is incorrect or the price is missing.
                if (itemParts.Length < 2 || string.IsNullOrWhiteSpace(itemParts[1])) continue;
 
                if (double.TryParse(itemParts[1], out double price))
                {
                    // Use price if it's non-negative. Ignore negative prices.
                    if (price >= 0)
                    {
                        totalIncome += price; // Add each price to our current total. (Lesson: Order Of Evaluations)
                    }
                }
            }
 
            return totalIncome;
        }
    }
    
      
    // ******    Employee management

     public class EmployeeManagement
    {
        public string AssignDepartment(string employeeData)
        {
            // Wrap everything within try...catch...finally. (Lesson: Try Catch Finally)
            try
            {
                if (string.IsNullOrEmpty(employeeData)) {
                    // Throw exception if name is empty. (Lesson: Exceptions & Throw Keyword)
                    throw new InvalidDataException();
                }
                
                // Getting name and department. (Lesson: String Manipulation, Formatting and More)
                string[] details = employeeData.Trim().Split(',');
                string employeeName = details[0].Trim();
 
                if (string.IsNullOrEmpty(employeeName)) {
                    // Throw exception if name is empty. (Lesson: Exceptions & Throw Keyword)
                    throw new ArgumentException();
                }
                
                // Format employeeName with first letter capitalized.
                employeeName = char.ToUpper(employeeName[0]) + employeeName.Substring(1).ToLowerInvariant();
                
                // Checking the first character of the employee's name to assign the department. (Lesson: Conditional Statements)
                string department = (employeeName.ToUpper()[0] >= 'A' && employeeName.ToUpper()[0] <= 'M') ? "Department 1." : "Department 2.";
 
                // Formatting the final string that needs to be returned.
                return $"{employeeName} is assigned to {department}";
            }
            catch (ArgumentException)
            {
                // In production ready application this would have been logged - but here we are printing it
                return "Empty employee name is not allowed.";
            }
            catch (InvalidDataException)
            {
                // In production ready application this would have been logged - but here we are printing it
                return "Employee data cannot be null.";
            }
            catch (Exception)
            {
                // Exception Handling: Catch block to handle all exceptions.
                // Here we are returning a generic error message as we do not know the cause of the error.
                // In production ready application this would have been logged - but here we are printing it
                return "An error occurred."; 
            }
        }
    }



    // ****** Transaction Log Builder ******


     public class TransactionLogBuilder
    {
        public string BuildLog(List<int[]> transactions)
        {
            // Use string builder for our final log. (Lesson: StringBuilder)
            StringBuilder log = new StringBuilder();
    
            // Iterate through all transactions. (Lesson: For Loop)
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i].Length != 2)
                {
                    // Defensive programming - make sure only valid arguments are used. (Lesson: Exceptions & Throw Keyword)
                    throw new ArgumentException("Each transaction must contain exactly two elements.");
                }
 
                int itemID = transactions[i][0];
                if (itemID < 0)
                {
                    throw new ArgumentException("Item ID cannot be negative.");
                }
    
                int quantitySold = transactions[i][1];
                if (quantitySold < 0)
                {
                    throw new ArgumentException("Quantity sold cannot be negative.");
                }
    
                log.AppendLine($"Transaction: ItemID is {itemID} and Quantity sold is {quantitySold}");
            }
    
            return log.ToString();
        }
    }
     
     */
}
