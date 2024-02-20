using Coding.Exercise;
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
            var (myGas, myMileage,CarName) = new Car1(100, 1000,"Jaguar");
            Console.WriteLine($"Car name {CarName} My total gas {myGas} and my Mileage {myMileage}");
            var (_, mymileage,carName) = new Car1(100, 1000, "ferarri");// using (_) to ignore the gas 
            Console.WriteLine($"Car name {carName}  and my Mileage {mymileage}");
        }
    }
    class Car1
    {
        public int gas { get; set;}
        public int mileage { get; set;}
        public string carName {  get; set;}

        public Car1(int gas, int mileage, string carName)
        {
            this.gas = gas;
            this.mileage = mileage;
            this.carName = carName;
        }
        public void Deconstruct(out int gas,out int mileage,out string carName) {
         
            gas = this.gas;
            mileage =   this.mileage;
            carName = this.carName;
        }
    }
}
