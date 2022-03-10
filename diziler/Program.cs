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

           
        }
    }
}
