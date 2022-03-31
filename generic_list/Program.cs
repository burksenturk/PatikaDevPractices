using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object türündedir

            // List<int> SayıListesi = new List<int>();

            // SayıListesi.Add(23);
            // SayıListesi.Add(10);
            // SayıListesi.Add(4);
            // SayıListesi.Add(5);
            // SayıListesi.Add(92);
            // SayıListesi.Add(34);

            // List<string> RenkListesi = new List<string>();

            // RenkListesi.Add("kırmızı");
            // RenkListesi.Add("Mavi");
            // RenkListesi.Add("Turuncu");
            // RenkListesi.Add("Sarı");
            // RenkListesi.Add("Yeşil");

            // //Count (liste içindeki eleman sayısını verir)
            // Console.WriteLine(RenkListesi.Count);
            // Console.WriteLine(SayıListesi.Count);

            
            // //Foreach ve list.foreach ile elemanlara erişim
            // foreach (var sayi in SayıListesi)  //elemanları listeledik...
            //   Console.WriteLine(sayi);

            // SayıListesi.ForEach(sayi => Console.WriteLine(sayi));   //foreach diğer gösterim.. => bu işaret öyleyse anlamında
            // RenkListesi.ForEach(renk => Console.WriteLine(renk));   

            // //Listeden eleman çıkarma
            // SayıListesi.Remove(4);     //listeden 4 ü attık
            // RenkListesi.Remove("Yeşil"); //yeşili attık
            // Console.WriteLine("dikkat1**************************");
            // SayıListesi.ForEach(sayi => Console.WriteLine(sayi)); 
            // RenkListesi.ForEach(renk => Console.WriteLine(renk)); 
            // Console.WriteLine("dikkat2**************************");
            // SayıListesi.RemoveAt(0); //0. indecteki elemanı attık
            // RenkListesi.RemoveAt(1); //1.indextekini attık

            // SayıListesi.ForEach(sayi => Console.WriteLine(sayi)); 
            // RenkListesi.ForEach(renk => Console.WriteLine(renk)); 

            // //Liste içerisinde arama
            // if (SayıListesi.Contains(10))
            //     Console.WriteLine("10 değeri liste içerisinde var");

            // //Eleman ile index e erişme
            // Console.WriteLine(RenkListesi.BinarySearch("Kırmızı"));

            // //Diziyi List'e çevirme
            // string[] hayvanlar = {"kedi","köpek","kuş"};
            // List<string> hayvanlistesi = new List<string>(hayvanlar);

            // //Listeyi nasıl temizleriz
            //  hayvanlistesi.Clear();

             //List içerisinde nesne tutmak
             List<Kullanıcılar> KullanıcıListesi = new List<Kullanıcılar>();

             Kullanıcılar kullanıcı1 = new Kullanıcılar();
             kullanıcı1.Isim="ayşe";
             kullanıcı1.Soyisim="yılmaz";
             kullanıcı1.Yas=26;

             Kullanıcılar kullanıcı2 = new Kullanıcılar();
             kullanıcı2.Isim="ahmet";
             kullanıcı2.Soyisim="gür";
             kullanıcı2.Yas=26;

             KullanıcıListesi.Add(kullanıcı1);
             KullanıcıListesi.Add(kullanıcı2);

             List<Kullanıcılar> YeniListe = new List<Kullanıcılar>();

             YeniListe.Add(new Kullanıcılar{
                 Isim= "burak",
                 Soyisim= "şentürk",
                 Yas=26

             });

             foreach (var kullanıcı in KullanıcıListesi)
             {
                 Console.WriteLine("kullanıcı adı: " + kullanıcı.Isim);
                 Console.WriteLine("kullanıcı soyadı: " + kullanıcı.Soyisim);
                 Console.WriteLine("kullanıcı yaşı: " + kullanıcı.Yas);
                 
             }
        
          }
    }

    public class Kullanıcılar{

     private string isim;   //bunlar kendiliğinden private geliyor yazmana gerek yok

     private string soyisim;

     private int yas;

     public string Isim {get => isim; set=> isim = value; }
     public string Soyisim {get => soyisim; set=> soyisim = value; }
     public int Yas {get => yas; set=> yas = value; }
    }
}
