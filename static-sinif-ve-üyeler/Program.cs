using System;

namespace static_sinif_ve_üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("çalışan sayısı: {0}",Calisan.CalisanSayisi);  //static sınıf adıyla erişim yaptık..

            Calisan calisan = new Calisan("burak","şentürk","İK");
            Console.WriteLine("çalışan sayısı: {0}",Calisan.CalisanSayisi); //çalışan sayısı artması lazım parametre girdik.. +1
            Calisan calisan1 = new Calisan("bilal","yılmaz","yazılım");
            Calisan calisan2= new Calisan("murat","beki","inşaat");
            Console.WriteLine("çalışan sayısı: {0}",Calisan.CalisanSayisi); //3 olması lazım

            Console.WriteLine("******MATEMATİK İŞLEMLERİ*****");
            Console.WriteLine("işlemin sonucu:  {0}", Islemler.topla(101,201));  //STATİC old. için sınıf adıyla eriştik!!
            Console.WriteLine("işlemin sonucu:  {0}", Islemler.cıkar(101,201));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }  //burada set etmedik. sadece calisan sınıfı içinden değiştircez.

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan(){
            calisanSayisi=0;   //static sınıf 1 kere çalışır publice geçer
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi ++;
        }

       
    }

     static class Islemler
        {
            public static long topla(int deger1,int deger2)
            {
                return deger1+deger2;
            }

            public static long cıkar(int deger1,int deger2)
            {
                return deger1-deger2;
            }
        }
}
