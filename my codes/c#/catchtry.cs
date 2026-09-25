using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main()
    {
        int cena, pocet, vystup;
        try
        {
            Console.WriteLine("Zadej cenu listku:");
            cena = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Musis zadat cislo");
            return;
        }
        try
        {
            Console.WriteLine("Zadej pocet osob: ");
            pocet = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Musis zadat cislo");
            return;
        }
        try
        {
            vystup = cena / pocet;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Nesmis delit nulou");
            return;
        }
        Console.WriteLine(vystup);
       
        
    }
}
