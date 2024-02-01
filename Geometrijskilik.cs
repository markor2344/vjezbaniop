using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbageometrijskilik
{
    class GeometrijskiLik
    {
        int BrojStranica;
        int[] Stranice = new int[10];

       
        public int[] Stranice1 { get => Stranice; set => Stranice = value; }
        public int BrojStranica1 { get => BrojStranica; set => BrojStranica = value; }

        public void UcitajStranice()
        {
            Console.WriteLine("Upiši duljinu stranica");
            for (int i = 0; i < BrojStranica1; i++) 
            {
                Console.WriteLine("Stranica br. ", i + 1);
                Stranice1[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int Opseg(int[] Stranice)
        {
            int opseg = 0;
            for (int i = 0; i < BrojStranica1; i++)
            {
                opseg += Stranice[i];
            }

                return opseg;
        }
    }
    class trokut : GeometrijskiLik
    {
        public trokut()
        {
            BrojStranica1 = 3;
        }
    }
    class cetverokut : GeometrijskiLik
    {
        public cetverokut()
        {
            BrojStranica1 = 4;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            trokut tr = new trokut();   

            cetverokut _4kut = new cetverokut();
            Console.WriteLine("trokut");
            tr.UcitajStranice();
            Console.WriteLine(tr.Opseg(tr.Stranice1));
            Console.WriteLine("cetverokut");
            _4kut.UcitajStranice();
            Console.WriteLine(_4kut.Opseg(_4kut.Stranice1));
            Console.ReadKey();
             
        }
    }
}
