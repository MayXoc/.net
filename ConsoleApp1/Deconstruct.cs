using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Deconstruct
    {
        public void run()
        {
            Console.WriteLine("\n Deconstruct ****\n");
            var (myGas, myMileage) = new Car1(100, 1000);
            Console.WriteLine($"My total gas {myGas} and my Mileage {myMileage}");
        }
    }
    class Car1
    {
        public int gas { get; set;}
        public int mileage { get; set;}

        public Car1(int gas, int mileage)
        {
            this.gas = gas;
            this.mileage = mileage;
        }
        public void Deconstruct(out int gas,out int mileage) {
         
            gas = this.gas;
            mileage =   this.mileage;
        }
    }
}
