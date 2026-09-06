namespace AIC_App
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.ButtonEnregistrer = new System.Windows.Forms.Button();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.comboBoxLieu = new System.Windows.Forms.ComboBox();
            this.labelLieu = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.textBoxCategorie = new System.Windows.Forms.TextBox();
            this.LabelCategorie = new System.Windows.Forms.Label();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.LabelNomProduit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAnnuler.Location = new System.Drawing.Point(594, 123);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(91, 37);
            this.buttonAnnuler.TabIndex = 23;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // ButtonEnregistrer
            // 
            this.ButtonEnregistrer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonEnregistrer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonEnregistrer.Location = new System.Drawing.Point(594, 60);
            this.ButtonEnregistrer.Name = "ButtonEnregistrer";
            this.ButtonEnregistrer.Size = new System.Drawing.Size(91, 37);
            this.ButtonEnregistrer.TabIndex = 14;
            this.ButtonEnregistrer.Text = "Enregistrer";
            this.ButtonEnregistrer.UseVisualStyleBackColor = false;
            this.ButtonEnregistrer.Click += new System.EventHandler(this.ButtonEnregistrer_Click);
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Items.AddRange(new object[] {
            "Marche",
            "Arret"});
            this.comboBoxEtat.Location = new System.Drawing.Point(170, 138);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(100, 24);
            this.comboBoxEtat.TabIndex = 31;
            // 
            // comboBoxLieu
            // 
            this.comboBoxLieu.FormattingEnabled = true;
            this.comboBoxLieu.Items.AddRange(new object[] {
            "Burreau",
            "Chantier"});
            this.comboBoxLieu.Location = new System.Drawing.Point(441, 136);
            this.comboBoxLieu.Name = "comboBoxLieu";
            this.comboBoxLieu.Size = new System.Drawing.Size(100, 24);
            this.comboBoxLieu.TabIndex = 30;
            // 
            // labelLieu
            // 
            this.labelLieu.AutoSize = true;
            this.labelLieu.BackColor = System.Drawing.SystemColors.Window;
            this.labelLieu.Location = new System.Drawing.Point(352, 141);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(32, 16);
            this.labelLieu.TabIndex = 29;
            this.labelLieu.Text = "Lieu";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.BackColor = System.Drawing.SystemColors.Window;
            this.labelEtat.Location = new System.Drawing.Point(78, 140);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(30, 16);
            this.labelEtat.TabIndex = 28;
            this.labelEtat.Text = "Etat";
            // 
            // textBoxCategorie
            // 
            this.textBoxCategorie.Location = new System.Drawing.Point(441, 60);
            this.textBoxCategorie.Name = "textBoxCategorie";
            this.textBoxCategorie.Size = new System.Drawing.Size(100, 22);
            this.textBoxCategorie.TabIndex = 27;
            // 
            // LabelCategorie
            // 
            this.LabelCategorie.AutoSize = true;
            this.LabelCategorie.BackColor = System.Drawing.SystemColors.Window;
            this.LabelCategorie.Location = new System.Drawing.Point(347, 63);
            this.LabelCategorie.Name = "LabelCategorie";
            this.LabelCategorie.Size = new System.Drawing.Size(66, 16);
            this.LabelCategorie.TabIndex = 26;
            this.LabelCategorie.Text = "Catégorie";
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.Location = new System.Drawing.Point(170, 60);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomProduit.TabIndex = 25;
            // 
            // LabelNomProduit
            // 
            this.LabelNomProduit.AutoSize = true;
            this.LabelNomProduit.BackColor = System.Drawing.SystemColors.Window;
            this.LabelNomProduit.Location = new System.Drawing.Point(63, 63);
            this.LabelNomProduit.Name = "LabelNomProduit";
            this.LabelNomProduit.Size = new System.Drawing.Size(98, 16);
            this.LabelNomProduit.TabIndex = 24;
            this.LabelNomProduit.Text = "Nom du produit";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(738, 221);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.comboBoxLieu);
            this.Controls.Add(this.labelLieu);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.textBoxCategorie);
            this.Controls.Add(this.LabelCategorie);
            this.Controls.Add(this.textBoxNomProduit);
            this.Controls.Add(this.LabelNomProduit);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.ButtonEnregistrer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "✏️  SAISIE D\'UN PRODUIT";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button ButtonEnregistrer;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.ComboBox comboBoxLieu;
        private System.Windows.Forms.Label labelLieu;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.TextBox textBoxCategorie;
        private System.Windows.Forms.Label LabelCategorie;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.Label LabelNomProduit;
    }
}