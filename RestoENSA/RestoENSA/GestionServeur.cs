using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class GestionServeur : MetroForm
    {
        public string connectionString = DBConnect.connectionString;
        CryptographyProcessor cp = new CryptographyProcessor();

        public GestionServeur()
        {
            InitializeComponent();
        }

        private void GestionServeur_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "" || login_txt.Text == "" || mdp_txt.Text == "" || confirmer_mdb_txt.Text == "")
                MessageBox.Show("Veuillez remplire tout le(s) champ(s) !!","Erreur");
          
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    if (mdp_txt.Text.Equals(confirmer_mdb_txt.Text))
                    {
                        string salt = cp.CreateSalt(15);
                        string passwordHash = cp.GenerateHash(mdp_txt.Text, salt);
                        SqlCommand command = new SqlCommand("Insert into Serveur (nom_serveur,login,mdp,salt) values ('" +
                            nom_txt.Text + "','" + login_txt.Text + "','" + passwordHash + "','" + salt + "')", connexion);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Serveur bien ajouté !", "Succès");
                        disp_data();
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe ne matche pas sa confirmation !", "Erreur");
                    }
                }
                vider_btn_Click(sender, e);
            }
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            id_txt.Text = "";
            nom_txt.Text = "";
            login_txt.Text = "";
            mdp_txt.Text = "";
            confirmer_mdb_txt.Text = "";
        }

        public Form RefToModeAdmin { get; set; }


        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeAdmin.Show();
        }

        public void disp_data()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("Select id_serveur,nom_serveur,login from serveur", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                serveur_grid.DataSource = dt;
            }
        }

        private void Modif_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un serveur !!","Erreur");
            }
            else if (nom_txt.Text == "" || login_txt.Text == "" || mdp_txt.Text == "" || confirmer_mdb_txt.Text == "")
                MessageBox.Show("Veuillez remplire tout le(s) champ(s) !!", "Erreur");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();

                    if (mdp_txt.Text.Equals(confirmer_mdb_txt.Text))
                    {

                        string salt = cp.CreateSalt(15);
                        string passwordHash = cp.GenerateHash(mdp_txt.Text, salt);

                        SqlCommand command = new SqlCommand("UPDATE Serveur SET nom_serveur = @nom, login = @login, mdp = @mdp,salt = @salt   WHERE id_serveur = @id", connexion);
                        command.Parameters.AddWithValue("@nom", nom_txt.Text);
                        command.Parameters.AddWithValue("@login", login_txt.Text);
                        command.Parameters.AddWithValue("@mdp", passwordHash);
                        command.Parameters.AddWithValue("@salt", salt);

                        command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));
                        command.ExecuteNonQuery();

                        MessageBox.Show("Serveur modifié avec succès!", "Succès");
                        disp_data();
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe ne matche pas sa confirmation !", "Erreur");
                    }
                }
                vider_btn_Click(sender, e);
            }
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un serveur !!", "Erreur");
            }
            else
            {
                if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce serveur ?", "Supprimer serveur", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connexion = new SqlConnection(connectionString))
                    {
                        connexion.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Serveur WHERE id_serveur = '" + id_txt.Text + "'", connexion);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Serveur supprimé avec succès!","Succès");
                        disp_data();
                    }
                }
                vider_btn_Click(sender, e);
            }


        }

        private void serveur_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serveur_grid.CurrentRow.Selected = true;
            id_txt.Text = serveur_grid.Rows[e.RowIndex].Cells["id_serveur"].FormattedValue.ToString();
            nom_txt.Text = serveur_grid.Rows[e.RowIndex].Cells["nom_serveur"].FormattedValue.ToString();
            login_txt.Text = serveur_grid.Rows[e.RowIndex].Cells["login"].FormattedValue.ToString();
        }
    }
}
