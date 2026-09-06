using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AIC_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string connectionString =
        @"Provider=Microsoft.ACE.OLEDB.16.0;
            Data Source=C:\Users\hp\Desktop\AIC Gestion produit\DB AIC.accdb;
            Persist Security Info=False;";
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            //string connectionString =
            //@"Provider=Microsoft.ACE.OLEDB.16.0;
            //Data Source=C:\Users\hp\Desktop\AIC Gestion produit\DB AIC.accdb;
            //Persist Security Info=False;";

            //try
            //{
            //    using (OleDbConnection conn = new OleDbConnection(connectionString))
            //    {
            //        conn.Open();

            //        using (OleDbCommand cmd = new OleDbCommand("SELECT 1", conn))
            //        { 
            //            object result = cmd.ExecuteScalar();

            //            if (Convert.ToInt32(result) == 1)
            //            {
            //                MessageBox.Show("Connexion réussie !");
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erreur : " + ex.Message);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            Form5 FormEmploye= new Form5();
            FormEmploye.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 FormProduit = new Form3();
            FormProduit.Show();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}