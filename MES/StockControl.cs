using System;
using System.Data;
using System.Windows.Forms;

namespace MES
{
    public partial class StockControl : UserControl
    {
        public StockControl()
        {
            InitializeComponent();
        }

        private void StockControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadInventoryData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            string latestFile = CsvFileHelper.GetLatestCsvFile("inventory_data_*.csv");

            if (string.IsNullOrEmpty(latestFile))
            {
                dgvInventoryData.DataSource = null;
                return;
            }

            DataTable dt = CsvFileHelper.LoadCsvToDataTable(latestFile);
            dgvInventoryData.DataSource = dt;

            if (dgvInventoryData.Rows.Count > 0)
            {
                dgvInventoryData.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 250, 244);
            }
        }
    }
}