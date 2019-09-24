using System;

namespace Övning6
{
    class Program
    {
        /*
        Skapa metoden ToPercentage() som tar in ett decimaltal och returnerar ett
        heltal. 
         */
        static void Main(string[] args)
        {
            try{
            System.Console.Write("Skriv in ett decimaltal: ");
            double input = Convert.ToDouble(Console.ReadLine()); 
            System.Console.WriteLine(ToPercentage(input));
            }
            catch{
                System.Console.WriteLine("Du måste skriva in ett tal!");
            }

            

        }
        static double ToPercentage(double myDecimal)
        {
            myDecimal = Convert.ToInt32(myDecimal);
            return myDecimal;
            
        }
    }
}
