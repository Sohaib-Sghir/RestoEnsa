using MetroFramework.Forms;
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
    public partial class ModeAdmin : MetroForm
    {
        public ModeAdmin(string message)
        {
            InitializeComponent();
            bienvenue_lbl.Text = message;
        }

        private void ModeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void gestion_serveurs_btn_Click(object sender, EventArgs e)
        {
            GestionServeur gestionServeur = new GestionServeur();
            gestionServeur.RefToModeAdmin = this;
            this.Hide();
            gestionServeur.Show();
        }

        public Form RefToAuthentication { get; set; }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToAuthentication.Show();
        }

        private void gestion_plat_click(object sender, EventArgs e)
        {
            Plats plats = new Plats();
            plats.RefToModeAdmin = this;
            this.Hide();
            plats.Show();
        }

        private void gestion_categorie_click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.RefToModeAdmin = this;
            this.Hide();
            categories.Show();
        }

        private void gestion_table_click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.RefToModeAdmin = this;
            this.Hide();
            tables.Show();
        }

        private void Gestion_chefs_btn_Click(object sender, EventArgs e)
        {
            GestionChefs gestionChefs = new GestionChefs();
            gestionChefs.RefToModeAdmin = this;
            this.Hide();
            gestionChefs.Show();
        }

        private void Gestion_horaire_btn_Click(object sender, EventArgs e)
        {
            GestionHoraires gestionCategories = new GestionHoraires();
            gestionCategories.RefToModeAdmin = this;
            this.Hide();
            gestionCategories.Show();
        }

        private void afficher_cal_btn_Click(object sender, EventArgs e)
        {
            Calendrier calendrier = new Calendrier("Admin");
            calendrier.RefToModeAdmin = this;
            this.Hide();
            calendrier.Show();
        }

        private void gestion_serveurs_btn_MouseEnter(object sender, EventArgs e)
        {
            gestion_serveurs_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void gestion_serveurs_btn_MouseLeave(object sender, EventArgs e)
        {
            gestion_serveurs_btn.BackColor = Color.DarkOrange;
        }

        private void Gestion_chefs_btn_MouseEnter(object sender, EventArgs e)
        {
            Gestion_chefs_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void Gestion_chefs_btn_MouseLeave(object sender, EventArgs e)
        {
            Gestion_chefs_btn.BackColor = Color.LimeGreen;
        }

        private void gestion_plats_btn_MouseEnter(object sender, EventArgs e)
        {
            gestion_plats_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void gestion_plats_btn_MouseLeave(object sender, EventArgs e)
        {
            gestion_plats_btn.BackColor = Color.LimeGreen;
        }

        private void gestion_tables_btn_MouseEnter(object sender, EventArgs e)
        {
            gestion_tables_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void gestion_tables_btn_MouseLeave(object sender, EventArgs e)
        {
            gestion_tables_btn.BackColor = Color.LimeGreen;
        }

        private void gestion_catégories_btn_MouseEnter(object sender, EventArgs e)
        {
            gestion_catégories_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void gestion_catégories_btn_MouseLeave(object sender, EventArgs e)
        {
            gestion_catégories_btn.BackColor = Color.DarkOrange;
        }

        private void Gestion_horaire_btn_MouseEnter(object sender, EventArgs e)
        {
            Gestion_horaire_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void Gestion_horaire_btn_MouseLeave(object sender, EventArgs e)
        {
            Gestion_horaire_btn.BackColor = Color.DarkOrange;
        }
    }
}
