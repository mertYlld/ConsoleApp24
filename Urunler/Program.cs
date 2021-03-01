using System;

namespace Urunler
{
    class Urun
    {

        public string urunAdi { get; set; }
        public double Fiyati { get; set; }
        public int stokAdedi { get; set; }
    }

    class Program
    {
    
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "T-shirt";
            urun1.Fiyati = 65;
            urun1.stokAdedi = 18;

            Urun urun2 = new Urun();
            urun2.urunAdi = "Ayakkabı";
            urun2.Fiyati = 150;
            urun2.stokAdedi = 14;

            Urun urun3 = new Urun();
            urun3.urunAdi = "Kazak";
            urun3.Fiyati = 75;
            urun3.stokAdedi = 21;

            Urun[] urunler = new Urun[]{urun1, urun2, urun3};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Tür: " +urun.urunAdi+ " / Fiyat: " + urun.Fiyati + " / Stok:" +urun.stokAdedi );
            }

            Console.WriteLine("----------------------------------");

            int i = 0;
            while(i<urunler.Length)
            {
                Console.WriteLine("Tür: " +urunler[i].urunAdi + " / Fiyat: " + urunler[i].Fiyati + " / Stok:" + urunler[i].stokAdedi);
                i++;
            }
            Console.WriteLine("--------------");
 

        }
     
    }
}
