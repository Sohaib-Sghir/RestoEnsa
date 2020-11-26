using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class Tables : MetroFramework.Forms.MetroForm
    {
        DBConnect db;
        public Tables()
        {
            InitializeComponent();
            db = new DBConnect();
            db.Afficher_Table(Table_grid);
        }

        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            bool verify1;
            try
            {
                int id = 0;
                verify1 = int.TryParse(table_code_box.Text, out id); if (!verify1) { throw new Ex("le code doit etre un nombre entier ! "); }
                if (db.check_Existence("Tablee", id.ToString()))
                {
                    MessageBox.Show("la table du code " + id + " existe deja !");
                }
                else
                {
                    db.Ajouter_Table(id);
                    MessageBox.Show("Succes!");
                    table_code_box.Clear();
                    db.Afficher_Table(Table_grid);
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = table_code_box.Text;

                //verifier si le text box est non vide || verifier si le code existe
                if (!db.check_Existence("Tablee", id) || string.IsNullOrWhiteSpace(id)) { throw new Ex("vous devez remplir le champ id correctement (type:entier) !"); }


                //verifier si la table est deja reservée
                int code = int.Parse(id);
                bool reserve = db.Verify_Reserved_Table(code);

                if (reserve) { throw new Ex("la table que vous voulez supprimer est deja reservée!"); }
                else
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer cette Table ?", "Supprimer Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        db.Supprimer_Table(code);
                        table_code_box.Clear();
                        db.Afficher_Table(Table_grid);
                    }

                    else
                    {
                        MessageBox.Show("Table non Supprimée !", "Spprimer Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {

            }

        }

        private void Table_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Table_grid.Rows[e.RowIndex];

                table_code_box.Text = row.Cells["id_table"].Value.ToString();
            }
        }

        private void Tables_Load(object sender, EventArgs e)
        {

        }

        public Form RefToModeAdmin { get; set; }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeAdmin.Show();
        }
    }
}
