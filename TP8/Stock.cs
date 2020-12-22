using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TP8
{
    public class Stock : IObservable
    {
        private Dictionary<Produit,int> stock_produit;
        private List<IObserver> _observers = new List<IObserver>();

        public Stock()
        {

        }

        public Stock(Produit prod, int nb_stock)
        {
            stock_produit = new Dictionary<Produit, int>();
            stock_produit.Add(prod,(nb_stock));
        }

        public Boolean GetProduitByName(String name_produit)
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                if (prod.Name.Equals(name_produit))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetStockProduitByName(String name_produit)
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                if (prod.Name.Equals(name_produit))
                {
                    return this.stock_produit[prod];
                }
            }

            return 0;
        }

        public Boolean ChangeStockValue(String name_produit, int stock_mvt)
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                if (prod.Name.Equals(name_produit))
                {
                    if(this.stock_produit[prod]+stock_mvt > 0)
                    {
                        this.stock_produit[prod] += stock_mvt;
                        return true;
                    }
                    else
                    {
                        this.Notify(prod);
                        this._observers.Remove(prod);
                        return false;
                    }
                }
            }

            return false;
        }


        public void AddProduitInStock(Produit prod, int nb_stock)
        {
            stock_produit.Add(prod, nb_stock);
            _observers.Add(prod);
        }

        public void ShowFullStock()
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                Console.WriteLine(prod.Name + " : " + this.stock_produit[prod]);
            }
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify(Produit prod)
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(prod);
            }
        }
    }
}
