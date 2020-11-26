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
    public partial class Calendrier : MetroForm
    {
        public string connectionString = DBConnect.connectionString;
        string mode;
        public Calendrier(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        public void disp_data(string cmd)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand(cmd, connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    info_lbl.Hide();
                    calendrier_grid.Show();
                    calendrier_grid.DataSource = dt;
                }
                else
                {
                    calendrier_grid.Hide();
                    info_lbl.Text = "Aucun calendrier trouvé.";
                    info_lbl.Show();
                }
            }
        }

        private void afficher_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void calend_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (calend_combo.SelectedIndex == -1)
                {
                    throw new Ex("Veuillez choisir un calendrier !!");
                }
                else
                {
                    if (calend_combo.SelectedItem.Equals("Serveurs"))
                    {
                        disp_data("select numero_semaine,nom_serveur,horaire_shift1,horaire_shift2,debut_semaine,fin_semaine " +
                            "from Serveur s,Calendrier c WHERE s.id_calendrier=c.id_calendrier");
                    }
                    else if (calend_combo.SelectedItem.Equals("Chefs"))
                    {
                        disp_data("select numero_semaine,nom_chef,horaire_shift1,horaire_shift2,debut_semaine,fin_semaine " +
                            "from Chef h,Calendrier c WHERE h.id_calendrier=c.id_calendrier");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public Form RefToModeAdmin { get; set; }
        public Form RefToModeServeur { get; set; }


        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            if(this.mode.Equals("Admin"))
                this.RefToModeAdmin.Show();
            else if (this.mode.Equals("Serveur"))
                this.RefToModeServeur.Show();

        }


    }
}
