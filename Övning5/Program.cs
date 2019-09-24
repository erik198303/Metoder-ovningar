using System;

namespace Övning5
{
    class Program
    {
        /*
        Fortsättning på föregående övning. Gör om funktionen så att man i
        metodanropet (via parameterlistan) får ange vad momsen ligger på. 
         */
        static void Main(string[] args)
        {
           System.Console.Write("Vad kostar produkt(SEK): ");
           double value = Convert.ToDouble(Console.ReadLine());
           System.Console.Write("Ange moms, 0,01->0,99(1%-99%): ");
           double tax = Convert.ToDouble(Console.ReadLine());
           double totalTax = TaxCalcu(value,tax);
           System.Console.WriteLine("Moms(SEK): {0}",totalTax);
           double toltalPriceWithTax = value + totalTax;
           System.Console.WriteLine("Totalpris ink. moms(SEK): {0}", toltalPriceWithTax);

            
        }
        static double TaxCalcu(double productValue, double taxValue)
        {
            double totalValue = productValue * taxValue;
            return totalValue;

        }
    }   

}
