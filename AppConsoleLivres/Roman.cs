using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }
        
        public Roman(string Titre, string Auteur, int NombrePages, int Numero, int Annee) : base(Titre, Auteur, NombrePages)


        {
            Genre = Genre;

        }
        public override void AfficherDetail()
        {

           Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Pages: {NombrePages}, Genre: {Genre}");

        }
    }
}
