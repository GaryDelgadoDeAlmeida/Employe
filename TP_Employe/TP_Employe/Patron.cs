using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    class Patron : Employe
    {
        protected double chiffreAffaire;
        protected double pourcentage;

        public Patron(string matricule, string name, string lastName, DateTime dateNaiss, double chiffreAffaire, double pourcentage) :
            base(matricule, name, lastName, dateNaiss)
        {
            this.chiffreAffaire = chiffreAffaire;
            this.pourcentage = pourcentage;
        }

        public double getChiffreAffaire()
        {
            return this.chiffreAffaire;
        }

        public double getPourcentage()
        {
            return this.pourcentage;
        }

        public void setChiffreAffaire(double chiffreAffaire)
        {
            this.chiffreAffaire = chiffreAffaire;
        }

        public void setPourcentage(double pourcentage)
        {
            this.pourcentage = pourcentage;
        }

        public override double getSalaire()
        {
            return (this.chiffreAffaire * pourcentage) / 100;
        }

        public override string ToString()
        {
            return "Matricule : " + this.matricule +
                "\nNom : " + this.name +
                "\nPrénom : " + this.lastName +
                "\nDate de Naissance : " + this.dateNaiss +
                "\nChiffre d'affaire : " + this.chiffreAffaire +
                "\nPourcentage : " + this.pourcentage;
        }
    }
}
