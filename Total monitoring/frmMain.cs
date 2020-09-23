using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Total_monitoring.Forms;
using SmithLibrary.Tools;

namespace Total_monitoring
{
    public partial class frmMain : Form
    {
        #region 변수, 생성자, Test
        //시간관련 변수
        int _iSec = 0, _iMin = 0, _iHour = 0;
        string _date;
        string _time;

        //그래프관련 변수
        public double xCount = 30;
        public double dYMaximum = 94.500;
        public double dYMinimum = 94.000;
        public double dYCenter;
        public double dInputData;

        //생성자
        Series data_series = new Series();

        //Test 변수
        Random _rdata = new Random();
        public int iTest;
        public int _iTotalCount = 0;
        public int _iChartCount = 0;
        #endregion
        #region MainForm
        public frmMain()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //타이머세팅
            tmrNow.Start();
            tmrNow.Interval = 1000;    //1초
            tmrWork.Start();
            tmrWork.Interval = 300;    //1초

            ShowSubForm();

            //차트 기본 세팅
            ChartSetting();
            DrawAllStrip();
            ChartAddSetting();


            //차트 데이터 입력 Test
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrWork.Stop();
            tmrNow.Stop();
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            //iniManager.WritePrivateProfileString("DB", "COUNT", iniManager.sDBCountNo.ToString(), iniManager.sINIPath);
        }
        #endregion
        #region 버튼(완료)
        private void btnEnd_Click(object sender, EventArgs e)
        {
            tmrWork.Stop();
            tmrNow.Stop();
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            // ini 파일에 데이터 확인
        }

        private void btnLimitSetting_Click(object sender, EventArgs e)
        {
            frmLimitSettingLoading();
        }
        
