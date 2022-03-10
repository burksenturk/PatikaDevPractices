using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<11)
               Console.WriteLine("günaydın!");
            else if(time<= 18)
               Console.WriteLine("iyi günler!");
            else
               Console.WriteLine("iyi akşamlar!");

            string sonuc = time>=6 && time<11 ? "günaydın!" : time<= 18 ? "iyi günler!" : "iyi akşamlar!";
               Console.WriteLine(sonuc);

            //NOTLAR:
            // : değilse anlamında gibi  ? ise anlamında gibi 
            // if -> koşul sağlandığında bir işlem yapılmasını sağlar.
            // else -> if içerisindeki koşul sağlanmadığında bir işlem yapılmasını sağlar ve if‘ten hemen sonra kullanılmalıdır.
            // elseif -> if içerisindeki koşul sağlanmadığında başka bir koşula uyduğunda kullanılır.
        }
    }
}
