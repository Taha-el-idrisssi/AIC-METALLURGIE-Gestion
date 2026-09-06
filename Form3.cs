using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // <--- À AJOUTER EN HAUT DU FICHIER


namespace AIC_App
{ 
    public partial class Form3 : Form
    {
        private string connectionString;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            string Query = "select * from Produit " +
                " order by IdProduit";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(Query, conn))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DgvProduit.DataSource = ds.Tables[0];
                    if (DgvProduit.Columns["IdProduit"] != null)
                    {
                        DgvProduit.Columns["IdProduit"].Visible = false;
                    }
                }
            }
            DgvProduit.ClearSelection();
            DgvProduit.CurrentCell = null;
            MettreAJourEtatBoutons();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // 1. Définir le symbole loupe Unicode
            buttonRecherche.Text = "\uE71E";
            buttonRecherche.Font = new Font("Segoe MDL2 Assets", 11F, FontStyle.Regular);// 3. Style optionnel pour un visuel moderne (UITheme)
            buttonRecherche.FlatAppearance.BorderSize = 0;

            DgvProduit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProduit.MultiSelect = false;

            // Attacher les événements pour la gestion de sélection et du double-clic
            DgvProduit.SelectionChanged += DgvProduit_SelectionChanged;
            DgvProduit.CellDoubleClick += DgvProduit_CellDoubleClick;

            if (comboBoxRecherche.Items.Count > 0)
            {
                comboBoxRecherche.SelectedIndex = 0;
            }
            loadDATA();
        }
        // 3. Gestion de l'activation des boutons Modifier et Supprimer
        private void DgvProduit_SelectionChanged(object sender, EventArgs e)
        {
            MettreAJourEtatBoutons();
        }

        public void MettreAJourEtatBoutons()
        {
            bool ligneSelectionnee = DgvProduit.SelectedRows.Count > 0;

            buttonAjouter.Enabled = true; // Toujours activé
            buttonModifier.Enabled = ligneSelectionnee; // Activé uniquement si une ligne est sélectionnée
            buttonSupprimer.Enabled = ligneSelectionnee; // Activé uniquement si une ligne est sélectionnée
        }

        // 4. Double-clic sur une ligne pour lancer la modification
        private void DgvProduit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // S'assurer qu'on a cliqué sur une ligne valide
            {
                buttonModifier_Click_1(sender, e);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                string Query = "insert into Produit ([NomProduit], [Categorie], [Etat], [Lieu])  values (@NomProduit,@Categorie,@Etat,@Lieu)";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomProduit", form4.NomProduit);
                        cmd.Parameters.AddWithValue("@Categorie", form4.Categorie);
                        cmd.Parameters.AddWithValue("@Etat", form4.Etat);
                        cmd.Parameters.AddWithValue("@Lieu", form4.Lieu);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                loadDATA();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // 1. Vérifier qu'une ligne est bien sélectionnée dans le DataGridView
            if (DgvProduit.CurrentRow != null && DgvProduit.CurrentRow.Cells["IdProduit"].Value != DBNull.Value)
            {

                int idProduit = Convert.ToInt32(DgvProduit.CurrentRow.Cells["IdProduit"].Value);
                string NomProduit = DgvProduit.CurrentRow.Cells["NomProduit"].Value.ToString();

                // 2. Afficher la boîte de dialogue de confirmation (MessageBox)
                DialogResult result = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer {NomProduit} ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // 3. Si l'utilisateur clique sur "Oui"
                if (result == DialogResult.Yes)
                {
                    // Chaîne de connexion à votre base Access
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\AIC Gestion produit\DB AIC.accdb;";

                    // Requête SQL DELETE paramétrée
                    string query = "DELETE FROM Produit WHERE IdProduit = @IdProduit";

                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                // Transmission de l'ID en paramètre pour éviter les injections SQL
                                cmd.Parameters.AddWithValue("@idProduit", idProduit);

                                // Exécution de la commande SQL dans la base
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Le produit a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // 4. Rafraîchir le DataGridView pour faire disparaître la ligne
                                    //ChargerDonnees();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Message si aucune ligne n'a été sélectionnée
                MessageBox.Show("Veuillez sélectionner un produit dans le tableau avant de cliquer sur Supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDATA();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltre();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifier_Click_1(object sender, EventArgs e)
        {
            if (DgvProduit.CurrentRow == null || DgvProduit.CurrentRow.Index < 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit a modifier de la liste.",
                    "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = DgvProduit.CurrentRow;
            var IdProduit = row.Cells["IdProduit"].Value;
            Form4 form4 = new Form4();
            form4.NomProduit = row.Cells["NomProduit"].Value?.ToString();
            form4.Categorie = row.Cells["Categorie"].Value?.ToString();
            form4.Etat = row.Cells["Etat"].Value?.ToString();
            form4.Lieu = row.Cells["Lieu"].Value?.ToString();
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                string query = "update Produit SET [NomProduit]=@NomProduit,[Categorie]=@Categorie, [Etat] = @Etat, [Lieu] = @Lieu where IdProduit =@ID";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomProduit", form4.NomProduit);
                        cmd.Parameters.AddWithValue("@Categorie", form4.Categorie);
                        cmd.Parameters.AddWithValue("@Etat", form4.Etat);
                        cmd.Parameters.AddWithValue("@Lieu", form4.Lieu);
                        cmd.Parameters.AddWithValue("@ID", IdProduit);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
                loadDATA();
            }
        }

        private void maskedTextBoxRecherche_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxRecherche_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            DgvProduit.ClearSelection();
            DgvProduit.CurrentCell = null;
        }
        private void AppliquerFiltre()
        {
            if (DgvProduit.DataSource is DataTable dt)
            {
                string critere = comboBoxRecherche.SelectedItem?.ToString();
                string recherche = maskedTextBoxRecherche.Text.Trim().Replace("'", "''");

                if (string.IsNullOrEmpty(recherche))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    string filtreSQL = "";
                    switch (critere)
                    {
                        case "NomProduit":
                            filtreSQL = $"[nomProduit] LIKE '%{recherche}%'";
                            break;
                        case "Categorie":
                            filtreSQL = $"[Categorie] LIKE '%{recherche}%'";
                            break;
                        case "Etat":
                            filtreSQL = $"[Etat] LIKE '%{recherche}%'";
                            break;
                        case "Lieu":
                            filtreSQL = $"[Lieu] LIKE '%{recherche}%'";
                            break;
                        default:
                            filtreSQL = $"[nomProduit] LIKE '%{recherche}%' OR [Categorie] LIKE '%{recherche}%' OR [Etat] LIKE '%{recherche}%' OR [Lieu] LIKE '%{recherche}%'";
                            break;
                    }

                    dt.DefaultView.RowFilter = filtreSQL;
                }

                // --- AJOUTS : Annuler la sélection automatique ---
                DgvProduit.ClearSelection();
                DgvProduit.CurrentCell = null;
                MettreAJourEtatBoutons(); // Met à jour l'état des boutons Modifier/Supprimer
            }
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            AppliquerFiltre();
        }

        private void maskedTextBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltre();
        }

        private void maskedTextBoxRecherche_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void buttonExel_Click(object sender, EventArgs e)


        {
            if (DgvProduit.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Export_Produits.csv");

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath, false, System.Text.Encoding.UTF8))
                {
                    // 1. En-têtes des colonnes visibles (séparateur point-virgule pour Excel en français)
                    var headers = DgvProduit.Columns.Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .Select(c => $"\"{c.HeaderText.Replace("\"", "\"\"")}\"");

                    writer.WriteLine(string.Join(";", headers));

                    // 2. Lignes de données
                    foreach (DataGridViewRow row in DgvProduit.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var cells = DgvProduit.Columns.Cast<DataGridViewColumn>()
                                .Where(c => c.Visible)
                                .Select(c => $"\"{row.Cells[c.Index].Value?.ToString().Replace("\"", "\"\"")}\"");

                            writer.WriteLine(string.Join(";", cells));
                        }
                    }
                }

                // 3. Ouvrir le fichier généré directement dans Excel
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
