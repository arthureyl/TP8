using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public class PreparateurFormuleVegetarienne
    {


        public FormuleRepas PreparationRepas1()
        {
            FormuleRepas formulRepas = new FormuleRepas();
            Boisson soda = new Boisson("soda", 12, 13, 12);
            Nourriture gateau = new Nourriture("gateau", 15, 16, 1);
            formulRepas = AjouterBoisson(formulRepas, soda);
            formulRepas = AjouterDessert(formulRepas, gateau);
            return formulRepas;
        }

        public FormuleRepas PreparationRepas2()
        {
            FormuleRepas formulRepas = new FormuleRepas();
            Boisson soda = new Boisson("soda", 12, 13, 12);
            Nourriture sandwich = new Nourriture("sandwich", 15, 16, 1);
            formulRepas = AjouterBoisson(formulRepas, soda);
            formulRepas = AjouterDessert(formulRepas, sandwich);
            return formulRepas;
        }

        public FormuleRepas PreparationRepas3()
        {
            FormuleRepas formulRepas = new FormuleRepas();
            Boisson soda = new Boisson("soda", 12, 13, 12);
            Nourriture sandwich = new Nourriture("sandwich", 15, 16, 1);
            Nourriture gateau = new Nourriture("gateau", 15, 16, 1);
            formulRepas = AjouterBoisson(formulRepas, soda);
            formulRepas = AjouterDessert(formulRepas, gateau);
            formulRepas = AjouterPlatPrincipal(formulRepas, sandwich);
            return formulRepas;
        }


        public FormuleRepas AjouterBoisson(FormuleRepas formuleRepas, Boisson produit)
        {
            formuleRepas.ajouterProduit(produit);
            return formuleRepas;
        }

        public FormuleRepas AjouterDessert(FormuleRepas formuleRepas, Nourriture produit)
        {
            formuleRepas.ajouterProduit(produit);
            return formuleRepas;
        }

        public FormuleRepas AjouterPlatPrincipal(FormuleRepas formuleRepas, Nourriture produit)
        {
            formuleRepas.ajouterProduit(produit);
            return formuleRepas;
        }

    }
}
