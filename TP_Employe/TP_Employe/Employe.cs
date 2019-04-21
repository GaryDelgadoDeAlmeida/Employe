using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe
{
    abstract class Employe
    {
        protected string matricule;
        protected string name;
        protected string lastName;
        protected DateTime dateNaiss;

        public Employe(string matricule, string name, string lastName, DateTime dateNaiss)
        {
            this.matricule = matricule;
            this.name = name;
            this.lastName = lastName;
            this.dateNaiss = dateNaiss;
        }

        public string getMatricule()
        {
            return this.matricule;
        }

        public string getName()
        {
            return this.name;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public DateTime getDateNaiss()
        {
            return this.dateNaiss;
        }

        public abstract double getSalaire();
    }
}
