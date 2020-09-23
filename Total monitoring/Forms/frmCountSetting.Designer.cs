namespace Total_monitoring.Forms
{
    partial class frmCountSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnChangeRecord = new System.Windows.Forms.Button();
            this.btnDelRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtboxKeyWidthMax2 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxKeyWidthMin2 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxKeyWidthMax1 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxKeyWidthMin1 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxThicknessMax = new System.Windows.Forms.MaskedTextBox();
            this.mtboxThicknessMin = new System.Windows.Forms.MaskedTextBox();
            this.mtboxInnerMax2 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxInnerMin2 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxInnerMax1 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxInnerMin1 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxOuterMax2 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxOuterMin2 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxOuterMax1 = new System.Windows.Forms.MaskedTextBox();
            this.mtboxOuterMin1 = new System.Windows.Forms.MaskedTextBox();
            this.tboxRecordName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnd.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btnEnd.Location = new System.Drawing.Point(685, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(103, 48);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "종 료";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddRecord.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddRecord.Location = new System.Drawing.Point(12, 12);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(103, 48);
            this.btnAddRecord.TabIndex = 3;
            this.btnAddRecord.Text = "추 가";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnChangeRecord
            // 
            this.btnChangeRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeRecord.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btnChangeRecord.Location = new System.Drawing.Point(121, 12);
            this.btnChangeRecord.Name = "btnChangeRecord";
            this.btnChangeRecord.Size = new System.Drawing.Size(103, 48);
            this.btnChangeRecord.TabIndex = 4;
            this.btnChangeRecord.Text = "수 정";
            this.btnChangeRecord.UseVisualStyleBackColor = false;
            this.btnChangeRecord.Click += new System.EventHandler(this.btnChangeRecord_Click);
            // 
            // btnDelRecord
            // 
            this.btnDelRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelRecord.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btnDelRecord.Location = new System.Drawing.Point(230, 12);
            this.btnDelRecord.Name = "btnDelRecord";
            this.btnDelRecord.Size = new System.Drawing.Size(103, 48);
            this.btnDelRecord.TabIndex = 5;
            this.btnDelRecord.Text = "삭 제";
            this.btnDelRecord.UseVisualStyleBackColor = false;
            this.btnDelRecord.Click += new System.EventHandler(this.btnDelRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtboxKeyWidthMax2);
            this.groupBox1.Controls.Add(this.mtboxKeyWidthMin2);
            this.groupBox1.Controls.Add(this.mtboxKeyWidthMax1);
            this.groupBox1.Controls.Add(this.mtboxKeyWidthMin1);
            this.groupBox1.Controls.Add(this.mtboxThicknessMax);
            this.groupBox1.Controls.Add(this.mtboxThicknessMin);
            this.groupBox1.Controls.Add(this.mtboxInnerMax2);
            this.groupBox1.Controls.Add(this.mtboxInnerMin2);
            this.groupBox1.Controls.Add(this.mtboxInnerMax1);
            this.groupBox1.Controls.Add(this.mtboxInnerMin1);
            this.groupBox1.Controls.Add(this.mtboxOuterMax2);
            this.groupBox1.Controls.Add(this.mtboxOuterMin2);
            this.groupBox1.Controls.Add(this.mtboxOuterMax1);
            this.groupBox1.Controls.Add(this.mtboxOuterMin1);
            this.groupBox1.Controls.Add(this.tboxRecordName);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelData);
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 379);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 레코드";
            // 
            // mtboxKeyWidthMax2
            // 
            this.mtboxKeyWidthMax2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxKeyWidthMax2.Location = new System.Drawing.Point(286, 336);
            this.mtboxKeyWidthMax2.Mask = "0.000";
            this.mtboxKeyWidthMax2.Name = "mtboxKeyWidthMax2";
            this.mtboxKeyWidthMax2.ResetOnSpace = false;
            this.mtboxKeyWidthMax2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxKeyWidthMax2.Size = new System.Drawing.Size(120, 30);
            this.mtboxKeyWidthMax2.TabIndex = 63;
            this.mtboxKeyWidthMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxKeyWidthMin2
            // 
            this.mtboxKeyWidthMin2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxKeyWidthMin2.Location = new System.Drawing.Point(128, 336);
            this.mtboxKeyWidthMin2.Mask = "0.000";
            this.mtboxKeyWidthMin2.Name = "mtboxKeyWidthMin2";
            this.mtboxKeyWidthMin2.ResetOnSpace = false;
            this.mtboxKeyWidthMin2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxKeyWidthMin2.Size = new System.Drawing.Size(120, 30);
            this.mtboxKeyWidthMin2.TabIndex = 62;
            this.mtboxKeyWidthMin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxKeyWidthMax1
            // 
            this.mtboxKeyWidthMax1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxKeyWidthMax1.Location = new System.Drawing.Point(286, 306);
            this.mtboxKeyWidthMax1.Mask = "0.000";
            this.mtboxKeyWidthMax1.Name = "mtboxKeyWidthMax1";
            this.mtboxKeyWidthMax1.ResetOnSpace = false;
            this.mtboxKeyWidthMax1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxKeyWidthMax1.Size = new System.Drawing.Size(120, 30);
            this.mtboxKeyWidthMax1.TabIndex = 61;
            this.mtboxKeyWidthMax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxKeyWidthMin1
            // 
            this.mtboxKeyWidthMin1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxKeyWidthMin1.Location = new System.Drawing.Point(128, 306);
            this.mtboxKeyWidthMin1.Mask = "0.000";
            this.mtboxKeyWidthMin1.Name = "mtboxKeyWidthMin1";
            this.mtboxKeyWidthMin1.ResetOnSpace = false;
            this.mtboxKeyWidthMin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxKeyWidthMin1.Size = new System.Drawing.Size(120, 30);
            this.mtboxKeyWidthMin1.TabIndex = 60;
            this.mtboxKeyWidthMin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxThicknessMax
            // 
            this.mtboxThicknessMax.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxThicknessMax.Location = new System.Drawing.Point(286, 259);
            this.mtboxThicknessMax.Mask = "0.000";
            this.mtboxThicknessMax.Name = "mtboxThicknessMax";
            this.mtboxThicknessMax.ResetOnSpace = false;
            this.mtboxThicknessMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxThicknessMax.Size = new System.Drawing.Size(120, 30);
            this.mtboxThicknessMax.TabIndex = 59;
            this.mtboxThicknessMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxThicknessMin
            // 
            this.mtboxThicknessMin.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxThicknessMin.Location = new System.Drawing.Point(128, 259);
            this.mtboxThicknessMin.Mask = "0.000";
            this.mtboxThicknessMin.Name = "mtboxThicknessMin";
            this.mtboxThicknessMin.ResetOnSpace = false;
            this.mtboxThicknessMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxThicknessMin.Size = new System.Drawing.Size(120, 30);
            this.mtboxThicknessMin.TabIndex = 58;
            this.mtboxThicknessMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxInnerMax2
            // 
            this.mtboxInnerMax2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxInnerMax2.Location = new System.Drawing.Point(286, 219);
            this.mtboxInnerMax2.Mask = "00.000";
            this.mtboxInnerMax2.Name = "mtboxInnerMax2";
            this.mtboxInnerMax2.ResetOnSpace = false;
            this.mtboxInnerMax2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxInnerMax2.Size = new System.Drawing.Size(120, 30);
            this.mtboxInnerMax2.TabIndex = 57;
            this.mtboxInnerMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxInnerMin2
            // 
            this.mtboxInnerMin2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxInnerMin2.Location = new System.Drawing.Point(128, 219);
            this.mtboxInnerMin2.Mask = "00.000";
            this.mtboxInnerMin2.Name = "mtboxInnerMin2";
            this.mtboxInnerMin2.ResetOnSpace = false;
            this.mtboxInnerMin2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxInnerMin2.Size = new System.Drawing.Size(120, 30);
            this.mtboxInnerMin2.TabIndex = 56;
            this.mtboxInnerMin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxInnerMax1
            // 
            this.mtboxInnerMax1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxInnerMax1.Location = new System.Drawing.Point(286, 189);
            this.mtboxInnerMax1.Mask = "00.000";
            this.mtboxInnerMax1.Name = "mtboxInnerMax1";
            this.mtboxInnerMax1.ResetOnSpace = false;
            this.mtboxInnerMax1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxInnerMax1.Size = new System.Drawing.Size(120, 30);
            this.mtboxInnerMax1.TabIndex = 55;
            this.mtboxInnerMax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxInnerMin1
            // 
            this.mtboxInnerMin1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxInnerMin1.Location = new System.Drawing.Point(128, 189);
            this.mtboxInnerMin1.Mask = "00.000";
            this.mtboxInnerMin1.Name = "mtboxInnerMin1";
            this.mtboxInnerMin1.ResetOnSpace = false;
            this.mtboxInnerMin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxInnerMin1.Size = new System.Drawing.Size(120, 30);
            this.mtboxInnerMin1.TabIndex = 54;
            this.mtboxInnerMin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxOuterMax2
            // 
            this.mtboxOuterMax2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxOuterMax2.Location = new System.Drawing.Point(286, 150);
            this.mtboxOuterMax2.Mask = "00.000";
            this.mtboxOuterMax2.Name = "mtboxOuterMax2";
            this.mtboxOuterMax2.ResetOnSpace = false;
            this.mtboxOuterMax2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxOuterMax2.Size = new System.Drawing.Size(120, 30);
            this.mtboxOuterMax2.TabIndex = 53;
            this.mtboxOuterMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxOuterMin2
            // 
            this.mtboxOuterMin2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxOuterMin2.Location = new System.Drawing.Point(128, 150);
            this.mtboxOuterMin2.Mask = "00.000";
            this.mtboxOuterMin2.Name = "mtboxOuterMin2";
            this.mtboxOuterMin2.ResetOnSpace = false;
            this.mtboxOuterMin2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxOuterMin2.Size = new System.Drawing.Size(120, 30);
            this.mtboxOuterMin2.TabIndex = 52;
            this.mtboxOuterMin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxOuterMax1
            // 
            this.mtboxOuterMax1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxOuterMax1.Location = new System.Drawing.Point(286, 120);
            this.mtboxOuterMax1.Mask = "00.000";
            this.mtboxOuterMax1.Name = "mtboxOuterMax1";
            this.mtboxOuterMax1.ResetOnSpace = false;
            this.mtboxOuterMax1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxOuterMax1.Size = new System.Drawing.Size(120, 30);
            this.mtboxOuterMax1.TabIndex = 51;
            this.mtboxOuterMax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtboxOuterMin1
            // 
            this.mtboxOuterMin1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.mtboxOuterMin1.Location = new System.Drawing.Point(128, 120);
            this.mtboxOuterMin1.Mask = "00.000";
            this.mtboxOuterMin1.Name = "mtboxOuterMin1";
            this.mtboxOuterMin1.ResetOnSpace = false;
            this.mtboxOuterMin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtboxOuterMin1.Size = new System.Drawing.Size(120, 30);
            this.mtboxOuterMin1.TabIndex = 50;
            this.mtboxOuterMin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxRecordName
            // 
            this.tboxRecordName.Font = new System.Drawing.Font("돋움", 22F, System.Drawing.FontStyle.Bold);
            this.tboxRecordName.Location = new System.Drawing.Point(186, 25);
            this.tboxRecordName.Name = "tboxRecordName";
            this.tboxRecordName.Size = new System.Drawing.Size(220, 41);
            this.tboxRecordName.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(255, 339);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 19);
            this.label17.TabIndex = 48;
            this.label17.Text = "~";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(255, 311);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 19);
            this.label18.TabIndex = 47;
            this.label18.Text = "~";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(255, 222);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 19);
            this.label15.TabIndex = 46;
            this.label15.Text = "~";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(255, 194);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 19);
            this.label16.TabIndex = 45;
            this.label16.Text = "~";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(255, 264);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 19);
            this.label14.TabIndex = 44;
            this.label14.Text = "~";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(255, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "~";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(255, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "~";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.TabIndex = 27;
            this.label10.Text = "키폭 2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "키폭 1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.TabIndex = 25;
            this.label9.Text = "두  께";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "내경 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "내경 1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "외경 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "외경 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelData
            // 
            this.btnCancelData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelData.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btnCancelData.Location = new System.Drawing.Point(667, 318);
            this.btnCancelData.Name = "btnCancelData";
            this.btnCancelData.Size = new System.Drawing.Size(103, 48);
            this.btnCancelData.TabIndex = 20;
            this.btnCancelData.Text = "취 소";
            this.btnCancelData.UseVisualStyleBackColor = false;
            this.btnCancelData.Click += new System.EventHandler(this.btnCancelData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveData.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveData.Location = new System.Drawing.Point(667, 264);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(103, 48);
            this.btnSaveData.TabIndex = 19;
            this.btnSaveData.Text = "저 장";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "현재 레코드";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(286, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "최대값";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(128, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "최소값";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "검사항목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvInformation.Location = new System.Drawing.Point(12, 66);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowTemplate.Height = 23;
            this.dgvInformation.Size = new System.Drawing.Size(776, 107);
            this.dgvInformation.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "레코드이름";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "외경1_최소값";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "외경1_최대값";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "외경2_최소값";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "외경2_최대값";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "내경1_최소값";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "내경1_최대값";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "내경2_최소값";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "내경2_최대값";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "두께_최소값";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "두께_최대값";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "키폭1_최소값";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "키폭1_최대값";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "키폭2_최소값";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "키폭2_최대값";
            this.Column15.Name = "Column15";
            // 
            // frmCountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelRecord);
            this.Controls.Add(this.btnChangeRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnEnd);
            this.Name = "frmCountSetting";
            this.Text = "검사기준정보등록";
            this.Load += new System.EventHandler(this.frmCountSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnChangeRecord;
        private System.Windows.Forms.Button btnDelRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelData;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.TextBox tboxRecordName;
        private System.Windows.Forms.MaskedTextBox mtboxOuterMin1;
        private System.Windows.Forms.MaskedTextBox mtboxKeyWidthMax2;
        private System.Windows.Forms.MaskedTextBox mtboxKeyWidthMin2;
        private System.Windows.Forms.MaskedTextBox mtboxKeyWidthMax1;
        private System.Windows.Forms.MaskedTextBox mtboxKeyWidthMin1;
        private System.Windows.Forms.MaskedTextBox mtboxThicknessMax;
        private System.Windows.Forms.MaskedTextBox mtboxThicknessMin;
        private System.Windows.Forms.MaskedTextBox mtboxInnerMax2;
        private System.Windows.Forms.MaskedTextBox mtboxInnerMin2;
        private System.Windows.Forms.MaskedTextBox mtboxInnerMax1;
        private System.Windows.Forms.MaskedTextBox mtboxInnerMin1;
        private System.Windows.Forms.MaskedTextBox mtboxOuterMax2;
        private System.Windows.Forms.MaskedTextBox mtboxOuterMin2;
        private System.Windows.Forms.MaskedTextBox mtboxOuterMax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}