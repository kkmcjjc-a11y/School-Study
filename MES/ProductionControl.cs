using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MES
{
    public partial class ProductionControl : UserControl
    {
            public ProductionControl()
            {
                InitializeComponent();
            }

            private void ProductionControl_VisibleChanged(object sender, EventArgs e)
            {
                if (this.Visible)
                {
                    LoadProductionData();
                }
            }

            private void btnRefresh_Click(object sender, EventArgs e)
            {
                LoadProductionData();
            }

            private void LoadProductionData()
            {
                // 최신 파일 탐색
                string latestFile = CsvFileHelper.GetLatestCsvFile("production_data_*.csv");

                if (string.IsNullOrEmpty(latestFile))
                {
                    dgvProductionData.DataSource = null;
                    return;
                }

                // 공통 메서드로 로드 및 바인딩
                DataTable dt = CsvFileHelper.LoadCsvToDataTable(latestFile);
                dgvProductionData.DataSource = dt;

                // 계획서 규격: 짝수 행 배경색 지정을 통한 엑셀 스타일 가독성 극대화
                if (dgvProductionData.Rows.Count > 0)
                {
                    dgvProductionData.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
                }
            }
        }
    }
