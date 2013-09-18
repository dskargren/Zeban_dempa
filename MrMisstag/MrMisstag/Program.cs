using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        Console.WriteLine("Hej,\nVi vill introducera dig för ett riktigt bra program där du kan köpa din bil.");


        



        Console.WriteLine("\n");


        // La till lite i text
        Console.WriteLine("Skriv in vilken bil du vill köpa");
        Console.WriteLine("\n");
        Console.WriteLine("Bilar att välja på: Volvo och Saab:");
        Console.WriteLine("\n");
        string inmatat = Console.ReadLine();

        Console.WriteLine("Du har fått en " + inmatat + " Grattis!");
        {
            string Volvo = "\nVolvo: Volvo Orsakar Landets Värsta Olyckor!!!";
            string Saab = "\nSaab: Sälj Aset Annars Byt!!!";

            if (inmatat == "Volvo" || inmatat == "volvo")
            {
                Console.WriteLine(Volvo);
            }
            else if (inmatat == "Saab" || inmatat == "saab")
            {
                Console.WriteLine(Saab);
            }
        }

        



        Console.WriteLine("\n");



        Console.WriteLine("\nSUA!!");

        Console.WriteLine("Ditt program suger");



    }

}

