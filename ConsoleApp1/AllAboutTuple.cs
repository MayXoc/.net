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
            //Old way of creating tuple
            Tuple<string, string, int> oldtuple = getoldtuple();
            Console.WriteLine($"{oldtuple.Item1} {oldtuple.Item2} {oldtuple.Item3}");

            //Unnamed tuple
            var UnnamedTuple = getunnamedtuple();
            Console.WriteLine($"{UnnamedTuple.Item1} {UnnamedTuple.Item2} {UnnamedTuple.Item3}");
        }
        public (string, string, int) getunnamedtuple()
        {
            return ("Xocaar", "op", 21); // no need to use Tuple.create
        }
        public Tuple<string, string, int> getoldtuple()
        {
            return Tuple.Create("Mayank", "Bisht", 21);
        }
    }

}
