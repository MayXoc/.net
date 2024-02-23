using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using ConsoleApp1;
using Coding.Exercise;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using SalesCalculate;
using SmartHome;
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
            x.employ("mayank", 1, 1_00_000);
            x.display();
            // Create an instance of PersonalDigitalLibrary
            Console.WriteLine("\n  PersonalDigitalLibrary ****\n");
            PersonalDigitalLibrary myLibrary = new PersonalDigitalLibrary();

            // Create some book instances
            Book book1 = new Book("The boy who loved", "Durjoy datta ", "4456543");
            Book book2 = new Book("Perfect us", "Durjoy datta","4657680");
            Book book3 = new Book("Wings of fire", "APJ","4457672");

            // Add the books to the library
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);

            // Display the books in the library
            Console.WriteLine("Books in the library:");
            foreach (Book book in myLibrary.Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            // creating dependency for a class
            Console.WriteLine("\n creating dependency for a class ****\n");
            Car car = new Car();
            Person person = new Person(car);  //dependency is injected into car object so bassicaly car is a dependency is injected to a person object
            person.drive();
            Console.WriteLine("\n Reading and Writing files ****\n");
            string[] hola = { "Yooo ist xocaar here", "And i hope everyone in this planet staty safe and healthy" };
            File.WriteAllLines("MyFirst.txt", hola);
            string[] answer=File.ReadAllLines("MyFirst.txt");
            foreach(string line in answer)
            {
                Console.WriteLine(line);
            }

            // if the file is too large then 
            foreach(string line in File.ReadLines("MyFirst.txt"))
            {
                Console.WriteLine(line);  //best way to deal with the large file
            }

            //Ref Local
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int i = arr[3];
            i = 70;
            Console.WriteLine("\n Local ref anf return ref  ****\n");
            Console.WriteLine("Value of array 4th element - {0} ", arr[3]);
            Console.WriteLine("Changing the byValue variable effect in array  - "+arr[3]+" No change");
            ref int o = ref arr[3];
            o = 600;
            Console.WriteLine("Changing the byRef variable effect in array  - " + arr[3] + " Means the value is changed");

            //Ref return
            int byValue = getRefOfIndex(3);
            byValue = 30;
            Console.WriteLine("Changing byVale - "+  arr[3]+" No change here");
            ref int byRef = ref getRefOfIndex(3);
            byRef = 30;
            Console.WriteLine("Changing byRef  - " + arr[3] + " Change happned here");
            ref int getRefOfIndex(int index) =>  ref arr[index];
            //Deconstruction 
            Deconstruct deconstruction = new Deconstruct();
            deconstruction.run();
            //Local Function nested function
            Console.WriteLine("\nNested function****\n");
            NestedFunction h = new NestedFunction();
            h.HH();
            //Patten match making
            Console.WriteLine("\nPattern match making (is , when) keyword used ****\n");
            PatternMatching patternMatching = new PatternMatching();
            patternMatching.Run();

            //SalesCalculator
            Console.WriteLine("\nSalesCalculator****\n");

            // Create an array of Sale instances
            Sale[] sales = new Sale[]
            {
                new Sale { itemSold = "Product A", saleAmount = 100 },
                new Sale { itemSold = "Product B", saleAmount = 150 },
                new Sale { itemSold = "Product C", saleAmount = 200 }
            };

            // Create a SalesCalculator instance with the array of sales
            SalesCalculator calculator = new SalesCalculator(sales);

            // Calculate total sales
            double totalSales = calculator.CalculateTotalSales();

            // Display the total sales
            Console.WriteLine($"Total sales: {totalSales}");


            //Smart home System

            Console.WriteLine("\nSmart home System****\n");

            // Create instances of smart devices
            ISmartDevice lightBulb = new LightBulb();
            ISmartDevice thermostat = new Thermostat();
            ISmartDevice doorLock = new DoorLock();

            // Turn on the devices
            lightBulb.TurnOn();
            thermostat.TurnOn();
            doorLock.TurnOn();

            // Display status of the devices
            Console.WriteLine(lightBulb.Status());
            Console.WriteLine(thermostat.Status());
            Console.WriteLine(doorLock.Status());

            // Turn off the devices
            lightBulb.TurnOff();
            thermostat.TurnOff();
            doorLock.TurnOff();

            // Display status of the devices after turning them off
            Console.WriteLine(lightBulb.Status());
            Console.WriteLine(thermostat.Status());
            Console.WriteLine(doorLock.Status());

            //Creating  RPG game simulator

            Console.WriteLine("\nRPG game simulator****\n");

            // Create instances of RPG characters
            RPGCharacter hero = new RPGCharacter("Hero", 200);
            List<RPGCharacter> enemies = new List<RPGCharacter>
            {
                new RPGCharacter("Enemy1", 50),
                new RPGCharacter("Enemy2", 60),
                new RPGCharacter("Enemy3", 70)
            };

            // Create an instance of RPGSimulator
            RPGSimulator simulator = new RPGSimulator(hero, enemies);

            // Start the game
            simulator.StartGame();


            // Creating Virtual Music Box

            Console.WriteLine("\nVirtual Music Box****\n");

            // Create instances of instruments
            List<Instrument> instruments = new List<Instrument>
            {
                new Guitar(),
                new Drum()
            };

            // Create an instance of VirtualMusicBand
            VirtualMusicBand musicBand = new VirtualMusicBand(instruments);

            // Play all instruments in the band
            musicBand.PlayAll();


            // Tuple

            Console.WriteLine("\nTuple****\n");
            allTuple tuple = new allTuple();
            tuple.run();

            //LINQ
            Console.WriteLine("\nLINQ****\n");
            AllAboutLinq lq = new AllAboutLinq();
            lq.run();
        }
    }
}
