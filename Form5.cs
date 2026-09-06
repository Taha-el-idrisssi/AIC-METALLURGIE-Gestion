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
using System.IO; // <--- À AJOUTER EN HAUT DU FICHIER

namespace AIC_App
{
    public partial class Form5 : Form
    {
        // 1. Déclarer la variable au niveau de la classe
        private string connectionString;

        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // 2. Charger la chaîne de connexion au démarrage du formulaire
            ChargerConnectionString();
        }


        //   string connectionString =
        //@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\AIC Gestion produit\DB AIC.accdb;";

        private void ChargerConnectionString()
        {
            string configFilePath = Path.Combine(Application.StartupPath, "config.txt");

            // 1. Lecture du contenu et suppression des espaces inutiles / retours à la ligne
            string dbPath = File.ReadAllText(configFilePath).Trim();

            // 2. Vérification si le fichier est vide
            if (string.IsNullOrWhiteSpace(dbPath))
            {
                MessageBox.Show("Le fichier config.txt est vide. Veuillez y inscrire le chemin de la base de données.",
                                "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Vérification si le chemin de la base Access existe réellement sur le PC
            if (!File.Exists(dbPath))
            {
                MessageBox.Show($"Le fichier de base de données est introuvable au chemin indiqué :\n{dbPath}",
                                "Fichier BDD Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
        }

        public void loadDATA()
        {
            string Query = "select * from Employe " +
                " order by IdEmploye";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(Query, conn))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    // 1. Masquer la colonne IdEmploye
                    if (dataGridView1.Columns["IdEmploye"] != null)
                    {
                        dataGridView1.Columns["IdEmploye"].Visible = false;
                    }
                }
            }
            dataGridView1.ClearSelection();
            // Mettre à jour l'état des boutons après le chargement
            //MettreAJourEtatBoutons();
            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null; // <-- LIGNE À AJOUTER
            //MettreAJourEtatBoutons();
            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null;

        }

        private void DgvEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {// 1. Définir le symbole loupe Unicode
            buttonRecherche.Text = "\uE71E";
            buttonRecherche.Font = new Font("Segoe MDL2 Assets", 11F, FontStyle.Regular);// 3. Style optionnel pour un visuel moderne (UITheme)
            buttonRecherche.FlatStyle = FlatStyle.Flat;
            buttonRecherche.FlatAppearance.BorderSize = 0;

            // 1. Configurer la sélection de la ligne entière
            dataGridView1.MultiSelect = false;

            // 2. Sélectionner toute la ligne au click
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Attacher les événements pour la sélection et le double-click
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            if (comboBoxRecherche.Items.Count>0)
            {
                comboBoxRecherche.SelectedIndex = 0;
            }

            loadDATA();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MettreAJourEtatBoutons();
        }
        private void MettreAJourEtatBoutons()
        {
            bool ligneSelectionnee = dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0;

            buttonAjouter.Enabled = true; // Toujours activé
            buttonModifier.Enabled = ligneSelectionnee; // Activé uniquement si une ligne est sélectionnée
            buttonSupprimer.Enabled = ligneSelectionnee; // Activé uniquement si une ligne est sélectionnée
        }

        // 4. Double-clic sur une ligne pour lancer la modification
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // S'assurer qu'on a cliqué sur une ligne valide (pas sur l'en-tête)
            {
                buttonModifier_Click(sender, e);
            }
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            if(form2.ShowDialog(this)==DialogResult.OK)
            {
                string Query = "insert into Employe (nom, prenom, Service, Lieu)  values (@Nom,@Prenom,@Sérvice,@Lieu)";
                using(OleDbConnection conn=new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(Query,conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom",form2.Nom);
                        cmd.Parameters.AddWithValue("@Prenom", form2.Prenom);
                        cmd.Parameters.AddWithValue("@Service", form2.Service);
                        cmd.Parameters.AddWithValue("@Lieu", form2.Lieu);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                loadDATA();
            }

              
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null|| dataGridView1.CurrentRow.Index<0)
            {
                MessageBox.Show("Veuillez sélectionner un employé a modifier de la liste.",
                    "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            var IdEmploye = row.Cells["IdEmploye"].Value;
            Form2  form2 = new Form2();
            form2.Nom = row.Cells["Nom"].Value?.ToString();
            form2.Prenom = row.Cells["Prenom"].Value?.ToString();
            form2.Service = row.Cells["Service"].Value?.ToString();
            form2.Lieu = row.Cells["Lieu"].Value?.ToString();
            if(form2.ShowDialog(this)==DialogResult.OK)
            {
                string query = "update Employe SET Nom=@Nom,Prenom=@Prenom, Service = @Service, Lieu = @Lieu where IdEmploye =@ID";
                using(OleDbConnection conn =new OleDbConnection(connectionString))
                {
                    using(OleDbCommand cmd =new OleDbCommand (query,conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", form2.Nom);
                        cmd.Parameters.AddWithValue("@Prenom", form2.Prenom);
                        cmd.Parameters.AddWithValue("@Service", form2.Service);
                        cmd.Parameters.AddWithValue("@Lieu", form2.Lieu);
                        cmd.Parameters.AddWithValue("@ID", IdEmploye);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
                loadDATA();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow==null||dataGridView1.CurrentRow.Index<0)
            {
                MessageBox.Show("Veillez sélectionner un employé a supprimer",
                    "Attention", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            var IdEmploye = row.Cells["IdEmploye"].Value;
            string Nom = row.Cells["Nom"].Value?.ToString();
            string Prenom = row.Cells["Prenom"].Value?.ToString();
            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'employé {Nom} {Prenom} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string query = "delete from employe where IdEmploye=@ID";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query,conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", IdEmploye);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
                loadDATA();
                MessageBox.Show("L'employé a été supprimé avec succès.", "Succès",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        //public void maskedtextboxrecherche_textchanged(object sender, MaskInputRejectedEventArgs e)
        //{
        //    AppliquerFiltre();
        //}
        private void maskedTextBoxRecherche_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                 //maskedtextboxrecherche_textchanged(sender, e);

        }

        private void comboBoxRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AppliquerFiltre();
        }
        private void AppliquerFiltre()
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                string critere = comboBoxRecherche.SelectedItem?.ToString();
                string recherche = maskedTextBoxRecherche.Text.Trim().Replace("'", "''");

                if (string.IsNullOrEmpty(recherche))
                {
                    dt.DefaultView.RowFilter = "";
                    return;
                }

                string filtreSQL = "";
                switch (critere)
                {
                    case "Nom ou prenom":
                        filtreSQL = $"[nom] LIKE '%{recherche}%' OR [prenom] LIKE '%{recherche}%' ";
                        break;
                    //case "Prénom":
                    //case "Prenom":
                    //    filtreSQL = $"[prenom] LIKE '%{recherche}%'";
                    //    break;
                    case "Service":
                        filtreSQL = $"[Service] LIKE '%{recherche}%'";
                        break;
                    case "Lieu":
                        filtreSQL = $"[Lieu] LIKE '%{recherche}%'";
                        break;
                    default:
                        filtreSQL = $"[nom] LIKE '%{recherche}%' OR [prenom] LIKE '%{recherche}%' OR [Service] LIKE '%{recherche}%' OR [Lieu] LIKE '%{recherche}%'";
                        break;
                }

                dt.DefaultView.RowFilter = filtreSQL;
            }
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            MettreAJourEtatBoutons();
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            AppliquerFiltre();
        }

        private void maskedTextBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltre();
        }

        private void buttonExel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Export_Produits.csv");

                // Utilisation de UTF8Encoding(true) pour écrire le BOM (support parfait des accents dans Excel)
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath, false, new System.Text.UTF8Encoding(true)))
                {
                    // Indique explicitement à Excel d'utiliser le point-virgule comme séparateur de colonnes
                    writer.WriteLine("sep=;");

                    // 1. En-têtes des colonnes visibles
                    var headers = dataGridView1.Columns.Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .Select(c => $"\"{c.HeaderText.Replace("\"", "\"\"")}\"");

                    writer.WriteLine(string.Join(";", headers));

                    // 2. Lignes de données
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var cells = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                .Where(c => c.Visible)
                                .Select(c => $"\"{row.Cells[c.Index].Value?.ToString().Replace("\"", "\"\"")}\"");

                            writer.WriteLine(string.Join(";", cells));
                        }
                    }
                }

                // 3. Ouvrir le fichier généré dans l'application par défaut (Excel)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
