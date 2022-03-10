using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //try içersine hataya neden olabilecek kodu yazıyoruz  ör:2 yaz burak yaz
        try
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girdiginiz sayi: " + sayi);
        }
        
        // try ın attıgı hatayı excep. yakalıyoruz o hatayı ne yapmak isiyosak onu karar veriyoruz
        catch(Exception ex)
        {
            Console.WriteLine("hata!: " + ex.Message.ToString());
        }
        
        // bir kod bloğu hata alsın almasın çalısmasını istediğimiz başka kod bloğu varsa finally e yazıyoruz.. opsiyoneldir
        //  finally
        // {
        //     Console.Write("işlem başarıyla tamamlandı");
        // }

        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("2000000000000");
        }
        catch (ArgumentNullException ex)   //argument hatası verecegini tahmin ettiğimizden
        {
            Console.WriteLine("bos deger girdiniz");
            Console.WriteLine(ex);    // bu şekil yapınca detaylarla veriyor
            
        }
        catch(FormatException ex)          //format uygun depil
        {
            Console.WriteLine("veri tipi uygun degil");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)     //int değerinin aşması 2000000... uygun degil
        {
            Console.WriteLine("çok küçük ya da çok büyük bir değer girdiniz");
            Console.WriteLine(ex);
        }
        finally{
            Console.WriteLine("bravo işlemi");
               }
        }
    }
}
