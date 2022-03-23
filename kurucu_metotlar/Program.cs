using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("******Çalışan 1 ************");
        calisan calisan1 = new calisan("burak","şentürk","ceo",98745632);
            calisan1.calisanbilgileri();
        
    Console.WriteLine("******Çalışan 2 ************");
    calisan calisan2 = new calisan();
    calisan2.ad="ali";
    calisan2.soyad="yılmaz";
    calisan2.departman="ik";
    calisan2.no=12345678;
        calisan2.calisanbilgileri();
    
    Console.WriteLine("******Çalışan 3 ************");
    calisan calisan3 = new calisan("selen","şentürk");
        calisan3.calisanbilgileri();


        }
    }

    class calisan
    {
        public string ad;
        public string soyad; //propertyler
        public string departman;
        public int no;

        public calisan(string Ad, string Soyad, string Departman, int No)   //kurucu metot sınıfla aynı isimde olur.
        {
            this.ad=Ad;
            this.soyad=Soyad;
            this.departman=Departman;
            this.no=No;
        }
        public calisan(string Ad, string Soyad)   //metot overloading yaptık
        {
            this.ad=Ad;                            //departmanı:boş verecek  no:0 verecek 
            this.soyad=Soyad;           //arka planda bu böyle çalışıyor stringi null verir int sıfır bool u false verir atamazsan
        }
        public calisan(){}    

        public void calisanbilgileri()
        {
            Console.WriteLine("calisanin adi: {0} ",ad);
            Console.WriteLine("calisanin soyadi: {0} ",soyad);
            Console.WriteLine("calisanin departmanı: {0} ",departman);
            Console.WriteLine("calisanin nosu: {0} ",no);
        }
    }
}

// Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara KURUCU yada CONSTRUCTOR denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

// Kurucu eetot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:

// **Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
// **Public olarak bildirilmeleri gerekir.
// **Geri dönüş değerleri yoktur
