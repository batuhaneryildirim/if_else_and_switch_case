using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_and_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

             if (username.Equals("Batuhan") && password.Equals("1283"))
            {
                Console.WriteLine("Hello Admin! ");
                Console.ReadLine();

            }

            
            else if(username.Equals("Mehmet") && password.Equals("1919"))
            {
                Console.WriteLine("Hello Moderator!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Hello Guest!");
                Console.ReadLine();
            }

             
            switch (username)
            {
                case "Batuhan":
                    Console.WriteLine("Hello Admin! ");
                    break;

                case "Mehmet":
                    Console.WriteLine("Hello Moderator! ");
                    break;
                default:
                    Console.WriteLine("Hello Guest! ");
                    break;
            }

        }
    }
}
