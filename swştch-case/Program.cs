using System;

namespace swştch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

           switch (month)
           {
               case 1:
               Console.WriteLine("ocak ayı");             
               break;                                     
               case 2:                                    
               Console.WriteLine("subat ayı");
               break;
               case 5:
               Console.WriteLine("mayıs ayı");
               break;
               case 3:
               Console.WriteLine("mart ayı");
               break;

               default:
               Console.WriteLine("yanlıs veri girdiniz");
               break;
           }
               switch (month)
               {
                   case 12:
                   case 1:
                   case 2:
                        Console.WriteLine("kıs mevsimindesiniz");
                        break;

                   case 3:
                   case 4:
                   case 5:
                         Console.WriteLine("ilkbahar mevsimindesiniz");
                         break;
                    case 6:
                    case 7:
                    case 8:
                         Console.WriteLine("yaz mevsimindesiniz");
                         break;
                    case 9:
                    case 10:
                    case 11:
                         Console.WriteLine("sonbahar mevsimindesiniz");
                         break;
                   
                   
                   default:
                   break;
                   }
        }
    }
}

//Switch-Case ifadelerinde dikkat edilmesi gereken durumlar aşağıdaki gibidir:

//Case ifadelerinin sırası önemli değildir.
// Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
// Default ifadesi zorunlu değildir. Yazılmasa da olur.
