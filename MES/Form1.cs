using System;
using System.Windows.Forms;

namespace MES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form 로드 시 기본 화면을 활성화합니다.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 실행 시 생산관리 화면을 기본 화면으로 활성화
            ShowControl(productionControl);
        }

        /// <summary>
        /// 지정된 UserControl을 맨 앞으로 가져와 화면에 표시합니다.
        /// </summary>
        private void ShowControl(UserControl control)
        {
            if (control != null)
            {
                control.Visible = true;
                control.BringToFront();
            }
        }

        /// <summary>
        /// 생산관리 버튼 클릭 시 호출됩니다.
        /// </summary>
        private void btnProduction_Click(object sender, EventArgs e)
        {
            ShowControl(productionControl);
        }

        /// <summary>
        /// 품질관리 버튼 클릭 시 호출됩니다.
        /// </summary>
        private void btnQuality_Click(object sender, EventArgs e)
        {
            ShowControl(qualityControl);
        }

        /// <summary>
        /// 재고관리 버튼 클릭 시 호출됩니다.
        /// </summary>
        private void btnStock_Click(object sender, EventArgs e)
        {
            ShowControl(stockControl);
        }
    }
}
