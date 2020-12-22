using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public class PreparateurFormule : IAssembleur
    {

        public FormuleRepas PreparationRepas1(Stock stock)
        {
            FormuleRepas formulRepas = new FormuleRepas();
            Boisson soda = new Boisson("soda", 12, 13, 12);
            Nourriture barreChocolatee = new Nourriture("gateau", 15, 16, 1);
            formulRepas = AjouterBoisson(formulRepas,soda);
            formulRepas = AjouterDessert(formulRepas,barreChocolatee);
            stock.ChangeStockValue(soda.Name, -1);
            stock.ChangeStockValue(barreChocolatee.Name, -1);
            return formulRepas;
        }

        public FormuleRepas PreparationRepas2(Stock stock)
        {
            FormuleRepas formulRepas = new FormuleRepas();
            Boisson soda = new Boisson("soda", 12, 13, 12);
            Nourriture sandwich = new Nourriture("sandwich", 15, 16, 1);
            formulRepas = AjouterBoisson(formulRepas, soda);
            formulRepas = AjouterDessert(formulRepas, sandwich);
            stock.ChangeStockValue(soda.Name, -1);
            stock.ChangeStockValue(sandwich.Name, -1);
            return formulRepas;
        }

        public FormuleRepas PreparationRepas3(Stock stock)
        {
            FormuleRepas formulRepas = new FormuleRepas();
            Boisson soda = new Boisson("soda", 12, 13, 12);
            Nourriture sandwich = new Nourriture("sandwich", 15, 16, 1);
            Nourriture barreChocolatee = new Nourriture("gateau", 15, 16, 1);
            formulRepas = AjouterBoisson(formulRepas, soda);
            formulRepas = AjouterDessert(formulRepas, barreChocolatee);
            formulRepas = AjouterPlatPrincipal(formulRepas, sandwich);
            stock.ChangeStockValue(soda.Name, -1);
            stock.ChangeStockValue(sandwich.Name, -1);
            stock.ChangeStockValue(barreChocolatee.Name, -1);
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
