using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliGestion
{
    class Produit
    {
        public int IDProduit { get; set; }
        public int FournisseurIDProduit { get; set; }
        public string LibelleCourtProduit { get; set; }
        public string LibelleLongProduit { get; set; }
        public decimal PrixUniteProduit { get; set; }
        public int StockProduit { get; set; }
        public int IDSousRubrique { get; set; }
        public int IDFournisseur { get; set; }

    }
}
