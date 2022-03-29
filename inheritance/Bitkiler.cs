using System;

namespace inheritance
{
   public class Bitkiler:Canlılar
    {

        protected void FotosentezYapmak(){
            Console.WriteLine("Bitkiler Fotosentez Yapar");
        }
    }
    public class TohumluBitkiler:Bitkiler{
        public TohumluBitkiler(){
            base.FotosentezYapmak();   //üst sınıfların yapması gereken işleri yapıcı mett içerisinde tanımlayarak daha az kod yazdık.
            base.Beslenme();           //base ile protected olanlara eriştik. protected ı herekese kalıtım vermemesi için yaptık.
            base.Solunum();            //:üst sınıfların metotlarına erişme şansı tanır
            base.Bosaltım();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler{
          public TohumsuzBitkiler(){        //NOT: kurucu metotlar ne zaman çalışıyor? bir sınıftan bir nesne olusturuldugunda 
            base.FotosentezYapmak();        //yapılması gereken işlemler varsa içerisine yazarız.
            base.Beslenme();
            base.Solunum();
            base.Bosaltım();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır");
        }
    }

}