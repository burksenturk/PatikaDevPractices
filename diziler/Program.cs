using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Dizi Tanımlama
           string[] renkler = new string[5];
           
           string[] hayvanlar = {"kedi","köpek","at"};
           
           int[] dizi;
           dizi = new int[5];

           //Dizilere değer atama ve erişim
            renkler[0] = "mavi";
            dizi[3] = 10;

           Console.WriteLine(hayvanlar[2]);
           Console.WriteLine(dizi[3]);
           Console.WriteLine(renkler[0]);

           //Döngülerle dizi kullanımı
           //Klavyeden girilen n tane sayının ortalamasını hesaplayan program.

           Console.Write("lütfen dizinin eleman ayisini giriniz: ");
           int diziuzunlugu = int.Parse(Console.ReadLine());
           int[] sayıDizisi = new int[diziuzunlugu];

           for (int i = 0; i < diziuzunlugu; i++)   //i küçk olacak küçk eşit değilçünkü 5 elemanlı dizi için max indeximiz 4 olmalıdır 
           {                                                                                                             //(0,1,2,3,4)
               Console.Write("lütfen {0}. sayıyı giriniz: ", i+1 ); //i+1 içeriyi 1 den başlatıyor {0} bu kısmı
               sayıDizisi[i] = int.Parse(Console.ReadLine());

           }
            int toplam = 0;
           foreach (var sayi in sayıDizisi)
            toplam+= sayi;


            Console.WriteLine("ortalama: " + toplam/diziuzunlugu);
           
         }
    }
}
