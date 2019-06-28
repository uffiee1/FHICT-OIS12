using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Applicatie
{
    public class Gebruiker
    {
        internal static List<Gebruiker> DataSource;

        public enum Type
        {
            User1,
            User2,
            User3,
            User4
        }

        public Type Gebruker { get; set; }

        public Gebruiker(Type Gebruiker)
        {
        }

        public Gebruiker()
        {
        }

        public string Gebruikersaam { get; set; }
        public string Naam { get; set; }
        public string Wachtwoord { get; set; }
    }
}