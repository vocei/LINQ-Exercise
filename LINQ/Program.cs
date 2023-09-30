using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
                List<string> myGame = new List<string>() { "Mario", "Sonic", "Call of Duty", "Payday 3" };
                {
                    var orderedMyGame = myGame.OrderByDescending(x => x.Length);

                    foreach (var games in orderedMyGame)

                    {
                        Console.WriteLine(games);
                    }
                }
            }
        }
    }

