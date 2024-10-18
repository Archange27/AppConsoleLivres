using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }
        public Revue(string Titre, string Auteur, int NombrePages, int Numero, int Annee) : base(Titre, Auteur, NombrePages)


        {
            Numero = Numero;
            Annee = Annee;

        }
        public override void AfficherDetail()
        {

            Console.WriteLine($"Numero: {Numero}, Année: {Annee}");
        }
    }
}
