using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static List<ketkerekuek> garazs = new List<ketkerekuek>(); //kétkerekű, mert így mind a kettő (motor,bicikli) tárolható benne
        static string tipus;

        static void Main(string[] args)
        {
            do
            {
                Console.Write("\nMit szeretnél a garázsba rakni? (m / b / moped - ha *, akkor vége): ");
                tipus = Console.ReadLine();

                ketkerekuek seged = null; //itt még nem tudjuk milyen jármű lesz --> ketkerekuek + null, mindene 0 vagy üres

                if (tipus == "m")
                {
                    Console.Write("\nAdd meg a kellő paramétereket space-el tagolva (guminyomás, személyek, súly, kuplung, tank, ccm3): "); //konstruktor sorrendje
                    string[] s = Console.ReadLine().Split(' ');

                    seged = new motor(double.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), s[3], int.Parse(s[4]), int.Parse(s[5]));
                }
                if (tipus == "b")
                {
                    Console.Write("\nAdd meg a kellő paramétereket space-el tagolva (guminyomás, személyek, súly, pedálmárka): ");
                    string[] s = Console.ReadLine().Split(' ');

                    seged = new bicikli(double.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), s[3]);
                }
                if (tipus == "moped")
                {
                    Console.Write("\nAdd meg a kellő paramétereket space-el tagolva (guminyomás, személyek, súly, akkumulátor (MAh)): ");
                    string[] s = Console.ReadLine().Split(' ');

                    seged = new moped(double.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]));
                }

                if (tipus == "b" || tipus == "m" || tipus == "moped") //nem adja hozzá a null-t
                {
                    garazs.Add(seged);
                    continue; //a ciklus elejére dob
                }

                Console.WriteLine(tipus != "*" ? "Nem jó értéket adtál meg." : "");
            } while (tipus != "*");

            Console.Write("Kiírjam az adatokat (igen / nem)? - ");
            string valasz = Console.ReadLine();

            if (valasz == "igen")
            {
                //var proba = garazs[0].GetType(); megnéztük mit csinál a GetType()

                foreach (var item in garazs) //vagy elseif, vagy continue
                {
                    if (item.GetType().Name == "motor")
                    {
                        motor s = item;

                        Console.WriteLine("Motor: ");
                        Console.WriteLine("\tGuminyomás: " + item.Guminyomas);
                        Console.WriteLine("\tSzemélyek: " + item.Szemelyek);
                        Console.WriteLine("\tSúly: " + item.Suly);
                        Console.WriteLine();

                        Console.WriteLine("\tKuplunk: ");

                        continue;
                    }

                    if (item.GetType().Name == "moped")
                    {

                    }


                    else if (item.GetType().Name == "bicikli")
                    {

                    }
                }
            }


            Console.ReadKey();
        }
    }
}
