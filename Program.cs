using System;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            hewandarat ular = new hewandarat();
            hewandarat singa = new hewandarat();
            hewandarat monyet = new hewandarat();
            hewandarat badak = new hewandarat();

            ular.bertelur();
            Console.WriteLine(badak.berburu());
            badak.makan2();

            karnivora harimau = new karnivora();
            Console.WriteLine(harimau.berburu());
            harimau.mengkonsumsi();
        }
    }
}
