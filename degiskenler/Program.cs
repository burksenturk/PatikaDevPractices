using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
           string ad = "burak";
            string soyad = "senturk";
            string tamisim = ad + " " + soyad;
            Console.WriteLine(tamisim);

            int ilksayı = 10;
            int ikincisayı = 2;
            int carpımı = ilksayı * ikincisayı;
            Console.WriteLine(carpımı);

            //dönüsüm
            string b1 = "3";
            int b2 = 15;
            string birlesim = b1 + b2.ToString();
            Console.WriteLine(birlesim);

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            //intdönüüsm
            int a1 = 13;
            string a2 = "3";
            int sonuc = a1 + Convert.ToInt32(a2);
            Console.WriteLine(sonuc);

            //deneme
            Console.WriteLine("adını gir:");
            string name = Console.ReadLine();
            Console.WriteLine("soyadını gir");
            string surname = Console.ReadLine();
            Console.WriteLine("merhaba " + name + " " + surname);
        }
    }
}
