using System;

namespace donguler_for_loop_break_continue_ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları yazdır

            Console.WriteLine("lütfen bir sayı giriniz");
            int sonuc = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sonuc; i++)                         //for loop döngüsü
            {
                if(i%2 ==1) //mod alma olayı operatörlerde vardı
                    Console.WriteLine(i);
            }

            // //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.

            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2 ==1)
                tektoplam+= i;      //tektoplam= tektoplam + i  
                else
                cifttoplam+= i;     // cifttoplam= cifttoplam + i

            }
                Console.WriteLine("tek toplam: " + tektoplam);
                Console.WriteLine("çift toplam: " + cifttoplam);

            for (int i = 1; i < 10; i++)
            {
                if(i== 5)
                   break;                       //Not: İç içe döngüler kullanıldığında break ifadesi yalnızca içinde bulunduğu ilk 
                Console.WriteLine(i);           //döngüyü sonlandırır.

            }
            
            for (int c = 1; c < 10; c++)        //Kullanım amacı break ifadesine benzer ama continue sadece mevcut iterasyonu 
            {                                   //sonlandırır. Döngü bir sonraki iterasyondan devam eder.
                if(c==6)
                continue;
                Console.WriteLine(c);
            }
        }
    }
}

//   NOTLAR
   //for(ifade1;kosul;ifade2)
// {
//     komut1;
//     komut2;
// }
//ifade1: Döngünün sayacının tanımlandığı ve atamasının yapıldığı ifadedir. Örneğin; int i=0;

// ifade2: Döngünün sayacının artırım yada azaltım şeklini belirten ifadedir. Örneğin ; i++, i-- gibi.

// koşul: döngünün devam etme koşuludur. Bu koşul sağlandığı sürece döngü devam eder. Örneğin : i<=12;

// ÖNEMLİ: For döngüsünü oluşturan bu 2 ifade 1 koşulun bir kısmı ya da tamamı boş bırakılabilir. Ama aralardaki ";" işareti mutlaka kullanılmalıdır.

// for(;;) // Sonsuz döngüyü ifade eder. 