using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person1
    {
        public Person1(bool IsAngry) => IsAngry = isAngry;
        public bool isAngry { get; }
    }
    class NormalPerson : Person1
    {
        public NormalPerson(bool IsAngry) 
            : base(IsAngry) 
        {
        }
    }
    class SuperPerson : Person1
    {
        public SuperPerson(bool IsAngry)
            : base(IsAngry)
        {
        }
    }

    class PatternMatching
    {
        public void Run()
        {
            Person1 normalPerson = new NormalPerson(true); // remember here it creates a new NormalPerson object with the isAngry property set to true,
                                                           // and then assigns this object to a variable named normalPerson, which has the type Person1.
            Person1 superPerson = new SuperPerson(false);
            BreakTheWall(normalPerson);
            BreakTheWall(superPerson);
            WhatCanYouBreak(normalPerson);
            WhatCanYouBreak(superPerson);
            WhatCanYouBreak(null);
        }
        private void BreakTheWall(Person1 person)
        {
            if( person is SuperPerson superperson || person is NormalPerson normalperson && normalperson.isAngry) // pattern matching 
            {
                Console.WriteLine("Wall break");
            }
            else
            {
                Console.WriteLine("Wall did'nt break");
            }
        }
        private void WhatCanYouBreak(Person1 person)
        {
            switch(person) // here switch taking custom types 
            {
                case SuperPerson superperson when superperson.isAngry:
                    Console.WriteLine( "Superperson is angry Wall broke,stone wall and titanium also");
                    break;
                case SuperPerson superperson:
                    Console.WriteLine("superperson Stone wall break");
                    break;
                case NormalPerson normalperson when normalperson.isAngry:
                    Console.WriteLine("Normalperson is angry stone wall break");
                    break;
                case NormalPerson normalperson:
                    Console.WriteLine("Normalperson not angry Wall did'nt break");
                    break;
                case null:
                    Console.WriteLine("since no one here Wall remain as it is");
                    break;
                default:
                    Console.WriteLine("Wall remain same");
                    break;
            }
        }
    }

}
   
