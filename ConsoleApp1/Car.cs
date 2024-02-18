using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        private bool _on;
        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "Car is on" : "Car is off");
        }
        public void drive()
        {
            if (_on)
            {
                Console.WriteLine("You can drive");
            }
            else
            {
                Console.WriteLine("You need to drive car first");
            }
        }
    }
}
