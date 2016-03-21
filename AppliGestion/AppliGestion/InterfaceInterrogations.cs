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
            InitializeSql();
        }
        public void InitializeSql()
        {
            SqlConnection Connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            Connect.Open();
            SqlCommand Requete = new SqlCommand("SELECT IDProduit, LibelleCourtProduit, LibelleLongProduit FROM Produit WHERE IDProduit NOT IN (SELECT  LC.IDProduit From LigneCommande LC JOIN Commande C ON  C.IDCommande = LC.IDCommande WHERE C.EtatCommande > 2)", Connect);
            SqlDataReader Resultat = Requete.ExecuteReader();
            while (Resultat.Read())
            {
                textBox1.Text += (Resultat["IDProduit"].ToString() + " " + Resultat["LibelleCourtProduit"].ToString() + " " + Resultat["LibelleLongProduit"].ToString() + "\r\n");
            }
        }
        private void Interrogation_Load(object sender, EventArgs e)
        {
        }
    }
}
