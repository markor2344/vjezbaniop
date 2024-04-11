using System;

namespace zadatak3
{
    class Vozilo
    {
        public bool JeLiLeti { get; set; }
        public bool JeLiPlovi { get; set; }

        public void KudaVozi()
        {
            Console.WriteLine("Je li vozilo leti: " + JeLiLeti);
            Console.WriteLine("Je li vozilo plovi: " + JeLiPlovi);
        }
    }

    class Brod : Vozilo
    {
        public Brod(bool jeLiPlovi)
        {
            JeLiPlovi = jeLiPlovi;
            JeLiLeti = false;
        }
    }

    class Zrakoplov : Vozilo
    {
        public Zrakoplov(bool jeLiLeti)
        {
            JeLiLeti = jeLiLeti;
            JeLiPlovi = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Brod brod1 = new Brod(true);
            Brod brod2 = new Brod(false);
            Zrakoplov zrakoplov1 = new Zrakoplov(true);
            Zrakoplov zrakoplov2 = new Zrakoplov(false);

            Console.WriteLine("Vrijednosti varijabli za brod1:");
            brod1.KudaVozi();
            Console.WriteLine();

            Console.WriteLine("Vrijednosti varijabli za brod2:");
            brod2.KudaVozi();
            Console.WriteLine();

            Console.WriteLine("Vrijednosti varijabli za zrakoplov1:");
            zrakoplov1.KudaVozi();
            Console.WriteLine();

            Console.WriteLine("Vrijednosti varijabli za zrakoplov2:");
            zrakoplov2.KudaVozi();
            Console.WriteLine();
        }
    }
}