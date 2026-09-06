using System;

namespace AIC_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSupprimer.Location = new System.Drawing.Point(221, 111);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(253, 43);
            this.buttonSupprimer.TabIndex = 23;
            this.buttonSupprimer.Text = "LISTES DES EMPLOYÉES";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(221, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "LISTES DES PRODUITS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFermer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonFermer.Location = new System.Drawing.Point(607, 350);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(96, 39);
            this.buttonFermer.TabIndex = 25;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = false;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(715, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSupprimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AIC GESTION - MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private readonly EventHandler Form1_Load;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label label1;
    }
}

