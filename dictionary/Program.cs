using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic namespace
            Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add(18,"ayşe yılmaz");    //18 keyi ayşe yılmaz value si gibi düşünebilirsin.. 
            kullanıcılar.Add(27,"bilal yılmaz");   //key i dizinin indexi, value yi dizinin elemanları gibi
            kullanıcılar.Add(25,"selen şentürk");
            kullanıcılar.Add(26,"burak şentürk");
          //kullanıcılar.Add(26,"burak şentürk");   //aynısını tekrar yazarsan runtime da patlarsın. bunlar unic olmalıdır

            //elemanlarına erişim
             Console.WriteLine("***elemanlarına erişim***");
            Console.WriteLine(kullanıcılar[25]);
            
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count (eleman sayısı)
            Console.WriteLine("***count***");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("***contains***");
            Console.WriteLine(kullanıcılar.ContainsKey(26));  //26 mı var mı diye sorduk true
            Console.WriteLine(kullanıcılar.ContainsValue("bilal yılmaz")); //aynı şekil

            //Remove (eleman çıkartma)
            Console.WriteLine("***Remove***");
            kullanıcılar.Remove(18);  //18 keyli elemanı çıkardı
            
            foreach (var item in kullanıcılar)  //elemanlarımı yazdır göreyim
                Console.WriteLine(item);   //Console.WriteLine(item.Values); yazsaydım sadece value leri yazdırcaktı..
            
            //Keys
            Console.WriteLine("***keys***");
            foreach (var item in kullanıcılar.Keys)
                  Console.WriteLine(item);
            
            //Values
             Console.WriteLine("***values***");
             foreach (var item in kullanıcılar.Values)
                  Console.WriteLine(item);
               
            


               
            





        }
    }
}
