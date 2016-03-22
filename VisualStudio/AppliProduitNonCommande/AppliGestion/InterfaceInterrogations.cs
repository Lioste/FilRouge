using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppliGestion
{
    public partial class Interrogation : Form
    {
        public Interrogation()
        {
            InitializeComponent();
            InitializeTB();
            LB_IDFournisseur.Enabled = false;
            LB_LibelleCourtPrdt.Enabled = false;
            LB_FourIDPrdt.Enabled = false;
            LB_LibelleLongPrdt.Enabled = false;
            LB_StockPrdt.Enabled = false;
            LB_IDFournisseur.Enabled = false;
            LB_PrixUnitePrdt.Enabled = false;
            LB_SousRubrique.Enabled = false;
        }
        public void InitializeTBProduitNonCommande()
        {
            ProduitDAO repo;
            repo = new ProduitDAO("server=(local);database=Fil_Rouge;Integrated Security = True");

            LB_IDPrdt.ValueMember = "IDProduit";
            LB_IDPrdt.DataSource = repo.ListeProduitNonCommande();
            LB_LibelleCourtPrdt.DisplayMember = "LibelleCourtProduit";
            LB_LibelleCourtPrdt.DataSource = repo.ListeProduitNonCommande();
            LB_FourIDPrdt.ValueMember = "FournisseurIDProduit";
            LB_FourIDPrdt.DataSource = repo.ListeProduitNonCommande();
            LB_LibelleLongPrdt.DisplayMember = "LibelleLongProduit";
            LB_LibelleLongPrdt.DataSource = repo.ListeProduitNonCommande();
            LB_StockPrdt.ValueMember = "StockProduit";
            LB_StockPrdt.DataSource = repo.ListeProduitNonCommande();
            LB_PrixUnitePrdt.ValueMember = "PrixUniteProduit";
            LB_PrixUnitePrdt.DataSource = repo.ListeProduitNonCommande();
            LB_SousRubrique.ValueMember = "IDSousRubrique";
            LB_SousRubrique.DataSource = repo.ListeProduitNonCommande();
            LB_IDFournisseur.ValueMember = "IDFournisseur";
            LB_IDFournisseur.DataSource = repo.ListeProduitNonCommande();
        }
        private void Interrogation_Load(object sender, EventArgs e)
        {
        }

        public void InitializeTB()
        {
            ProduitDAO repo;
            repo = new ProduitDAO("server=(local);database=Fil_Rouge;Integrated Security = True");
            
            LB_IDPrdt.ValueMember = "IDProduit";
            LB_IDPrdt.DataSource = repo.Liste();
            LB_LibelleCourtPrdt.DisplayMember = "LibelleCourtProduit";
            LB_LibelleCourtPrdt.DataSource = repo.Liste();
            LB_FourIDPrdt.ValueMember = "FournisseurIDProduit";
            LB_FourIDPrdt.DataSource = repo.Liste();
            LB_LibelleLongPrdt.DisplayMember = "LibelleLongProduit";
            LB_LibelleLongPrdt.DataSource = repo.Liste();
            LB_StockPrdt.ValueMember = "StockProduit";
            LB_StockPrdt.DataSource = repo.Liste();
            LB_PrixUnitePrdt.ValueMember = "PrixUniteProduit";
            LB_PrixUnitePrdt.DataSource = repo.Liste();
            LB_SousRubrique.ValueMember = "IDSousRubrique";
            LB_SousRubrique.DataSource = repo.Liste();
            LB_IDFournisseur.ValueMember = "IDFournisseur";
            LB_IDFournisseur.DataSource = repo.Liste();

        }

        private void LB_IDPrdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_IDFournisseur.SelectedIndex != -1)
            {
                LB_IDFournisseur.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_LibelleCourtPrdt.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_FourIDPrdt.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_LibelleLongPrdt.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_StockPrdt.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_IDFournisseur.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_PrixUnitePrdt.SelectedIndex = LB_IDPrdt.SelectedIndex;
                LB_SousRubrique.SelectedIndex = LB_IDPrdt.SelectedIndex;

            }
        }

        private void BTN_PrdtNCommande_Click(object sender, EventArgs e)
        {
            InitializeTBProduitNonCommande();
        }

        private void BTN_ListeEntiere_Click(object sender, EventArgs e)
        {
            InitializeTB();
        }
    }
}
