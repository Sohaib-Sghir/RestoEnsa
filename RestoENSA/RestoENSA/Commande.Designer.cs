namespace RestoENSA
{
    partial class Commande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commande));
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.facture_box = new MetroFramework.Controls.MetroComboBox();
            this.generer_facture_tile = new MetroFramework.Controls.MetroTile();
            this.total_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.quantite_num = new System.Windows.Forms.NumericUpDown();
            this.plat_box = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.categorie_box = new MetroFramework.Controls.MetroComboBox();
            this.Commande_grid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.id_table_box = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.filtre_combobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.code_cmd_box = new MetroFramework.Controls.MetroTextBox();
            this.retour_btn = new System.Windows.Forms.Button();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.modif_btn = new MetroFramework.Controls.MetroButton();
            this.vider_btn = new MetroFramework.Controls.MetroButton();
            this.confirmer_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.quantite_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commande_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(559, 518);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 20);
            this.metroLabel4.TabIndex = 77;
            this.metroLabel4.Text = "N° de table";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // facture_box
            // 
            this.facture_box.FormattingEnabled = true;
            this.facture_box.ItemHeight = 24;
            this.facture_box.Items.AddRange(new object[] {
            " "});
            this.facture_box.Location = new System.Drawing.Point(684, 518);
            this.facture_box.Margin = new System.Windows.Forms.Padding(4);
            this.facture_box.Name = "facture_box";
            this.facture_box.Size = new System.Drawing.Size(185, 30);
            this.facture_box.TabIndex = 10;
            this.facture_box.UseSelectable = true;
            this.facture_box.SelectedIndexChanged += new System.EventHandler(this.facture_box_SelectedIndexChanged);
            // 
            // generer_facture_tile
            // 
            this.generer_facture_tile.ActiveControl = null;
            this.generer_facture_tile.Location = new System.Drawing.Point(948, 518);
            this.generer_facture_tile.Name = "generer_facture_tile";
            this.generer_facture_tile.Size = new System.Drawing.Size(240, 68);
            this.generer_facture_tile.TabIndex = 12;
            this.generer_facture_tile.Text = "Générer la facture";
            this.generer_facture_tile.UseSelectable = true;
            this.generer_facture_tile.Click += new System.EventHandler(this.generer_facture_tile_Click);
            // 
            // total_txt
            // 
            // 
            // 
            // 
            this.total_txt.CustomButton.Image = null;
            this.total_txt.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.total_txt.CustomButton.Name = "";
            this.total_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.total_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.total_txt.CustomButton.TabIndex = 1;
            this.total_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total_txt.CustomButton.UseSelectable = true;
            this.total_txt.CustomButton.Visible = false;
            this.total_txt.Enabled = false;
            this.total_txt.Lines = new string[0];
            this.total_txt.Location = new System.Drawing.Point(684, 563);
            this.total_txt.MaxLength = 32767;
            this.total_txt.Name = "total_txt";
            this.total_txt.PasswordChar = '\0';
            this.total_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total_txt.SelectedText = "";
            this.total_txt.SelectionLength = 0;
            this.total_txt.SelectionStart = 0;
            this.total_txt.ShortcutsEnabled = true;
            this.total_txt.Size = new System.Drawing.Size(185, 23);
            this.total_txt.TabIndex = 11;
            this.total_txt.UseSelectable = true;
            this.total_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.total_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(559, 563);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 20);
            this.metroLabel5.TabIndex = 80;
            this.metroLabel5.Text = "Total";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(872, 565);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 20);
            this.metroLabel6.TabIndex = 81;
            this.metroLabel6.Text = "DH";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(52, 264);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 20);
            this.metroLabel3.TabIndex = 99;
            this.metroLabel3.Text = "Quantité";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // quantite_num
            // 
            this.quantite_num.Location = new System.Drawing.Point(221, 264);
            this.quantite_num.Name = "quantite_num";
            this.quantite_num.Size = new System.Drawing.Size(222, 22);
            this.quantite_num.TabIndex = 2;
            // 
            // plat_box
            // 
            this.plat_box.FormattingEnabled = true;
            this.plat_box.ItemHeight = 24;
            this.plat_box.Items.AddRange(new object[] {
            " "});
            this.plat_box.Location = new System.Drawing.Point(221, 216);
            this.plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.plat_box.Name = "plat_box";
            this.plat_box.Size = new System.Drawing.Size(222, 30);
            this.plat_box.TabIndex = 1;
            this.plat_box.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(52, 168);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 20);
            this.metroLabel2.TabIndex = 94;
            this.metroLabel2.Text = "Catégorie";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // categorie_box
            // 
            this.categorie_box.FormattingEnabled = true;
            this.categorie_box.ItemHeight = 24;
            this.categorie_box.Items.AddRange(new object[] {
            " "});
            this.categorie_box.Location = new System.Drawing.Point(221, 168);
            this.categorie_box.Margin = new System.Windows.Forms.Padding(4);
            this.categorie_box.Name = "categorie_box";
            this.categorie_box.Size = new System.Drawing.Size(224, 30);
            this.categorie_box.TabIndex = 0;
            this.categorie_box.UseSelectable = true;
            this.categorie_box.SelectedIndexChanged += new System.EventHandler(this.categorie_box_SelectedIndexChanged);
            // 
            // Commande_grid
            // 
            this.Commande_grid.AllowUserToOrderColumns = true;
            this.Commande_grid.AllowUserToResizeRows = false;
            this.Commande_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Commande_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Commande_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Commande_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Commande_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Commande_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Commande_grid.EnableHeadersVisualStyles = false;
            this.Commande_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Commande_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Commande_grid.Location = new System.Drawing.Point(478, 127);
            this.Commande_grid.Margin = new System.Windows.Forms.Padding(4);
            this.Commande_grid.Name = "Commande_grid";
            this.Commande_grid.ReadOnly = true;
            this.Commande_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Commande_grid.RowHeadersWidth = 51;
            this.Commande_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Commande_grid.RowTemplate.Height = 25;
            this.Commande_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Commande_grid.Size = new System.Drawing.Size(705, 357);
            this.Commande_grid.Style = MetroFramework.MetroColorStyle.Green;
            this.Commande_grid.TabIndex = 9;
            this.Commande_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commande_grid_CellClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(52, 305);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 20);
            this.metroLabel1.TabIndex = 92;
            this.metroLabel1.Text = "N° de table";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // id_table_box
            // 
            this.id_table_box.FormattingEnabled = true;
            this.id_table_box.ItemHeight = 24;
            this.id_table_box.Items.AddRange(new object[] {
            " "});
            this.id_table_box.Location = new System.Drawing.Point(221, 305);
            this.id_table_box.Margin = new System.Windows.Forms.Padding(4);
            this.id_table_box.Name = "id_table_box";
            this.id_table_box.Size = new System.Drawing.Size(222, 30);
            this.id_table_box.TabIndex = 3;
            this.id_table_box.UseSelectable = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel22.Location = new System.Drawing.Point(756, 89);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(155, 20);
            this.metroLabel22.TabIndex = 88;
            this.metroLabel22.Text = "Commande par table";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // filtre_combobox
            // 
            this.filtre_combobox.FormattingEnabled = true;
            this.filtre_combobox.ItemHeight = 24;
            this.filtre_combobox.Items.AddRange(new object[] {
            " "});
            this.filtre_combobox.Location = new System.Drawing.Point(984, 89);
            this.filtre_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.filtre_combobox.Name = "filtre_combobox";
            this.filtre_combobox.Size = new System.Drawing.Size(199, 30);
            this.filtre_combobox.TabIndex = 8;
            this.filtre_combobox.UseSelectable = true;
            this.filtre_combobox.SelectedIndexChanged += new System.EventHandler(this.filtre_combobox_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel15.Location = new System.Drawing.Point(52, 216);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(34, 20);
            this.metroLabel15.TabIndex = 85;
            this.metroLabel15.Text = "Plat";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // code_cmd_box
            // 
            this.code_cmd_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.code_cmd_box.CustomButton.Image = null;
            this.code_cmd_box.CustomButton.Location = new System.Drawing.Point(198, 2);
            this.code_cmd_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.code_cmd_box.CustomButton.Name = "";
            this.code_cmd_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.code_cmd_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code_cmd_box.CustomButton.TabIndex = 1;
            this.code_cmd_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code_cmd_box.CustomButton.UseSelectable = true;
            this.code_cmd_box.CustomButton.Visible = false;
            this.code_cmd_box.Enabled = false;
            this.code_cmd_box.Lines = new string[0];
            this.code_cmd_box.Location = new System.Drawing.Point(208, 93);
            this.code_cmd_box.Margin = new System.Windows.Forms.Padding(4);
            this.code_cmd_box.MaxLength = 32767;
            this.code_cmd_box.Name = "code_cmd_box";
            this.code_cmd_box.PasswordChar = '\0';
            this.code_cmd_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code_cmd_box.SelectedText = "";
            this.code_cmd_box.SelectionLength = 0;
            this.code_cmd_box.SelectionStart = 0;
            this.code_cmd_box.ShortcutsEnabled = true;
            this.code_cmd_box.Size = new System.Drawing.Size(224, 28);
            this.code_cmd_box.TabIndex = 84;
            this.code_cmd_box.UseCustomBackColor = true;
            this.code_cmd_box.UseSelectable = true;
            this.code_cmd_box.Visible = false;
            this.code_cmd_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code_cmd_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(30, 76);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 13;
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
            this.supprimer_btn.Location = new System.Drawing.Point(266, 378);
            this.supprimer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(50, 63);
            this.supprimer_btn.Style = MetroFramework.MetroColorStyle.White;
            this.supprimer_btn.TabIndex = 6;
            this.supprimer_btn.UseCustomBackColor = true;
            this.supprimer_btn.UseCustomForeColor = true;
            this.supprimer_btn.UseSelectable = true;
            this.supprimer_btn.Click += new System.EventHandler(this.Supprimer_Cmd_Button);
            // 
            // modif_btn
            // 
            this.modif_btn.BackColor = System.Drawing.Color.Transparent;
            this.modif_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modif_btn.BackgroundImage")));
            this.modif_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modif_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.modif_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.modif_btn.Highlight = true;
            this.modif_btn.Location = new System.Drawing.Point(187, 378);
            this.modif_btn.Margin = new System.Windows.Forms.Padding(4);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(61, 63);
            this.modif_btn.Style = MetroFramework.MetroColorStyle.White;
            this.modif_btn.TabIndex = 5;
            this.modif_btn.UseCustomBackColor = true;
            this.modif_btn.UseCustomForeColor = true;
            this.modif_btn.UseSelectable = true;
            this.modif_btn.Click += new System.EventHandler(this.Modifier_Cmd_Click);
            // 
            // vider_btn
            // 
            this.vider_btn.BackColor = System.Drawing.Color.Transparent;
            this.vider_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vider_btn.BackgroundImage")));
            this.vider_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vider_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.vider_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.vider_btn.Highlight = true;
            this.vider_btn.Location = new System.Drawing.Point(331, 378);
            this.vider_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vider_btn.Name = "vider_btn";
            this.vider_btn.Size = new System.Drawing.Size(51, 63);
            this.vider_btn.Style = MetroFramework.MetroColorStyle.White;
            this.vider_btn.TabIndex = 7;
            this.vider_btn.UseCustomBackColor = true;
            this.vider_btn.UseCustomForeColor = true;
            this.vider_btn.UseSelectable = true;
            this.vider_btn.Click += new System.EventHandler(this.Vider_Champs);
            // 
            // confirmer_btn
            // 
            this.confirmer_btn.BackColor = System.Drawing.Color.Transparent;
            this.confirmer_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmer_btn.BackgroundImage")));
            this.confirmer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.confirmer_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.confirmer_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.confirmer_btn.Highlight = true;
            this.confirmer_btn.Location = new System.Drawing.Point(112, 378);
            this.confirmer_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmer_btn.Name = "confirmer_btn";
            this.confirmer_btn.Size = new System.Drawing.Size(60, 63);
            this.confirmer_btn.Style = MetroFramework.MetroColorStyle.White;
            this.confirmer_btn.TabIndex = 4;
            this.confirmer_btn.UseCustomBackColor = true;
            this.confirmer_btn.UseCustomForeColor = true;
            this.confirmer_btn.UseSelectable = true;
            this.confirmer_btn.Click += new System.EventHandler(this.Confirmer_Click);
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 615);
            this.ControlBox = false;
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.modif_btn);
            this.Controls.Add(this.vider_btn);
            this.Controls.Add(this.confirmer_btn);
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.quantite_num);
            this.Controls.Add(this.plat_box);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.categorie_box);
            this.Controls.Add(this.Commande_grid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.id_table_box);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.filtre_combobox);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.code_cmd_box);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.generer_facture_tile);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.facture_box);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Commande";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantite_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commande_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox facture_box;
        private MetroFramework.Controls.MetroTile generer_facture_tile;
        private MetroFramework.Controls.MetroTextBox total_txt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown quantite_num;
        private MetroFramework.Controls.MetroComboBox plat_box;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox categorie_box;
        private MetroFramework.Controls.MetroGrid Commande_grid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox id_table_box;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox filtre_combobox;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox code_cmd_box;
        private System.Windows.Forms.Button retour_btn;
        private MetroFramework.Controls.MetroButton supprimer_btn;
        private MetroFramework.Controls.MetroButton modif_btn;
        private MetroFramework.Controls.MetroButton vider_btn;
        private MetroFramework.Controls.MetroButton confirmer_btn;
    }
}