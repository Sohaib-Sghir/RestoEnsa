using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace RestoENSA
{
    public partial class GestionChefs : MetroForm
    {
        public string connectionString = DBConnect.connectionString;

        public GestionChefs()
        {
            InitializeComponent();
        }

        private void GestionChefs_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "")
                MessageBox.Show("Veuillez remplir le champ vide !!","Erreur");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("Insert into Chef (nom_chef) values ('" + nom_txt.Text + "')", connexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Chef bien ajouté !", "Succès");
                    disp_data();
                }
                vider_btn_Click(sender, e);
            }
        }

        private void modif_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un chef !!","Erreur");
            }else if(nom_txt.Text == "")
                MessageBox.Show("Veuillez remplir le champ vide !!", "Erreur");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE  Chef SET nom_chef = @nom   WHERE id_chef = @id", connexion);
                    command.Parameters.AddWithValue("@nom", nom_txt.Text);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Chef modifié avec succès !","Succès");
                    disp_data();
                }
                vider_btn_Click(sender, e);
            }
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un chef !!","Erreur");
            }
            else
            {
                if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce chef ?", "Supprimer chef", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connexion = new SqlConnection(connectionString))
                    {
                        connexion.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Chef WHERE id_chef = '" + id_txt.Text + "'", connexion);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Chef supprimé avec succès !","Succès");
                        disp_data();

                    }
                }
                vider_btn_Click(sender, e);
            }
        }

        public void disp_data()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("select id_chef as code_chef,nom_chef from chef", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                chef_grid.DataSource = dt;
            }
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            nom_txt.Text = "";
        }

        private void chef_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chef_grid.CurrentRow.Selected = true;
            nom_txt.Text = chef_grid.Rows[e.RowIndex].Cells["nom_chef"].FormattedValue.ToString();
            id_txt.Text = chef_grid.Rows[e.RowIndex].Cells["code_chef"].FormattedValue.ToString();
        }

        public Form RefToModeAdmin { get; set; }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeAdmin.Show();
        }
    }
}
