using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIC_App
{
    public partial class Form2 : Form
    {
        // Propriétés publiques avec getter et setter
        public string Nom
        {
            get => textBoxNom.Text;
            set => textBoxNom.Text = value;
        }

        public string Prenom
        {
            get => textBoxPrenom.Text;
            set => textBoxPrenom.Text = value;
        }

        public string Service
        {
            get => textBoxService.Text;
            set => textBoxService.Text = value;
        }

        public string Lieu
        {
            get => comboBoxLieu.Text;
            set => comboBoxLieu.Text = value;
        }
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string connectionString =
        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\AIC Gestion produit\DB AIC.accdb;";

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(textBoxNom.Text)||
                string.IsNullOrWhiteSpace(textBoxPrenom.Text)||
                string.IsNullOrWhiteSpace(textBoxService.Text)||
                comboBoxLieu.SelectedIndex == -1)
            {
                MessageBox.Show("veillez remplir tous les champs !",
                    "champs manquants", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        //    string connectionString =
        //@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\AIC Gestion produit\DB AIC.accdb;";

            //    try
            //    {
            //        using (OleDbConnection conn = new OleDbConnection(connectionString))
            //        {
            //            conn.Open();

            //            using (OleDbCommand cmd = new OleDbCommand("SELECT 1", conn))
            //            {
            //                object result = cmd.ExecuteScalar();

            //                if (Convert.ToInt32(result) == 1)
            //                {
            //                    MessageBox.Show("Database connection successful!",
            //                        "Success",
            //                        MessageBoxButtons.OK,
            //                        MessageBoxIcon.Information);
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Database connection failed!\n\n" + ex.Message,
            //            "Error",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Error);
            //    }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            //DataTable dt = OleDbEnumerator.GetRootEnumerator();

            //foreach(DataRow row in dt.Rows)
            //{
            //    MessageBox.Show(row["SOURCES_NAME"].ToString());
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
