using System;

namespace diziler_array_sinifi_metodları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayıdizisi = {37,34,2,5,12,26,45,8};

            Console.WriteLine("**sırasız dizi**");
            foreach (var sayi in sayıdizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("**sıralı dizi**");
            Array.Sort(sayıdizisi);

            foreach (var sayi in sayıdizisi)
                Console.WriteLine(sayi);

            //clear

            Console.WriteLine("**Array clear**");
            //sayıdizisi elemanlarını kullanarak 2 indexten itibaren 2 elemanı sıfırlar
            Array.Clear(sayıdizisi,2,2);

            foreach (var sayi in sayıdizisi)    //tek satır kullandıgımız için süslü parantez koymadık
                Console.WriteLine(sayi);
            
            //Reaverse   (ayna yansıması yapar dizi içinde)
            Console.WriteLine("**Array reverse**");
            Array.Reverse(sayıdizisi);
            
            foreach (var sayi in sayıdizisi)  
                Console.WriteLine(sayi);

            //indexof
            Console.WriteLine("**Array indexof**");
            Array.IndexOf(sayıdizisi,37);

           Console.WriteLine(Array.IndexOf(sayıdizisi,37));          //not: işlemler son kalan diziden devam ediyor 

           //resize
           Console.WriteLine("**Array resize**");       //dizi boyutu büyütüyor
           Array.Resize<int>(ref sayıdizisi,9); //9 elemanlı oldu
           sayıdizisi[8] = 101;   // 8. indexi git 101 yap dedik not:index sıfırdan baslar

           foreach (var sayi in sayıdizisi)  
                Console.WriteLine(sayi);









            
                
        

        }
    }
}
