using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_2022._01._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21.feladat: Írj programot, ami csak pozitív számot hajlandó beolvasni.
            int pozitiv;
            do
            {
                Console.Write("Kérem adjon meg egy pozitív egész számot: ");
                pozitiv = Convert.ToInt32(Console.ReadLine());
            } while(pozitiv <= 0);
            Console.WriteLine("Pozitív számot adott meg!!!");

            //22.feladat: Írj programot, mely addig olvas be számokat a billentyűzetről, ameddig azok
            //kisebbek, mint tíz. Írja ki ezek után a beolvasott számok összegét!
            //Összegzes törvénye
            int osszeg = 0;
            int tiz;
            do
            {
                Console.Write("Kérem adjon meg egy 10-nél nagyobb egész számot: ");
                tiz = Convert.ToInt32(Console.ReadLine());
                if (tiz < 10)
                {
                    osszeg = osszeg + tiz;
                }           
            } while (tiz < 10);
            Console.WriteLine("A tiznél kisebb számok összege: " + osszeg);

            //23.feladat: Írj programot, amely beolvas egy egész számot, majd elosztja 2-vel annyiszor,
            //ahányszor lehet és közben felírja a számot a kettes számok szorzataként
            //megszorozva egy olyan számmal, amely már nem osztható 2 - vel.Például:
            //Kérek egy egész számot: 120
            //120 = 2 * 2 * 2 * 15
            Console.Write("Kérem adjon meg  egy egész számot: ");
            int oszto = int.Parse(Console.ReadLine());
            Console.Write(oszto + " = ");
            while(oszto % 2 == 0)
            {
                oszto = oszto / 2;
                Console.Write("2*");
            }
            Console.Write(oszto);

            //24.feladat: Írj programot, ami csak az "alma" szót hajlandó beolvasni, ha ez sikerült, akkor
            //kiírja, hogy az "Az alma gyümölcs!".
            Console.WriteLine();
            string szo;
            do
            {
                Console.Write("Kérem adjon meg egy szót: ");
                szo = Console.ReadLine();
            }  while  (!szo.Equals("alma") && !szo.Equals("ALMA"));
            Console.WriteLine($"Az {szo} gyümölcs!");

            //25.feladat: Írj programot, ami beolvas egy egész számot, majd addig von ki belőle 3-at, amíg
            //háromnál kisebb nem lesz az eredmény. Írja ki ezek után a hárommal való maradékos osztását a számnak.Például:
            //16=5*3+1
            Console.WriteLine();
            Console.Write("Kérem adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int n = 0;
            Console.Write(szam + " = ");
            while (szam > 3)
            {
                szam = szam - 3;
                n++;
            }
            Console.Write($"{n}*3+{szam}");
            Console.ReadKey();
        }
    }
}
