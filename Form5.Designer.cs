namespace AIC_App
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.LabelvRecherche = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.maskedTextBoxRecherche = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRecherche = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelvRecherche
            // 
            this.LabelvRecherche.AutoSize = true;
            this.LabelvRecherche.BackColor = System.Drawing.SystemColors.Window;
            this.LabelvRecherche.Location = new System.Drawing.Point(17, 69);
            this.LabelvRecherche.Name = "LabelvRecherche";
            this.LabelvRecherche.Size = new System.Drawing.Size(86, 16);
            this.LabelvRecherche.TabIndex = 23;
            this.LabelvRecherche.Text = "Rechercher...";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSupprimer.Location = new System.Drawing.Point(211, 113);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(87, 32);
            this.buttonSupprimer.TabIndex = 22;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouter.Location = new System.Drawing.Point(11, 113);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(87, 32);
            this.buttonAjouter.TabIndex = 21;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonModifier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonModifier.Location = new System.Drawing.Point(111, 113);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(87, 32);
            this.buttonModifier.TabIndex = 20;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFermer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonFermer.Location = new System.Drawing.Point(782, 462);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(90, 33);
            this.buttonFermer.TabIndex = 19;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = false;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Catégorie du produit",
            "Nom du produit",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(266, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(113, 66);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 22);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(358, 19);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(160, 16);
            this.labelTitre.TabIndex = 16;
            this.labelTitre.Text = "LISTE DES EMPLOYÉES";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonRecherche);
            this.panel1.Controls.Add(this.maskedTextBoxRecherche);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxRecherche);
            this.panel1.Location = new System.Drawing.Point(11, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 58);
            this.panel1.TabIndex = 24;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRecherche.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRecherche.Location = new System.Drawing.Point(478, 16);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(28, 25);
            this.buttonRecherche.TabIndex = 26;
            this.buttonRecherche.UseVisualStyleBackColor = false;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // maskedTextBoxRecherche
            // 
            this.maskedTextBoxRecherche.Location = new System.Drawing.Point(263, 16);
            this.maskedTextBoxRecherche.Name = "maskedTextBoxRecherche";
            this.maskedTextBoxRecherche.Size = new System.Drawing.Size(209, 22);
            this.maskedTextBoxRecherche.TabIndex = 15;
            this.maskedTextBoxRecherche.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.maskedTextBoxRecherche.TextChanged += new System.EventHandler(this.maskedTextBoxRecherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rechercher :";
            // 
            // comboBoxRecherche
            // 
            this.comboBoxRecherche.FormattingEnabled = true;
            this.comboBoxRecherche.Items.AddRange(new object[] {
            "Nom ou Prénom",
            "Sérvice",
            "Lieu"});
            this.comboBoxRecherche.Location = new System.Drawing.Point(114, 16);
            this.comboBoxRecherche.Name = "comboBoxRecherche";
            this.comboBoxRecherche.Size = new System.Drawing.Size(129, 24);
            this.comboBoxRecherche.TabIndex = 4;
            this.comboBoxRecherche.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecherche_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 305);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonExel.Location = new System.Drawing.Point(702, 113);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(170, 32);
            this.buttonExel.TabIndex = 26;
            this.buttonExel.Text = "Extraire la liste en EXCEL";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelvRecherche);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "GESTION DES EMPLOYÉS";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelvRecherche;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRecherche;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRecherche;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Button buttonExel;
    }
}