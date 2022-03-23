using System;

namespace struct_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KısaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("class alan hesabı  :{0}", dikdortgen.AlanHesapla());

            Dikdortgen_struct dikdortgen_struct = new Dikdortgen_struct(); //Dikdortgen_struct dikdortgen_struct;  bu da olur newlemeden
            dikdortgen_struct.KısaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
            Console.WriteLine("struct alan hesabı  :{0}", dikdortgen_struct.AlanHesapla());

            Dikdortgen_struct dikdortgen_structt = new Dikdortgen_struct(5, 6);
            Console.WriteLine("struct alan hesabı  :{0}", dikdortgen_structt.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KısaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }

    }

    struct Dikdortgen_struct
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdortgen_struct(int kısaKenar, int uzunKenar)
        {
            KısaKenar = kısaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }

    }
//ÖZELLİKLERİS
//**Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
//**Diğer struct yada sınıflardan kalıtım almazlar.
//**Interface'lerden kalıtım alabilirler.
//**new anahtar sözcüğü ile nesneleri yaratılabilir.
//**Sınıflar gibi metot, property ve field'lardan oluşurlar.
//**Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
//**Static üye barındırabilirler
}
