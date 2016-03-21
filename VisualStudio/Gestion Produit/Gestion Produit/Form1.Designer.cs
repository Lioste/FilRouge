namespace Gestion_Produit
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.B_AjoutProduit = new System.Windows.Forms.Button();
            this.Label_Static_FournisseurIDProduit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Static_LibelleCourt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Label_Static_LibelleLongProduit = new System.Windows.Forms.Label();
            this.Label_Static_PrixUnitaire = new System.Windows.Forms.Label();
            this.Label_Static_StockProduit = new System.Windows.Forms.Label();
            this.Label_Static_Rubrique = new System.Windows.Forms.Label();
            this.Label_Static_SousRubrique = new System.Windows.Forms.Label();
            this.Label_Static_IDFournisseur = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 238);
            this.listBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(72, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // B_AjoutProduit
            // 
            this.B_AjoutProduit.Location = new System.Drawing.Point(182, 12);
            this.B_AjoutProduit.Name = "B_AjoutProduit";
            this.B_AjoutProduit.Size = new System.Drawing.Size(75, 23);
            this.B_AjoutProduit.TabIndex = 2;
            this.B_AjoutProduit.Text = "Ajout Produit";
            this.B_AjoutProduit.UseVisualStyleBackColor = true;
            // 
            // Label_Static_FournisseurIDProduit
            // 
            this.Label_Static_FournisseurIDProduit.AutoSize = true;
            this.Label_Static_FournisseurIDProduit.Location = new System.Drawing.Point(293, 17);
            this.Label_Static_FournisseurIDProduit.Name = "Label_Static_FournisseurIDProduit";
            this.Label_Static_FournisseurIDProduit.Size = new System.Drawing.Size(138, 13);
            this.Label_Static_FournisseurIDProduit.TabIndex = 3;
            this.Label_Static_FournisseurIDProduit.Text = "ID Produit Chez Fournisseur";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Que des chiffres ici";
            // 
            // Label_Static_LibelleCourt
            // 
            this.Label_Static_LibelleCourt.AutoSize = true;
            this.Label_Static_LibelleCourt.Location = new System.Drawing.Point(293, 56);
            this.Label_Static_LibelleCourt.Name = "Label_Static_LibelleCourt";
            this.Label_Static_LibelleCourt.Size = new System.Drawing.Size(101, 13);
            this.Label_Static_LibelleCourt.TabIndex = 6;
            this.Label_Static_LibelleCourt.Text = "Libelle Court Produit";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Pas plus de 5 caractere";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(319, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = " pas plus de 4000 caractere";
            // 
            // Label_Static_LibelleLongProduit
            // 
            this.Label_Static_LibelleLongProduit.AutoSize = true;
            this.Label_Static_LibelleLongProduit.Location = new System.Drawing.Point(296, 102);
            this.Label_Static_LibelleLongProduit.Name = "Label_Static_LibelleLongProduit";
            this.Label_Static_LibelleLongProduit.Size = new System.Drawing.Size(103, 13);
            this.Label_Static_LibelleLongProduit.TabIndex = 9;
            this.Label_Static_LibelleLongProduit.Text = "Libelle Long Produit ";
            // 
            // Label_Static_PrixUnitaire
            // 
            this.Label_Static_PrixUnitaire.AutoSize = true;
            this.Label_Static_PrixUnitaire.Location = new System.Drawing.Point(299, 141);
            this.Label_Static_PrixUnitaire.Name = "Label_Static_PrixUnitaire";
            this.Label_Static_PrixUnitaire.Size = new System.Drawing.Size(66, 13);
            this.Label_Static_PrixUnitaire.TabIndex = 10;
            this.Label_Static_PrixUnitaire.Text = "Prix Unitraire";
            // 
            // Label_Static_StockProduit
            // 
            this.Label_Static_StockProduit.AutoSize = true;
            this.Label_Static_StockProduit.Location = new System.Drawing.Point(299, 188);
            this.Label_Static_StockProduit.Name = "Label_Static_StockProduit";
            this.Label_Static_StockProduit.Size = new System.Drawing.Size(71, 13);
            this.Label_Static_StockProduit.TabIndex = 11;
            this.Label_Static_StockProduit.Text = "Stock Produit";
            // 
            // Label_Static_Rubrique
            // 
            this.Label_Static_Rubrique.AutoSize = true;
            this.Label_Static_Rubrique.Location = new System.Drawing.Point(482, 27);
            this.Label_Static_Rubrique.Name = "Label_Static_Rubrique";
            this.Label_Static_Rubrique.Size = new System.Drawing.Size(50, 13);
            this.Label_Static_Rubrique.TabIndex = 12;
            this.Label_Static_Rubrique.Text = "Rubrique";
            // 
            // Label_Static_SousRubrique
            // 
            this.Label_Static_SousRubrique.AutoSize = true;
            this.Label_Static_SousRubrique.Location = new System.Drawing.Point(482, 80);
            this.Label_Static_SousRubrique.Name = "Label_Static_SousRubrique";
            this.Label_Static_SousRubrique.Size = new System.Drawing.Size(77, 13);
            this.Label_Static_SousRubrique.TabIndex = 13;
            this.Label_Static_SousRubrique.Text = "Sous Rubrique";
            // 
            // Label_Static_IDFournisseur
            // 
            this.Label_Static_IDFournisseur.AutoSize = true;
            this.Label_Static_IDFournisseur.Location = new System.Drawing.Point(484, 125);
            this.Label_Static_IDFournisseur.Name = "Label_Static_IDFournisseur";
            this.Label_Static_IDFournisseur.Size = new System.Drawing.Size(75, 13);
            this.Label_Static_IDFournisseur.TabIndex = 14;
            this.Label_Static_IDFournisseur.Text = "ID Fournisseur";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(488, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(488, 43);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 261);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label_Static_IDFournisseur);
            this.Controls.Add(this.Label_Static_SousRubrique);
            this.Controls.Add(this.Label_Static_Rubrique);
            this.Controls.Add(this.Label_Static_StockProduit);
            this.Controls.Add(this.Label_Static_PrixUnitaire);
            this.Controls.Add(this.Label_Static_LibelleLongProduit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Label_Static_LibelleCourt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_Static_FournisseurIDProduit);
            this.Controls.Add(this.B_AjoutProduit);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button B_AjoutProduit;
        private System.Windows.Forms.Label Label_Static_FournisseurIDProduit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Static_LibelleCourt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Label_Static_LibelleLongProduit;
        private System.Windows.Forms.Label Label_Static_PrixUnitaire;
        private System.Windows.Forms.Label Label_Static_StockProduit;
        private System.Windows.Forms.Label Label_Static_Rubrique;
        private System.Windows.Forms.Label Label_Static_SousRubrique;
        private System.Windows.Forms.Label Label_Static_IDFournisseur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

