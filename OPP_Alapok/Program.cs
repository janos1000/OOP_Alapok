using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Alapok
{
    public class Szemely
    {
        protected string nev;
        private int kor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        public override string ToString()
        {
            return $"A személy neve {nev} életkora {kor}";
        }
    }

    public class Bankszamla
    {
        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set
            {
                if (value >= 0)
                    egyenleg = value;
                else
                    Console.WriteLine("Az érték nem lehet negatív.");
            }
        }
        public void Betesz()
        {

        }

        public void Kivesz()
        {

        }
    }

    public class Hallgato : Szemely 
    {
        private string neptunkod;

        public string Neptukod
        {
            get { return neptunkod; }
            set 
            {
                if (value.Length <= 6)
                    neptunkod = value;
                else
                    Console.WriteLine("Nem megfelelő hosszúság.");
            }

        }

        public void Kiir() 
        {
            nev = string.Empty;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Laura";
            tanulo1.Kor = 67;

            Console.WriteLine(tanulo1);

            Console.WriteLine("--------------------------------------------");

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine(bankszamla1.Egyenleg);

            Console.WriteLine("--------------------------------------------");

            Hallgato hallgato1 = new Hallgato();
            hallgato1.Neptukod = "MLESD3";
            Console.WriteLine(hallgato1.Neptukod);

            Console.WriteLine("--------------------------------------------");

            List<Hallgato> hallgatok = new List<Hallgato>();
            for (int i = 0; i < 5; i++)
            {
                Szemely hallgato = new Hallgato();
                Console.WriteLine($"Kérem a(z) {i+1} hallgató nevét: ");
                hallgato.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem a(z) {i+1} hallgató életkorát: ");
                hallgato.Kor = int.Parse(Console.ReadLine());
            }

        }
    }
}
