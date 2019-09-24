using System;

namespace Övning7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ifMyndig = Myndig(17);
            System.Console.WriteLine("Du är myndig = {0}", ifMyndig);
        }
      static bool Myndig(int age)
     {
            if (age >= 18)
         {
            return true;
            //System.Console.WriteLine("Grattis! Spring och köpa brews!");
         }
          else
         {   return false;
            //System.Console.WriteLine("Tyvärr, då får dricka Fanta!");
         }
     }


    }
}
