using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class allTuple 
    {
        public void run()
        {
            //old way of creating tuple
            Tuple<string, string, int> oldtuple = getoldtuple();
            Console.WriteLine($"{oldtuple.Item1} {oldtuple.Item2}");
        }
        public Tuple<string, string, int> getoldtuple()
        {
            return Tuple.Create("Mayank", "Bisht", 21);
        }
    }

}
