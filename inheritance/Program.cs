using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        //                          CANLILAR
        //                              |
        //         BİTKİLER                             HAYVANLAR
        //     |              |                     |               |
        // Tohumlu         Tohumsuz               Sürüngenler    Kuslar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            System.Console.WriteLine("*********************");

            Kuslar kartal = new Kuslar();
            kartal.Ucmak();

        }
    }
}

// TohumluBitkiler tohumluBitki = new TohumluBitkiler();
//             tohumluBitki.Beslenme();
//             tohumluBitki.Bosaltım();
//             tohumluBitki.Solunum();                      //bu şekilde de nesne tanımlayarak yaparsın ama hepsi public olmalı.
//             tohumluBitki.FotosentezYapmak();
//             tohumluBitki.TohumlaCogalma();

//             System.Console.WriteLine("*********************");

//             Kuslar kartal = new Kuslar();
//             kartal.Beslenme();
//             kartal.Bosaltım();
//             kartal.Solunum();
//             kartal.Adaptasyon();
//             kartal.Ucmak();
