using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using ConsoleApp1;
namespace Prog
{
    public class Program

    {
       
        public static void Main(string[] args)
        {
            /*  //**** Downloading Google main page 
              using (WebClient client = new WebClient())
              {
                  string googleMainPage = client.DownloadString("https://www.google.com/");
                  Console.WriteLine(googleMainPage);
              }*/
            
           Inheritance x = new Inheritance();
            x.Firstname = "Mayank"; //derived class object accesing the base class properties
            x.Lastname = "Bisht";
         
            Console.WriteLine(x.Firstname);
            Console.WriteLine(x.Lastname);


        }
    }
}
