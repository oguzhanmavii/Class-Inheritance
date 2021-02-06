using System;

namespace Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun = new Urun();

            Bilgisayar bilgisayar = new Bilgisayar();

            Telefon telefon = new Telefon();



            telefon.urunAdi = "Xiaomi Redmi Note 8";
            telefon.İsletimSistemi = "Android 10.0";
            telefon.Model = "Redmi Note 8";
            telefon.SesSistemi = "Dolby digitals";
            telefon.cameraPixel = "48 MP";
            telefon.StokAdedi = 5000;
            telefon.Fiyat = "2500 TL";

            telefon.Yazdir();




        }
    }
}
