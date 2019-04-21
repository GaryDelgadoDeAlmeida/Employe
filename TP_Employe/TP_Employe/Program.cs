using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------------------------------------------------------\n" +
                "\t\tClasse Abstraite - Employe" +
                "\n-----------------------------------------------------------------\n");

            // Ouvrier
            Ouvrier ouvrier = new Ouvrier("Dubois", "Mathieu", new DateTime(1998, 1, 1), new DateTime(2019, 2, 2));
            Console.WriteLine(ouvrier.ToString());
            Console.WriteLine("Salaire de l'ouvrier : " + ouvrier.getSalaire());
            Console.WriteLine("\n-----------------------------------------------------------------\n");

            // Cadre
            Cadre cadre = new Cadre("13000 DH", "Dupont", "Marc", new DateTime(2000, 1, 1), 1);
            Console.WriteLine(cadre.ToString());
            Console.WriteLine("Salaire du cadre : " + cadre.getSalaire());
            Console.WriteLine("\n-----------------------------------------------------------------\n");

            // Patron
            Patron patron = new Patron("21000 DH", "Dupuis", "David", new DateTime(1995, 5, 15), 1800000, 0.3);
            Console.WriteLine(patron.ToString());
            Console.WriteLine("Salaire du patron : " + patron.getSalaire());
            Console.WriteLine("\n-----------------------------------------------------------------\n");

            Console.ReadLine();
        }
    }
}
