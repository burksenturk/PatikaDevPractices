using System;

namespace inheritance
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar Adaptasyon Sağlar.");
        }

    }
    public class Surungenler:Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltım();
        }
         public void SurunerekHareketEtmek(){
            Console.WriteLine("Hayvanlar Adaptasyon Sağlar.");
        }
    }
    public class Kuslar:Hayvanlar{
          public Kuslar(){          //yapıcı metot hepsini çalışltırır
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltım();
        }
         public void Ucmak(){
            Console.WriteLine("Kuşlar Uçar.");
        }
    }


}