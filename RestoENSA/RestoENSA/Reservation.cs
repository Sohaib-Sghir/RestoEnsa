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
    public partial class Reservation : MetroForm
    {
        public string connectionString = DBConnect.connectionString;
        DBConnect db;

        public Reservation()
        {
            InitializeComponent();
            db = new DBConnect();
            if (db.conn.State != ConnectionState.Open)
            {
                db.conn.Open();
            }
            db.Fill_Table_3(reservation_box);
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MetroFramework.Controls.MetroTextBox || control is MetroFramework.Controls.MetroComboBox)
                    {
                        control.ResetText();
                    }
                    else if (control is NumericUpDown)
                    {
                        control.Text = "0";
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void reserver_btn_Click(object sender, EventArgs e)
        {
            if (reservation_box.SelectedIndex == -1)
                MessageBox.Show("Veuillez remplire le champ !!!!!");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();

                    SqlCommand command = new SqlCommand("Select * from Tablee where id_table = @id", connexion);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(reservation_box.SelectedItem));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1 && dt.Rows[0].Field<bool>("reservee")==false)
                    {
                        SqlCommand command2 = new SqlCommand("UPDATE Tablee SET reservee = 1 WHERE id_table = @id", connexion);
                        command2.Parameters.AddWithValue("@id", Convert.ToInt32(reservation_box.SelectedItem));
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Table réservée avec succès !!", "Succès");
                    }
                    else
                    {
                        MessageBox.Show("Table introuvable ou déjà réservée !!", "Erreur");
                    }
                }
            }
            ClearTextBoxes();
        }

        private void supprimer_txt_Click(object sender, EventArgs e)
        {
            if (reservation_box.SelectedIndex == -1)
                MessageBox.Show("Veuillez remplire le champ !!!!!");
            else
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette réservation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connexion = new SqlConnection(connectionString))
                    {
                        connexion.Open();

                        SqlCommand command = new SqlCommand("Select * from Tablee where id_table = @id", connexion);
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(reservation_box.SelectedItem));

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1 && dt.Rows[0].Field<bool>("reservee") == true)
                        {
                            SqlCommand command2 = new SqlCommand("UPDATE Tablee SET reservee = 0 and nom_serveur = '-' WHERE id_table = @id", connexion);
                            SqlCommand command3 = new SqlCommand("DELETE FROM Commande WHERE id_table = @id", connexion);

                            command2.Parameters.AddWithValue("@id", Convert.ToInt32(reservation_box.SelectedItem));
                            command3.Parameters.AddWithValue("@id", Convert.ToInt32(reservation_box.SelectedItem));

                            command2.ExecuteNonQuery();
                            command3.ExecuteNonQuery();

                            MessageBox.Show("Réservation supprimée avec succès !!", "Succès");
                        }
                        else
                        {
                            MessageBox.Show("Table introuvable ou n'est pas réservée !!", "Erreur");
                        }
                    }
                    ClearTextBoxes();
                }
            }
        }

        public Form RefToModeServeur { get; set; }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeServeur.Show();
        }
    }
}
