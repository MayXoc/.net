using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UnscrambledWords
    {
        public void run()
        {
            bool ContinueUnscrambling = true;
            do
            {
                Console.WriteLine("Enter F for file name M for Manually option - ");
                var option = Console.ReadLine() ?? string.Empty;
                switch (option.ToUpper())
                {
                    case "F":
                        Console.WriteLine("Enter File name - ");
                        WordUnscramblingFileCase();
                        break;
                    case "M":
                        Console.WriteLine("Enter Word - ");
                        WordUnscramblingManullyCase();
                        break;
                    default:
                        Console.WriteLine("Entered Option not recognised");
                        break;
                } while (ContinueUnscrambling)
                {
                    Console.WriteLine("You want to continue type Y / N - ");
                    var Decision = Console.ReadLine() ?? string.Empty;
                    switch (Decision.ToUpper())
                    {
                        case "Y":
                            break; 
                        case "N":
                            ContinueUnscrambling = false;
                            break; 
                        default:
                            Console.WriteLine("Entered Option not recognised");
                            break;
                    }
                }
            }
        }

        private void WordUnscramblingManullyCase()
        {
            

        }

        private void WordUnscramblingFileCase()
        {
            
        }
    }
}
