using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "aleyna";
            musteri1.Soyadi = "ilhan";
            musteri1.TcNo = "2222222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54565";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "123354590";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri(); //musteri classı hem gercek musterinin hem de tuzel musterinin referansını tutabiliyor.
            CustomerManager customer = new CustomerManager();
            customer.Add(musteri1);
            customer.Add(musteri2);
        }
    }
}
