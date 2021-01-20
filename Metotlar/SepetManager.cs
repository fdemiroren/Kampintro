using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Product produc)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! : " + produc.Adi+" "+produc.Aciklama);
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyati, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! : " + urunAdi,Aciklama,fiyati);


        }

    }
}
