using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_monitoring.Class
{
    public static class iniManager
    {
        #region System
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string sAppName, string sKeyName, string sDefault, StringBuilder sReturnedString, int nSize, string sFileName);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string sAppName, string sKeyName, string sValue, string sFileName);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int WritePrivateProfileInt(string sAppName, string sKeyName, int sValue, string sFileName);
        #endregion
        public static string sINIPath = Environment.CurrentDirectory + @"\Config.ini";

        #region 저장할 키값
        /// <summary>
        /// Database 레코드 데이터 값
        /// </summary>
        /// 
        public static string RecordName = string.Empty;

        public static string OuterMin1 = string.Empty;
        public static string OuterMax1 = string.Empty;
        public static string OuterMin2 = string.Empty;
        public static string OuterMax2 = string.Empty;

        public static string InnerMin1 = string.Empty;
        public static string InnerMax1 = string.Empty;
        public static string InnerMin2 = string.Empty;
        public static string InnerMax2 = string.Empty;

        public static string ThicknessMin = string.Empty;
        public static string ThicknessMax = string.Empty;

        public static string KeyWidthMin1 = string.Empty;
        public static string KeyWidthMax1 = string.Empty;
        public static string KeyWidthMin2 = string.Empty;
        public static string KeyWidthMax2 = string.Empty;
        #endregion

        public static bool bCheck = false;

        public static void LoadIniFile()
        {
            StringBuilder Buf = new StringBuilder(1024);

            GetPrivateProfileString(RecordName, "현재 레코드 이름", "sDefault", Buf, 1024, sINIPath);
            RecordName = Buf.ToString();

            GetPrivateProfileString(RecordName, "외경1 최소값", "sDefault", Buf, 1024, sINIPath);
            OuterMin1 = Buf.ToString();
            GetPrivateProfileString(RecordName, "외경1 최대값", "sDefault", Buf, 1024, sINIPath);
            OuterMax1 = Buf.ToString();
            GetPrivateProfileString(RecordName, "외경2 최소값", "sDefault", Buf, 1024, sINIPath);
            OuterMin2 = Buf.ToString();
            GetPrivateProfileString(RecordName, "외경2 최대값", "sDefault", Buf, 1024, sINIPath);
            OuterMax2 = Buf.ToString();


            GetPrivateProfileString(RecordName, "내경1 최소값", "sDefault", Buf, 1024, sINIPath);
            InnerMin1 = Buf.ToString();
            GetPrivateProfileString(RecordName, "내경1 최대값", "sDefault", Buf, 1024, sINIPath);
            InnerMax1 = Buf.ToString();
            GetPrivateProfileString(RecordName, "내경2 최소값", "sDefault", Buf, 1024, sINIPath);
            InnerMin2 = Buf.ToString();
            GetPrivateProfileString(RecordName, "내경2 최대값", "sDefault", Buf, 1024, sINIPath);
            InnerMax2 = Buf.ToString();

            GetPrivateProfileString(RecordName, "두께 최소값", "sDefault", Buf, 1024, sINIPath);
            ThicknessMin = Buf.ToString();
            GetPrivateProfileString(RecordName, "두께 최대값", "sDefault", Buf, 1024, sINIPath);
            ThicknessMax = Buf.ToString();

            GetPrivateProfileString(RecordName, "키폭1 최소값", "sDefault", Buf, 1024, sINIPath);
            KeyWidthMin1 = Buf.ToString();
            GetPrivateProfileString(RecordName, "키폭1 최대값", "sDefault", Buf, 1024, sINIPath);
            KeyWidthMax1 = Buf.ToString();
            GetPrivateProfileString(RecordName, "키폭2 최소값", "sDefault", Buf, 1024, sINIPath);
            KeyWidthMin2 = Buf.ToString();
            GetPrivateProfileString(RecordName, "키폭2 최대값", "sDefault", Buf, 1024, sINIPath);
            KeyWidthMax2 = Buf.ToString();
        }

        public static void SaveIniFile()
        {
            WritePrivateProfileString(RecordName, "현재 레코드 이름", RecordName, sINIPath);
            WritePrivateProfileString(RecordName, "외경1 최소값", OuterMin1, sINIPath);
            WritePrivateProfileString(RecordName, "외경1 최대값", OuterMax1, sINIPath);
            WritePrivateProfileString(RecordName, "외경2 최소값", OuterMin2, sINIPath);
            WritePrivateProfileString(RecordName, "외경2 최대값", OuterMax2, sINIPath);

            WritePrivateProfileString(RecordName, "내경1 최소값", InnerMin1, sINIPath);
            WritePrivateProfileString(RecordName, "내경1 최대값", InnerMax1, sINIPath);
            WritePrivateProfileString(RecordName, "내경2 최소값", InnerMin2, sINIPath);
            WritePrivateProfileString(RecordName, "내경2 최대값", InnerMax2, sINIPath);

            WritePrivateProfileString(RecordName, "두께 최소값", ThicknessMin, sINIPath);
            WritePrivateProfileString(RecordName, "두께 최대값", ThicknessMax, sINIPath);

            WritePrivateProfileString(RecordName, "키폭1 최소값", KeyWidthMin1, sINIPath);
            WritePrivateProfileString(RecordName, "키폭1 최대값", KeyWidthMax1, sINIPath);
            WritePrivateProfileString(RecordName, "키폭2 최소값", KeyWidthMin2, sINIPath);
            WritePrivateProfileString(RecordName, "키폭2 최대값", KeyWidthMax2, sINIPath);
        }

        public static void WriteUpdatingInfo(bool b)
        {
            string sVal = b == true ? "true" : "false";
            WritePrivateProfileString("UPDATE", "UPDATING", sVal, sINIPath);
        }

        public static string ReadUPdatingInfo()
        {
            StringBuilder Buf = new StringBuilder(1024);
            GetPrivateProfileString("UPDATE", "UPDATING", "", Buf, 1024, sINIPath);
            return Buf.ToString();
        }

        //중복실행 방지
        public static void IniInit()
        {
            try
            {
                string sUpdateInfo = ReadUPdatingInfo();

                WriteUpdatingInfo(false);

                if (sUpdateInfo == "true")
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmMain());
                }
                else
                {
                    int iCount = 0;

                    Process[] procs = Process.GetProcesses();
                    foreach (Process p in procs)
                    {
                        if (p.ProcessName.Equals("ISSAC") == true)
                            iCount++;
                    }
                    if (iCount > 1)
                    {
                        MessageBox.Show("이미 실행중입니다.");
                        return;
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new frmMain());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ini 파일 초기화 오류");
            }
        }
    }
}
