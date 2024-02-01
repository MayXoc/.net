using System;
namespace Sum {

  class Prog
    {
        public void SuM(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}",a,b,c);
        }
        public static void Main(string[] args)
        {
            int a, b;
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            Prog obj = new Prog();
            obj.SuM(a,b);
        }
    }    
}
