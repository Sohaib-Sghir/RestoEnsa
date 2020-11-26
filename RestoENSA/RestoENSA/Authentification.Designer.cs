namespace RestoENSA
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.qui_combo = new MetroFramework.Controls.MetroComboBox();
            this.qui_lbl = new MetroFramework.Controls.MetroLabel();
            this.utilisateur_txt = new MetroFramework.Controls.MetroTextBox();
            this.mdp_txt = new MetroFramework.Controls.MetroTextBox();
            this.utilisateur_lbl = new MetroFramework.Controls.MetroLabel();
            this.mdp_lbl = new MetroFramework.Controls.MetroLabel();
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.credits = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.credits.SuspendLayout();
            this.SuspendLayout();
            // 
            // qui_combo
            // 
            this.qui_combo.FormattingEnabled = true;
            this.qui_combo.ItemHeight = 24;
            this.qui_combo.Items.AddRange(new object[] {
            "Admin",
            "Serveur"});
            this.qui_combo.Location = new System.Drawing.Point(258, 280);
            this.qui_combo.Name = "qui_combo";
            this.qui_combo.Size = new System.Drawing.Size(250, 30);
            this.qui_combo.TabIndex = 0;
            this.qui_combo.UseSelectable = true;
            // 
            // qui_lbl
            // 
            this.qui_lbl.AutoSize = true;
            this.qui_lbl.BackColor = System.Drawing.Color.Transparent;
            this.qui_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.qui_lbl.Location = new System.Drawing.Point(123, 280);
            this.qui_lbl.Name = "qui_lbl";
            this.qui_lbl.Size = new System.Drawing.Size(84, 20);
            this.qui_lbl.TabIndex = 1;
            this.qui_lbl.Text = "Vous-etes ?";
            this.qui_lbl.UseCustomBackColor = true;
            this.qui_lbl.UseCustomForeColor = true;
            // 
            // utilisateur_txt
            // 
            // 
            // 
            // 
            this.utilisateur_txt.CustomButton.Image = null;
            this.utilisateur_txt.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.utilisateur_txt.CustomButton.Name = "";
            this.utilisateur_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.utilisateur_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.utilisateur_txt.CustomButton.TabIndex = 1;
            this.utilisateur_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.utilisateur_txt.CustomButton.UseSelectable = true;
            this.utilisateur_txt.CustomButton.Visible = false;
            this.utilisateur_txt.Lines = new string[0];
            this.utilisateur_txt.Location = new System.Drawing.Point(258, 340);
            this.utilisateur_txt.MaxLength = 32767;
            this.utilisateur_txt.Name = "utilisateur_txt";
            this.utilisateur_txt.PasswordChar = '\0';
            this.utilisateur_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.utilisateur_txt.SelectedText = "";
            this.utilisateur_txt.SelectionLength = 0;
            this.utilisateur_txt.SelectionStart = 0;
            this.utilisateur_txt.ShortcutsEnabled = true;
            this.utilisateur_txt.Size = new System.Drawing.Size(250, 23);
            this.utilisateur_txt.TabIndex = 1;
            this.utilisateur_txt.UseSelectable = true;
            this.utilisateur_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.utilisateur_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdp_txt
            // 
            // 
            // 
            // 
            this.mdp_txt.CustomButton.Image = null;
            this.mdp_txt.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.mdp_txt.CustomButton.Name = "";
            this.mdp_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdp_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp_txt.CustomButton.TabIndex = 1;
            this.mdp_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp_txt.CustomButton.UseSelectable = true;
            this.mdp_txt.CustomButton.Visible = false;
            this.mdp_txt.Lines = new string[0];
            this.mdp_txt.Location = new System.Drawing.Point(258, 389);
            this.mdp_txt.MaxLength = 32767;
            this.mdp_txt.Name = "mdp_txt";
            this.mdp_txt.PasswordChar = '●';
            this.mdp_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp_txt.SelectedText = "";
            this.mdp_txt.SelectionLength = 0;
            this.mdp_txt.SelectionStart = 0;
            this.mdp_txt.ShortcutsEnabled = true;
            this.mdp_txt.Size = new System.Drawing.Size(250, 23);
            this.mdp_txt.TabIndex = 2;
            this.mdp_txt.UseSelectable = true;
            this.mdp_txt.UseSystemPasswordChar = true;
            this.mdp_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdp_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // utilisateur_lbl
            // 
            this.utilisateur_lbl.AutoSize = true;
            this.utilisateur_lbl.BackColor = System.Drawing.Color.Transparent;
            this.utilisateur_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.utilisateur_lbl.Location = new System.Drawing.Point(123, 340);
            this.utilisateur_lbl.Name = "utilisateur_lbl";
            this.utilisateur_lbl.Size = new System.Drawing.Size(76, 20);
            this.utilisateur_lbl.TabIndex = 4;
            this.utilisateur_lbl.Text = "Utilisateur";
            this.utilisateur_lbl.UseCustomBackColor = true;
            this.utilisateur_lbl.UseCustomForeColor = true;
            // 
            // mdp_lbl
            // 
            this.mdp_lbl.AutoSize = true;
            this.mdp_lbl.BackColor = System.Drawing.Color.Transparent;
            this.mdp_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mdp_lbl.Location = new System.Drawing.Point(123, 389);
            this.mdp_lbl.Name = "mdp_lbl";
            this.mdp_lbl.Size = new System.Drawing.Size(98, 20);
            this.mdp_lbl.TabIndex = 5;
            this.mdp_lbl.Text = "Mot de passe";
            this.mdp_lbl.UseCustomBackColor = true;
            this.mdp_lbl.UseCustomForeColor = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.login_btn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(258, 449);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(139, 54);
            this.login_btn.Style = MetroFramework.MetroColorStyle.Green;
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Se connecter";
            this.login_btn.UseCustomBackColor = true;
            this.login_btn.UseCustomForeColor = true;
            this.login_btn.UseSelectable = true;
            this.login_btn.UseStyleColors = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.ImageLocation = "";
            this.logoBox.Location = new System.Drawing.Point(115, -6);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(361, 257);
            this.logoBox.TabIndex = 7;
            this.logoBox.TabStop = false;
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.DarkOrange;
            this.credits.Controls.Add(this.metroLabel4);
            this.credits.Controls.Add(this.metroLabel3);
            this.credits.Controls.Add(this.metroLabel2);
            this.credits.Controls.Add(this.metroLabel1);
            this.credits.HorizontalScrollbarBarColor = true;
            this.credits.HorizontalScrollbarHighlightOnWheel = false;
            this.credits.HorizontalScrollbarSize = 10;
            this.credits.Location = new System.Drawing.Point(776, 401);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(285, 152);
            this.credits.TabIndex = 8;
            this.credits.UseCustomBackColor = true;
            this.credits.UseCustomForeColor = true;
            this.credits.VerticalScrollbarBarColor = true;
            this.credits.VerticalScrollbarHighlightOnWheel = false;
            this.credits.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel4.Location = new System.Drawing.Point(72, 109);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "SGHIR Sohaib";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel3.Location = new System.Drawing.Point(72, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "BELQAID Salma";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(72, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "BAHAMAD Imane";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(31, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Elaboré par :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // Authentification
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-100, 0, 0, 0);
            this.BackMaxSize = 1000;
            this.ClientSize = new System.Drawing.Size(1101, 586);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.mdp_lbl);
            this.Controls.Add(this.utilisateur_lbl);
            this.Controls.Add(this.mdp_txt);
            this.Controls.Add(this.utilisateur_txt);
            this.Controls.Add(this.qui_lbl);
            this.Controls.Add(this.qui_combo);
            this.MaximizeBox = false;
            this.Name = "Authentification";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.credits.ResumeLayout(false);
            this.credits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox qui_combo;
        private MetroFramework.Controls.MetroLabel qui_lbl;
        private MetroFramework.Controls.MetroTextBox utilisateur_txt;
        private MetroFramework.Controls.MetroTextBox mdp_txt;
        private MetroFramework.Controls.MetroLabel utilisateur_lbl;
        private MetroFramework.Controls.MetroLabel mdp_lbl;
        private MetroFramework.Controls.MetroButton login_btn;
        private System.Windows.Forms.PictureBox logoBox;
        private MetroFramework.Controls.MetroPanel credits;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

