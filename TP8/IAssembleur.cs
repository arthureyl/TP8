using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    public interface IAssembleur
    {
        public FormuleRepas AjouterPlatPrincipal(FormuleRepas formuleRepas, Nourriture produit);
        public FormuleRepas AjouterBoisson(FormuleRepas formuleRepas, Boisson produit);
        public FormuleRepas AjouterDessert(FormuleRepas formuleRepas, Nourriture produit);
    }
}
