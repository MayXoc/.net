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
            //By using LINQ and Lembda Expression
            var hobbie = hobbies.Where(h => h.Name.Equals("Games"));    

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
