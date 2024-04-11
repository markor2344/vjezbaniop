using System;

namespace Ispitzadatak2
{
    internal class Program
    {
        class Zrakoplov
        {
            private string Naziv;
            private double SnagaMotora;
            private int DosegLeta;

            public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
            {
                Naziv = naziv;
                SnagaMotora = snagaMotora;
                DosegLeta = dosegLeta;
            }

            public void IspisiDetalje()
            {
                Console.WriteLine("Naziv: " + Naziv);
                Console.WriteLine("Snaga motora: " + SnagaMotora + " kW");
                Console.WriteLine("Doseg leta: " + DosegLeta + " km");
            }
        }

        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine("Detalji o zrakoplovima:");
            x380.IspisiDetalje();
            Console.WriteLine();
            C162.IspisiDetalje();
            Console.WriteLine();
            PC_21.IspisiDetalje();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}