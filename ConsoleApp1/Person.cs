using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private Car _car;
        public Person(Car car)
        {
            _car = car;
        }
        public void drive()
        {
            _car.TurnOnOff();
            _car.drive();
        }
    }
}
