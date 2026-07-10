namespace MES
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnQuality = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.grpDisplayContainer = new System.Windows.Forms.GroupBox();
            this.productionControl = new MES.ProductionControl();
            this.qualityControl = new MES.QualityControl();
            this.stockControl = new MES.StockControl();
            this.grpDisplayContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduction
            // 
            this.btnProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnProduction.ForeColor = System.Drawing.Color.White;
            this.btnProduction.Location = new System.Drawing.Point(12, 50);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(150, 50);
            this.btnProduction.TabIndex = 0;
            this.btnProduction.Text = "생산관리";
            this.btnProduction.UseVisualStyleBackColor = false;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnQuality
            // 
            this.btnQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuality.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnQuality.ForeColor = System.Drawing.Color.White;
            this.btnQuality.Location = new System.Drawing.Point(12, 110);
            this.btnQuality.Name = "btnQuality";
            this.btnQuality.Size = new System.Drawing.Size(150, 50);
            this.btnQuality.TabIndex = 1;
            this.btnQuality.Text = "품질관리";
            this.btnQuality.UseVisualStyleBackColor = false;
            this.btnQuality.Click += new System.EventHandler(this.btnQuality_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(12, 170);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(150, 50);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "재고관리";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // grpDisplayContainer
            // 
            this.grpDisplayContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDisplayContainer.Controls.Add(this.productionControl);
            this.grpDisplayContainer.Controls.Add(this.qualityControl);
            this.grpDisplayContainer.Controls.Add(this.stockControl);
            this.grpDisplayContainer.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpDisplayContainer.Location = new System.Drawing.Point(178, 12);
            this.grpDisplayContainer.Name = "grpDisplayContainer";
            this.grpDisplayContainer.Size = new System.Drawing.Size(1192, 676);
            this.grpDisplayContainer.TabIndex = 3;
            this.grpDisplayContainer.TabStop = false;
            this.grpDisplayContainer.Text = "시스템 모니터";
            // 
            // productionControl
            // 
            this.productionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.productionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionControl.Location = new System.Drawing.Point(3, 35);
            this.productionControl.Margin = new System.Windows.Forms.Padding(5);
            this.productionControl.Name = "productionControl";
            this.productionControl.Size = new System.Drawing.Size(1186, 638);
            this.productionControl.TabIndex = 0;
            // 
            // qualityControl
            // 
            this.qualityControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.qualityControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualityControl.Location = new System.Drawing.Point(3, 35);
            this.qualityControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.qualityControl.Name = "qualityControl";
            this.qualityControl.Size = new System.Drawing.Size(1186, 638);
            this.qualityControl.TabIndex = 1;
            // 
            // stockControl
            // 
            this.stockControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.stockControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockControl.Location = new System.Drawing.Point(3, 35);
            this.stockControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stockControl.Name = "stockControl";
            this.stockControl.Size = new System.Drawing.Size(1186, 638);
            this.stockControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1398, 700);
            this.Controls.Add(this.grpDisplayContainer);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnQuality);
            this.Controls.Add(this.btnProduction);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MES (생산관리 시스템)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDisplayContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnQuality;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.GroupBox grpDisplayContainer;
        private MES.ProductionControl productionControl;
        private MES.QualityControl qualityControl;
        private MES.StockControl stockControl;
    }
}
