using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi); //numeric değerini verecek yani 6.. NOT:cumaya 23 desek 24 verecekti ardışık
                                                                                          //p.tesi 1 olsada yukardaki 
           int sıcaklık =32;
           if (sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("hava normalin altında dışarı çıkma!");
           else if (sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("hava çok çok sıcak dışarı çıkma!");
           else if (sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("hava güzel dışarı çıkabilirsin!");

        } 
    }
    enum Gunler
    {
        Pazartesi=1,  //p.tesiye 1 verince otomatik salı 2 oldu maksat sıralama yapmak
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30
    }
}
