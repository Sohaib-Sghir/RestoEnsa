namespace RestoENSA
{
    partial class Plats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plats));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.retour_btn = new System.Windows.Forms.Button();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.modif_btn = new MetroFramework.Controls.MetroButton();
            this.vider_btn = new MetroFramework.Controls.MetroButton();
            this.Ajouter_btn = new MetroFramework.Controls.MetroButton();
            this.disponible_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.categorie_box = new MetroFramework.Controls.MetroComboBox();
            this.code_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.filtre_combobox = new MetroFramework.Controls.MetroComboBox();
            this.plat_grid = new MetroFramework.Controls.MetroGrid();
            this.prix_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.nom_plat_box = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.plat_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(15, 70);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 10;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.BackColor = System.Drawing.Color.Transparent;
            this.supprimer_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supprimer_btn.BackgroundImage")));
            this.supprimer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.supprimer_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.supprimer_btn.ForeColor = System.Drawing.Color.Red;
            this.supprimer_btn.Highlight = true;
            this.supprimer_btn.Location = new System.Drawing.Point(246, 393);
            this.supprimer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(49, 59);
            this.supprimer_btn.Style = MetroFramework.MetroColorStyle.White;
            this.supprimer_btn.TabIndex = 6;
            this.supprimer_btn.UseCustomBackColor = true;
            this.supprimer_btn.UseCustomForeColor = true;
            this.supprimer_btn.UseSelectable = true;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // modif_btn
            // 
            this.modif_btn.BackColor = System.Drawing.Color.Transparent;
            this.modif_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modif_btn.BackgroundImage")));
            this.modif_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modif_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.modif_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.modif_btn.Highlight = true;
            this.modif_btn.Location = new System.Drawing.Point(167, 389);
            this.modif_btn.Margin = new System.Windows.Forms.Padding(4);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(60, 63);
            this.modif_btn.Style = MetroFramework.MetroColorStyle.White;
            this.modif_btn.TabIndex = 5;
            this.modif_btn.UseCustomBackColor = true;
            this.modif_btn.UseCustomForeColor = true;
            this.modif_btn.UseSelectable = true;
            this.modif_btn.Click += new System.EventHandler(this.modif_btn_Click);
            // 
            // vider_btn
            // 
            this.vider_btn.BackColor = System.Drawing.Color.Transparent;
            this.vider_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vider_btn.BackgroundImage")));
            this.vider_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vider_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.vider_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.vider_btn.Highlight = true;
            this.vider_btn.Location = new System.Drawing.Point(311, 389);
            this.vider_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vider_btn.Name = "vider_btn";
            this.vider_btn.Size = new System.Drawing.Size(50, 63);
            this.vider_btn.Style = MetroFramework.MetroColorStyle.White;
            this.vider_btn.TabIndex = 7;
            this.vider_btn.UseCustomBackColor = true;
            this.vider_btn.UseCustomForeColor = true;
            this.vider_btn.UseSelectable = true;
            this.vider_btn.Click += new System.EventHandler(this.vider_btn_Click);
            // 
            // Ajouter_btn
            // 
            this.Ajouter_btn.BackColor = System.Drawing.Color.Transparent;
            this.Ajouter_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajouter_btn.BackgroundImage")));
            this.Ajouter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ajouter_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Ajouter_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Ajouter_btn.Highlight = true;
            this.Ajouter_btn.Location = new System.Drawing.Point(92, 389);
            this.Ajouter_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(59, 63);
            this.Ajouter_btn.Style = MetroFramework.MetroColorStyle.White;
            this.Ajouter_btn.TabIndex = 4;
            this.Ajouter_btn.UseCustomBackColor = true;
            this.Ajouter_btn.UseCustomForeColor = true;
            this.Ajouter_btn.UseSelectable = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.Ajouter_btn_Click);
            // 
            // disponible_combo
            // 
            this.disponible_combo.FormattingEnabled = true;
            this.disponible_combo.ItemHeight = 24;
            this.disponible_combo.Location = new System.Drawing.Point(181, 314);
            this.disponible_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disponible_combo.Name = "disponible_combo";
            this.disponible_combo.Size = new System.Drawing.Size(236, 30);
            this.disponible_combo.TabIndex = 3;
            this.disponible_combo.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(35, 314);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 20);
            this.metroLabel2.TabIndex = 80;
            this.metroLabel2.Text = "Disponibilité";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(35, 266);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 20);
            this.metroLabel1.TabIndex = 79;
            this.metroLabel1.Text = "Catégorie";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // categorie_box
            // 
            this.categorie_box.FormattingEnabled = true;
            this.categorie_box.ItemHeight = 24;
            this.categorie_box.Items.AddRange(new object[] {
            " "});
            this.categorie_box.Location = new System.Drawing.Point(181, 266);
            this.categorie_box.Margin = new System.Windows.Forms.Padding(4);
            this.categorie_box.Name = "categorie_box";
            this.categorie_box.Size = new System.Drawing.Size(236, 30);
            this.categorie_box.TabIndex = 2;
            this.categorie_box.UseSelectable = true;
            // 
            // code_plat_box
            // 
            this.code_plat_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.code_plat_box.CustomButton.Image = null;
            this.code_plat_box.CustomButton.Location = new System.Drawing.Point(215, 2);
            this.code_plat_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.code_plat_box.CustomButton.Name = "";
            this.code_plat_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.code_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code_plat_box.CustomButton.TabIndex = 1;
            this.code_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code_plat_box.CustomButton.UseSelectable = true;
            this.code_plat_box.CustomButton.Visible = false;
            this.code_plat_box.Enabled = false;
            this.code_plat_box.Lines = new string[0];
            this.code_plat_box.Location = new System.Drawing.Point(176, 99);
            this.code_plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.code_plat_box.MaxLength = 32767;
            this.code_plat_box.Name = "code_plat_box";
            this.code_plat_box.PasswordChar = '\0';
            this.code_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code_plat_box.SelectedText = "";
            this.code_plat_box.SelectionLength = 0;
            this.code_plat_box.SelectionStart = 0;
            this.code_plat_box.ShortcutsEnabled = true;
            this.code_plat_box.Size = new System.Drawing.Size(241, 28);
            this.code_plat_box.TabIndex = 69;
            this.code_plat_box.UseCustomBackColor = true;
            this.code_plat_box.UseSelectable = true;
            this.code_plat_box.Visible = false;
            this.code_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel22.Location = new System.Drawing.Point(638, 111);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(175, 20);
            this.metroLabel22.TabIndex = 76;
            this.metroLabel22.Text = "Chercher par catégorie :";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // filtre_combobox
            // 
            this.filtre_combobox.FormattingEnabled = true;
            this.filtre_combobox.ItemHeight = 24;
            this.filtre_combobox.Items.AddRange(new object[] {
            " "});
            this.filtre_combobox.Location = new System.Drawing.Point(901, 111);
            this.filtre_combobox.Margin = new System.Windows.Forms.Padding(5);
            this.filtre_combobox.Name = "filtre_combobox";
            this.filtre_combobox.Size = new System.Drawing.Size(232, 30);
            this.filtre_combobox.TabIndex = 8;
            this.filtre_combobox.UseSelectable = true;
            this.filtre_combobox.SelectedIndexChanged += new System.EventHandler(this.filtre_combobox_SelectedIndexChanged);
            // 
            // plat_grid
            // 
            this.plat_grid.AllowUserToOrderColumns = true;
            this.plat_grid.AllowUserToResizeRows = false;
            this.plat_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plat_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plat_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plat_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.plat_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.plat_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.plat_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.plat_grid.EnableHeadersVisualStyles = false;
            this.plat_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plat_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plat_grid.Location = new System.Drawing.Point(453, 149);
            this.plat_grid.Margin = new System.Windows.Forms.Padding(4);
            this.plat_grid.Name = "plat_grid";
            this.plat_grid.ReadOnly = true;
            this.plat_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.plat_grid.RowHeadersWidth = 51;
            this.plat_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.plat_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plat_grid.Size = new System.Drawing.Size(680, 298);
            this.plat_grid.Style = MetroFramework.MetroColorStyle.Green;
            this.plat_grid.TabIndex = 9;
            this.plat_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plat_grid_CellClick);
            // 
            // prix_plat_box
            // 
            // 
            // 
            // 
            this.prix_plat_box.CustomButton.Image = null;
            this.prix_plat_box.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.prix_plat_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.prix_plat_box.CustomButton.Name = "";
            this.prix_plat_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.prix_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prix_plat_box.CustomButton.TabIndex = 1;
            this.prix_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prix_plat_box.CustomButton.UseSelectable = true;
            this.prix_plat_box.CustomButton.Visible = false;
            this.prix_plat_box.Lines = new string[0];
            this.prix_plat_box.Location = new System.Drawing.Point(181, 223);
            this.prix_plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.prix_plat_box.MaxLength = 32767;
            this.prix_plat_box.Name = "prix_plat_box";
            this.prix_plat_box.PasswordChar = '\0';
            this.prix_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prix_plat_box.SelectedText = "";
            this.prix_plat_box.SelectionLength = 0;
            this.prix_plat_box.SelectionStart = 0;
            this.prix_plat_box.ShortcutsEnabled = true;
            this.prix_plat_box.Size = new System.Drawing.Size(236, 28);
            this.prix_plat_box.TabIndex = 1;
            this.prix_plat_box.UseSelectable = true;
            this.prix_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prix_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel15.Location = new System.Drawing.Point(35, 177);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(42, 20);
            this.metroLabel15.TabIndex = 72;
            this.metroLabel15.Text = "Nom";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(35, 223);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 20);
            this.metroLabel8.TabIndex = 71;
            this.metroLabel8.Text = "Prix (dhs)";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // nom_plat_box
            // 
            // 
            // 
            // 
            this.nom_plat_box.CustomButton.Image = null;
            this.nom_plat_box.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.nom_plat_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.nom_plat_box.CustomButton.Name = "";
            this.nom_plat_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nom_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_plat_box.CustomButton.TabIndex = 1;
            this.nom_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_plat_box.CustomButton.UseSelectable = true;
            this.nom_plat_box.CustomButton.Visible = false;
            this.nom_plat_box.Lines = new string[0];
            this.nom_plat_box.Location = new System.Drawing.Point(181, 177);
            this.nom_plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.nom_plat_box.MaxLength = 32767;
            this.nom_plat_box.Name = "nom_plat_box";
            this.nom_plat_box.PasswordChar = '\0';
            this.nom_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_plat_box.SelectedText = "";
            this.nom_plat_box.SelectionLength = 0;
            this.nom_plat_box.SelectionStart = 0;
            this.nom_plat_box.ShortcutsEnabled = true;
            this.nom_plat_box.Size = new System.Drawing.Size(236, 28);
            this.nom_plat_box.TabIndex = 0;
            this.nom_plat_box.UseSelectable = true;
            this.nom_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Plats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 476);
            this.ControlBox = false;
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.modif_btn);
            this.Controls.Add(this.vider_btn);
            this.Controls.Add(this.Ajouter_btn);
            this.Controls.Add(this.disponible_combo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.categorie_box);
            this.Controls.Add(this.code_plat_box);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.filtre_combobox);
            this.Controls.Add(this.plat_grid);
            this.Controls.Add(this.prix_plat_box);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.nom_plat_box);
            this.Controls.Add(this.retour_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plats";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gestion des plats";
            ((System.ComponentModel.ISupportInitialize)(this.plat_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button retour_btn;
        private MetroFramework.Controls.MetroButton supprimer_btn;
        private MetroFramework.Controls.MetroButton modif_btn;
        private MetroFramework.Controls.MetroButton vider_btn;
        private MetroFramework.Controls.MetroButton Ajouter_btn;
        private MetroFramework.Controls.MetroComboBox disponible_combo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox categorie_box;
        private MetroFramework.Controls.MetroTextBox code_plat_box;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox filtre_combobox;
        private MetroFramework.Controls.MetroGrid plat_grid;
        private MetroFramework.Controls.MetroTextBox prix_plat_box;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox nom_plat_box;
    }
}