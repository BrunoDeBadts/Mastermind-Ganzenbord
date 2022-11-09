using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Ganzenbord 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var boardPos = 0;

            if (boardPos < 63)
            {
                Console.WriteLine("Je staat nu op start. Gooi je dobbelsteen (g): ");
                string dieThrow = Console.ReadLine();
                while (dieThrow == "g" || boardPos > 0)
                {
                    Random random = new Random();
                    int eyes = random.Next(6);
                    boardPos = eyes + boardPos;

                    Console.WriteLine($"Je hebt {eyes} gegooid, je staat nu op plaats {boardPos}. Gooi je dobbelsteen (g).");
                    dieThrow = Console.ReadLine();

                    if (boardPos == 23)
                    {
                        Console.WriteLine("Je zit in de gevangenis, spel voorbij.");
                        Environment.Exit(0);
                    }
                    if (boardPos > 63)
                    {
                        Console.WriteLine("Je hebt gewonnen!");
                        Environment.Exit(0);
                    }

                    if (boardPos == 25 || boardPos == 45)
                    {
                        Console.WriteLine("Terug naar start!");
                        boardPos = 0;
                    }
                    if (boardPos == 10 || boardPos == 20 || boardPos == 30 || boardPos == 40 || boardPos == 50 || boardPos == 60)
                    {
                        Console.WriteLine("Je gegooide worp telt dubbel!");
                        boardPos = eyes + boardPos;
                    }

                }

            }


        }
    }
}