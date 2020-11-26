using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    class DBConnect
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspaces\DotNet\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter adapt;
        public DataSet ds;

        public DBConnect()
        {
            conn = new SqlConnection(connectionString);

            if(conn.State != ConnectionState.Open )
            {
                conn.Open();
            }
        }

        public void Afficher_Plat(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT id_plat,id_categorie,nom_plat,prix,disponible FROM Plat", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);

            ds.Tables[0].Columns.Add("Disponibilité", typeof(string));

            grid.DataSource = ds.Tables[0];

            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                if (grid.Rows[i].Cells[4].Value.ToString() == "True")
                {
                    grid.Rows[i].Cells[5].Value = "disponible";
                }
                if (grid.Rows[i].Cells[4].Value.ToString() == "False")
                {
                    grid.Rows[i].Cells[5].Value = "non disponible";
                }

            }
            grid.Columns["id_plat"].Visible = false;
            grid.Columns["id_categorie"].Visible = false;
            grid.Columns["disponible"].Visible = false;
        }

        public void Afficher_Plat_ParFiltre(MetroFramework.Controls.MetroGrid grid, string nom_categorie)
        {
            int code = Categorie_Nom_Code(nom_categorie);
            cmd = new SqlCommand("SELECT id_plat,id_categorie,nom_plat,prix,disponible FROM Plat where id_categorie = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("Disponibilité", typeof(string));

            grid.DataSource = ds.Tables[0];

            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                if (grid.Rows[i].Cells[4].Value.ToString() == "True")
                {
                    grid.Rows[i].Cells[5].Value = "disponible";
                }
                if (grid.Rows[i].Cells[4].Value.ToString() == "False")
                {
                    grid.Rows[i].Cells[5].Value = "non disponible";
                }

            }

            grid.Columns["id_plat"].Visible = false;
            grid.Columns["id_categorie"].Visible = false;
            grid.Columns["disponible"].Visible = false;
            cmd.Parameters.Clear();

        }
        //categorie_nom_code return the id of the categorie's name given in input
        public int Categorie_Nom_Code(string nom)
        {

            cmd = new SqlCommand("SELECT id_categorie FROM Categorie where nom_categorie=@nom", conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return id;
        }

        //categorie_code_nom return the nom of the categorie's id given in input
        public string Categorie_Code_Nom(int id)
        {

            cmd = new SqlCommand("SELECT nom_categorie FROM Categorie where id_categorie=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            return ds.Tables[0].Rows[0][0].ToString();


        }

        public void Fill_Categorie(MetroFramework.Controls.MetroComboBox combo)
        {

            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT nom_categorie FROM Categorie", conn);
            adapt = new SqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        

        public void Fill_Disponible(MetroFramework.Controls.MetroComboBox combo)
        {
            combo.Items.Clear();
            combo.ResetText();
            combo.Items.Add("disponible");
            combo.Items.Add("non disponible");
            combo.SelectedItem = "disponible";
        }

        public void Ajouter_Plat( string nom_plat, float prix, int var_disponible, string categorie)
        {
            int code_categorie = Categorie_Nom_Code(categorie);
            cmd = new SqlCommand("insert into Plat (nom_plat,prix,disponible,id_categorie) values (@nom,@prix,@dispo,@categorie) ",conn);
            cmd.Parameters.AddWithValue("@nom", nom_plat);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@dispo", var_disponible);
            cmd.Parameters.AddWithValue("@categorie", code_categorie);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();     
        }

        public void Modifier_Plat(int id_plat, string nom_plat, float prix,int var_disponible, string categorie)
        {
            int code_categorie = Categorie_Nom_Code(categorie);
            cmd = new SqlCommand("update Plat set nom_plat=@nom,prix=@prix, disponible=@dispo,id_categorie=@categorie where id_plat=@id ",conn);
            cmd.Parameters.AddWithValue("@nom", nom_plat);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@dispo", var_disponible);
            cmd.Parameters.AddWithValue("@categorie", code_categorie);
            cmd.Parameters.AddWithValue("@id", id_plat);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Supprimer_Plat(int code)
        {
            cmd = new SqlCommand("delete from Plat where id_plat = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        

        public bool check_Existence(string table, string code)
        {
            if (table.Equals("Plat"))
            {
                cmd = new SqlCommand("select id_plat from Plat", conn);
            }
            if (table.Equals("Tablee"))
            {
                cmd = new SqlCommand("select id_table from Tablee", conn);
            }
            if (table.Equals("Categorie"))
            {
                cmd = new SqlCommand("select id_categorie from Categorie", conn);
            }
            if (table.Equals("Commande"))
            {
                cmd = new SqlCommand("select id_commande from Commande", conn);
            }



            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                if (x[0].ToString() == code) { return true; }

            }
            return false;

        }


        //***********************************************************
        //Categorie

        public void Afficher_Categorie(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT id_categorie,nom_categorie FROM Categorie", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];

        }

        public void Ajouter_Categorie(string nom)
        {
            cmd = new SqlCommand("insert into Categorie (nom_categorie) values (@nom)",conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Modifier_Categorie(int id, string nom)
        {
            cmd = new SqlCommand("update Categorie set nom_categorie=@nom where id_categorie=@id ",conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Supprimer_Categorie(int id)
        {
            cmd = new SqlCommand("delete from Categorie where id_categorie = @id",conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


        public int Verify_Empty_Categorie(string id)
        {
            cmd = new SqlCommand("SELECT id_categorie FROM Plat where id_categorie = @code", conn);
            cmd.Parameters.AddWithValue("@code", id);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            return ds.Tables[0].Rows.Count;
        }



        //*******************************************************************
        //Tables
        public void Afficher_Table(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT id_table,nom_serveur,reservee FROM Tablee", conn);

            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);

            ds.Tables[0].Columns.Add("Reservation", typeof(string));            

            grid.DataSource = ds.Tables[0];
            grid.Columns["reservee"].Visible = false;
            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                if (grid.Rows[i].Cells[2].Value.ToString() == "True")
                {
                    grid.Rows[i].Cells[3].Value = "reservée";
                }
                if (grid.Rows[i].Cells[2].Value.ToString() == "False")
                {
                    grid.Rows[i].Cells[3].Value = "non reservée";
                }

            }
        }

        public void Ajouter_Table(int id)
        {
            cmd = new SqlCommand("insert into Tablee (id_table,nom_serveur) values (@id,'-')",conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public bool Verify_Reserved_Table(int id)
        {
            cmd = new SqlCommand("SELECT reservee FROM Tablee where id_table = @code", conn);
            cmd.Parameters.AddWithValue("@code", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            return bool.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public void Supprimer_Table(int id)
        {
            cmd = new SqlCommand("delete from Tablee where id_table = @id",conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //partie serveurs
        public void Fill_Table(MetroFramework.Controls.MetroComboBox combo)
        {

            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT id_table FROM Tablee where reservee = 'True' and nom_serveur = '"+ 
                Authentification.user_info[1] +"'", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        public void Fill_Table_2(MetroFramework.Controls.MetroComboBox combo)
        {

            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT id_table FROM Tablee where reservee = 'True' and (nom_serveur = '-' or nom_serveur = '"+
                Authentification.user_info[1] + "')", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        public void Fill_Table_3(MetroFramework.Controls.MetroComboBox combo)
        {

            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT id_table FROM Tablee where nom_serveur = '-' or nom_serveur = '" +
                Authentification.user_info[1] + "'", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        //commande ************************************************

        public void Ajouter_Cmd( string nom_plat, int quantite, float prix, int id_table)
        {
            cmd = new SqlCommand("insert into Commande (nom_plat,quantite,prix,id_table,facture) values (@nom_plat,@quantite,@prix,@id_table,@facture)", conn);
            cmd.Parameters.AddWithValue("@nom_plat", nom_plat);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@prix", prix*quantite);
            cmd.Parameters.AddWithValue("@id_table", id_table);
            cmd.Parameters.AddWithValue("@facture", "Non facturé");
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd = new SqlCommand("Update Tablee set nom_serveur = @nom_serveur where id_table = @id_table", conn);
            cmd.Parameters.AddWithValue("@nom_serveur", Authentification.user_info[1]);
            cmd.Parameters.AddWithValue("@id_table", id_table);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Modifier_Cmd(int id_cmd, string nom_plat,int quantite, float prix, int id_table)
        {
            cmd = new SqlCommand("update Commande set nom_plat=@nom,quantite = @quantite,prix = @prix, id_table=@id_table where id_commande=@id ", conn);
            cmd.Parameters.AddWithValue("@id", id_cmd);
            cmd.Parameters.AddWithValue("@nom", nom_plat);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@prix", prix * quantite);
            cmd.Parameters.AddWithValue("@id_table", id_table);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


        public void Supprimer_Cmd(int id)
        {
            cmd = new SqlCommand("delete from Commande where id_commande = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void Afficher_Cmd(MetroFramework.Controls.MetroGrid grid)
        {
            cmd = new SqlCommand("SELECT id_commande,nom_plat,quantite,prix,id_table,facture FROM Commande where id_table in "+
                "(Select id_table from Tablee where nom_serveur = '"+ Authentification.user_info[1] +"')", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];
            //grid.Columns["id_table"].Visible = false;
        }

        public void Afficher_Cmd_ParFiltre(MetroFramework.Controls.MetroGrid grid, int id_table)
        {
            cmd = new SqlCommand("SELECT id_commande,nom_plat,quantite,prix,id_table,facture FROM Commande where id_table = @code", conn);
            cmd.Parameters.AddWithValue("@code", id_table);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];
            //grid.Columns["id_table"].Visible = false;
            cmd.Parameters.Clear();
        }

        ////*******Plats

        public void Fill_Plat_ParCategorie(MetroFramework.Controls.MetroComboBox combo,int id_categorie)
        {
            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT nom_plat FROM Plat where disponible = 'True' and id_categorie = '"+ id_categorie +"'", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            ds.Tables[0].DefaultView.Sort = "nom_plat ASC";
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        public void Fill_Plat(MetroFramework.Controls.MetroComboBox combo)
        {
            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT nom_plat FROM Plat where disponible = 'True'", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            ds.Tables[0].DefaultView.Sort = "nom_plat ASC";
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }
    }
}
