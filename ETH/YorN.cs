using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETH
{  
        class YesNoQuestion
        {
            public static bool Ask(string message)
            {
                while (true)
                {
                    Console.Write($"{message} (y/n): ");
                    string input = Console.ReadLine().Trim().ToLower();

                    if (input == "y")
                    {
                        return true;
                    }
                    else if (input == "n")
                    {
                    Console.WriteLine("Thank you for using this program"); return false;
                    }
                }
            }
        }
}
