using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    class Cadre : Employe
    {
        protected int indice;

        public Cadre(string matricule, string name, string lastName, DateTime dateNaiss, int indice) : base(matricule, name, lastName, dateNaiss)
        {
            this.indice = indice;
        }

        public int getIndice()
        {
            return this.indice;
        }

        public override double getSalaire()
        {
            double salaire = 0.0;

            switch (this.indice)
            {
                case 1:
                    salaire = 13000;
                    break;
                case 2:
                    salaire = 15000;
                    break;

                case 3:
                    salaire = 17000;
                    break;

                case 4:
                    salaire = 20000;
                    break;

                default:
                    Console.WriteLine("Indice inexistant.");
                    break;
            }

            return salaire;
        }

        public override string ToString()
        {
            return "Matricule : " + this.matricule +
                "\nNom : " + this.name +
                "\nPrénom : " + this.lastName +
                "\nDate de Naissance : " + this.dateNaiss +
                "\nIndice : " + this.indice;
        }
    }
}
