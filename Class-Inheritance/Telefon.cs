using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Inheritance
{
    class Telefon:Urun
    {
        public string İsletimSistemi { get; set; }

        public string cameraPixel { get; set; }

        public string SesSistemi { get; set; }



        public void Yazdir()
        {
            Console.WriteLine(urunAdi);
            Console.WriteLine(İsletimSistemi);
            Console.WriteLine(Model);
            Console.WriteLine(SesSistemi);
            Console.WriteLine(cameraPixel);
            Console.WriteLine(StokAdedi);
            Console.WriteLine(Fiyat);
        }

    }
}
