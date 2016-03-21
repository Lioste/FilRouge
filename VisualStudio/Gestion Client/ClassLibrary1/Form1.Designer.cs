namespace ClassLibrary1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Ajouter = new System.Windows.Forms.Button();
            this.B_Modifier = new System.Windows.Forms.Button();
            this.B_Suppr = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Coef = new System.Windows.Forms.TextBox();
            this.TB_IDContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Static_CoefClient = new System.Windows.Forms.Label();
            this.Label_IDContact = new System.Windows.Forms.Label();
            this.Label_StaticIDClient = new System.Windows.Forms.Label();
            this.Label_IDClient = new System.Windows.Forms.Label();
            this.B_Valider = new System.Windows.Forms.Button();
            this.B_Annuler = new System.Windows.Forms.Button();
            this.CB_ContactClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // B_Ajouter
            // 
            this.B_Ajouter.Location = new System.Drawing.Point(197, 12);
            this.B_Ajouter.Name = "B_Ajouter";
            this.B_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.B_Ajouter.TabIndex = 0;
            this.B_Ajouter.Text = "Ajouter";
            this.B_Ajouter.UseVisualStyleBackColor = true;
            this.B_Ajouter.Click += new System.EventHandler(this.B_Ajouter_Click);
            // 
            // B_Modifier
            // 
            this.B_Modifier.Location = new System.Drawing.Point(197, 41);
            this.B_Modifier.Name = "B_Modifier";
            this.B_Modifier.Size = new System.Drawing.Size(75, 23);
            this.B_Modifier.TabIndex = 1;
            this.B_Modifier.Text = "Modifier";
            this.B_Modifier.UseVisualStyleBackColor = true;
            this.B_Modifier.Click += new System.EventHandler(this.B_Modifier_Click);
            // 
            // B_Suppr
            // 
            this.B_Suppr.Location = new System.Drawing.Point(197, 70);
            this.B_Suppr.Name = "B_Suppr";
            this.B_Suppr.Size = new System.Drawing.Size(75, 23);
            this.B_Suppr.TabIndex = 2;
            this.B_Suppr.Text = "Suppr.";
            this.B_Suppr.UseVisualStyleBackColor = true;
            this.B_Suppr.Click += new System.EventHandler(this.B_Suppr_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 238);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(398, 14);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(141, 20);
            this.TB_Nom.TabIndex = 4;
            this.TB_Nom.TextChanged += new System.EventHandler(this.TB_Nom_TextChanged);
            // 
            // TB_Coef
            // 
            this.TB_Coef.Location = new System.Drawing.Point(398, 43);
            this.TB_Coef.Name = "TB_Coef";
            this.TB_Coef.Size = new System.Drawing.Size(141, 20);
            this.TB_Coef.TabIndex = 5;
            this.TB_Coef.TextChanged += new System.EventHandler(this.TB_Coef_TextChanged);
            // 
            // TB_IDContact
            // 
            this.TB_IDContact.Location = new System.Drawing.Point(404, 168);
            this.TB_IDContact.Name = "TB_IDContact";
            this.TB_IDContact.Size = new System.Drawing.Size(141, 20);
            this.TB_IDContact.TabIndex = 6;
            this.TB_IDContact.TextChanged += new System.EventHandler(this.TB_IDContact_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // Label_Static_CoefClient
            // 
            this.Label_Static_CoefClient.AutoSize = true;
            this.Label_Static_CoefClient.Location = new System.Drawing.Point(287, 46);
            this.Label_Static_CoefClient.Name = "Label_Static_CoefClient";
            this.Label_Static_CoefClient.Size = new System.Drawing.Size(105, 13);
            this.Label_Static_CoefClient.TabIndex = 8;
            this.Label_Static_CoefClient.Text = "Coefficient de remise";
            // 
            // Label_IDContact
            // 
            this.Label_IDContact.AutoSize = true;
            this.Label_IDContact.Location = new System.Drawing.Point(348, 75);
            this.Label_IDContact.Name = "Label_IDContact";
            this.Label_IDContact.Size = new System.Drawing.Size(44, 13);
            this.Label_IDContact.TabIndex = 9;
            this.Label_IDContact.Text = "Contact";
            // 
            // Label_StaticIDClient
            // 
            this.Label_StaticIDClient.AutoSize = true;
            this.Label_StaticIDClient.Location = new System.Drawing.Point(348, 105);
            this.Label_StaticIDClient.Name = "Label_StaticIDClient";
            this.Label_StaticIDClient.Size = new System.Drawing.Size(47, 13);
            this.Label_StaticIDClient.TabIndex = 10;
            this.Label_StaticIDClient.Text = "ID Client";
            // 
            // Label_IDClient
            // 
            this.Label_IDClient.AutoSize = true;
            this.Label_IDClient.Location = new System.Drawing.Point(401, 105);
            this.Label_IDClient.Name = "Label_IDClient";
            this.Label_IDClient.Size = new System.Drawing.Size(10, 13);
            this.Label_IDClient.TabIndex = 11;
            this.Label_IDClient.Text = "-";
            // 
            // B_Valider
            // 
            this.B_Valider.Location = new System.Drawing.Point(464, 100);
            this.B_Valider.Name = "B_Valider";
            this.B_Valider.Size = new System.Drawing.Size(75, 23);
            this.B_Valider.TabIndex = 12;
            this.B_Valider.Text = "Valider";
            this.B_Valider.UseVisualStyleBackColor = true;
            this.B_Valider.Click += new System.EventHandler(this.B_Valider_Click);
            // 
            // B_Annuler
            // 
            this.B_Annuler.Location = new System.Drawing.Point(197, 100);
            this.B_Annuler.Name = "B_Annuler";
            this.B_Annuler.Size = new System.Drawing.Size(75, 23);
            this.B_Annuler.TabIndex = 13;
            this.B_Annuler.Text = "Annuler";
            this.B_Annuler.UseVisualStyleBackColor = true;
            this.B_Annuler.Click += new System.EventHandler(this.B_Annuler_Click);
            // 
            // CB_ContactClient
            // 
            this.CB_ContactClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ContactClient.FormattingEnabled = true;
            this.CB_ContactClient.Location = new System.Drawing.Point(398, 70);
            this.CB_ContactClient.Name = "CB_ContactClient";
            this.CB_ContactClient.Size = new System.Drawing.Size(144, 21);
            this.CB_ContactClient.TabIndex = 14;
            this.CB_ContactClient.SelectedIndexChanged += new System.EventHandler(this.CB_ContactClient_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.CB_ContactClient);
            this.Controls.Add(this.B_Annuler);
            this.Controls.Add(this.B_Valider);
            this.Controls.Add(this.Label_IDClient);
            this.Controls.Add(this.Label_StaticIDClient);
            this.Controls.Add(this.Label_IDContact);
            this.Controls.Add(this.Label_Static_CoefClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_IDContact);
            this.Controls.Add(this.TB_Coef);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.B_Suppr);
            this.Controls.Add(this.B_Modifier);
            this.Controls.Add(this.B_Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Ajouter;
        private System.Windows.Forms.Button B_Modifier;
        private System.Windows.Forms.Button B_Suppr;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Coef;
        private System.Windows.Forms.TextBox TB_IDContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Static_CoefClient;
        private System.Windows.Forms.Label Label_IDContact;
        private System.Windows.Forms.Label Label_StaticIDClient;
        private System.Windows.Forms.Label Label_IDClient;
        private System.Windows.Forms.Button B_Valider;
        private System.Windows.Forms.Button B_Annuler;
        private System.Windows.Forms.ComboBox CB_ContactClient;
    }
}