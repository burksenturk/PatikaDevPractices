using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
          Ogrenci ogrenci = new Ogrenci();          
          ogrenci.Isim="burak";
          ogrenci.Soyisim="şentürk";
          ogrenci.OgrenciNo=940;
          ogrenci.Sinif=3;
          ogrenci.OgrenciBiigileriniGetir();

          ogrenci.SınıfAtlat();
          ogrenci.OgrenciBiigileriniGetir();

          Ogrenci ogrenci1 = new Ogrenci("ahmet", "yılmaz", 1615, 1); 
          ogrenci1.SınıfDusur();
          ogrenci1.SınıfDusur();
          ogrenci1.OgrenciBiigileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;   //ctrl+. ile kapsüle et
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get  {return isim;} 
            set  {isim = value;}                //alttakiyle aynı gösterim 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; } //ctrl+. ile olusturucuya parametre ekledik.kurucu metoda
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value < 1)
                {
                 Console.WriteLine("sınıf en az 1 olabilir!");   // sınıfın 1 den düşük olursa -1 çıkmasınoın önüne geçtik
                 sinif=1;
                }
                else
                sinif = value;
            }  
        }  

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif) //kurucu metodumuz
        {
            Isim = ısim;    //ctrl+.
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBiigileriniGetir()
        {
            Console.WriteLine("****** Öğrenci Bilgileri ******");
            Console.WriteLine("öğrenci adı   :{0}",this.Isim);  //this ile public olanlara eriştik getir setir olayı
            Console.WriteLine("öğrenci soyadı   :{0}",this.Soyisim);
            Console.WriteLine("öğrenci öğrenci Nosu   :{0}",this.OgrenciNo);
            Console.WriteLine("öğrenci sınıfı   :{0}",this.Sinif);
        }

        public void SınıfAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SınıfDusur()
        {
            this.Sinif= this.Sinif -1;
        }
    }
}

// class Ogrenci
// {
//     private string name; =>//field

//     public string Name =>//property
//     {
//         get { return name; }
//         set { name = value; }
//     }
// }


// Bilindiği gibi C# nesneye dayalı bir programlama dilidir. Kapsülleme (Encapsulation) kavramı bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır. Private erişim belirteci sayesinde bu şekilde tanımlanan bir field’ i başka sınıflardan gizlemiş oluruz. Ayrıca bu field başka sınıflarda kullanılamaz.


// Kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur. Fakat bazı durumlarda private field’ lara erişmemiz ve özelliklerini kullanmamız gerekebilir. Bu durumda Property kavramı devreye girer. Property bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar
