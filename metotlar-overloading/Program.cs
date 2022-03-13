using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler

            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int OutSayi);         
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(OutSayi);
            }
            else
            {
                 Console.WriteLine("başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamsonucu);
            Console.WriteLine(toplamsonucu);

            //Metot aşırı yükleme-overloading
            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("burak","senturk");

            //Metot İmzası
            //Metot adı + parametre sayısı + parametre


        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam= a+b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);        
        }

        public void EkranaYazdır(string veri1, string veri2)
        {
             Console.WriteLine(veri1 + veri2);
        }


    }
}
