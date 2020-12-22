using System;
using System.Collections.Generic;
using System.Text;
using TP8;

namespace XUnitTestProject
{
    public class BuilderTest
    {
        public BuilderTest()
        {

        }
        public BDE bde;
        public Stock stock;
        public BDE genererBDE()
        {
            bde = BDE.Instance;
            bde.AddStudent(new Etudiant("Jean", "Etudiant", 18,2020),1000);
            bde.AddStudent(new AutreClient("Jean", "Prof", 40), 1000);

            stock = new Stock();
            Produit soda = new Boisson("soda", 10,11,12);
            Produit gateau = new Nourriture("gateau", 10, 11, 12);
            Produit sandwich = new Nourriture("sandwich", 5, 6, 7);

            stock.AddProduitInStock(soda, 1);
            stock.AddProduitInStock(gateau, 10);
            stock.AddProduitInStock(sandwich, 5);

            return bde;
        }
        
        
    }
}
