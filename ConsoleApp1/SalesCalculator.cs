using System;

namespace SalesCalculate
{
    // Using struct to create Sale entity. (Lesson: Classes vs Structs)
    // Sale is a good candidate for a struct because it represents a simple, immutable transaction record. (Lesson: Reference vs Value Types)
    public struct Sale
    {
        public string itemSold;
        public double saleAmount;

        // Using non-static method to get amount. (Lesson: Static vs Non Static)
        public double GetSaleAmount()
        {
            // Ensure the item sold is not null or empty, and the sale amount is non-negative.
            if (string.IsNullOrEmpty(itemSold) || saleAmount < 0)
            {
                throw new ArgumentException("Invalid sale data.");
            }
            return saleAmount;
        }
    }

    // SalesCalculator class to handle a collection of sales. (Lesson : Classes vs Structs)
    // The SalesCalculator class is a good candidate for a class because it's more complex and mutable. (Lesson: Reference vs Value Types)
    public class SalesCalculator
    {
        private Sale[] sales;

        public SalesCalculator(Sale[] sales)
        {
            if (sales == null)
            {
                throw new ArgumentNullException("Sales array cannot be null.");
            }
            this.sales = sales;
        }

        // Using static method to calculate sales. 
        public double CalculateTotalSales()
        {
            double total = 0;
            foreach (var sale in this.sales)
            {
                total += sale.GetSaleAmount();
            }
            return total;
        }
    }
}

