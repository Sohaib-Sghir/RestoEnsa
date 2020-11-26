using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class Authentification : MetroForm
    {
        public string connectionString = DBConnect.connectionString;

        CryptographyProcessor cp = new CryptographyProcessor();
        public static object[] user_info = new object[3];
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();

                SqlCommand command = new SqlCommand("Select * from Admin", connexion);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    string salt = cp.CreateSalt(15);
                    string passwordHash = cp.GenerateHash("admin", salt);
                    SqlCommand command2 = new SqlCommand("Insert into Admin (nom_admin,login,mdp,salt) values ('Administrateur','admin','" + passwordHash + "','" + salt + "')", connexion);
                    command2.ExecuteNonQuery();
                }
            }
        }

        public void vider()
        {
            qui_combo.Text = "";
            utilisateur_txt.Text = "";
            mdp_txt.Text = "";
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    if (qui_combo.SelectedIndex == -1 || utilisateur_txt.Text == "" || mdp_txt.Text == "")
                    {
                        throw new Ex("Veuillez remplir les champs !!");
                    }
                    if (qui_combo.SelectedItem.Equals("Admin"))
                    {
                        SqlCommand command = new SqlCommand("Select * from Admin where login = '" + utilisateur_txt.Text + "'", connexion);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1 && cp.AreEqual(mdp_txt.Text, dt.Rows[0].Field<string>("mdp"), dt.Rows[0].Field<string>("salt")))
                        {
                            user_info[0] = dt.Rows[0].Field<int?>("id_admin");
                            user_info[1] = dt.Rows[0].Field<string>("nom_admin");
                            user_info[2] = dt.Rows[0].Field<string>("login");

                            ModeAdmin admin_mode = new ModeAdmin("Bienvenue " + user_info[1] + " !");
                            admin_mode.RefToAuthentication = this;
                            this.Hide();
                            admin_mode.Show();
                        }
                        else
                        {
                            MessageBox.Show("Verifie ton nom d'utilisateur/mot de passe");
                        }
                    }
                    else if (qui_combo.SelectedItem.Equals("Serveur"))
                    {
                        SqlCommand command = new SqlCommand("Select * from Serveur where login = '" + utilisateur_txt.Text + "'", connexion);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1 && cp.AreEqual(mdp_txt.Text, dt.Rows[0].Field<string>("mdp"), dt.Rows[0].Field<string>("salt")))
                        {
                            user_info[0] = dt.Rows[0].Field<int?>("id_serveur");
                            user_info[1] = dt.Rows[0].Field<string>("nom_serveur");
                            user_info[2] = dt.Rows[0].Field<string>("login");

                            ModeServeur serveur_mode = new ModeServeur("Bienvenue " + user_info[1] + " !");
                            serveur_mode.RefToAuthentication = this;
                            this.Hide();
                            serveur_mode.Show();
                        }
                        else
                        {
                            MessageBox.Show("Verifie ton nom d'utilisateur/mot de passe");
                        }
                    }
                    vider();

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
