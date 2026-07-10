using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MES
{
    public partial class CsvFileHelper : Form
    {
        public CsvFileHelper()
        {
            InitializeComponent();
        }
            // 시뮬레이터 디렉토리 기본 경로 정의 (상대 경로 기준으로 설정하거나 필요시 절대 경로로 변경 가능)
            // 여기서는 기존 실행 위치(MES\bin\Debug) 대비 상대 경로 또는 절대 기준 디렉토리를 탐색하기 유연하도록 지정합니다.
        private static readonly string BaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\Users\메카트로닉스\Desktop\PC - Based Control 1.1.1K\SystemSW\Simulator\bin\Debug");

        /// <summary>
        /// 지정된 패턴에 일치하는 파일 중 가장 최근에 수정된 파일 경로를 반환합니다.
        /// </summary>
        public static string GetLatestCsvFile(string pattern)
        {
            try
            {
                // 만약 상대 경로 디렉토리가 없다면 기본 바탕화면 고정 경로 대안책 지정 (사용자 환경 맞춤)
                string targetDir = Directory.Exists(BaseDirectory) ? BaseDirectory : @"C:\Users\메카트로닉스\Desktop\PC-Based Control 1.1.1K\SystemSW\Simulator\bin\Debug";

                if (!Directory.Exists(targetDir)) return null;

                var directoryInfo = new DirectoryInfo(targetDir);
                var latestFile = directoryInfo.GetFiles(pattern)
                                              .OrderByDescending(f => f.LastWriteTime)
                                              .FirstOrDefault();

                return latestFile?.FullName;
            }
            catch
            {
                return null;
            }
        }
        

        /// <summary>
        /// CSV 파일을 안전하게 읽어 DataTable로 변환합니다. (한글 헤더 완벽 지원)
        /// </summary>
        public static DataTable LoadCsvToDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return dt;

            try
            {
                // 타 프로그램과의 파일 접근 충돌 방지를 위해 FileShare.ReadWrite 부여
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string headerLine = sr.ReadLine();
                    if (headerLine != null)
                    {
                        string[] headers = headerLine.Split(',');
                        foreach (string header in headers)
                        {
                            dt.Columns.Add(header.Trim());
                        }

                        string dataLine;
                        while ((dataLine = sr.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(dataLine)) continue;
                            string[] rows = dataLine.Split(',');

                            if (rows.Length == dt.Columns.Count)
                            {
                                dt.Rows.Add(rows);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"CSV 파일 로딩 중 오류가 발생했습니다.\n{ex.Message}", "오류", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
