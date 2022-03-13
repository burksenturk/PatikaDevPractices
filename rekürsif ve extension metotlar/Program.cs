using System;

namespace rekürsif_ve_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif-öz yinelemeli
            //not: genellikle faktoriyellerde üslü işlemlerde kullanılır
            //3^4 =3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
            
            result = result * 3;
            Console.WriteLine(result);

            islemler instance = new islemler();
            Console.WriteLine(instance.expo(3,4));

            //!!Extension(genişletilmiş) metot   
            //not:static olmalıdır.olmazsa erişemeyiz.nesnesi olmadan erişmemiz için.

            string ifade = "Burak Senturk Selen Yuntem";
            bool sonuc = ifade.checkSpace();
            Console.WriteLine(sonuc);
            
            if (sonuc)
             Console.WriteLine(ifade.RemoveWhiteSpace()); //bosluk buldu yukarda eger böyleyse araya kalp ekledik.
            
            Console.WriteLine(ifade.MakeUpperCase()); //harfbüyütme
            Console.WriteLine(ifade.MakeLowerCase()); //harfküçültme

            //şimdi int bir diziyi sıralayan extension metot yapıcaz.
            int[] dizi = {9,3,6,2,5,1,8};
            dizi.SortArray();
            dizi.EkranaYazdır();

            //çift sayı mı olayı
            int sayi = 5;
            Console.WriteLine(sayi.İsEvenNumber());

            //ilk karakter olayı
            Console.WriteLine(ifade.GetFirstCharacter());

                
        
        }
    }

    public class islemler
    {
        public int expo(int sayi, int üs)
        {
            if (üs<2)
                return sayi;
            return expo(sayi,üs-1)*sayi;                //rekürsif öreneği

        }
        //expo(3,4);
        //expo(3,3)*3;
        //expo(3,2)*3*3;
        //expo(3,1)*3*3*3;
        //3*3*3*3 = 3^4;

    }

    public static class Extension
    {
        public static bool checkSpace(this string param)                //extension örnekleri
        {
            return param.Contains(" ");  //contains istediğin şeyleri buluyor burada bosluk buldu.
        }

        public static string RemoveWhiteSpace(this string param) // bosluk varsa silen veya baska karaktrle dolduran metot
        {
            string[] dizi = param.Split(" "); // bu tringi bosluklara göre ayır ve bir diziye at dedik
            return string.Join("",dizi); // bu string dizisini birleştir dedik.tırnaklar birleştir
        }

        public static string MakeUpperCase(this string param)  // harfleri büyüttük
           {
                return param.ToUpper();
           } 

        public static string MakeLowerCase(this string param)  // harfleri küçülttük
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)  //diziyi sıralayan metot
        {
            Array.Sort(param);
            return param;
        } 

        public static void EkranaYazdır(this int[] param)  //diziyi ekrana yazdırdık
        {
            foreach (int item in param)
            Console.WriteLine(param);
        } 

        public static bool İsEvenNumber(this int param) // int sayının çift olup olmadıgına bakıyoruz
        {
            return param%2 == 0;
        }

        public static string GetFirstCharacter( this string param)
        {
            return param.Substring(0,1);  // 0. indexten başla 1. karakteri yakala yaptık
        }
    }
}
