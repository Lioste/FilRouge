namespace AppliGestion
{
    partial class Interrogation
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_IDPrdt = new System.Windows.Forms.ListBox();
            this.LB_FourIDPrdt = new System.Windows.Forms.ListBox();
            this.LB_LibelleCourtPrdt = new System.Windows.Forms.ListBox();
            this.LB_LibelleLongPrdt = new System.Windows.Forms.ListBox();
            this.LB_PrixUnitePrdt = new System.Windows.Forms.ListBox();
            this.LB_StockPrdt = new System.Windows.Forms.ListBox();
            this.LB_SousRubrique = new System.Windows.Forms.ListBox();
            this.LB_IDFournisseur = new System.Windows.Forms.ListBox();
            this.BTN_PrdtNCommande = new System.Windows.Forms.Button();
            this.BTN_ListeEntiere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_IDPrdt
            // 
            this.LB_IDPrdt.FormattingEnabled = true;
            this.LB_IDPrdt.Location = new System.Drawing.Point(12, 12);
            this.LB_IDPrdt.Name = "LB_IDPrdt";
            this.LB_IDPrdt.Size = new System.Drawing.Size(96, 316);
            this.LB_IDPrdt.TabIndex = 0;
            this.LB_IDPrdt.SelectedIndexChanged += new System.EventHandler(this.LB_IDPrdt_SelectedIndexChanged);
            // 
            // LB_FourIDPrdt
            // 
            this.LB_FourIDPrdt.FormattingEnabled = true;
            this.LB_FourIDPrdt.Location = new System.Drawing.Point(734, 12);
            this.LB_FourIDPrdt.Name = "LB_FourIDPrdt";
            this.LB_FourIDPrdt.Size = new System.Drawing.Size(96, 316);
            this.LB_FourIDPrdt.TabIndex = 1;
            // 
            // LB_LibelleCourtPrdt
            // 
            this.LB_LibelleCourtPrdt.FormattingEnabled = true;
            this.LB_LibelleCourtPrdt.Location = new System.Drawing.Point(216, 12);
            this.LB_LibelleCourtPrdt.Name = "LB_LibelleCourtPrdt";
            this.LB_LibelleCourtPrdt.Size = new System.Drawing.Size(96, 316);
            this.LB_LibelleCourtPrdt.TabIndex = 2;
            // 
            // LB_LibelleLongPrdt
            // 
            this.LB_LibelleLongPrdt.FormattingEnabled = true;
            this.LB_LibelleLongPrdt.Location = new System.Drawing.Point(318, 12);
            this.LB_LibelleLongPrdt.Name = "LB_LibelleLongPrdt";
            this.LB_LibelleLongPrdt.Size = new System.Drawing.Size(96, 316);
            this.LB_LibelleLongPrdt.TabIndex = 3;
            // 
            // LB_PrixUnitePrdt
            // 
            this.LB_PrixUnitePrdt.FormattingEnabled = true;
            this.LB_PrixUnitePrdt.Location = new System.Drawing.Point(522, 12);
            this.LB_PrixUnitePrdt.Name = "LB_PrixUnitePrdt";
            this.LB_PrixUnitePrdt.Size = new System.Drawing.Size(96, 316);
            this.LB_PrixUnitePrdt.TabIndex = 4;
            // 
            // LB_StockPrdt
            // 
            this.LB_StockPrdt.FormattingEnabled = true;
            this.LB_StockPrdt.Location = new System.Drawing.Point(420, 12);
            this.LB_StockPrdt.Name = "LB_StockPrdt";
            this.LB_StockPrdt.Size = new System.Drawing.Size(96, 316);
            this.LB_StockPrdt.TabIndex = 5;
            // 
            // LB_SousRubrique
            // 
            this.LB_SousRubrique.FormattingEnabled = true;
            this.LB_SousRubrique.Location = new System.Drawing.Point(624, 12);
            this.LB_SousRubrique.Name = "LB_SousRubrique";
            this.LB_SousRubrique.Size = new System.Drawing.Size(96, 316);
            this.LB_SousRubrique.TabIndex = 6;
            // 
            // LB_IDFournisseur
            // 
            this.LB_IDFournisseur.FormattingEnabled = true;
            this.LB_IDFournisseur.Location = new System.Drawing.Point(114, 12);
            this.LB_IDFournisseur.Name = "LB_IDFournisseur";
            this.LB_IDFournisseur.Size = new System.Drawing.Size(96, 316);
            this.LB_IDFournisseur.TabIndex = 7;
            // 
            // BTN_PrdtNCommande
            // 
            this.BTN_PrdtNCommande.Location = new System.Drawing.Point(12, 345);
            this.BTN_PrdtNCommande.Name = "BTN_PrdtNCommande";
            this.BTN_PrdtNCommande.Size = new System.Drawing.Size(159, 23);
            this.BTN_PrdtNCommande.TabIndex = 8;
            this.BTN_PrdtNCommande.Text = "Liste Produit Non Commande";
            this.BTN_PrdtNCommande.UseVisualStyleBackColor = true;
            this.BTN_PrdtNCommande.Click += new System.EventHandler(this.BTN_PrdtNCommande_Click);
            // 
            // BTN_ListeEntiere
            // 
            this.BTN_ListeEntiere.Location = new System.Drawing.Point(755, 345);
            this.BTN_ListeEntiere.Name = "BTN_ListeEntiere";
            this.BTN_ListeEntiere.Size = new System.Drawing.Size(75, 23);
            this.BTN_ListeEntiere.TabIndex = 9;
            this.BTN_ListeEntiere.Text = "Liste Produit";
            this.BTN_ListeEntiere.UseVisualStyleBackColor = true;
            this.BTN_ListeEntiere.Click += new System.EventHandler(this.BTN_ListeEntiere_Click);
            // 
            // Interrogation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 380);
            this.Controls.Add(this.BTN_ListeEntiere);
            this.Controls.Add(this.BTN_PrdtNCommande);
            this.Controls.Add(this.LB_IDFournisseur);
            this.Controls.Add(this.LB_SousRubrique);
            this.Controls.Add(this.LB_StockPrdt);
            this.Controls.Add(this.LB_PrixUnitePrdt);
            this.Controls.Add(this.LB_LibelleLongPrdt);
            this.Controls.Add(this.LB_LibelleCourtPrdt);
            this.Controls.Add(this.LB_FourIDPrdt);
            this.Controls.Add(this.LB_IDPrdt);
            this.Name = "Interrogation";
            this.Text = "Interrogation";
            this.Load += new System.EventHandler(this.Interrogation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_IDPrdt;
        private System.Windows.Forms.ListBox LB_FourIDPrdt;
        private System.Windows.Forms.ListBox LB_LibelleCourtPrdt;
        private System.Windows.Forms.ListBox LB_LibelleLongPrdt;
        private System.Windows.Forms.ListBox LB_PrixUnitePrdt;
        private System.Windows.Forms.ListBox LB_StockPrdt;
        private System.Windows.Forms.ListBox LB_SousRubrique;
        private System.Windows.Forms.ListBox LB_IDFournisseur;
        private System.Windows.Forms.Button BTN_PrdtNCommande;
        private System.Windows.Forms.Button BTN_ListeEntiere;
    }
}

