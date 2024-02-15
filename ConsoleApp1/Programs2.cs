using System;
using System.Net;
namespace Prog
{
    public class Program

    {
        public class person
        {
            public person(string fname, string lname)
            {
                firstname = fname;
                lastname = lname;
            }
            public string firstname { get; }
            public string lastname { get; }
        }
        public static void Main(string[] args)
        {
            /*  //**** Downloading Google main page 
              using (WebClient client = new WebClient())
              {
                  string googleMainPage = client.DownloadString("https://www.google.com/");
                  Console.WriteLine(googleMainPage);
              }*/
            person x = null;
            person y = x ?? new person("Default","person");
            Console.WriteLine(y.firstname);
        }
    }
}
