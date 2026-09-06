using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AIC_App
{
    public partial class Form4 : Form
    {
        // Propriétés publiques avec getter et setter
        public string NomProduit
        {
            get => textBoxNomProduit.Text;
            set => textBoxNomProduit.Text = value;
        }

        public string Etat
        {
            get => comboBoxEtat.Text;
            set => comboBoxEtat.Text = value;
        }

        public string Categorie
        {
            get => textBoxCategorie.Text;
            set => textBoxCategorie.Text = value;
        }

        public string Lieu
        {
            get => comboBoxLieu.Text;
            set => comboBoxLieu.Text = value;
        }
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomProduit.Text) ||
                string.IsNullOrWhiteSpace(textBoxCategorie.Text) ||
                comboBoxEtat.SelectedIndex == -1 ||
                comboBoxLieu.SelectedIndex == -1)
            {
                MessageBox.Show("veillez remplir tous les champs !",
                    "champs manquants", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
