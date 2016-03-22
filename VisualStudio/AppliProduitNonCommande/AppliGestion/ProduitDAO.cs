using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppliGestion
{
    class ProduitDAO
    {
        SqlConnection _connect;
        public ProduitDAO(string chaine)
        {
            _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
        }
        public List<Produit> Liste()
        {
            
            _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            _connect.Open();
            List<Produit> resultat = new List<Produit>();
            SqlCommand requete = new SqlCommand("select * from Produit", _connect);

            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Produit p = new Produit();
                p.IDProduit = Convert.ToInt32(lecture["IDProduit"]);
                p.FournisseurIDProduit = Convert.ToInt32(lecture["FournisseurIDProduit"]);
                p.LibelleCourtProduit = Convert.ToString(lecture["LibelleCourtProduit"]);
                p.LibelleLongProduit = Convert.ToString(lecture["LibelleLongProduit"]);
                p.PrixUniteProduit = Convert.ToDecimal(lecture["PrixUniteProduit"]);
                p.StockProduit = Convert.ToInt32(lecture["StockProduit"]);
                p.IDSousRubrique = Convert.ToInt32(lecture["IDSousRubrique"]);
                p.IDFournisseur = Convert.ToInt32(lecture["IDFournisseur"]);
                resultat.Add(p);

            }
            //Form1.listBox1.DataSource = Form1.repo.Liste();
            _connect.Close();
            return resultat;
        }

        public List<Produit> ListeProduitNonCommande()
        {

            _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            _connect.Open();
            List<Produit> resultat = new List<Produit>();
            SqlCommand Requete = new SqlCommand("SELECT * FROM Produit WHERE IDProduit NOT IN (SELECT  LC.IDProduit From LigneCommande LC JOIN Commande C ON  C.IDCommande = LC.IDCommande WHERE C.EtatCommande > 2)", _connect);
            SqlDataReader lecture = Requete.ExecuteReader();
            while (lecture.Read())
            {
                Produit p = new Produit();
                p.IDProduit = Convert.ToInt32(lecture["IDProduit"]);
                p.FournisseurIDProduit = Convert.ToInt32(lecture["FournisseurIDProduit"]);
                p.LibelleCourtProduit = Convert.ToString(lecture["LibelleCourtProduit"]);
                p.LibelleLongProduit = Convert.ToString(lecture["LibelleLongProduit"]);
                p.PrixUniteProduit = Convert.ToDecimal(lecture["PrixUniteProduit"]);
                p.StockProduit = Convert.ToInt32(lecture["StockProduit"]);
                p.IDSousRubrique = Convert.ToInt32(lecture["IDSousRubrique"]);
                p.IDFournisseur = Convert.ToInt32(lecture["IDFournisseur"]);
                resultat.Add(p);
            }


            //Form1.listBox1.DataSource = Form1.repo.Liste();
            _connect.Close();
            return resultat;
        }
    }
}
