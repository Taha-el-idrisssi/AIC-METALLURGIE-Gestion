namespace AIC_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ButtonEnregistrer = new System.Windows.Forms.Button();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.LabelService = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.labelLieu = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.comboBoxLieu = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonEnregistrer
            // 
            this.ButtonEnregistrer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonEnregistrer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonEnregistrer.Location = new System.Drawing.Point(592, 62);
            this.ButtonEnregistrer.Name = "ButtonEnregistrer";
            this.ButtonEnregistrer.Size = new System.Drawing.Size(91, 37);
            this.ButtonEnregistrer.TabIndex = 1;
            this.ButtonEnregistrer.Text = "Enregistrer";
            this.ButtonEnregistrer.UseVisualStyleBackColor = false;
            this.ButtonEnregistrer.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(416, 62);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(100, 22);
            this.textBoxService.TabIndex = 8;
            // 
            // LabelService
            // 
            this.LabelService.AutoSize = true;
            this.LabelService.BackColor = System.Drawing.SystemColors.Window;
            this.LabelService.Location = new System.Drawing.Point(322, 68);
            this.LabelService.Name = "LabelService";
            this.LabelService.Size = new System.Drawing.Size(53, 16);
            this.LabelService.TabIndex = 7;
            this.LabelService.Text = "Sérvice";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(145, 62);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.BackColor = System.Drawing.SystemColors.Window;
            this.LabelNom.Location = new System.Drawing.Point(52, 68);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(36, 16);
            this.LabelNom.TabIndex = 5;
            this.LabelNom.Text = "Nom";
            // 
            // labelLieu
            // 
            this.labelLieu.AutoSize = true;
            this.labelLieu.BackColor = System.Drawing.SystemColors.Window;
            this.labelLieu.Location = new System.Drawing.Point(327, 146);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(32, 16);
            this.labelLieu.TabIndex = 11;
            this.labelLieu.Text = "Lieu";
            this.labelLieu.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.SystemColors.Window;
            this.labelPrenom.Location = new System.Drawing.Point(51, 146);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(54, 16);
            this.labelPrenom.TabIndex = 9;
            this.labelPrenom.Text = "Prénom";
            // 
            // comboBoxLieu
            // 
            this.comboBoxLieu.FormattingEnabled = true;
            this.comboBoxLieu.Items.AddRange(new object[] {
            "Présentiel",
            "A distance",
            "Hybride"});
            this.comboBoxLieu.Location = new System.Drawing.Point(416, 138);
            this.comboBoxLieu.Name = "comboBoxLieu";
            this.comboBoxLieu.Size = new System.Drawing.Size(100, 24);
            this.comboBoxLieu.TabIndex = 12;
            this.comboBoxLieu.SelectedIndexChanged += new System.EventHandler(this.comboBoxLieu_SelectedIndexChanged);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAnnuler.Location = new System.Drawing.Point(592, 125);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(91, 37);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(145, 140);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenom.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(738, 221);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.comboBoxLieu);
            this.Controls.Add(this.labelLieu);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.LabelService);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.ButtonEnregistrer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "✏️  SAISIE D\'UN EMPLOYÉ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnregistrer;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.Label LabelService;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label labelLieu;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.ComboBox comboBoxLieu;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxPrenom;
    }
}