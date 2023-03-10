using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Sklep
    {
        public static int[] shop(int[] character, int mxaHp, int maxMoc)
        {
            Console.WriteLine("Witaj w moim sklepie!!!");
            Console.WriteLine($"1 - misktura regeneracji 10 coinów \t 2 - lepsza mikstura regenarcji 30 coinów \t 3 - mikstura ataku 15coinów \t 4 - kup nielegalnie rybę 25coinów \t");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, mxaHp);
                case 2:
                    return heal1(character, mxaHp);
                case 3:
                    return upAtac(character);
                case 4:
                    return nryb(character);


            }
            Console.WriteLine("Opuszczasz sklep");
            return character;
        }






        public static int[] heal(int[] character, int mxaHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10, 20);
            Console.WriteLine(character[0]);
            if (character[3] >= 10)
            {
                Console.WriteLine("Płacisz 10 coiny");
                character[3] -= 10;
                if (character[0] + heal >= mxaHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = mxaHp;
                    return character;
                }
                else
                {
                    Console.WriteLine($"mikstura uleczyła cię o {heal}, masz teraz {character[0]} hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie masz wystarczjaco coinów");
            return character;
        }


        public static int[] heal1(int[] character, int mxaHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(40, 60);
            Console.WriteLine(character[0]);
            if (character[3] >= 30)
            {
                Console.WriteLine("Płacisz 30 coiny");
                character[3] -= 30;
                if (character[0] + heal >= mxaHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = mxaHp;
                    return character;
                }
                else
                {
                    Console.WriteLine($"mikstura uleczyła cię o {heal}, masz teraz {character[0]} hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie masz wystarczjaco coinów");
            return character;
        }




        public static int[] upAtac(int[] character)
        {
            if (character[3] >= 15)
            {
                Console.WriteLine("Twoj atak zwiekszyl sie o +5 po treningu, wydajesz 15 coinów");
                character[3] -= 15;
                character[1] += 5;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }


        public static int[] nryb(int[] character)
        {
            if (character[3] >= 25)
            {
                Console.WriteLine("Do twojego ekwipunku trafiła podejrzanego pochodzenia ryba (w karczmie nikt się nie zorientuje dlatego możesz spokojnie dalej grać)");
                character[3] -= 25;
                character[4] += 1;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco coinów");
            }
            return character;
        }

    }
}
