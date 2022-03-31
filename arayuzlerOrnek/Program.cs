using System;

namespace arayuzlerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Civic civic = new Civic();
            System.Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(civic.StandartRengiNe().ToString());
            System.Console.WriteLine(civic.KacTekerlektenOlusur());

            Corolla corolla = new Corolla();
            System.Console.WriteLine(corolla.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(corolla.StandartRengiNe().ToString());
            System.Console.WriteLine(corolla.KacTekerlektenOlusur());

            


        }
    }
}
