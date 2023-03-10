using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Magia
    {
        public static int[] SpelsBook(int[] character, int mxaHp, int maxMoc)
        {
            Console.WriteLine($"1 - Lecznie \t 2 - zwiększenie ataku \t 3 - ??? ");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    return Heal(character, mxaHp, maxMoc);
                case "2":
                    return atak(character, maxMoc);
                case "3":
                    return iskr(character, mxaHp);
                default:
                    return character;
            }
        }

        public static int[] Heal(int[] character, int mxaHp, int maxMoc)
        {
            if (character[2] >= 100)
            {
                character[0] = mxaHp;
                character[2] -= 100;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy");
            }

            return character;
        }

        // hp atack moc gold wendka
        public static int[] atak(int[] character, int maxMoc)
        {
            Random rnd = new Random();
            if (character[2] >= 80)
            {
                character[1] += rnd.Next(1, 25);
                character[2] -= 80;
                Console.WriteLine("Masz dodatkowe punkty do ataku");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy");
            }

            return character;
        }

        public static int[] iskr(int[] character, int mxaHp)
        { 
            if (character[2] >= 100)
            {
                character[0] = 0 ;
                character[2] -= 100;
                Console.WriteLine("Aj to chyba nie był dobry pomysł");
                Console.WriteLine("Jakieś siły mocy cię otoczyły i udusiły, więc UMIERASZ przegrywie!");
                return character;
            }
            else
            {
                Console.WriteLine("Brak mocy");
            }

            return character;
        }




    }
}
