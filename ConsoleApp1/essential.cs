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



    //******* Tallest Building Finder  *****

    
        public int FindTallestBuilding(int[] heights, int n)
        {
            // Checking that heights array is not empty to avoid exceptions.
            if (heights == null || heights.Length == 0)
            {
                throw new ArgumentException("Height array should not be null or empty.");        
            }
 
            // Checking that n is not negative.
            if (n < 0) {
                throw new ArgumentOutOfRangeException("The number of growth spurts cannot be negative.");
            }
            
            // Sorting heights array ascending order to know exactly - tallest building index.
            Array.Sort(heights);
            
            // Using for loop to go through growth spurts. (Lesson: For Loop)
            for (int spurt = 0; spurt < n; spurt++)
            {
                // Get the min height
                int min = heights[0];
                int i = 0;
 
                // Using while loop to iterate heights array and only increase min heights equal to it
                // Using while loop as it is cleaner to perform logic in one line instead of for loop with additional conditional statement
                // (Lesson: While Loop)
                while(i < heights.Length && heights[i] == min)
                {
                    heights[i]++;
                    i++;
                }
            }
            
            // Tallest building is always going to be the last element after sorting and even incrementing per growth spurt
            return heights[heights.Length - 1];
        }
    }


    // ****** SurroundingPositionFinder  ***** 


    public class SurroundingPositionFinder
    {
        public List<int[]> FindSurroundingPositions(int[,] arr, int[] position)
        {
            // Check validity of the position.
            if (position == null || position.Length != 2 || !IsValidPosition(arr, position[0], position[1]))
            {
                throw new ArgumentException("Invalid input. Please provide valid position.");
            }
    
            // Find the surrounding positions.
            return GetPositions(arr, position);
        }
        
        // Looking for surrounding positions for up, down, left and right. (Lesson: Jagged Arrays vs Multidimensional Arrays)
        private List<int[]> GetPositions(int[,] arr, int[] position)
        {
            List<int[]> neighbors = new List<int[]>();
            int row = position[0];
            int col = position[1];
    
            // Check Up
            if (row > 0) {
                neighbors.Add(new int[] { row - 1, col});
            }
            
            // Check Down
            if (row < arr.GetLength(0) - 1) {
                neighbors.Add(new int[] { row + 1, col});
            }
            
            // Check Left
            if (col > 0) {
                neighbors.Add(new int[] { row, col - 1});
            }
            
            // Check Right
            if (col < arr.GetLength(1) - 1) {
                neighbors.Add(new int[] { row, col + 1});
            }
    
            return neighbors;
        }
        
        // Check and make sure given position is within bounds
        private bool IsValidPosition(int[,] arr, int row, int col)
        {
            return (row >= 0 && row < arr.GetLength(0) && col >= 0 && col < arr.GetLength(1));
        }
    }
     
     */
    
    public class person

    {
        public string _firstname="Xocaar";
        public string _lastname;
        
        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value.Length < 1) // Use the provided value instead of the property's current value
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    _firstname = value;
                }
            }
        }
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set { 
                if(value.Length < 1)
                {
                    throw new ArgumentException("Abbey apna last name bhi bhul gya kya");
                }
                _lastname = value;

            }
        }
    }


}
