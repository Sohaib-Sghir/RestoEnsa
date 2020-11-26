namespace RestoENSA
{
    partial class ModeServeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeServeur));
            this.bienvenue_lbl = new MetroFramework.Controls.MetroLabel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.réservation_btn = new MetroFramework.Controls.MetroButton();
            this.commande_btn = new MetroFramework.Controls.MetroButton();
            this.calendrier_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bienvenue_lbl
            // 
            this.bienvenue_lbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.bienvenue_lbl.Location = new System.Drawing.Point(262, 39);
            this.bienvenue_lbl.Name = "bienvenue_lbl";
            this.bienvenue_lbl.Size = new System.Drawing.Size(441, 36);
            this.bienvenue_lbl.TabIndex = 3;
            this.bienvenue_lbl.UseCustomBackColor = true;
            this.bienvenue_lbl.UseCustomForeColor = true;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(735, 377);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(257, 163);
            this.logoBox.TabIndex = 11;
            this.logoBox.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(907, 18);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(60, 57);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // réservation_btn
            // 
            this.réservation_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.réservation_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("réservation_btn.BackgroundImage")));
            this.réservation_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.réservation_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.réservation_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.réservation_btn.Location = new System.Drawing.Point(288, 239);
            this.réservation_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.réservation_btn.Name = "réservation_btn";
            this.réservation_btn.Size = new System.Drawing.Size(404, 83);
            this.réservation_btn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.réservation_btn.TabIndex = 1;
            this.réservation_btn.Text = "Réservation";
            this.réservation_btn.UseCustomBackColor = true;
            this.réservation_btn.UseCustomForeColor = true;
            this.réservation_btn.UseSelectable = true;
            this.réservation_btn.UseStyleColors = true;
            this.réservation_btn.Click += new System.EventHandler(this.réserver_btn_Click);
            this.réservation_btn.MouseEnter += new System.EventHandler(this.réservation_btn_MouseEnter);
            this.réservation_btn.MouseLeave += new System.EventHandler(this.réservation_btn_MouseLeave);
            // 
            // commande_btn
            // 
            this.commande_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.commande_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commande_btn.BackgroundImage")));
            this.commande_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.commande_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.commande_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commande_btn.Location = new System.Drawing.Point(288, 127);
            this.commande_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commande_btn.Name = "commande_btn";
            this.commande_btn.Size = new System.Drawing.Size(404, 83);
            this.commande_btn.Style = MetroFramework.MetroColorStyle.Purple;
            this.commande_btn.TabIndex = 0;
            this.commande_btn.Text = "Commande";
            this.commande_btn.UseCustomBackColor = true;
            this.commande_btn.UseCustomForeColor = true;
            this.commande_btn.UseSelectable = true;
            this.commande_btn.UseStyleColors = true;
            this.commande_btn.Click += new System.EventHandler(this.Ajouter_Cmd);
            this.commande_btn.MouseEnter += new System.EventHandler(this.commande_btn_MouseEnter);
            this.commande_btn.MouseLeave += new System.EventHandler(this.commande_btn_MouseLeave);
            // 
            // calendrier_btn
            // 
            this.calendrier_btn.BackColor = System.Drawing.Color.Transparent;
            this.calendrier_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendrier_btn.BackgroundImage")));
            this.calendrier_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calendrier_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.calendrier_btn.Highlight = true;
            this.calendrier_btn.Location = new System.Drawing.Point(441, 341);
            this.calendrier_btn.Margin = new System.Windows.Forms.Padding(4);
            this.calendrier_btn.Name = "calendrier_btn";
            this.calendrier_btn.Size = new System.Drawing.Size(90, 79);
            this.calendrier_btn.Style = MetroFramework.MetroColorStyle.White;
            this.calendrier_btn.TabIndex = 2;
            this.calendrier_btn.UseCustomBackColor = true;
            this.calendrier_btn.UseCustomForeColor = true;
            this.calendrier_btn.UseSelectable = true;
            this.calendrier_btn.UseStyleColors = true;
            this.calendrier_btn.Click += new System.EventHandler(this.calendrier_btn_Click);
            // 
            // ModeServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 542);
            this.ControlBox = false;
            this.Controls.Add(this.calendrier_btn);
            this.Controls.Add(this.commande_btn);
            this.Controls.Add(this.réservation_btn);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.bienvenue_lbl);
            this.Controls.Add(this.logout_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModeServeur";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Mode serveur";
            this.Load += new System.EventHandler(this.ModeServeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel bienvenue_lbl;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button logout_btn;
        private MetroFramework.Controls.MetroButton réservation_btn;
        private MetroFramework.Controls.MetroButton commande_btn;
        private MetroFramework.Controls.MetroButton calendrier_btn;
    }
}