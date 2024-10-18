using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        public Livre(string Titre, string Auteur, int NombrePages)
        {
            Titre = Titre;
            Auteur = Auteur;
            NombrePages = NombrePages;
        }
        public virtual void AfficherDetail()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombre de pages: {NombrePages}");
        }
    }
   
}  
