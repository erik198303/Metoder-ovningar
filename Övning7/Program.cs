using System;

namespace Övning7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Hur gammal är du: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            bool ifMyndig = Myndig(answer);
            if(ifMyndig == true)
            {   
                System.Console.WriteLine("Grattis, du är myndig! Köp brews!");
            }
            else
            {
                System.Console.WriteLine("Tyvärr, du är inte tillräckligt gammal för brews!");
            }
        }
      static bool Myndig(int age)
     {
            if (age >= 18)
         {
            return true;
            
         }
          else
         {   return false;
            
         }
     }


    }
}
