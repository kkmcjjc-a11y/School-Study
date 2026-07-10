namespace Test4
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
            this.btnState = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(817, 272);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(283, 198);
            this.btnState.TabIndex = 0;
            this.btnState.Text = "상황 확인하기";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "시그널 타워 색깔";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "빨강",
            "주황",
            "초록"});
            this.cboColor.Location = new System.Drawing.Point(303, 386);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(461, 29);
            this.cboColor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 1193);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboColor;
    }
}

