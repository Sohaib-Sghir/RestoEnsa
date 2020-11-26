namespace RestoENSA
{
    partial class Calendrier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendrier));
            this.calendrier_grid = new MetroFramework.Controls.MetroGrid();
            this.calend_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.info_lbl = new MetroFramework.Controls.MetroLabel();
            this.retour_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calendrier_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // calendrier_grid
            // 
            this.calendrier_grid.AllowUserToResizeRows = false;
            this.calendrier_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendrier_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calendrier_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendrier_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.calendrier_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendrier_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.calendrier_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calendrier_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.calendrier_grid.EnableHeadersVisualStyles = false;
            this.calendrier_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.calendrier_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calendrier_grid.Location = new System.Drawing.Point(67, 189);
            this.calendrier_grid.Margin = new System.Windows.Forms.Padding(4);
            this.calendrier_grid.Name = "calendrier_grid";
            this.calendrier_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendrier_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.calendrier_grid.RowHeadersWidth = 51;
            this.calendrier_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.calendrier_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calendrier_grid.Size = new System.Drawing.Size(935, 248);
            this.calendrier_grid.Style = MetroFramework.MetroColorStyle.Green;
            this.calendrier_grid.TabIndex = 1;
            // 
            // calend_combo
            // 
            this.calend_combo.FormattingEnabled = true;
            this.calend_combo.ItemHeight = 24;
            this.calend_combo.Items.AddRange(new object[] {
            "Serveurs",
            "Chefs"});
            this.calend_combo.Location = new System.Drawing.Point(499, 78);
            this.calend_combo.Margin = new System.Windows.Forms.Padding(4);
            this.calend_combo.Name = "calend_combo";
            this.calend_combo.Size = new System.Drawing.Size(196, 30);
            this.calend_combo.TabIndex = 0;
            this.calend_combo.UseSelectable = true;
            this.calend_combo.SelectedValueChanged += new System.EventHandler(this.calend_combo_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(353, 78);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 20);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Calendrier  des :";
            // 
            // info_lbl
            // 
            this.info_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.info_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.info_lbl.Location = new System.Drawing.Point(300, 243);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(500, 30);
            this.info_lbl.Style = MetroFramework.MetroColorStyle.Purple;
            this.info_lbl.TabIndex = 25;
            this.info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info_lbl.UseCustomBackColor = true;
            this.info_lbl.UseCustomForeColor = true;
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
            this.retour_btn.TabIndex = 3;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // Calendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 490);
            this.ControlBox = false;
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.calend_combo);
            this.Controls.Add(this.calendrier_grid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calendrier";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Calendrier";
            ((System.ComponentModel.ISupportInitialize)(this.calendrier_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid calendrier_grid;
        private MetroFramework.Controls.MetroComboBox calend_combo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel info_lbl;
        private System.Windows.Forms.Button retour_btn;
    }
}