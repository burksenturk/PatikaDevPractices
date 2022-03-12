using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_dönüş_tipi metot_adı(parametre listesi/argüman)
            //{
                ///komutlar
                //return (bunu geri dönüşü istiyosak yapıyoruz)
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b); //a=değer1 b=değer2
            Console.WriteLine(sonuc);
            
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırveTopla(a,b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));

            int sonuc3 = ornek.ArttırveToplarsın(ref a,ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc3));
            ornek.EkranaYazdır(Convert.ToString(a + b));



        }
        static int Topla(int deger1, int deger2)  //yazdırma işlemini manin metod içerisinde yaptık basına statik yazdık çünkü static 
        {                                         //metodlar içerisinden statik bir metod erişebilir
            return (deger1 + deger2);
        }

    }

        class Metotlar                    //bulundugumz class içerisinden değilde başka bir class içinden bir methoda erişmek istiyorsak mutlaka o classın bir instance sini yaratıp o intance(ornek) aracılıgıyla methoda erişiriz. Metotlarr ornek= ...
        {
            public void EkranaYazdır(string veri)      //public verdik erişilsin diye defaultu private dır
            {
                Console.WriteLine(veri);
            }

            public int ArttırveTopla(int deger1, int deger2)
            {
                deger1+=1;
                deger2+=1;
                return deger1 + deger2;
            }

            public int ArttırveToplarsın(ref int deger1,ref int deger2) 
            {
                deger1+=1;
                deger2+=1;
                return deger1 + deger2;

            }
        }  //ref vermek: ben bu fonksiyona a ve b değerlerini değilde bellekteki karşılıklarını veriyorum
}
