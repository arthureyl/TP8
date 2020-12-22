using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public class Nourriture : Produit
    {
        public Nourriture(string name, double purchase_price, double price_not_member, double price_member) : base(name, purchase_price, price_not_member, price_member)
        {

        }
    }
}
