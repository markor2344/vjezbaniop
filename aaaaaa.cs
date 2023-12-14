using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezbao2
{
    class KlasaB
    {
        public string bezPrvogIZadnjeg(string tekst)
        {
            tekst = tekst.Substring(1, tekst.Length - 2);
            return tekst;
        }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
            KlasaB objekt = new KlasaB();
            Console.WriteLine("Upisi neki tekst duzi od dva znaka.");
            string tekst = Console.ReadLine();

            if(tekst.Length > 2)
            {
                Console.WriteLine(objekt.bezPrvogIZadnjeg(tekst));
            }
            else
            {
                Console.WriteLine("Tekst nije duzi od 2 znaka.");
            }

            Console.ReadKey();
             
            }
    }
    
}
