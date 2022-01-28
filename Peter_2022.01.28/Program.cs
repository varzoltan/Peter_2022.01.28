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
            while(oszto % 2 == 0)
            {
                
            }
            Console.ReadKey();
        }
    }
}
