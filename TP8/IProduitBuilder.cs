using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public interface IProduitBuilder : IPackaging
    {
        /*
        nom, de prix d’achat de prix de vente public.
        */
        public Produit BuildProduitBoisson(string name, double purchase_price, double price_not_member, double price_member);
        public Produit BuildProduitBoissonAlcoolisee(string name, double purchase_price, double price_not_member, double price_member, double alcoolDegree);
        public Produit BuildProduitNourriture(string name, double purchase_price, double price_not_member, double price_member);
    }
}
