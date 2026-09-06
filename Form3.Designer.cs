namespace AIC_App
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DgvProduit = new System.Windows.Forms.DataGridView();
            this.labelTitre = new System.Windows.Forms.Label();
            this.comboBoxRecherche = new System.Windows.Forms.ComboBox();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.LabelRecherche = new System.Windows.Forms.Label();
            this.panelRecherche = new System.Windows.Forms.Panel();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.maskedTextBoxRecherche = new System.Windows.Forms.MaskedTextBox();
            this.buttonExel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduit)).BeginInit();
            this.panelRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProduit
            // 
            this.DgvProduit.AllowUserToOrderColumns = true;
            this.DgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProduit.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DgvProduit.ColumnHeadersHeight = 29;
            this.DgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvProduit.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvProduit.Location = new System.Drawing.Point(12, 147);
            this.DgvProduit.Name = "DgvProduit";
            this.DgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvProduit.RowTemplate.Height = 24;
            this.DgvProduit.Size = new System.Drawing.Size(861, 309);
            this.DgvProduit.TabIndex = 0;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(366, 20);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(148, 16);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "LISTE DES PRODUITS";
            // 
            // comboBoxRecherche
            // 
            this.comboBoxRecherche.FormattingEnabled = true;
            this.comboBoxRecherche.Items.AddRange(new object[] {
            "NomProduit",
            "Etat",
            "Catégorie",
            "Lieu"});
            this.comboBoxRecherche.Location = new System.Drawing.Point(114, 16);
            this.comboBoxRecherche.Name = "comboBoxRecherche";
            this.comboBoxRecherche.Size = new System.Drawing.Size(129, 24);
            this.comboBoxRecherche.TabIndex = 4;
            this.comboBoxRecherche.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecherche_SelectedIndexChanged);
            // 
            // buttonFermer
            // 
            this.buttonFermer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFermer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonFermer.Location = new System.Drawing.Point(787, 463);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(86, 33);
            this.buttonFermer.TabIndex = 7;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = false;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonModifier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonModifier.Location = new System.Drawing.Point(105, 109);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(88, 32);
            this.buttonModifier.TabIndex = 8;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click_1);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouter.Location = new System.Drawing.Point(12, 109);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(88, 32);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSupprimer.Location = new System.Drawing.Point(199, 109);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(88, 32);
            this.buttonSupprimer.TabIndex = 13;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // LabelRecherche
            // 
            this.LabelRecherche.AutoSize = true;
            this.LabelRecherche.BackColor = System.Drawing.SystemColors.Window;
            this.LabelRecherche.Location = new System.Drawing.Point(18, 20);
            this.LabelRecherche.Name = "LabelRecherche";
            this.LabelRecherche.Size = new System.Drawing.Size(83, 16);
            this.LabelRecherche.TabIndex = 14;
            this.LabelRecherche.Text = "Rechercher :";
            // 
            // panelRecherche
            // 
            this.panelRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecherche.Controls.Add(this.buttonRecherche);
            this.panelRecherche.Controls.Add(this.maskedTextBoxRecherche);
            this.panelRecherche.Controls.Add(this.LabelRecherche);
            this.panelRecherche.Controls.Add(this.comboBoxRecherche);
            this.panelRecherche.Location = new System.Drawing.Point(12, 45);
            this.panelRecherche.Name = "panelRecherche";
            this.panelRecherche.Size = new System.Drawing.Size(861, 58);
            this.panelRecherche.TabIndex = 15;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRecherche.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRecherche.Location = new System.Drawing.Point(464, 17);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(28, 24);
            this.buttonRecherche.TabIndex = 27;
            this.buttonRecherche.UseVisualStyleBackColor = false;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // maskedTextBoxRecherche
            // 
            this.maskedTextBoxRecherche.Location = new System.Drawing.Point(249, 17);
            this.maskedTextBoxRecherche.Name = "maskedTextBoxRecherche";
            this.maskedTextBoxRecherche.Size = new System.Drawing.Size(209, 22);
            this.maskedTextBoxRecherche.TabIndex = 15;
            this.maskedTextBoxRecherche.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxRecherche_MaskInputRejected_1);
            this.maskedTextBoxRecherche.TextChanged += new System.EventHandler(this.maskedTextBoxRecherche_TextChanged);
            this.maskedTextBoxRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxRecherche_KeyDown);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonExel.Location = new System.Drawing.Point(704, 109);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(170, 32);
            this.buttonExel.TabIndex = 27;
            this.buttonExel.Text = "Extraire la liste en EXCEL";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(885, 507);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.panelRecherche);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.DgvProduit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "GESTION DES PRODUITS";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduit)).EndInit();
            this.panelRecherche.ResumeLayout(false);
            this.panelRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduit;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.ComboBox comboBoxRecherche;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label LabelRecherche;
        private System.Windows.Forms.Panel panelRecherche;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRecherche;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Button buttonExel;
    }
}