using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MES
{
    public partial class QualityControl : UserControl
    {
        // 타겟 CSV 파일 경로 정의
        private readonly string csvFilePath = @"C:\Users\메카트로닉스\Desktop\PC-Based Control 1.1.1K\SystemSW\PCB_controlPLC\bin\x64\Debug\quality_data.csv";

        public QualityControl()
        {
            InitializeComponent();
        }

        private void QualityControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadQualityData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadQualityData();
        }

        private void LoadQualityData()
        {
            string latestFile = CsvFileHelper.GetLatestCsvFile("quality_data_*.csv");

            if (string.IsNullOrEmpty(latestFile))
            {
                dgvQualityData.DataSource = null;
                ClearChart();
                ResetAnalysisLabels();
                return;
            }

            DataTable dt = CsvFileHelper.LoadCsvToDataTable(latestFile);
            dgvQualityData.DataSource = dt;

            if (dgvQualityData.Rows.Count > 0)
            {
                dgvQualityData.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 242, 242);
            }

            // 새 구조에 맞춘 차트 및 대시보드 업데이트
            BindChartData(dt);
            AnalyzeQualityData(dt);
        }

        private void ClearChart()
        {
            if (chartQuality.Series.Count > 0)
            {
                foreach (var series in chartQuality.Series)
                {
                    series.Points.Clear();
                }
            }
        }

        private void ResetAnalysisLabels()
        {
            lblValueTotal.Text = "0";      // 총 사이클수
            lblValueYield.Text = "0.0%";    // 평균 Steel 제거율
            lblValueFailRate.Text = "0";    // Steel 감지 합계
            lblValueStatus.Text = "-";      // 품질 판정
            lblValueStatus.ForeColor = System.Drawing.Color.DimGray;
        }

        private void BindChartData(DataTable dt)
        {
            ClearChart();

            // 계획서 적용: 3개 시리즈에서 'Steel제거율 추이' 1개 시리즈 구조로 간소화 및 맵핑 변경
            if (chartQuality.Series.Count > 0)
            {
                // 기존 불필요해진 시리즈 명칭 및 설정을 코드로 동적 조정
                chartQuality.Series[0].Name = "Steel제거율(%)";
                chartQuality.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                // 남은 기존 2개 시리즈 제거/비활성화 처리
                while (chartQuality.Series.Count > 1)
                {
                    chartQuality.Series.RemoveAt(1);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                string rawTime = row["기록시각"]?.ToString() ?? "";
                string displayTime = rawTime.Length >= 19 ? rawTime.Substring(11, 8) : rawTime;

                // 새 컬럼명 'Steel제거율(%)' 기준 파싱
                double removalRate = double.TryParse(row["Steel제거율(%)"]?.ToString(), out double r) ? r : 0;

                chartQuality.Series["Steel제거율(%)"].Points.AddXY(displayTime, removalRate);
            }
        }

        private void AnalyzeQualityData(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                ResetAnalysisLabels();
                return;
            }

            try
            {
                int totalCycles = dt.Rows.Count; // 총 사이클수
                double totalRemovalRateSum = 0;
                int totalSteelDetected = 0;

                foreach (DataRow row in dt.Rows)
                {
                    totalRemovalRateSum += double.TryParse(row["Steel제거율(%)"]?.ToString(), out double r) ? r : 0;
                    totalSteelDetected += int.TryParse(row["Steel감지"]?.ToString(), out int s) ? s : 0;
                }

                double avgRemovalRate = totalCycles > 0 ? (totalRemovalRateSum / totalCycles) : 0;

                // UI 라벨 매핑 업데이트 (계획서 기준 변경 사항 반영)
                lblTitleTotal.Text = "총 사이클수";
                lblValueTotal.Text = totalCycles.ToString("N0");

                lblTitleYield.Text = "평균 Steel제거율";
                lblValueYield.Text = avgRemovalRate.ToString("F1") + "%";

                lblTitleFailRate.Text = "Steel감지 합계";
                lblValueFailRate.Text = totalSteelDetected.ToString("N0");

                // 제거율 기준 품질 상태 판정
                if (avgRemovalRate >= 95.0)
                {
                    lblValueStatus.Text = "우수";
                    lblValueStatus.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
                }
                else if (avgRemovalRate >= 85.0)
                {
                    lblValueStatus.Text = "보통";
                    lblValueStatus.ForeColor = System.Drawing.Color.FromArgb(243, 156, 18);
                }
                else
                {
                    lblValueStatus.Text = "품질 경고";
                    lblValueStatus.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
                }
            }
            catch
            {
                ResetAnalysisLabels();
            }
        }
    }
}