using System;
using System.Net;
namespace Prog
{
    class program
    {

        //****   Downloading google main page
       
         using(WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("https://www.google.com/");
    Console.WriteLine(googleMainPage);
            }
        
    }
}