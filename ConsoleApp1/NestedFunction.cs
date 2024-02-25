using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NestedFunction
    {
        public void HH()
        {
            int a = 10;
            void GG()
            {
                var a = 50;//child cant override the parent function
                a = 20;
                Console.WriteLine(a);
            }
            GG();
            Console.WriteLine($"Can access variable of HH function,value of a after change in function GG - {a}");
        }
    }
}
