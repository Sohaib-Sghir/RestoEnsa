namespace RestoENSA
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.id_lbl = new MetroFramework.Controls.MetroLabel();
            this.reserver_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_txt = new MetroFramework.Controls.MetroButton();
            this.reservation_box = new MetroFramework.Controls.MetroComboBox();
            this.retour_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(180, 195);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(129, 20);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "Numéro de la table";
            // 
            // reserver_btn
            // 
            this.reserver_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reserver_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.reserver_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reserver_btn.Location = new System.Drawing.Point(233, 291);
            this.reserver_btn.Name = "reserver_btn";
            this.reserver_btn.Size = new System.Drawing.Size(103, 38);
            this.reserver_btn.TabIndex = 1;
            this.reserver_btn.Text = "Réserver";
            this.reserver_btn.UseCustomBackColor = true;
            this.reserver_btn.UseCustomForeColor = true;
            this.reserver_btn.UseSelectable = true;
            this.reserver_btn.Click += new System.EventHandler(this.reserver_btn_Click);
            // 
            // supprimer_txt
            // 
            this.supprimer_txt.BackColor = System.Drawing.Color.Crimson;
            this.supprimer_txt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.supprimer_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimer_txt.Location = new System.Drawing.Point(354, 291);
            this.supprimer_txt.Name = "supprimer_txt";
            this.supprimer_txt.Size = new System.Drawing.Size(220, 38);
            this.supprimer_txt.TabIndex = 2;
            this.supprimer_txt.Text = "Supprimer la réservation";
            this.supprimer_txt.UseCustomBackColor = true;
            this.supprimer_txt.UseCustomForeColor = true;
            this.supprimer_txt.UseSelectable = true;
            this.supprimer_txt.Click += new System.EventHandler(this.supprimer_txt_Click);
            // 
            // reservation_box
            // 
            this.reservation_box.FormattingEnabled = true;
            this.reservation_box.ItemHeight = 24;
            this.reservation_box.Location = new System.Drawing.Point(354, 195);
            this.reservation_box.Name = "reservation_box";
            this.reservation_box.Size = new System.Drawing.Size(241, 30);
            this.reservation_box.TabIndex = 0;
            this.reservation_box.UseSelectable = true;
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(23, 80);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 102;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 455);
            this.ControlBox = false;
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.reservation_box);
            this.Controls.Add(this.supprimer_txt);
            this.Controls.Add(this.reserver_btn);
            this.Controls.Add(this.id_lbl);
            this.Name = "Reservation";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Réservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel id_lbl;
        private MetroFramework.Controls.MetroButton reserver_btn;
        private MetroFramework.Controls.MetroButton supprimer_txt;
        private MetroFramework.Controls.MetroComboBox reservation_box;
        private System.Windows.Forms.Button retour_btn;
    }
}