using System;

namespace hazır_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
         string degisken = "Dersimiz Csharp, Hosgeldiniz";
         string degisken2 = "Dersimiz Csharp";
         string degisken3 = "dersimiz Csharp, Hosgeldiniz";

         //Lenght; (karakter sayısını verir)
         Console.WriteLine(degisken.Length); 

         //ToUpper , ToLower; (harfleri büyük , küçük yapar)
         Console.WriteLine(degisken.ToUpper());
         Console.WriteLine(degisken.ToLower());

         //Concat; (stringi yazılanla birleştirir. sonuna ekledi)
         Console.WriteLine(string.Concat(degisken," merhaba"));

         //Compare / CompareTo; (karakter kıyaslama)

         Console.WriteLine(degisken.CompareTo(degisken2)); //-1,0,1 verir. karakter sayısını kıyaslar. deg > deg2 ise 1 tersi -1
         Console.WriteLine(string.Compare(degisken,degisken2,true)); //true da büyük küçük harf duyarsız. bunda 0 verdi
         Console.WriteLine(string.Compare(degisken,degisken3,false)); //false da duyarlı.  bunda 1  verdi

         //Contains; ( 2. string 1. stringin içinde var mı.. true false dönüyor)
         Console.WriteLine(degisken.Contains(degisken2)); //true çıktı
         
         Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));  //NOT: hosgeldiniz ile bitiyor mu ?
         Console.WriteLine(degisken.StartsWith("merhaba"));    //NOT: merhaba ile baslıyor mu?

         //İndexOf; ( tsring içinde arattıgını yakalar ve ilk indexini verir)
         Console.WriteLine(degisken.IndexOf("Hos"));
         Console.WriteLine(degisken.IndexOf("burak")); // bir şey bulamazsa -1 döner

         Console.WriteLine(degisken.LastIndexOf("i")); // i harfi en son kaçıncı indexte onu verir.

         //İnsert;
         Console.WriteLine(degisken.Insert(0," merhaba! "));  //(0. indexten başla merhaba ekle dedik)

         //PadLeft , Padright;
         Console.WriteLine(degisken + degisken2.PadLeft(30));  // solda bos bırakcak şkilde deg2 yi 30karaktere tamamladı ve birleştirdi
         Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); // bunu aynı şekil yıldız koyarak yaptı
         Console.WriteLine(degisken.PadRight(50) + degisken2); // sagda bosluk bıracak skilde deg ni 50 karaktere tmmladı ve birleştirdi
         Console.WriteLine(degisken.PadRight(50,'%') + degisken2); // bunu yüzde koyarak aynısını yaptı

         //Remove;
         Console.WriteLine(degisken.Remove(10));  // 10. indexten itibaren sil
         Console.WriteLine(degisken.Remove(5,3)); // 5. indexten başla 3 karakter sil  
         Console.WriteLine(degisken.Remove(0,1)); // 0. indexten başla 1 karakter 
         
         //Replace;
         Console.WriteLine(degisken.Replace("Csharp","c#")); // Csharp yazısını c# olarak değiştir dedik
         Console.WriteLine(degisken.Replace(" ","*")); //boslukları yıldızla doldurduk

         //***Split;

         Console.WriteLine(degisken.Split(" ")[1]);  //bosluklara göre ayır bir dizi tanımla 3 elemanlı oldu. 1. indexi getir dedik

         //Substring;
         Console.WriteLine(degisken.Substring(4)); //4. indexten bvaşla gerisini getir dedik
         Console.WriteLine(degisken.Substring(4,6)); // 4.indexten başla 6 karakter getir dedik







        }
    }
}
