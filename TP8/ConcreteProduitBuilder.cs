using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public class ConcreteProduitBuilder : IProduitBuilder
    {

        public Produit BuildProduitBoisson(string name, double purchase_price, double price_not_member, double price_member)
        {
            Boisson boisson = new Boisson(name, purchase_price,price_not_member,price_member) ;
            boisson.Emballage = IPackaging.emballageBouteille;
            return boisson;
        }

        public Produit BuildProduitBoissonAlcoolisee(string name, double purchase_price, double price_not_member, double price_member, double alcoolDegree)
        {
            BoissonAlcoolisee boissonAlcoolisee =  new BoissonAlcoolisee(name, purchase_price, price_not_member, price_member,alcoolDegree);
            boissonAlcoolisee.Emballage = IPackaging.emballageBouteille;
            return boissonAlcoolisee;
        }

        public Produit BuildProduitNourriture(string name, double purchase_price, double price_not_member, double price_member)
        {
            Nourriture nourriture =  new Nourriture(name, purchase_price, price_not_member, price_member);
            nourriture.Emballage = IPackaging.emballagePapier;
            return nourriture;
        }
    }
}
