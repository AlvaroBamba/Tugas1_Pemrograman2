using System;

namespace Tugas1
{
    public class hewandarat : Hewan   //inheriten -> hewan sebegai super class
    {
        //cunstructor
        public hewandarat()
        {

        }

        //property
        int jumlah;
        string jenis_makanan;
        string nama_famili;

        //function
        public void beranak()
        {
            Console.WriteLine("tidak bertelur");
        }

        public void bertelur()
        {
            Console.WriteLine("tidak beranak");
        }

        public string berburu()
        {
            return "Makanan";
        }
    }
}