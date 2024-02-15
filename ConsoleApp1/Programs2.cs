using System;
using System.Net;

namespace Prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            //**** Downloading Google main page 
            using (WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("https://www.google.com/");
                Console.WriteLine(googleMainPage);
            }
        }
    }
}
