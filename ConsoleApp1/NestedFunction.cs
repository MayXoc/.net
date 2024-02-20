using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedFunction
    {
        public void HH()
        {
            int a = 10;
            void GG()
            {
                a = 20;
            }
            GG();
            Console.WriteLine($"Can access variable of HH function,value of a after change in function GG - {a}");
        }
    }
}
