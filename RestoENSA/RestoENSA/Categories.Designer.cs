namespace RestoENSA
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.categorie_nom_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Categorie_grid = new MetroFramework.Controls.MetroGrid();
            this.categorie_code_box = new MetroFramework.Controls.MetroTextBox();
            this.retour_btn = new System.Windows.Forms.Button();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.modif_btn = new MetroFramework.Controls.MetroButton();
            this.vider_btn = new MetroFramework.Controls.MetroButton();
            this.Ajouter_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Categorie_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // categorie_nom_box
            // 
            // 
            // 
            // 
            this.categorie_nom_box.CustomButton.Image = null;
            this.categorie_nom_box.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.categorie_nom_box.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.categorie_nom_box.CustomButton.Name = "";
            this.categorie_nom_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.categorie_nom_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categorie_nom_box.CustomButton.TabIndex = 1;
            this.categorie_nom_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categorie_nom_box.CustomButton.UseSelectable = true;
            this.categorie_nom_box.CustomButton.Visible = false;
            this.categorie_nom_box.Lines = new string[0];
            this.categorie_nom_box.Location = new System.Drawing.Point(211, 200);
            this.categorie_nom_box.Margin = new System.Windows.Forms.Padding(5);
            this.categorie_nom_box.MaxLength = 32767;
            this.categorie_nom_box.Name = "categorie_nom_box";
            this.categorie_nom_box.PasswordChar = '\0';
            this.categorie_nom_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categorie_nom_box.SelectedText = "";
            this.categorie_nom_box.SelectionLength = 0;
            this.categorie_nom_box.SelectionStart = 0;
            this.categorie_nom_box.ShortcutsEnabled = true;
            this.categorie_nom_box.Size = new System.Drawing.Size(271, 28);
            this.categorie_nom_box.TabIndex = 0;
            this.categorie_nom_box.UseSelectable = true;
            this.categorie_nom_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categorie_nom_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(32, 200);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 20);
            this.metroLabel1.TabIndex = 86;
            this.metroLabel1.Text = "Nom catégorie";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // Categorie_grid
            // 
            this.Categorie_grid.AllowUserToOrderColumns = true;
            this.Categorie_grid.AllowUserToResizeRows = false;
            this.Categorie_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Categorie_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Categorie_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Categorie_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Categorie_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Categorie_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Categorie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Categorie_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Categorie_grid.EnableHeadersVisualStyles = false;
            this.Categorie_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Categorie_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Categorie_grid.Location = new System.Drawing.Point(518, 78);
            this.Categorie_grid.Margin = new System.Windows.Forms.Padding(4);
            this.Categorie_grid.Name = "Categorie_grid";
            this.Categorie_grid.ReadOnly = true;
            this.Categorie_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Categorie_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Categorie_grid.RowHeadersWidth = 51;
            this.Categorie_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Categorie_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Categorie_grid.Size = new System.Drawing.Size(714, 332);
            this.Categorie_grid.Style = MetroFramework.MetroColorStyle.Orange;
            this.Categorie_grid.TabIndex = 5;
            this.Categorie_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Categorie_grid_CellClick);
            // 
            // categorie_code_box
            // 
            this.categorie_code_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.categorie_code_box.CustomButton.Image = null;
            this.categorie_code_box.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.categorie_code_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.categorie_code_box.CustomButton.Name = "";
            this.categorie_code_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.categorie_code_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categorie_code_box.CustomButton.TabIndex = 1;
            this.categorie_code_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categorie_code_box.CustomButton.UseSelectable = true;
            this.categorie_code_box.CustomButton.Visible = false;
            this.categorie_code_box.Enabled = false;
            this.categorie_code_box.Lines = new string[0];
            this.categorie_code_box.Location = new System.Drawing.Point(211, 112);
            this.categorie_code_box.Margin = new System.Windows.Forms.Padding(5);
            this.categorie_code_box.MaxLength = 32767;
            this.categorie_code_box.Name = "categorie_code_box";
            this.categorie_code_box.PasswordChar = '\0';
            this.categorie_code_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categorie_code_box.SelectedText = "";
            this.categorie_code_box.SelectionLength = 0;
            this.categorie_code_box.SelectionStart = 0;
            this.categorie_code_box.ShortcutsEnabled = true;
            this.categorie_code_box.Size = new System.Drawing.Size(271, 28);
            this.categorie_code_box.TabIndex = 82;
            this.categorie_code_box.UseCustomBackColor = true;
            this.categorie_code_box.UseSelectable = true;
            this.categorie_code_box.Visible = false;
            this.categorie_code_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categorie_code_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(21, 75);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 6;
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
            this.supprimer_btn.Location = new System.Drawing.Point(274, 288);
            this.supprimer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(50, 59);
            this.supprimer_btn.Style = MetroFramework.MetroColorStyle.White;
            this.supprimer_btn.TabIndex = 3;
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
            this.modif_btn.Location = new System.Drawing.Point(195, 284);
            this.modif_btn.Margin = new System.Windows.Forms.Padding(4);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(61, 63);
            this.modif_btn.Style = MetroFramework.MetroColorStyle.White;
            this.modif_btn.TabIndex = 2;
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
            this.vider_btn.Location = new System.Drawing.Point(339, 284);
            this.vider_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vider_btn.Name = "vider_btn";
            this.vider_btn.Size = new System.Drawing.Size(51, 63);
            this.vider_btn.Style = MetroFramework.MetroColorStyle.White;
            this.vider_btn.TabIndex = 4;
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
            this.Ajouter_btn.Location = new System.Drawing.Point(120, 284);
            this.Ajouter_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(60, 63);
            this.Ajouter_btn.Style = MetroFramework.MetroColorStyle.White;
            this.Ajouter_btn.TabIndex = 1;
            this.Ajouter_btn.UseCustomBackColor = true;
            this.Ajouter_btn.UseCustomForeColor = true;
            this.Ajouter_btn.UseSelectable = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.Ajouter_btn_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 439);
            this.ControlBox = false;
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.modif_btn);
            this.Controls.Add(this.vider_btn);
            this.Controls.Add(this.Ajouter_btn);
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.categorie_nom_box);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Categorie_grid);
            this.Controls.Add(this.categorie_code_box);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Categories";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Gestion des catégories des plats";
            ((System.ComponentModel.ISupportInitialize)(this.Categorie_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox categorie_nom_box;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid Categorie_grid;
        private MetroFramework.Controls.MetroTextBox categorie_code_box;
        private System.Windows.Forms.Button retour_btn;
        private MetroFramework.Controls.MetroButton supprimer_btn;
        private MetroFramework.Controls.MetroButton modif_btn;
        private MetroFramework.Controls.MetroButton vider_btn;
        private MetroFramework.Controls.MetroButton Ajouter_btn;
    }
}