        private void btnCountSetting_Click(object sender, EventArgs e)
        {
            frmCountSettingLoading();
        }
        frmCountSetting _fls;
        private void frmLimitSettingLoading()
        {
            if (_fls != null)
            {
                _fls.Dispose();
                _fls = null;
            }
            _fls = new frmCountSetting();
            _fls.Show();
        }
        frmCountSetting _fcs;
        private void frmCountSettingLoading()
        {
            if (_fcs != null)
            {
                _fcs.Dispose();
                _fcs = null;
            }
            _fcs = new frmCountSetting();
            _fcs.Show();
        }
        #endregion
        #region 타이머
        private void tmrNow_Tick(object sender, EventArgs e)
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd");
            _time = DateTime.Now.ToString("HH:mm:ss");
            lblNow.Text = string.Format("{0}  {1}", _date, _time);
        }
        private void tmrWork_Tick(object sender, EventArgs e)
        {
            //1초에 1번 가동상태 네트워크 확인
            //pnlState01 ~ pnlState11을 체크함
            _iSec++;
            if (0 == _iSec % 1)
            {
                //1초에 그래프에 데이터 출력
                ChartAddData(_iChartCount, double.Parse((_rdata.Next((int)dYMinimum, (int)dYMaximum) + _rdata.NextDouble()).ToString("F3")));
                _iChartCount++;
                if (_iChartCount > 30)
                    ChartSettingAfter30();
            }
            if (_iSec > 59)
            {
                _iMin++;
                _iSec = 0;
                if (_iMin > 59)
                {
                    _iHour++;
                    _iMin = 0;
                    if (_iHour > 23)
                    {
                        _iHour = 0;
                    }
                }
            }

        }
        #endregion
        #region 기능구현 메소드
        //듀얼 모니터시 서브모니터 출력
        private void ShowSubForm()
        {
            Screen[] screens = Screen.AllScreens;
            if (screens.Length > 1)
            {
                SubForm subForm = new SubForm(this);
                subForm.ControlBox = false;
                subForm.Location = screens[2].Bounds.Location;  //sxreens[2]이 모니터의 위치
                //subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.StartPosition = FormStartPosition.Manual;
                subForm.WindowState = FormWindowState.Maximized;
                subForm.Show();
                return;
            }
        }
        //윈도우즈의 해상도를 가져오는 방법
        private void WindowSize()
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void ChartSetting()
        {

            dYCenter = (dYMaximum + dYMinimum) / 2;
            // chart1 컨트롤에 Collection에 있었던 내용을 삭제
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            // ChartArea 추가
            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;
            chart1.ChartAreas["Draw"].InnerPlotPosition.Height = 90;
            chart1.ChartAreas["Draw"].InnerPlotPosition.Width = 97;
            chart1.ChartAreas["Draw"].InnerPlotPosition.X = 3;
            chart1.ChartAreas["Draw"].InnerPlotPosition.Y = 1;

            // ChartArea X축과 Y축을 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisX.Maximum = 30;
            chart1.ChartAreas["Draw"].AxisX.Interval = 1;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;

            chart1.ChartAreas["Draw"].AxisY.Minimum = dYCenter - 1.000;
            chart1.ChartAreas["Draw"].AxisY.Maximum = dYCenter + 1.000;
            chart1.ChartAreas["Draw"].AxisY.Interval = 0.300;

            // 하한, 상한 설정
            lblMinData01.Text = "[하한: " + dYMinimum.ToString("F3") + "]";
            lblMaxData01.Text = "[상한: " + dYMaximum.ToString("F3") + "]";
        }
        private void ChartSettingAfter30()
        {
            // ChartArea X축과 Y축을 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum++;
            chart1.ChartAreas["Draw"].AxisX.Maximum++;
        }
        private void ChartAddSetting()
        {
            // Series 추가(Sin)    
            data_series.ChartType = SeriesChartType.Line;
            data_series.Name = "VAS";
            data_series.IsValueShownAsLabel = true;
            data_series.LabelForeColor = Color.Red;
            data_series.MarkerStyle = MarkerStyle.Circle;
            data_series.MarkerSize = 4;
            data_series.MarkerColor = Color.Red;
            data_series.IsValueShownAsLabel = false;
            chart1.Series.Add(data_series);
        }
        private void ChartAddData(int x, double y)
        {
            Push_Data(data_series, x, y);
        }
        private void Push_Data(Series series, int ixPoint, double dData)
        {
            DataPoint dp = new DataPoint(); //데이타 기록하기 정도
            dp.SetValueXY(ixPoint, dData);
            series.Points.Add(dp);
            lblCheckCount1.Text = _iTotalCount.ToString();// 검사항목 = 총계수
            lblCheckData1.Text = dData.ToString("F3");// 검사내용 = 측정데이터(Y);

            _iTotalCount++;
        }
        private void DrawAllStrip()
        {
            DrawStrip(dYCenter, Color.White);
            DrawStrip(dYMinimum, Color.Red);
            DrawStrip(dYMaximum, Color.Red);
        }
        private void DrawStrip(double dintervaloffset, Color stripcolor)
        {
            StripLine center_strip = new StripLine();
            center_strip.Interval = 0;
            center_strip.IntervalOffset = dintervaloffset;
            center_strip.StripWidth = 0.0;
            center_strip.BorderColor = stripcolor;
            center_strip.BorderDashStyle = ChartDashStyle.Solid;
            center_strip.BorderWidth = 3;

            chart1.ChartAreas["Draw"].AxisY.StripLines.Add(center_strip);

            //TextAnnotation ta = new TextAnnotation();
            //ta.AxisX = chart1.ChartAreas["Draw"].AxisX;
            //ta.AxisY = chart1.ChartAreas["Draw"].AxisY;
            //ta.IsSizeAlwaysRelative = false;
            //ta.AnchorOffsetY = dintervaloffset;
            //ta.AnchorAlignment = ContentAlignment.MiddleRight;
            //ta.Text = dintervaloffset.ToString();
            //ta.ForeColor = Color.Red;

            //chart1.Annotations.Add(ta);
        }
        #endregion
        
    }
}
