using System;

namespace hazır_metotlar_Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date); //saati 00.00 görerek getirir
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın hangi günündeyiz
            Console.WriteLine(DateTime.Now.DayOfYear); // yılın kacıncı günündeyiz

            Console.WriteLine(DateTime.Now.ToLongDateString()); //18 mart 2022 cuma
            Console.WriteLine(DateTime.Now.ToShortDateString()); //18.03.2022
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //saat:dk:sn
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //sat:dk

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(30)); //bunlarla saat dk yıl vs ekleme yapıyorsun
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddSeconds(23));
            Console.WriteLine(DateTime.Now.AddYears(5));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //18
            Console.WriteLine(DateTime.Now.ToString("ddd")); //cum
            Console.WriteLine(DateTime.Now.ToString("ddddd")); //cuma
           
            Console.WriteLine(DateTime.Now.ToString("MM")); //03
            Console.WriteLine(DateTime.Now.ToString("MMM")); //mar
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //mart
           
            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            Console.WriteLine("**** math kütüphanesi****");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            
            Console.WriteLine(Math.Ceiling(22.3)); //23 yapar. 22.3 den sonraki tamsayıya yuvarlar
            Console.WriteLine(Math.Round(22.3)); //22 yapar. 0,5 e göre yukarı veya aşağı yuvarlar
            Console.WriteLine(Math.Round(22.7)); //23 yapar. 0,5 e göre yukarı veya aşağı yuvarlar
            Console.WriteLine(Math.Floor(22.3)); //22 yapar. 22.3 den önceki tamsayıya yuvarlar

            Console.WriteLine(Math.Max(2,6)); // iki sayıdan küçüğü verir
            Console.WriteLine(Math.Min(2,6)); // iki sayıdan büyüğü verir

            Console.WriteLine(Math.Pow(3,4)); // 3^4 ü veriri 81
            Console.WriteLine(Math.Sqrt(16)); // karekök
            Console.WriteLine(Math.Log(9)); //e tabanında log
            Console.WriteLine(Math.Exp(3)); // e^3 alır
            Console.WriteLine(Math.Log10(10)); // 10 tabında log
            





        }
    }
}
