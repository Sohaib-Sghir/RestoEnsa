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
    public partial class Categories : MetroFramework.Forms.MetroForm
    {
        DBConnect db;

        public Categories()
        {
            InitializeComponent();
            db = new DBConnect();
            db.Afficher_Categorie(Categorie_grid);
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

                    else
                        func(control.Controls);

            };

            func(Controls);
        }

        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string nom = "";

                if (string.IsNullOrWhiteSpace(categorie_nom_box.Text)) { throw new Ex("vous devez remplir le champ nom!!"); } else { nom = categorie_nom_box.Text; }

                if (db.check_Existence("Categorie", categorie_code_box.Text))
                {
                    MessageBox.Show("la Categorie du code " + categorie_code_box.Text + " existe deja \n pour la modifier cliquer sur Modifier !");
                }
                else
                {
                    db.Ajouter_Categorie(nom);
                    MessageBox.Show("Succes!");
                    ClearTextBoxes();
                    db.Afficher_Categorie(Categorie_grid);
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void modif_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                string nom = "";

                if (string.IsNullOrWhiteSpace(categorie_code_box.Text)) { throw new Ex("vous devez selectionner la commande \n que vous voulez modifier !!"); } else { id = int.Parse(categorie_code_box.Text); }
                if (string.IsNullOrWhiteSpace(categorie_nom_box.Text)) { throw new Ex("vous devez remplir le champ nom!!"); } else { nom = categorie_nom_box.Text; }


                db.Modifier_Categorie(id, nom);
                MessageBox.Show("Succes!");
                ClearTextBoxes();
                db.Afficher_Categorie(Categorie_grid);
            }
            catch (Exception ex)
            {

            }
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = categorie_code_box.Text;

                //verifier si le text box est non vide || verifier si le code existe
                if (string.IsNullOrWhiteSpace(id)) { throw new Ex("vous devez selectionner la categorie\nque vous voulez supprimer!"); }


                //verifier si la categorie ne contient aucun plat
                int verify = db.Verify_Empty_Categorie(id);

                if (verify != 0) { throw new Ex("la categorie que vous voulez supprimer contient des plats!"); }
                else
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer cette Categorie ?", "Supprimer Categorie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        int code = int.Parse(id);
                        db.Supprimer_Categorie(code);
                        ClearTextBoxes();
                        db.Afficher_Categorie(Categorie_grid);
                    }

                    else
                    {
                        MessageBox.Show("Categorie non Supprimée !", "Spprimer Categorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void Categorie_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Categorie_grid.Rows[e.RowIndex];

                categorie_code_box.Text = row.Cells["id_categorie"].Value.ToString();
                categorie_nom_box.Text = row.Cells["nom_categorie"].Value.ToString();


            }
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

        }

        public Form RefToModeAdmin { get; set; }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToModeAdmin.Show();
        }
    }
}
