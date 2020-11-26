using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class Report : MetroForm
    {
        public string connectionString = DBConnect.connectionString;
        private int id_table;
        public Report(int id_table)
        {
            this.id_table = id_table;
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Commande where id_table = '" + id_table + "' and facture = 'Non facturé'", connexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                RestoDataSet ds = new RestoDataSet();
                da.Fill(ds.Commande);

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Tablee where id_table = '" + id_table + "'", connexion);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(ds.Tablee);

                FactureReport facture = new FactureReport();
                facture.SetDataSource(ds);
                factureViewer.ReportSource = facture;
                factureViewer.Refresh();       
            }
        }
    }
}
