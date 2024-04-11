using System;

namespace Ispit
{

    internal class Program
    {

        class Sport
        {
            private string Naziv;
            private bool IgraLiSeLoptom;
            private byte BrojIgraca;


            public Sport(string naziv)
            {
                Naziv = naziv;
                IgraLiSeLoptom = false;
                BrojIgraca = 0;
            }


            public Sport(string naziv, bool igraLiSeLoptom)
            {
                Naziv = naziv;
                IgraLiSeLoptom = igraLiSeLoptom;
                BrojIgraca = 0;
            }


            public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
            {
                Naziv = naziv;
                IgraLiSeLoptom = igraLiSeLoptom;
                BrojIgraca = brojIgraca;
            }


            public void IspisiDetalje()
            {
                Console.WriteLine("Naziv sporta: " + Naziv);
                Console.WriteLine("Igra li se loptom: " + (IgraLiSeLoptom ? "Da" : "Ne"));
                Console.WriteLine("Broj igraca: " + BrojIgraca);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Sport nogomet = new Sport("Nogomet", true, 22);
                Sport vaterpolo = new Sport("Vaterpolo", true, 14);
                Sport curling = new Sport("Curling", false, 8);


                Console.WriteLine("Detalji o sportovima:");
                nogomet.IspisiDetalje();
                Console.WriteLine();
                vaterpolo.IspisiDetalje();
                Console.WriteLine();
                curling.IspisiDetalje();


                Console.ReadLine();
            }
        }
    }
}










