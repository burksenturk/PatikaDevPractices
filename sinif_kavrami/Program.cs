using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
    // class SinifAdi
    // {
    //     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;   not:propertyler
    //     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])  not: metot kısmı
    //     {
    //         //Metot Komutları
    //     }
    // }


    // Erişim Belirleyiciler
    // 1. Public : Her yerden erişilebilir.

    // 2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

    // 3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

    // 4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.


    calisan calisan1 = new calisan();
    calisan1.ad= "burak";
    calisan1.soyad= "şentürk";
    calisan1.departman= "ceo";
    calisan1.No= 535000213;
    
    calisan1.calisanbilgileri();
    Console.WriteLine("********************");
   
    calisan calisan2 = new calisan();
    calisan2.ad="ali";
    calisan2.soyad="yılmaz";
    calisan2.departman="ik";
    calisan2.No=12345678;

    calisan2.calisanbilgileri();


        }
    }

    class calisan
    {
        public string ad;
        public string soyad; //propertyler
        public string departman;
        public int No;

        public void calisanbilgileri()
        {
            Console.WriteLine("calisanin adi: {0} ",ad);
            Console.WriteLine("calisanin soyadi: {0} ",soyad);
            Console.WriteLine("calisanin departmanı: {0} ",departman);
            Console.WriteLine("calisanin nosu: {0} ",No);
        }


    }
}
