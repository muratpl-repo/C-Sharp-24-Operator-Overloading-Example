using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65DersOperatorOverloadingOrnek1  //Dikdortgen sinifinda olusturdugumuz instanceleri karsilastirma
{                                           //ozeligi kazandirdigimiz ornek...
    class Program
    {   
        class Dikdortgen
        {
            public int En { get; set; } //Properties..
            public int Boy { get; set; } //Properties..

            public Dikdortgen(int x, int y)//Constructo metot..
            {
                En = x;
                Boy = y;
            }
            // Burada instance'leri karsilastirmak icin operator overloading yaptik.
            public static bool operator >(Dikdortgen dik1, Dikdortgen dik2)
            {
                if (dik1.En * dik1.Boy > dik2.En * dik2.Boy)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Burada instance'leri karsilastirmak icin operator overloading yaptik.
            public static bool operator <(Dikdortgen dik1, Dikdortgen dik2) 
            {
                if (dik1.En * dik1.Boy < dik2.En * dik2.Boy)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen(15, 10);
            Dikdortgen d2 = new Dikdortgen(20, 7);

            bool buyukMu = d1 > d2;

            Console.WriteLine(buyukMu);
        }


    }
}
