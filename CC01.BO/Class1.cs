using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Carte

    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Date_naissance { get; set; }
        public string Lieu { get; set; }
        public string Matricule { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Carte()
        {
        }

        public Carte(string nom, string prenom, int date_naissance, string lieu, string matricule, string contact, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Date_naissance = date_naissance;
            Lieu = lieu;
            Matricule = matricule;
            Contact = contact;
            Email = email;
        }
    }
}
