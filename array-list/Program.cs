using System;
using System.Collections;
using System.Collections.Generic;
namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections; namespace

            ArrayList Liste = new ArrayList();
            Liste.Add("selen");
            Liste.Add(2);
            Liste.Add(true);
            Liste.Add('B');

            //içerisinde verilere erişim
            Console.WriteLine(Liste[1]);  //1.indexteki eleman

            foreach (var item in Liste)
                Console.WriteLine(item);

            //AddRAnge (karışık dizi ekleme)
            Console.WriteLine("***AddRange***");

            string[] renkler = {"siyah","bordo","turuncu"};     //string ve int türü ikisinide listeye ekledik addrange ile
            List<int> sayılar = new List<int>{1,8,3,7,9,92,5};
            Liste.Add(renkler);
            Liste.Add(sayılar);

            foreach (var item in Liste)
                Console.WriteLine(item);

            //sort (düzeltip sıralama)
            Console.WriteLine("***Sort***");   //not: sadece int aldıgında sıralama yapar.string falan karışık olduğunda RUN yapınca 
            Liste.Sort();                      // hata verir. dikkat et! 

            foreach (var item in Liste)
                 Console.WriteLine(item);

            //Binary search (index bulma)
            Console.WriteLine("***binary search***");    
            Console.WriteLine(Liste.BinarySearch(7));   //NOT:binary de ilk sortla sıralama yap sonra 7nin indexini verir..!!

            //Reverse (ayna yansıması)
            Console.WriteLine("***reverse***"); 
            Liste.Reverse();
            
            foreach (var item in Liste)
                Console.WriteLine(item);
            
            //clear (listeyi temizledik)
            Liste.Clear();
            Console.WriteLine("***clear***"); 
            foreach (var item in Liste)
                 Console.WriteLine(item); 


            }
    }
}
