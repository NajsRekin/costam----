using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class GameInformation
    {
        public static void informations(int[] character, int round)
        {
            Console.WriteLine($" etap - {round} ");
            Console.WriteLine($"Twoje życie {character[0]} | atak {character[1]} | moc {character[2]}  | coiny {character[3]} | zebrane ryby {character[4]}");
            Console.WriteLine($"w - przygoda | z - zaklęcia | b - karczma |s - Sklep | k - kowal | m - nauczyciel | ");
            Thread.Sleep(900);
        }


    }
}
