using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Total_monitoring.Class;

namespace Total_monitoring.Forms
{
    public partial class frmCountSetting : Form
    {
        public frmCountSetting()
        {
            InitializeComponent();
        }
        private void frmCountSetting_Load(object sender, EventArgs e)
        {
            UIInit("InformationUnchange");
            iniManager.RecordName = "2";
            iniManager.LoadIniFile();
            InformationLoad();
            //DataGridView에 데이터 넣어주기
        }

        private void cboxRecord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region 버튼
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //추가 버튼 -> 현재 레코드 증가 -> 검사항목 데이터 00.000 이런식으로 초기화
            InformationInit();
            UIInit("InformationChange");
        }

        private void btnChangeRecord_Click(object sender, EventArgs e)
        {
            UIInit("InformationChange");
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            //tbox에 넣은 새로운 내용을 ini으로 저장
            InformationSave();
            iniManager.SaveIniFile();

            //UI 초기화 -> 해당 정보 초기화
            UIInit("InformationUnchange");
            InformationLoad();
        }

        private void btnCancelData_Click(object sender, EventArgs e)
        {
            //tbox에 넣은 새로운 정보는 기존 정보로 대처하고 RollBack
            iniManager.LoadIniFile();

            //UI 초기화 -> 해당 정보 초기화
            UIInit("InformationUnchange");
            InformationLoad();
        }
        #endregion

        #region 테이블 구현

        #endregion
        #region 기능구현
        private void UIInit(string sCheck)
        {
            if (sCheck == "InformationUnchange")
            {
                this.tboxRecordName.Enabled = false;

                this.mtboxOuterMin1.Enabled = false;
                this.mtboxOuterMax1.Enabled = false;
                this.mtboxOuterMin2.Enabled = false;
                this.mtboxOuterMax2.Enabled = false;

                this.mtboxInnerMin1.Enabled = false;
                this.mtboxInnerMax1.Enabled = false;
                this.mtboxInnerMin2.Enabled = false;
                this.mtboxInnerMax2.Enabled = false;

                this.mtboxThicknessMin.Enabled = false;
                this.mtboxThicknessMax.Enabled = false;

                this.mtboxKeyWidthMin1.Enabled = false;
                this.mtboxKeyWidthMax1.Enabled = false;
                this.mtboxKeyWidthMin2.Enabled = false;
                this.mtboxKeyWidthMax2.Enabled = false;

                this.btnSaveData.Enabled = false;
                this.btnCancelData.Enabled = false;
            }
            else if (sCheck == "InformationChange")
            {
                this.tboxRecordName.Enabled = true;

                this.mtboxOuterMin1.Enabled = true;
                this.mtboxOuterMax1.Enabled = true;
                this.mtboxOuterMin2.Enabled = true;
                this.mtboxOuterMax2.Enabled = true;

                this.mtboxInnerMin1.Enabled = true;
                this.mtboxInnerMax1.Enabled = true;
                this.mtboxInnerMin2.Enabled = true;
                this.mtboxInnerMax2.Enabled = true;

                this.mtboxThicknessMin.Enabled = true;
                this.mtboxThicknessMax.Enabled = true;

                this.mtboxKeyWidthMin1.Enabled = true;
                this.mtboxKeyWidthMax1.Enabled = true;
                this.mtboxKeyWidthMin2.Enabled = true;
                this.mtboxKeyWidthMax2.Enabled = true;

                this.btnSaveData.Enabled = true;
                this.btnCancelData.Enabled = true;
            }
        }
        private void InformationInit()
        {
            //불러오면 Config.ini에 저장된 정보를 화면에 출력00.
            this.tboxRecordName.Text = string.Empty;

            this.mtboxOuterMin1.Text = string.Empty;
            this.mtboxOuterMax1.Text = string.Empty;
            this.mtboxOuterMin2.Text = string.Empty;
            this.mtboxOuterMax2.Text = string.Empty;

            this.mtboxInnerMin1.Text = string.Empty;
            this.mtboxInnerMax1.Text = string.Empty;
            this.mtboxInnerMin2.Text = string.Empty;
            this.mtboxInnerMax2.Text = string.Empty;

            this.mtboxThicknessMin.Text = string.Empty;
            this.mtboxThicknessMax.Text = string.Empty;

            this.mtboxKeyWidthMin1.Text = string.Empty;
            this.mtboxKeyWidthMax1.Text = string.Empty;
            this.mtboxKeyWidthMin2.Text = string.Empty;
            this.mtboxKeyWidthMax2.Text = string.Empty;
        }
        private void InformationLoad()
        {
            //불러오면 Config.ini에 저장된 정보를 화면에 출력00.
            this.tboxRecordName.Text = iniManager.RecordName;

            this.mtboxOuterMin1.Text = iniManager.OuterMin1;
            this.mtboxOuterMax1.Text = iniManager.OuterMax1;
            this.mtboxOuterMin2.Text = iniManager.OuterMin2;
            this.mtboxOuterMax2.Text = iniManager.OuterMax2;

            this.mtboxInnerMin1.Text = iniManager.InnerMin1;
            this.mtboxInnerMax1.Text = iniManager.InnerMin1;
            this.mtboxInnerMin2.Text = iniManager.InnerMax2;
            this.mtboxInnerMax2.Text = iniManager.InnerMax2;

            this.mtboxThicknessMin.Text = iniManager.ThicknessMin;
            this.mtboxThicknessMax.Text = iniManager.ThicknessMax;

            this.mtboxKeyWidthMin1.Text = iniManager.KeyWidthMin1;
            this.mtboxKeyWidthMax1.Text = iniManager.KeyWidthMax1;
            this.mtboxKeyWidthMin2.Text = iniManager.KeyWidthMin2;
            this.mtboxKeyWidthMax2.Text = iniManager.KeyWidthMax2;
        }
        private void InformationSave()
        {
            iniManager.RecordName = this.tboxRecordName.Text;

            iniManager.OuterMin1 = this.mtboxOuterMin1.Text;
            iniManager.OuterMax1 = this.mtboxOuterMax1.Text;
            iniManager.OuterMin2 = this.mtboxOuterMin2.Text;
            iniManager.OuterMax2 = this.mtboxOuterMax2.Text;

            iniManager.InnerMin1 = this.mtboxInnerMin1.Text;
            iniManager.InnerMax1 = this.mtboxInnerMax1.Text;
            iniManager.InnerMin2 = this.mtboxInnerMin2.Text;
            iniManager.InnerMax2 = this.mtboxInnerMax2.Text;

            iniManager.ThicknessMin = this.mtboxThicknessMin.Text;
            iniManager.ThicknessMax = this.mtboxThicknessMax.Text;

            iniManager.KeyWidthMin1 = this.mtboxKeyWidthMin1.Text;
            iniManager.KeyWidthMax1 = this.mtboxKeyWidthMax1.Text;
            iniManager.KeyWidthMin2 = this.mtboxKeyWidthMin2.Text;
            iniManager.KeyWidthMax2 = this.mtboxKeyWidthMax2.Text;
        }
        #endregion

    }
}
