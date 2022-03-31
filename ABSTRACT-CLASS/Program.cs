using System;

namespace ABSTRACT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************İNTERFACE***************");           
            Civic civic = new Civic();
            System.Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(civic.StandartRengiNe().ToString());
            System.Console.WriteLine(civic.KacTekerlektenOlusur());

            Console.WriteLine("*****************************");
            Corolla corolla = new Corolla();
            System.Console.WriteLine(corolla.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(corolla.StandartRengiNe().ToString());
            System.Console.WriteLine(corolla.KacTekerlektenOlusur());
            
            Console.WriteLine("*************ABSTRACT****************");
            NewCivic civic1 = new NewCivic();
            System.Console.WriteLine(civic1.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(civic1.StandartRengiNe().ToString());
            System.Console.WriteLine(civic1.KacTekerlektenOlusur()); 
            
            Console.WriteLine("*****************************");
            NewCorolla corolla1 = new NewCorolla();
            System.Console.WriteLine(corolla1.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(corolla1.StandartRengiNe().ToString());
            System.Console.WriteLine(corolla1.KacTekerlektenOlusur());                       

        }
    }
}
