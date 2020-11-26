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
    public partial class GestionHoraires : MetroForm
    {
        DBConnect db;
        public string connectionString = DBConnect.connectionString;
        public GestionHoraires()
        {
            InitializeComponent();
            db = new DBConnect();
            disp_data();
            chefComboBox();
            serveurComboBox();
            debut_time.Value = DateTime.Now;
            fin_time.Value = debut_time.Value.AddDays(7);
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
                        numero_txt.Value = 0;
                        debut_time.Value = DateTime.Now;
                        fin_time.Value = debut_time.Value.AddDays(7);
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            if (debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "")
            {
                MessageBox.Show("Veuillez remplire le(s) champ(s) vide(s) !!","Erreur");

            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("Insert into Calendrier (numero_semaine,horaire_shift1,horaire_shift2,debut_semaine,fin_semaine)  values (@numero,@shift1,@shift2,@debut,@fin)", connexion);
                    command.Parameters.AddWithValue("@numero", numero_txt.Text);
                    command.Parameters.AddWithValue("@shift1", shift1_comboBox.Text);
                    command.Parameters.AddWithValue("@shift2", shift2_comboBox.Text);
                    command.Parameters.AddWithValue("@debut", SqlDbType.Date).Value = debut_time.Value.Date;
                    command.Parameters.AddWithValue("@fin", SqlDbType.Date).Value = fin_time.Value.Date;

                    command.ExecuteNonQuery();
                    MessageBox.Show("Calendrier bien ajouté !", "Succès");
                    command.Parameters.Clear();
                    disp_data();
                }
                ClearTextBoxes();
            }

        }

        public void disp_data()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("select id_calendrier,numero_semaine,debut_semaine,fin_semaine,horaire_shift1,horaire_shift2 from Calendrier", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                Horaire_grid.DataSource = dt;
                Horaire_grid.Columns["id_calendrier"].Visible = false;
            }
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        

        private void modif_btn_Click(object sender, EventArgs e)
        {
            if (id_calendrier_txt.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un calendrier !!", "Erreur");
            }
            else if (numero_txt.Value == 0 || debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "")
            {
                MessageBox.Show("Veuillez remplire le(s) champ(s) vide(s) !!", "Erreur");
            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE Calendrier SET numero_semaine=@numero, horaire_shift1=@shift1, horaire_shift2=@shift2, debut_semaine=@debut, fin_semaine=@fin WHERE id_calendrier=@id", connexion);
                    command.Parameters.AddWithValue("@numero", numero_txt.Value);
                    command.Parameters.AddWithValue("@shift1", shift1_comboBox.Text);
                    command.Parameters.AddWithValue("@shift2", shift2_comboBox.Text);
                    command.Parameters.AddWithValue("@debut", SqlDbType.Date).Value = debut_time.Value.Date;
                    command.Parameters.AddWithValue("@fin", SqlDbType.Date).Value = fin_time.Value.Date;
                    command.Parameters.AddWithValue("@id", numero_txt.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Calendrier modifié avec succès !!", "Succès");
                    disp_data();
                }
                ClearTextBoxes();
            }
        }

        private void Horaire_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Horaire_grid.CurrentRow.Selected = true;
            id_calendrier_txt.Text = Horaire_grid.Rows[e.RowIndex].Cells["id_calendrier"].FormattedValue.ToString();
            numero_txt.Value = Convert.ToInt32(Horaire_grid.Rows[e.RowIndex].Cells["numero_semaine"].FormattedValue);
            debut_time.Text = Horaire_grid.Rows[e.RowIndex].Cells["debut_semaine"].FormattedValue.ToString();
            fin_time.Text = Horaire_grid.Rows[e.RowIndex].Cells["fin_semaine"].FormattedValue.ToString();
            shift1_comboBox.Text = Horaire_grid.Rows[e.RowIndex].Cells["horaire_shift1"].FormattedValue.ToString();
            shift2_comboBox.Text = Horaire_grid.Rows[e.RowIndex].Cells["horaire_shift2"].FormattedValue.ToString();
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (id_calendrier_txt.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un calendrier !!", "Erreur");
            }
            else if (numero_txt.Value == 0 || debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "")
            {
                MessageBox.Show("Veuillez remplire le(s) champ(s) vide(s) !!", "Erreur");
            }
            else
            {
                if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce calendrier ?", "Supprimer calendrier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connexion = new SqlConnection(connectionString))
                    {
                        connexion.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Calendrier WHERE id_calendrier=@id", connexion);
                        SqlCommand command2 = new SqlCommand("Update Chef SET id_calendrier=null WHERE id_calendrier=@id", connexion);
                        SqlCommand command3 = new SqlCommand("Update Serveur SET id_calendrier=null WHERE id_calendrier=@id", connexion);

                        command.Parameters.AddWithValue("@id", numero_txt.Text);
                        command2.Parameters.AddWithValue("@id", numero_txt.Text);
                        command3.Parameters.AddWithValue("@id", numero_txt.Text);


                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();

                        MessageBox.Show("Calendrier supprimé avec succès !!", "Succès");
                        disp_data();
                    }
                }
                ClearTextBoxes();
            }
        }

        private void show_chef_btn_Click(object sender, EventArgs e)
        {           
            nomChef_label.Show();
            chef_comboBox.Show();
            affecter_chef_btn.Show();
            nomServeur_label.Hide();
            serveur_comboBox.Hide();
            affecter_serveur_btn.Hide();
        }

        private void show_serveur_btn_Click(object sender, EventArgs e)
        {
            nomServeur_label.Show();
            serveur_comboBox.Show();
            affecter_serveur_btn.Show();
            nomChef_label.Hide();
            chef_comboBox.Hide();
            affecter_chef_btn.Hide();
        }

        void chefComboBox()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select nom_chef from Chef ;", connexion);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    chef_comboBox.Items.Add(myReader["nom_chef"].ToString());
                }
            }
        }

        void serveurComboBox()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select nom_serveur from Serveur ;", connexion);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    serveur_comboBox.Items.Add(myReader["nom_serveur"].ToString());
                }
            }
        }

        private void affecter_chef_btn_Click(object sender, EventArgs e)
        {
            if (numero_txt.Value == 0 || debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "" || chef_comboBox.Text == "")
            { MessageBox.Show("Veuillez selectionner un calendrier et un chef !!!!"); }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE Chef SET id_calendrier=@id WHERE id_chef=(SELECT id_chef FROM Chef WHERE nom_chef=@nom)", connexion);
                    command.Parameters.AddWithValue("@id", id_calendrier_txt.Text);
                    command.Parameters.AddWithValue("@nom", chef_comboBox.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Le Chef est affecter au calendrie !", "Succès");
                    command.Parameters.Clear();
                    disp_data();
                }
            }

        }

        private void affecter_serveur_btn_Click(object sender, EventArgs e)
        {
            if (numero_txt.Value==0 || debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "" || serveur_comboBox.Text == "")
            { MessageBox.Show("Veuillez selectionner un calendrier et un chef !!!!"); }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE Serveur SET id_calendrier=@id WHERE id_serveur=(SELECT id_serveur FROM Serveur WHERE nom_serveur=@nom)", connexion);
                    command.Parameters.AddWithValue("@id", id_calendrier_txt.Text);
                    command.Parameters.AddWithValue("@nom", serveur_comboBox.Text);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Le serveur est affecter au calendrie !", "Succès");
                    command.Parameters.Clear();
                    disp_data();
                }
            }
        }

        public Form RefToModeAdmin { get; set; }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeAdmin.Show();
        }
    }

}
