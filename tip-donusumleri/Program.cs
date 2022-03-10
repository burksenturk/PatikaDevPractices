using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implict conversion (bilinçsiz donusum)
            byte a = 3;
            short b = 4;
            sbyte c = 5;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            string m = "burak";
            char f = 'q';
            object sntrk = f+m+b+m;
            Console.WriteLine("sntrk:" + sntrk);

            //explict conversion ( bilinçli donusum)

            int aa = 4;
            byte bb = (byte)aa;
            Console.WriteLine("bb:" + bb);

            float cc = 11.2f;
            byte gg = (byte)cc;
            Console.WriteLine("gg:" + gg);   //tam sayı verecek 11 olarak

            //ToString dönüsümü
            
            string selen = 2.3f.ToString();
            Console.WriteLine("selen:" + selen);

            int kastamonu = 32;
            string taskopru = kastamonu.ToString();
            Console.WriteLine("taskopru:" + taskopru);

            //systemconvert

            string c1="5", c2="9";
            int s1, s2;
            int sonuc;
            s1= Convert.ToInt32(c1);
            s2= Convert.ToInt32(c2);
            sonuc= s1 + s2;
            Console.WriteLine("donusumlusonuc:" + sonuc);

            //PARSE(string ifadeleri dönüştürmek içiçn      string>int e çevirmek gibi            )
            //yeni bir kod bloğu açtık aynı değişken isimlerini kullanabilmek için.

            ParseMethod();          //fonksiyon olusturduk main'in içinden çağırmazsak hiçbir değişken çalışmaz.
   
        }
            public static void ParseMethod()
            {
                string cagla1= "19";
                string zeynep1= "18";
                int s1; 
                s1= Int32.Parse(cagla1);
                double s2;
                s2= double.Parse(zeynep1);
                
                Console.WriteLine("s1:" + s1);
                Console.WriteLine("s2:" + s2);


                //datetime

                //Convert.ToDateTime() yada DateTime.Parse() methodları ile

        }
    }
}
