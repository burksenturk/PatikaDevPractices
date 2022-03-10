using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 2;
            int y = 4;
            y = y+2;
            Console.WriteLine(y);
            y += 6;
            Console.WriteLine(y);
            x *= 4;
            Console.WriteLine(x);
            x /= 2;
            Console.WriteLine(x);

            // mantıksal 

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("perfect");
            if(isSuccess || isCompleted)
            Console.WriteLine("harika!");
            if(isSuccess && !isCompleted)
            Console.WriteLine("vaov!");

            //ilişkisel 

            int m = 10;
            int n = 5;
            bool durum1 = m<=n;
            Console.WriteLine(durum1);
            durum1 = m!=n;
            Console.WriteLine(durum1);
            durum1 = m==n;
            Console.WriteLine(durum1);
            
            //Aritmetik paremetler

            int w = 16;
            int s = 8;
            int sonuc2 = w / s;
            Console.WriteLine(sonuc2);
            sonuc2 = w*s;
            Console.WriteLine(sonuc2);
            sonuc2 = w+s;
            Console.WriteLine(sonuc2);
            sonuc2 = w % s;
            Console.WriteLine(sonuc2);
            sonuc2 =s++;
            Console.WriteLine(s);

        }
    }
}
