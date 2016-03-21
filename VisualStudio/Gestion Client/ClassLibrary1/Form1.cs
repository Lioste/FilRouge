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

namespace ClassLibrary1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Switch = 0;
        Client c = new Client();
        public void InitializeLB_ListeNom()
        {
          
            ClientDAO repo;
            repo = new ClientDAO("server=(local);database=Fil_Rouge;Integrated Security = True");
            listBox1.DisplayMember = "NomClient";
            listBox1.ValueMember = "IDClient";
        
            CB_ContactClient.ValueMember = "IDContactClient";
            listBox1.DataSource = repo.Liste();

        }
        public void InitializeCB_ContactClientListNom()
        {
            ContactClientDAO repo;
            repo = new ContactClientDAO("server=(local);database=Fil_Rouge;Integrated Security = True");
            CB_ContactClient.ValueMember = "IDContactClient";
            CB_ContactClient.DataSource = repo.Liste();
        }
        public void B_Modifier_Click(object sender, EventArgs e)
        {
            DesactivationObjet();
            Switch = 2;
            listBox1.Enabled = false;
            AggrandirFenetre();
            ActivationObjetCache();
            InitializeTBpourModif();
            InitializeCB_ContactClientListNom();
            CB_ContactClient.SelectedValue = Convert.ToInt32(TB_IDContact.Text);
            B_Valider.Text = "Modifier Ok";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            InitializeLB_ListeNom();
            InitializeCB_ContactClientListNom();
            DesactivationObjetCache();
            DiminuerFenetre();
            
        }

        public void B_Ajouter_Click(object sender, EventArgs e)
        {
            DesactivationObjet();
            Switch = 1;
            listBox1.Enabled = false;
            VidageTBpourAjout();
            AggrandirFenetre();
            ActivationObjetCache();
            CB_ContactClient.Enabled = true;
            B_Valider.Text = "Ajouter Ok";

        }

        private void B_Suppr_Click(object sender, EventArgs e)
        {
            CB_ContactClient.Enabled = false;
            listBox1.Enabled = false;
            /*
            DesactivationObjet();
            Switch = 2;
            listBox1.Enabled = true;
            AggrandirFenetre();
            ActivationObjetCache();
            InitializeTBpourModif();
            B_Valider.Text = "Modifier Ok";
    */
            DesactivationObjet();
            DesactivationObjetCache();
            AggrandirFenetre();
            B_Valider.Enabled = true;
            

            Switch = 3;
            InitializeTBpourModif();
            CB_ContactClient.SelectedValue = Convert.ToInt32(TB_IDContact.Text);
            B_Valider.Text = "Supprimer Ok";
        }
        public void DesactivationObjetCache()
        {
            TB_Nom.Enabled = false;
            TB_Coef.Enabled = false;
            TB_IDContact.Enabled = false;
            B_Valider.Enabled = false;
        }
        public void ActivationObjetCache()
        {
            TB_Nom.Enabled = true;
            TB_Coef.Enabled = true;
            TB_IDContact.Enabled = true;
            B_Valider.Enabled = true;
        }
        public void AggrandirFenetre()
        {
            Width = 570;
        }
        public void DiminuerFenetre()
        {
            Width = 300;
        }
        public void InitializeTBpourModif()
        {
            ContactClient cc = (ContactClient)CB_ContactClient.SelectedItem;
            Client c = (Client)listBox1.SelectedItem;
            TB_Nom.Text = (c.NomClient);
            TB_IDContact.Text = Convert.ToString(c.IDContactClient);
            //CB_ContactClient.DisplayMember = Convert.ToString(cc.IDContactClient);

            CB_ContactClient.SelectedValue = Convert.ToString(c.IDContactClient); 

            //CB_ContactClient.Text += Convert.ToString(cc.NomContactClient);
            TB_Coef.Text = Convert.ToString(c.CoefClient);
            Label_IDClient.Text = Convert.ToString(c.IDClient);
        }
        public void InitializeCB()
        {
            ContactClient cc = (ContactClient)CB_ContactClient.SelectedItem;
            CB_ContactClient.Text = Convert.ToString(c.IDContactClient + " ");
            CB_ContactClient.Text += Convert.ToString(cc.NomContactClient);
        }
        public void VidageTBpourAjout()
        {
            TB_Nom.Clear();
            TB_IDContact.Clear();
            TB_Coef.Clear();
            Label_IDClient.Text = "-";
        }

        private void B_Annuler_Click(object sender, EventArgs e)
        {
            ActivationObjet();
            listBox1.Enabled = true;
            VidageTBpourAjout();
            DesactivationObjetCache();
            CB_ContactClient.Enabled = true;
            DiminuerFenetre();
        }

        public void TB_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        public void TB_Coef_TextChanged(object sender, EventArgs e)
        {

        }

        public void TB_IDContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Valider_Click(object sender, EventArgs e)
        {
            switch(Switch)
            {
                case 1:
                    TBversClient();
                    InitializeRepo().Insert(c);
                    ActivationObjet();
                    VidageTBpourAjout();
                    ActivationObjet();
                    DesactivationObjetCache();
                    Switch = 0;
                    listBox1.Enabled = true;
                    InitializeLB_ListeNom();
                    //InitializeCB_ContactClientListNom();
                    DiminuerFenetre();
                    break;
                case 2:
                    InitializeRepo().Update(c, TB_Nom.Text, Convert.ToDecimal(TB_Coef.Text), /*TB_IDContact.Text*/Convert.ToString(CB_ContactClient.SelectedValue), Convert.ToInt32(Label_IDClient.Text));
                    ActivationObjet();
                    DiminuerFenetre();
                    DesactivationObjetCache();
                    InitializeLB_ListeNom();
                    //InitializeCB_ContactClientListNom();
                    listBox1.Enabled = true;
                    Switch = 0;
                    break;
                case 3:
                    B_Valider.Enabled = true;
                    TBversClient();
                    InitializeRepo().Delete(c, Convert.ToInt32(Label_IDClient.Text));
                    ActivationObjet();
                    DiminuerFenetre();
                    DesactivationObjetCache();
                    InitializeLB_ListeNom();
                    //InitializeCB_ContactClientListNom();
                    B_Valider.Enabled = true;
                    listBox1.Enabled = true;
                    CB_ContactClient.Enabled = true;
                    Switch = 0;
                    break;

            }
        }
        public void ActivationObjet()
        {
            
            B_Ajouter.Enabled = true;
            B_Modifier.Enabled = true;
            B_Suppr.Enabled = true;
        }
        public void DesactivationObjet()
        {
            B_Ajouter.Enabled = false;
            B_Modifier.Enabled = false;
            B_Suppr.Enabled = false;
        }
        public void TBversClient()
        {
            c.NomClient = TB_Nom.Text;
            c.CoefClient = Convert.ToDecimal(TB_Coef.Text);
            c.IDContactClient = Convert.ToInt32(CB_ContactClient.SelectedValue);
            //c.IDContactClient = Convert.ToInt32(CB_ContactClient.SelectedValue);
        }
        public void CBversClient()
        {

        }
        public ClientDAO InitializeRepo()
        {
            ClientDAO repo;

            return (repo = new ClientDAO("server=(local);database=Fil_Rouge;Integrated Security=True"));

        }


        private void CB_ContactClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
