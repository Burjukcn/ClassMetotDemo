using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle( Musteri musteri)
        {
            Console.WriteLine("Tebrikler "+musteri.Name+" "+musteri.Surname+" isimli müşteri eklendi");
        }

        public void MusteriSil( Musteri musteri)
        {
            Console.WriteLine("Tebrikler "+musteri.Name+" "+musteri.Surname+" isimli müşteri silindi");
        }

        public void MusteriListele(Musteri[] musteri) 
        {
            foreach( var Musteri in musteri ) 
             {
                Console.WriteLine("Müşteri İsmi: " + Musteri.Name);
                Console.WriteLine("Müşteri Id: " + Musteri.ID  );
                Console.WriteLine("Müşteri Soyisim: " + Musteri.Surname );
                Console.WriteLine("Müşteri Açıklaması: " + Musteri.Description);
                Console.WriteLine("--------------------");

            }
 
                
                
         }
    }
}
