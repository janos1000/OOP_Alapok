using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Alapok
{
    internal class Program
    {
        public class Szemely 
        { 
            private string nev;
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

            /*public Szemely(string Nev, int Kor)
            {
                nev = Nev;
                kor = Kor;
            }

            public string Kiir()
            {
                return $"A tanuló neve {nev} és {kor} éves.";
            }*/
        }

        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Laura";
            Console.WriteLine(tanulo1.Nev);
            tanulo1.Kor = 67;
            Console.WriteLine(tanulo1.Kor);
            /*Szemely tanulo1 = new Szemely("Laura",67);
            Console.WriteLine(tanulo1.Kiir());*/
        }
    }
}
