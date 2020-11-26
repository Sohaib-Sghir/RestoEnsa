namespace RestoENSA
{
    partial class Report
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
            this.factureViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FactureReport1 = new RestoENSA.FactureReport();
            this.SuspendLayout();
            // 
            // factureViewer
            // 
            this.factureViewer.ActiveViewIndex = -1;
            this.factureViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.factureViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.factureViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factureViewer.Location = new System.Drawing.Point(20, 60);
            this.factureViewer.Name = "factureViewer";
            this.factureViewer.Size = new System.Drawing.Size(925, 435);
            this.factureViewer.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 515);
            this.Controls.Add(this.factureViewer);
            this.Name = "Report";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer factureViewer;
        private FactureReport FactureReport1;
    }
}