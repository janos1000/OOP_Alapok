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
            public string nev = "Jani";
            public int kor = 67;
            
        }

        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            Console.WriteLine($"A tanuló neve {tanulo1.nev} és {tanulo1.kor} éves.");
        }
    }
}
