using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AllAboutLinq
    {
        public void run()
        {
            //making array of hobbies
            Hobbies[] hobbies = { new Hobbies(1, "Games"), new Hobbies(2, "Batminton"), new Hobbies(3, "Music") };
            // now its time to access these hobbies
            //By using LINQ and Lambda Expression
            var hobbie = hobbies.Where(h => h.Name.Equals("Games"));
            var anotherHobbie = from h in hobbies where h.Name.Equals("Games") select h;//using Query method both give the same output

            var EveryhobbieExceptFirstOne = hobbies.Skip(1); //now it will give output Batminton and Music and skip the First one
            var HobbieOnlySecondOne = hobbies.Skip(1).Take(1);//now it will only one after skipping
            Console.WriteLine("Hobby at index 1:");
            foreach (var item in HobbieOnlySecondOne)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
    class Hobbies 
    {
        public Hobbies(int id,string name) 
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }

}
