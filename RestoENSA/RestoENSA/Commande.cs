using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class Commande : MetroFramework.Forms.MetroForm
    {
        DBConnect db;
        public Commande()
        {

            InitializeComponent();
            db = new DBConnect();
            if (db.conn.State != ConnectionState.Open)
            {
                db.conn.Open();
            }
            db.Fill_Categorie(categorie_box);
            db.Fill_Table(filtre_combobox);
            db.Fill_Table_2(id_table_box);
            db.Fill_Table(facture_box);
            db.Afficher_Cmd(Commande_grid);
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MetroFramework.Controls.MetroTextBox || control is MetroFramework.Controls.MetroComboBox )
                    {
                        control.ResetText();
                    }else if(control is NumericUpDown)
                    {
                        control.Text = "0";
                    }else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Confirmer_Click(object sender, EventArgs e)
        {
            try
            {
                string nom_plat = "";
                int quantite = 0;
                float prix = 0;
                int id_table = 0;

                if (string.IsNullOrWhiteSpace(plat_box.Text)) { throw new Ex("Veuillez selectionner un plat !!"); } else { nom_plat = plat_box.Text; }
                if (quantite_num.Value == 0) { throw new Ex("Veuillez choisir une quantité !!"); } else { quantite = Convert.ToInt32(quantite_num.Value); }
                if (id_table_box.SelectedIndex == -1 || string.IsNullOrWhiteSpace(id_table_box.SelectedItem.ToString())) { throw new Ex("Selectionnez une table !!"); } else { id_table = int.Parse(id_table_box.SelectedItem.ToString()); }


                if (db.check_Existence("Commande", code_cmd_box.Text))
                {
                    MessageBox.Show("La Commande du code " + code_cmd_box.Text + " existe deja \n pour la modifier cliquer sur Modifier !");
                }
                else
                {
                    db.cmd = new SqlCommand("SELECT * FROM Plat where nom_plat = '" + nom_plat + "'", db.conn);
                    SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        prix = dt.Rows[0].Field<float>("prix");
                        db.Ajouter_Cmd(nom_plat, quantite, prix, id_table);
                        MessageBox.Show("Commande bien ajoutée !!", "Succès");
                        db.Afficher_Cmd(Commande_grid);
                    }
                    ClearTextBoxes();
                    db.Fill_Table(filtre_combobox);
                    db.Fill_Table(facture_box);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Modifier_Cmd_Click(object sender, EventArgs e)
        {
            try
            {
                int cmd_Code = 0;
                string nom_plat = "";
                int quantite = 0;
                float prix = 0;
                int id_table = 0;

                if (string.IsNullOrWhiteSpace(code_cmd_box.Text)) { throw new Ex("Veuillez selectionner la commande \n que vous voulez modifier !!"); } else { cmd_Code = int.Parse(code_cmd_box.Text); }
                if (string.IsNullOrWhiteSpace(plat_box.Text)) { throw new Ex("Veuillez selectionner un plat !!"); } else { nom_plat = plat_box.Text; }
                if (quantite_num.Value == 0) { throw new Ex("Veuillez choisir une quantité !!"); } else { quantite = Convert.ToInt32(quantite_num.Value); }
                if (id_table_box.SelectedIndex == -1|| string.IsNullOrWhiteSpace(id_table_box.SelectedItem.ToString()) ) { throw new Ex("Selectionnez une table !!"); } else { id_table = int.Parse(id_table_box.SelectedItem.ToString()); }

                db.cmd = new SqlCommand("SELECT * FROM Plat where nom_plat = '" + nom_plat + "'", db.conn);
                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    prix = dt.Rows[0].Field<float>("prix");
                    db.Modifier_Cmd(cmd_Code, nom_plat, quantite, prix, id_table);
                    MessageBox.Show("Commande bien modifiée !!", "Succès");
                    db.Afficher_Cmd(Commande_grid);
                }

                ClearTextBoxes();
            }
            catch (Exception ex)
            {

            }
        }

        private void categorie_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_categorie = categorie_box.SelectedItem.ToString();
            db.cmd = new SqlCommand("SELECT * FROM Categorie where nom_categorie = '" + nom_categorie + "'", db.conn);
            SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                db.Fill_Plat_ParCategorie(plat_box, dt.Rows[0].Field<int>("id_categorie"));
            }
        }

        private void filtre_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_table = filtre_combobox.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(id_table))
            {
                db.Afficher_Cmd(Commande_grid);
            }
            else
            {
                int table = int.Parse(id_table);
                db.Afficher_Cmd_ParFiltre(Commande_grid, table);
            }
        }

        private void Commande_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db.Fill_Plat(plat_box);
            Commande_grid.CurrentRow.Selected = true;
            code_cmd_box.Text = Commande_grid.Rows[e.RowIndex].Cells["id_commande"].FormattedValue.ToString();
            categorie_box.SelectedItem = "";
            quantite_num.Value = Convert.ToInt32(Commande_grid.Rows[e.RowIndex].Cells["quantite"].FormattedValue.ToString());
            plat_box.SelectedItem = Commande_grid.Rows[e.RowIndex].Cells["nom_plat"].FormattedValue.ToString();
            id_table_box.SelectedItem = Commande_grid.Rows[e.RowIndex].Cells["id_table"].FormattedValue.ToString();
        }


        private void Vider_Champs(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Supprimer_Cmd_Button(object sender, EventArgs e)
        {
            string code = code_cmd_box.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Selectionnez une commande d'abord!","Erreur");
            }
            else
            {
                string message = "Voulez vous vraiment supprimer cette Commande?";
                db.cmd = new SqlCommand("SELECT * FROM Commande where id_commande = '" + code + "'", db.conn);
                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0 && dt.Rows[0].Field<string>("facture").Equals("Non facturé"))
                {
                    message = "Cette commande n'est pas facturé! Supprimer quand meme ?";
                }

                if (MessageBox.Show(message, "Supprimer commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = int.Parse(code);
                    db.Supprimer_Cmd(id);
                    db.Afficher_Cmd(Commande_grid);
                    MessageBox.Show("Commande bien supprimée !!","Succès");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Commande non Supprimée !", "Annulation");
                }
            }
        }

        private void facture_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_table = facture_box.SelectedItem.ToString();
            double total = 0;
            db.cmd = new SqlCommand("SELECT * FROM Commande where id_table = '" + id_table + "' and facture = 'Non facturé'", db.conn);
            SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    total += row.Field<double>("prix");
                }
            }
            total_txt.Text = total.ToString();
        }

        private void generer_facture_tile_Click(object sender, EventArgs e)
        {
            try
            {
                total_txt.Text = "";
                if (facture_box.SelectedIndex == -1 || string.IsNullOrWhiteSpace(facture_box.SelectedItem.ToString()))
                {
                    throw new Ex("Veuillez selectionner une table !!");
                }

                if (MessageBox.Show("Voulez-vous générer la facture pour cette table?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id_table = Convert.ToInt32(facture_box.SelectedItem);
                    db.cmd = new SqlCommand("SELECT * FROM Commande where id_table = '" + id_table + "' and facture = 'Non facturé'", db.conn);
                    SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        new Report(id_table).Show();
                        db.cmd = new SqlCommand("Update Commande set facture = 'Facturé' where id_table = '" + id_table + "'", db.conn);
                        db.cmd.ExecuteNonQuery();
                        db.Afficher_Cmd(Commande_grid);
                    }
                    else
                    {
                        MessageBox.Show("Aucune commande non facturée trouvée !!", "Information");
                    }
                }
            }catch(Exception ex)
            {

            }
        }

        private void Commande_Load(object sender, EventArgs e)
        {

        }

        public Form RefToModeServeur { get; set; }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeServeur.Show();
        }
    }
}
