using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RPG_project
{
    public class Barek
    {
        
        public static int[] baaar(int[] character, int maxHp)
        {
            Console.WriteLine("Witaj w barze!!");
            Console.WriteLine("Mamy do zaoferowania napitek jak i zabawę w wędkowanie, no i może coś jeszce...");
            Console.WriteLine("1 - Napój 5 coin \t 2 - wędkowanie \t 3 - ... \t ");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {

                case 1:
                    return napoj(character, maxHp);
                case 2:
                    return wendka(character);
                case 3:
                    return krop(character);
                default:
                    return character;
            }
            Console.WriteLine("Wychodzisz z karczmy");
            return character;
        }

        public static int[] napoj(int[] character, int maxHp)
        {
            if (character[3] >= 5)
            {
                Console.WriteLine("zyskujesz +10 Hp");
                character[3] -= 5;
                character[2] += 10;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }


        public static int[] wendka(int[] character)
        {
            if (character[4] >= 1)
            {
                Console.WriteLine($"Gratuluje złowiłeś rybę, co prawda nie jest ci ona do niczego potrzebna, ale łów dalej i miej frajdę!");
                character[4] += 1;
            }
            else
            {
                Console.WriteLine($"Nie możesz łowić w bajorku w karczmie, jeżeli nigdy wcześniej nie łowiłeś. Musisz zdobyć chociaż jedną rybę i wtedy możesz tu wrócić POWODZENIA");
            }
            return character;
        }


        public static int[] krop(int[] character)
        {

            Console.WriteLine("Zagrajmy...");
            Console.WriteLine($"Rzucimy kostką, wybierasz liczby parzyste lub nie parzyste, jeżeli wylosuje się wybrana przez ciebie opcja dostaniesz pieniądze, jeżeli nie stracisz je!");
            Console.WriteLine(" 1 - parzyste \t 2 - nieparzyste");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {

                case 1:
                    return parz(character);
                case 2:
                    return nparz(character);
                default:
                    return character;
            }
            Console.WriteLine("");
            return character;
        }

        public static int[] parz(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int k = rnd.Next(1, 20);
            if (a == 0)
            {
                Console.WriteLine($"Parzysta, zdobywasz {k} coinsów");
                character[3] += k;

            }
            else if (a == 1)
            {
                character[3] -= k;
                Console.WriteLine($"Nieparzysta, Straciłeś {k} masz {character[3]} coinsów");
            }
            return character;
        }


        public static int[] nparz(int[] character)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int k = rnd.Next(1, 25);
            if (a == 0)
            {
                Console.WriteLine($"Nieparzysta, zdobywasz {k} coinsów");
                character[3] += k;

            }
            else if (a == 1)
            {
                character[3] -= k;
                Console.WriteLine($"Parzysta, Straciłeś {k} masz {character[3]} coinsów");
            }
            return character;

        }





    }
}