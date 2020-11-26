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
    public partial class ModeServeur : MetroForm
    {
        public ModeServeur(string message)
        {
            InitializeComponent();
            bienvenue_lbl.Text = message;
        }

        private void ModeServeur_Load(object sender, EventArgs e)
        {

        }

        public Form RefToAuthentication { get; set; }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToAuthentication.Show();
        }

        private void réserver_btn_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.RefToModeServeur = this;
            this.Hide();
            reservation.Show();
        }

        private void Ajouter_Cmd(object sender, EventArgs e)
        {
            Commande commande = new Commande();
            commande.RefToModeServeur = this;
            this.Hide();
            commande.Show();
        }

        private void calendrier_btn_Click(object sender, EventArgs e)
        {
            Calendrier calendrier = new Calendrier("Serveur");
            calendrier.RefToModeServeur = this;
            this.Hide();
            calendrier.Show();
        }

        private void commande_btn_MouseEnter(object sender, EventArgs e)
        {
            commande_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void commande_btn_MouseLeave(object sender, EventArgs e)
        {
            commande_btn.BackColor = Color.LimeGreen;
        }

        private void réservation_btn_MouseEnter(object sender, EventArgs e)
        {
            réservation_btn.BackColor = SystemColors.InactiveCaption;
        }

        private void réservation_btn_MouseLeave(object sender, EventArgs e)
        {
            réservation_btn.BackColor = Color.DarkOrange;
        }
    }
}
