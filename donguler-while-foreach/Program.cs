using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While:Koşullar sağlandıkça komut satırlarının çalıştırılmasını sağlar. For döngüsünden farklı olarak iterasyon sayısı belli değildir
            
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
            Console.Write("bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi)
            {
                toplam+= sayac;
                sayac ++; // +1 arttırmak anlamında (++)

            }
            Console.WriteLine("ortalama: " + toplam/sayi);   // eğer sayac sayıya eşit bitmeseydi bölen:(sayi - 1) yazılcaktı.

            //a dan z ye kadar tüm harfleri console a yazdır.
            char karakter = 'a';
            while (karakter < 'z')
            {
                Console.Write(karakter);
                karakter ++;
            }

            //Foreach

            string[] arabalar = {"opel", "toyota", "audi"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            //ForEach notları
// Foreach döngüsü diziler ve koleksiyonlarla döngüsel işlemler yapmak için kullanılır. Yapısı while ve for döngüsünden biraz farklıdır. Döngünün ne kadar devam edeceğini kullanılan dizi veya koleksiyonun eleman sayısı belirler. Her bir elaman için bir iterasyon gerçekleşir.

// Yazım şekli aşağıdaki gibidir.

// foreach(değişkenTipi değişkenAdı in diziAdı)
// {
//     //Komutlar
// }
        }
    }
}
