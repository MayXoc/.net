using System;
namespace Sum {
 
 //****    Adding Two numbers using function     ****
  
  // class Prog
  //   {
  //       public void SuM(int a, int b)
  //       {
  //           int c = a + b;
  //           Console.WriteLine("Sum of {0} and {1} is {2}",a,b,c);
  //       }
  //       public static void Main(string[] args)
  //       {
  //           int a, b;
  //           a= Convert.ToInt32(Console.ReadLine());
  //           b= Convert.ToInt32(Console.ReadLine());
  //           Prog obj = new Prog();
  //           obj.SuM(a,b);
  //       }
  //   } 

  //*****    Factorial function using recursion   *****
  
//       public long Factorial(int n)
//     {
//         if (n >= 1)
//         {
//             return n * Factorial(n - 1);
//         }
           
//         else
//             return 1;
//     }
//     static void Main(string[] args)
//     {
//         Program obj = new Program();
//         int num;
//         Console.WriteLine("Enter your desired number - ");
//         num = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("The factorial of {0} is {1}", num, obj.Factorial(num));
//     }
// }

  // ****    Using refrence variable as a parameter finding factorial    ****

    //  long FactRef(int n, ref int f)
    // {
    //     for(int i = 1; i <= n; i++)
    //     {
    //         f = f * i;
    //     }
    //     return f;
    // }
    // public static void Main(string[] args)
    // {
    //     int n, f;
    //     Console.WriteLine("Enter number - ");
    //     n = Convert.ToInt32(Console.ReadLine());
    //     f = 1;
    //     Program obj = new Program();
    //     obj.FactRef(n, ref f);
    //     Console.WriteLine("Here is the factorial - {0}", f);
    // }

   //****   using (out) parameter means returning more than one diffrent type of value   ****

 //  public void show(int Empno,out string name,out int Sallary)
 // {
 //     if (Empno == 1)
 //     {
 //         name = "Xocaar";
 //         Sallary = 10000000;
 //     }
 //     else
 //     {
 //         name = "NOT FOUND";
 //         Sallary =0;
 //     }
 // }
 // static void Main(string[] args)
 // {
 //     int EmpNo, Sallary;
 //     string name;
 //     Program obj = new Program();
 //     Console.WriteLine("Enter Employ no - ");
 //     EmpNo = Convert.ToInt32( Console.ReadLine() );
 //     obj.show(EmpNo, out name, out Sallary);
 //     Console.WriteLine("Employ name {0} and his sallary {1}", name, Sallary);

 // }

 // ****  Value type stored in Stack and reference type will be stored in Heap   ****
 
  //int n;
  // public static void Main(string[] args)
  // {
  //     Program obj1 = new Program();
  //     obj1.n = 1;
  //     Program obj2 = obj1;
  //     obj2.n = 2;
  //     Console.WriteLine(obj1.n);
  //     Console.WriteLine(obj1.GetHashCode());
  //     Console.WriteLine(obj2.GetHashCode());

  // }

 // ***   How Strings are stored in c#   *******
 

  // public static void Main(string[] args)
  // {
  //     string s1="XOCAAR", s2="xocaar", s3="Xocaar", s4="xocaaR",s5="XOCAAR";
  //     Console.WriteLine(s1.GetHashCode());
  //     Console.WriteLine(s2.GetHashCode());
  //     Console.WriteLine(s3.GetHashCode());
  //     Console.WriteLine(s4.GetHashCode());
  //     Console.WriteLine(s5.GetHashCode());  // Conclusion for same value there is no new memory allocate
  // }

 //****  using Params keyword  for taking n number of arguments   *****

 

//  public void show(params string[] name)
// {  
//     foreach(string s in name)
//     {
//         Console.Write(s +" ");
//     }
//     Console.WriteLine();
// }
// public static void Main(string[] args) // params is a keyword which is used to specify a parameter that takes variable number of arguments.
// {
//     Program obj = new Program();
//     obj .show();
//     obj .show("Xocaar");
//     obj.show("XOCAAR", "LUCIAN");
//     obj.show("XOCAAR", "LUCIAN", "SLUG");
// }

  //****    BOXING and Unboxing      ****

  //  public static void Main(string[] args)
  // {
  //     int x = 20;
  //     string name = "XOCAAR";
  //     Program obj = new Program();
  //     /*   Boxing  */
  //     object y = x;
  //     object z = name;

