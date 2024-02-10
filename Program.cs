using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.


            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Name = "Nehir";
            musteri1.Surname = "Çayan";
            musteri1.Description = "Ado";

            Musteri muster2= new Musteri();
            muster2.ID = 2;
            muster2.Name = "Ege";
            muster2.Surname = "Çayan";
            muster2.Description = "Ado";

            Musteri musteri3= new Musteri();
            musteri3.ID = 3;
            musteri3.Name = "Ali";
            musteri3.Surname = "Çayan";
            musteri3.Description = "Adulte";


            Musteri[] musteri = new Musteri[] { musteri1, muster2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("--------- Müşteri Ekleme Metotu------------");
            musteriManager.MusteriEkle(musteri1);

            Console.WriteLine("---------- Müşteri Silme Metotu -----------");
            musteriManager.MusteriSil(musteri3 );

            Console.WriteLine("---------- Müşteri Listeleme Metotu --------");
            musteriManager.MusteriListele(musteri);


            Console.ReadLine();

        }
    }
}
