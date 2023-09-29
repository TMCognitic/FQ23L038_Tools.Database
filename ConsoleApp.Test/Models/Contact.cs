using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test.Models
{
    public class Contact
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public DateTime Anniversaire { get; init; }

        public Contact(int id, string nom, string prenom, DateTime anniversaire)
            : this (nom, prenom, anniversaire)
        {
            Id = id;
        }

        public Contact(string nom, string prenom, DateTime anniversaire)
        {
            Nom = nom;
            Prenom = prenom;
            Anniversaire = anniversaire;
        }
    }
}
