using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance : person,Interface1
    {
        private int Id;
        private string Name = string.Empty;
        private int Salary;

        public void employ(string name, int id, int salary)
        {
            if (id < 0)
                throw new ArgumentException("Id cannot be negative.");
            if (name == null)
                throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            if (salary <= 0)
                throw new ArgumentException("Salary must be greater than zero.");

            Id = id;
            Name = name;
            Salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Employee name = {0}, Id = {1}, and Salary = {2}.", Name, Id, Salary);
        }

       
    }
}
