using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    class Ouvrier : Employe
    {
        protected DateTime dateEntree;

        public Ouvrier(string name, string lastName, DateTime dateNaiss, DateTime dateEntree) : 
            base("2500 DH", name, lastName, dateNaiss)
        {
            this.dateEntree = dateEntree;
        }

        public override double getSalaire()
        {
            int ancien = 0;
            Console.WriteLine("\nVeuillez indiqué le nombre d'année d'ancienneté de l'ouvrier");
            this.inputAncienneteOuvrier(out ancien);

            double calc = 2500 + (ancien * 100);

            if(calc > (2500 * 2))
            {
                calc = 2500 * 2;
            }
            return calc;
        }

        private void inputAncienneteOuvrier(out int ancien)
        {
            try
            {
               ancien = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Conversion insérer impossible. Veuillez recommencé");
                try
                {
                    ancien = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception a)
                {
                    Console.WriteLine("Vous avez reprovoqué une erreur. La valeur demandé sera 0.");
                    ancien = 0;
                }
            }
        }

        public override string ToString()
        {
            return "Matricule : " + this.matricule +
                "\nNom : " + this.name +
                "\nPrénom : " + this.lastName +
                "\nDate de Naissance : " + this.dateNaiss +
                "\nDate d'entrée : " + this.dateEntree;
        }
    }
}
