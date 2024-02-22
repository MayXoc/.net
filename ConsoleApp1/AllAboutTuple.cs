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
            //using deconstruction method
            var (FirstnameV1, LastnameV1, ageV1) = getunnamedtuple();
            Console.WriteLine($"using deconstructing method {FirstnameV1} {LastnameV1} {ageV1}");
            //named tuple 
            var (FirstnameV2, LastnameV2, ageV2) = getNamedtuple();
            Console.WriteLine($"Named tuple -  {FirstnameV2} {LastnameV2} {ageV2}"); // still feel nhi aa rha hai 
            var getnametuple = getNamedtuple();
            Console.WriteLine($"By Best method - {getnametuple.Firstname} {getnametuple.lastname} {getnametuple.age}"); // aab maza aaya now aab pta chal rha ki konsa item konsa hai
        }
        public (string Firstname,string lastname,int age) getNamedtuple()
        {
            return ("Xocaar", "op", 21);
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