  //     /*   Unboxing */

  //     int x1 = (Int32)y;
  //     string y1 = (String)z;

  //     Console.WriteLine(x1 + " " + y1);
      
  // }


// ****      Method overloading        *****
 

 // void show()
 // {
 //     Console.WriteLine("hello");
 // }
 // void show(int n)
 // {
 //     Console.WriteLine(n);
 // }
 // void show(int n, string s)
 // {
 //     Console.WriteLine(s + " " + n);
 // }

 // public static void Main(string[] args)
 // {
 //     int a;
 //     string? userName = Console.ReadLine();
 //     a = Convert.ToInt32(Console.ReadLine());
 //     Program obj = new Program();
 //     obj.show();
 //     obj.show(a);
 //     obj.show(a, userName);
 // }

     // ****** Celcius to farenheit  ******

 

 //  double ChangeCenToFeren(double c)
 // {
 //     double f = ((9 * c) / 5) + 32;
 //     return f; 
 // }
     

 // public static void Main(string[] args)
 // {
 //     double c;
 //     Program obj = new Program();
 //     Console.WriteLine("Enter celcis value - ");
 //     c = Convert.ToDouble(Console.ReadLine());
 //     Console.WriteLine("Here Cel to fer value  {0} - ",obj.ChangeCenToFeren(c));
 // }


//******   overriding ToString method    *******

 
// int x;
// double y;
// string? name;
// public override string ToString()
// {
//     return "Employ no - " + x + " Experience " + y + " Name " + name;
// }

// public static void Main(string[] args)
// {
//     Program p = new Program();
//     p.x = 1;
//     p.y = 2.5;
//     p.name = "XOCAAR";
//     Console.WriteLine(p);
    
// }


 // ********* Static Constructor

 
  //  int x;
  // double y;
  // string name;
  // // using static constructor 
  // static Program()
  // {
  //     Console.WriteLine("This is static constructor");
  // }
  // public static void Main(string[] args)
  // {

  // }

     // ******  instance Constructor  and constructor overloading

 
//     int x;
//     double y;
//     string? name;
    
//     static Program()
//     {
//         Console.WriteLine("This is static constructor");
//     }
//     Program()
//     {
//         this.x = 10;
//         this.y = 20.5;
//         this.name = "Xocua";
//     }
//     Program(int x, double y,string name)
//     {
//         this.x = x;
//         this.y = y;
//         this.name = name;
//     }
//     public override string ToString()
//     {
//         return "X = "  + x +" Y = " + y + " name = "  + name;
//     }
//     public static void Main(string[] args)
//     {
//         Program p = new Program();
//         Console.WriteLine(p);
//         Program p2 = new Program(50,783.354,"Lucian");
//         Console.WriteLine(p2);
//     }

// }


      // ******* Static members   ******
 
        // static int n;
        // static void Main(string[] args)
        // {

        //     Program.n = 56;
          
        //     Console.WriteLine(Program.n);

        //     // hence Console is a class and WriteLine is static method;
        // }


   // ******** Inheritance and inheritance using constructor also using base keyword
 

//    class X {
//     public X()
//     {
//         Console.WriteLine("Base class constructor");
//     }
//     public void show()
//     {
//         Console.WriteLine("Base class Show()");
//     }
// }

// class Y : X {
//     public Y()
//     {
//         Console.WriteLine("Derived class constructor");
//     }
//     public void show()
//     {
//         base.show(); //base keyword used to pass value from derived to base class
//         Console.WriteLine("Derived class Show()");
//     }
// }


// class Program
// {
//     public static void Main(string[] args) {
//         Y obj = new Y();
//         obj.show();
//     }
// }



  // ******* using base constructor to pass data from derived to base class

 
//  class X {
//     int a;
//     int b; int c; int d;
//     public X(int A,int B,int C,int D)
//     {
//         this.a = A;
//         this.b = B;
//         this.c = C;
//         this.d = D;
//     }
//     public override string ToString()
//     {
//         return "A = " + a + " B = " + b + " C = " + c + " D = " + d;
//     }

// }

// class Y : X {
//     public Y(int a,int b,int c ,int d) : base(a, b, c, d)
//     {

//     }
   
// }


// class Program
// {
//     public static void Main(string[] args) {
//         Y obj = new Y(2,4,5,7);
//         Console.WriteLine(obj);
//     }
// }
}
