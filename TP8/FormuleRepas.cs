using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public class FormuleRepas
    {
        IDictionary<string,Produit> dictionaryProduit;

        public void ajouterProduit(Produit produit)
        {
            dictionaryProduit.Add(produit.Name,produit);
        }

        public IDictionary<string, Produit> DictionaryProduit { get; set; }

        public double prixPublic(string nomProduit)
        {
            return dictionaryProduit[nomProduit].Price_not_member;
        }

        public double prixMembre(string nomProduit)
        {
            return dictionaryProduit[nomProduit].Price_member;
        }

        public override string ToString()
        {
            return DictionaryProduit.ToString();
        }
    }
}
