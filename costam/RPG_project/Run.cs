using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Run
    {
        static void Main(string[] args)
        {
            // hp atack moc coin 
            int[] character = Postacie.characterClassSelection();
            int round = 0;

            int maxHp = character[0];
            int maxMoc = character[2];

            while (Postacie.isAlive(character))
            {
                // opcje co gracz moze zrobic
                GameInformation.informations(character, round);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "w":
                        Console.WriteLine("---------------");
                        Potwory.faight(character);
                        break;
                    case "z":
                        Console.WriteLine("---------------");
                        Magia.SpelsBook(character, maxHp, maxMoc);
                        break;
                    case "s":
                        Sklep.shop(character, maxHp, maxMoc);
                        Console.WriteLine("---------------");
                        break;
                    case "m":
                        Nauczyciel.mistrzu(character);
                        Console.WriteLine("---------------");
                        break;
                    case "k":
                        Rzemioslo.kowal(character);
                        Console.WriteLine("---------------");
                        break;
                    case "b":
                        Barek.baaar(character, maxHp);
                        Console.WriteLine("---------------");
                        break;
                    default:
                        Console.WriteLine("Nie ma tak");
                        break;
                }
                round += 1;
            }



            Console.WriteLine("Dziekuje za grę");
            Console.ReadKey();
        }
    }
}

