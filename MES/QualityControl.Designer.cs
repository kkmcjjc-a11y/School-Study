namespace MES
{
    partial class QualityControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvQualityData = new System.Windows.Forms.DataGridView();
            this.chartQuality = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlAnalysisSummary = new System.Windows.Forms.Panel();
            this.lblValueStatus = new System.Windows.Forms.Label();
            this.lblTitleStatus = new System.Windows.Forms.Label();
            this.lblValueFailRate = new System.Windows.Forms.Label();
            this.lblTitleFailRate = new System.Windows.Forms.Label();
            this.lblValueYield = new System.Windows.Forms.Label();
            this.lblTitleYield = new System.Windows.Forms.Label();
            this.lblValueTotal = new System.Windows.Forms.Label();
            this.lblTitleTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualityData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuality)).BeginInit();
            this.pnlAnalysisSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(39, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "품질 관리";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(42, 131);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(752, 37);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "생산 공정 중 수집되는 검사 결과 및 품질 현황을 분석합니다.";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(914, 44);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(189, 61);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvQualityData
            // 
            this.dgvQualityData.AllowUserToAddRows = false;
            this.dgvQualityData.AllowUserToDeleteRows = false;
            this.dgvQualityData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvQualityData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQualityData.BackgroundColor = System.Drawing.Color.White;
            this.dgvQualityData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQualityData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQualityData.ColumnHeadersHeight = 40;
            this.dgvQualityData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQualityData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQualityData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvQualityData.Location = new System.Drawing.Point(39, 255);
            this.dgvQualityData.Margin = new System.Windows.Forms.Padding(5);
            this.dgvQualityData.Name = "dgvQualityData";
            this.dgvQualityData.ReadOnly = true;
            this.dgvQualityData.RowHeadersVisible = false;
            this.dgvQualityData.RowHeadersWidth = 51;
            this.dgvQualityData.RowTemplate.Height = 30;
            this.dgvQualityData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQualityData.Size = new System.Drawing.Size(500, 461);
            this.dgvQualityData.TabIndex = 3;
            // 
            // chartQuality
            // 
            this.chartQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartQuality.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartQuality.Legends.Add(legend1);
            this.chartQuality.Location = new System.Drawing.Point(560, 255);
            this.chartQuality.Margin = new System.Windows.Forms.Padding(5);
            this.chartQuality.Name = "chartQuality";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            series1.Legend = "Legend1";
            series1.Name = "스틸 합격";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            series2.Legend = "Legend1";
            series2.Name = "스틸 불량";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            series3.Legend = "Legend1";
            series3.Name = "플라스틱 합격";
            this.chartQuality.Series.Add(series1);
            this.chartQuality.Series.Add(series2);
            this.chartQuality.Series.Add(series3);
            this.chartQuality.Size = new System.Drawing.Size(543, 461);
            this.chartQuality.TabIndex = 4;
            this.chartQuality.Text = "품질 차트";
            // 
            // pnlAnalysisSummary
            // 
            this.pnlAnalysisSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAnalysisSummary.BackColor = System.Drawing.Color.White;
            this.pnlAnalysisSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnalysisSummary.Controls.Add(this.lblValueStatus);
            this.pnlAnalysisSummary.Controls.Add(this.lblTitleStatus);
            this.pnlAnalysisSummary.Controls.Add(this.lblValueFailRate);
            this.pnlAnalysisSummary.Controls.Add(this.lblTitleFailRate);
            this.pnlAnalysisSummary.Controls.Add(this.lblValueYield);
            this.pnlAnalysisSummary.Controls.Add(this.lblTitleYield);
            this.pnlAnalysisSummary.Controls.Add(this.lblValueTotal);
            this.pnlAnalysisSummary.Controls.Add(this.lblTitleTotal);
            this.pnlAnalysisSummary.Location = new System.Drawing.Point(39, 175);
            this.pnlAnalysisSummary.Name = "pnlAnalysisSummary";
            this.pnlAnalysisSummary.Size = new System.Drawing.Size(1063, 70);
            this.pnlAnalysisSummary.TabIndex = 5;
            // 
            // lblValueStatus
            // 
            this.lblValueStatus.AutoSize = true;
            this.lblValueStatus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblValueStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblValueStatus.Location = new System.Drawing.Point(760, 32);
            this.lblValueStatus.Name = "lblValueStatus";
            this.lblValueStatus.Size = new System.Drawing.Size(29, 38);
            this.lblValueStatus.TabIndex = 7;
            this.lblValueStatus.Text = "-";
            // 
            // lblTitleStatus
            // 
            this.lblTitleStatus.AutoSize = true;
            this.lblTitleStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleStatus.Location = new System.Drawing.Point(760, 10);
            this.lblTitleStatus.Name = "lblTitleStatus";
            this.lblTitleStatus.Size = new System.Drawing.Size(104, 30);
            this.lblTitleStatus.TabIndex = 6;
            this.lblTitleStatus.Text = "품질 판정";
            // 
            // lblValueFailRate
            // 
            this.lblValueFailRate.AutoSize = true;
            this.lblValueFailRate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblValueFailRate.ForeColor = System.Drawing.Color.Black;
            this.lblValueFailRate.Location = new System.Drawing.Point(510, 32);
            this.lblValueFailRate.Name = "lblValueFailRate";
            this.lblValueFailRate.Size = new System.Drawing.Size(81, 38);
            this.lblValueFailRate.TabIndex = 5;
            this.lblValueFailRate.Text = "0.0%";
            // 
            // lblTitleFailRate
            // 
            this.lblTitleFailRate.AutoSize = true;
            this.lblTitleFailRate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleFailRate.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleFailRate.Location = new System.Drawing.Point(510, 10);
            this.lblTitleFailRate.Name = "lblTitleFailRate";
            this.lblTitleFailRate.Size = new System.Drawing.Size(125, 30);
            this.lblTitleFailRate.TabIndex = 4;
            this.lblTitleFailRate.Text = "스틸 불량률";
            // 
            // lblValueYield
            // 
            this.lblValueYield.AutoSize = true;
            this.lblValueYield.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblValueYield.ForeColor = System.Drawing.Color.Black;
            this.lblValueYield.Location = new System.Drawing.Point(260, 32);
            this.lblValueYield.Name = "lblValueYield";
            this.lblValueYield.Size = new System.Drawing.Size(81, 38);
            this.lblValueYield.TabIndex = 3;
            this.lblValueYield.Text = "0.0%";
            // 
            // lblTitleYield
            // 
            this.lblTitleYield.AutoSize = true;
            this.lblTitleYield.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleYield.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleYield.Location = new System.Drawing.Point(260, 10);
            this.lblTitleYield.Name = "lblTitleYield";
            this.lblTitleYield.Size = new System.Drawing.Size(125, 30);
            this.lblTitleYield.TabIndex = 2;
            this.lblTitleYield.Text = "종합 합격률";
            // 
            // lblValueTotal
            // 
            this.lblValueTotal.AutoSize = true;
            this.lblValueTotal.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblValueTotal.ForeColor = System.Drawing.Color.Black;
            this.lblValueTotal.Location = new System.Drawing.Point(20, 32);
            this.lblValueTotal.Name = "lblValueTotal";
            this.lblValueTotal.Size = new System.Drawing.Size(33, 38);
            this.lblValueTotal.TabIndex = 1;
            this.lblValueTotal.Text = "0";
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleTotal.Location = new System.Drawing.Point(20, 10);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(104, 30);
            this.lblTitleTotal.TabIndex = 0;
            this.lblTitleTotal.Text = "총 검사수";
            // 
            // QualityControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlAnalysisSummary);
            this.Controls.Add(this.chartQuality);
            this.Controls.Add(this.dgvQualityData);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QualityControl";
            this.Size = new System.Drawing.Size(1147, 765);
            this.VisibleChanged += new System.EventHandler(this.QualityControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualityData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuality)).EndInit();
            this.pnlAnalysisSummary.ResumeLayout(false);
            this.pnlAnalysisSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvQualityData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuality;
        private System.Windows.Forms.Panel pnlAnalysisSummary;
        private System.Windows.Forms.Label lblTitleTotal;
        private System.Windows.Forms.Label lblValueTotal;
        private System.Windows.Forms.Label lblTitleYield;
        private System.Windows.Forms.Label lblValueYield;
        private System.Windows.Forms.Label lblTitleFailRate;
        private System.Windows.Forms.Label lblValueFailRate;
        private System.Windows.Forms.Label lblTitleStatus;
        private System.Windows.Forms.Label lblValueStatus;
    }
}
