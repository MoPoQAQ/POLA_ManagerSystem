﻿namespace POLA_MMS.Pays_UI
{
    partial class frmPays_Add
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPays_Add));
            this.label10 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblSubtract = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmnuDetails_Bonus = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.cmnuDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvPayDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMemBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labBonus3 = new System.Windows.Forms.Label();
            this.labBonus2 = new System.Windows.Forms.Label();
            this.labBonus1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPref3 = new System.Windows.Forms.TextBox();
            this.txtPref2 = new System.Windows.Forms.TextBox();
            this.txtPref1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtProj3 = new System.Windows.Forms.TextBox();
            this.txtProj2 = new System.Windows.Forms.TextBox();
            this.txtProj1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmp2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboEmp3 = new System.Windows.Forms.ComboBox();
            this.cboEmp1 = new System.Windows.Forms.ComboBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numMoney = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMemName = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmnuDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "卡内余额：";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(77, 20);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(146, 21);
            this.txtCode.TabIndex = 2;
            // 
            // lblSubtract
            // 
            this.lblSubtract.AutoSize = true;
            this.lblSubtract.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubtract.ForeColor = System.Drawing.Color.Blue;
            this.lblSubtract.Location = new System.Drawing.Point(318, 164);
            this.lblSubtract.Name = "lblSubtract";
            this.lblSubtract.Size = new System.Drawing.Size(33, 12);
            this.lblSubtract.TabIndex = 8;
            this.lblSubtract.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "美疗师：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "消费单号：";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSum.ForeColor = System.Drawing.Color.Blue;
            this.lblSum.Location = new System.Drawing.Point(112, 164);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(33, 12);
            this.lblSum.TabIndex = 7;
            this.lblSum.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(170, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "右键单击可修改消费折扣";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(75, 59);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(504, 21);
            this.txtRemark.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(238, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "优惠金额：￥";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "最近续费：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(406, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "非会员可不用输入";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(6, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "商品消费合计：￥";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "消费时间：";
            // 
            // cmnuDetails_Bonus
            // 
            this.cmnuDetails_Bonus.Name = "cmnuDetails_Bonus";
            this.cmnuDetails_Bonus.Size = new System.Drawing.Size(180, 22);
            this.cmnuDetails_Bonus.Text = "修改折扣及价格(&M)";
            this.cmnuDetails_Bonus.Click += new System.EventHandler(this.cmnuDetails_Bonus_Click);
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayDate.Location = new System.Drawing.Point(75, 86);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(85, 21);
            this.dtpPayDate.TabIndex = 7;
            // 
            // cmnuDetails
            // 
            this.cmnuDetails.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnuDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuDetails_Bonus});
            this.cmnuDetails.Name = "cmnuDetails";
            this.cmnuDetails.Size = new System.Drawing.Size(181, 26);
            // 
            // dgvPayDetails
            // 
            this.dgvPayDetails.AllowUserToAddRows = false;
            this.dgvPayDetails.AllowUserToResizeRows = false;
            this.dgvPayDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column9,
            this.Column5});
            this.dgvPayDetails.ContextMenuStrip = this.cmnuDetails;
            this.dgvPayDetails.Location = new System.Drawing.Point(8, 40);
            this.dgvPayDetails.Name = "dgvPayDetails";
            this.dgvPayDetails.RowHeadersWidth = 62;
            this.dgvPayDetails.RowTemplate.Height = 23;
            this.dgvPayDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayDetails.Size = new System.Drawing.Size(571, 120);
            this.dgvPayDetails.TabIndex = 3;
            this.dgvPayDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPayDetails_RowPostPaint);
            this.dgvPayDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPayDetails_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SPItem.ID";
            this.Column1.HeaderText = "商品编号";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SPItem.Name";
            this.Column2.HeaderText = "商品名称";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 128;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SPItem.UnitPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "单价";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Bonused";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "折后单价";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "数量";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SumText";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "合计";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(403, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "美睫师：";
            // 
            // lblMemBalance
            // 
            this.lblMemBalance.AutoSize = true;
            this.lblMemBalance.ForeColor = System.Drawing.Color.Red;
            this.lblMemBalance.Location = new System.Drawing.Point(300, 47);
            this.lblMemBalance.Name = "lblMemBalance";
            this.lblMemBalance.Size = new System.Drawing.Size(41, 12);
            this.lblMemBalance.TabIndex = 15;
            this.lblMemBalance.Text = "￥0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "消费备注：";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.ForeColor = System.Drawing.Color.Red;
            this.lblLastTime.Location = new System.Drawing.Point(459, 47);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(41, 12);
            this.lblLastTime.TabIndex = 20;
            this.lblLastTime.Text = "无记录";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labBonus3);
            this.groupBox1.Controls.Add(this.labBonus2);
            this.groupBox1.Controls.Add(this.labBonus1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtPref3);
            this.groupBox1.Controls.Add(this.txtPref2);
            this.groupBox1.Controls.Add(this.txtPref1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtProj3);
            this.groupBox1.Controls.Add(this.txtProj2);
            this.groupBox1.Controls.Add(this.txtProj1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboEmp2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cboEmp3);
            this.groupBox1.Controls.Add(this.cboEmp1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 136);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务信息";
            // 
            // labBonus3
            // 
            this.labBonus3.AutoSize = true;
            this.labBonus3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBonus3.ForeColor = System.Drawing.Color.Blue;
            this.labBonus3.Location = new System.Drawing.Point(486, 103);
            this.labBonus3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBonus3.Name = "labBonus3";
            this.labBonus3.Size = new System.Drawing.Size(32, 17);
            this.labBonus3.TabIndex = 25;
            this.labBonus3.Text = "0.00";
            // 
            // labBonus2
            // 
            this.labBonus2.AutoSize = true;
            this.labBonus2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBonus2.ForeColor = System.Drawing.Color.Blue;
            this.labBonus2.Location = new System.Drawing.Point(285, 103);
            this.labBonus2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBonus2.Name = "labBonus2";
            this.labBonus2.Size = new System.Drawing.Size(32, 17);
            this.labBonus2.TabIndex = 24;
            this.labBonus2.Text = "0.00";
            // 
            // labBonus1
            // 
            this.labBonus1.AutoSize = true;
            this.labBonus1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBonus1.ForeColor = System.Drawing.Color.Blue;
            this.labBonus1.Location = new System.Drawing.Point(90, 103);
            this.labBonus1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBonus1.Name = "labBonus1";
            this.labBonus1.Size = new System.Drawing.Size(32, 17);
            this.labBonus1.TabIndex = 23;
            this.labBonus1.Text = "0.00";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 104);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 22;
            this.label24.Text = "提成金额：";
            // 
            // txtPref3
            // 
            this.txtPref3.Location = new System.Drawing.Point(473, 76);
            this.txtPref3.Margin = new System.Windows.Forms.Padding(2);
            this.txtPref3.Name = "txtPref3";
            this.txtPref3.Size = new System.Drawing.Size(100, 21);
            this.txtPref3.TabIndex = 21;
            this.txtPref3.Text = "0.0";
            this.txtPref3.TextChanged += new System.EventHandler(this.TxtPref3_TextChanged);
            // 
            // txtPref2
            // 
            this.txtPref2.Location = new System.Drawing.Point(274, 75);
            this.txtPref2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPref2.Name = "txtPref2";
            this.txtPref2.Size = new System.Drawing.Size(100, 21);
            this.txtPref2.TabIndex = 20;
            this.txtPref2.Text = "0.0";
            this.txtPref2.TextChanged += new System.EventHandler(this.TxtPref2_TextChanged);
            // 
            // txtPref1
            // 
            this.txtPref1.Location = new System.Drawing.Point(79, 75);
            this.txtPref1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPref1.Name = "txtPref1";
            this.txtPref1.Size = new System.Drawing.Size(98, 21);
            this.txtPref1.TabIndex = 19;
            this.txtPref1.Text = "0.0";
            this.txtPref1.TextChanged += new System.EventHandler(this.TxtPref1_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(397, 25);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 18;
            this.label23.Text = "美睫项目：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(199, 25);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 17;
            this.label22.Text = "美甲项目：";
            // 
            // txtProj3
            // 
            this.txtProj3.Location = new System.Drawing.Point(472, 20);
            this.txtProj3.Margin = new System.Windows.Forms.Padding(2);
            this.txtProj3.Name = "txtProj3";
            this.txtProj3.Size = new System.Drawing.Size(100, 21);
            this.txtProj3.TabIndex = 11;
            this.txtProj3.Text = "0";
            this.txtProj3.TextChanged += new System.EventHandler(this.txtProj3_TextChanged);
            // 
            // txtProj2
            // 
            this.txtProj2.Location = new System.Drawing.Point(274, 20);
            this.txtProj2.Margin = new System.Windows.Forms.Padding(2);
            this.txtProj2.Name = "txtProj2";
            this.txtProj2.Size = new System.Drawing.Size(100, 21);
            this.txtProj2.TabIndex = 10;
            this.txtProj2.Text = "0";
            this.txtProj2.TextChanged += new System.EventHandler(this.txtProj2_TextChanged);
            // 
            // txtProj1
            // 
            this.txtProj1.Location = new System.Drawing.Point(79, 21);
            this.txtProj1.Margin = new System.Windows.Forms.Padding(2);
            this.txtProj1.Name = "txtProj1";
            this.txtProj1.Size = new System.Drawing.Size(98, 21);
            this.txtProj1.TabIndex = 9;
            this.txtProj1.Text = "0";
            this.txtProj1.TextChanged += new System.EventHandler(this.txtProj1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 8;
            this.label19.Text = "美容项目：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "提成：";
            // 
            // cboEmp2
            // 
            this.cboEmp2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp2.FormattingEnabled = true;
            this.cboEmp2.Location = new System.Drawing.Point(273, 48);
            this.cboEmp2.Name = "cboEmp2";
            this.cboEmp2.Size = new System.Drawing.Size(100, 20);
            this.cboEmp2.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(205, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "美甲师：";
            // 
            // cboEmp3
            // 
            this.cboEmp3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp3.FormattingEnabled = true;
            this.cboEmp3.Location = new System.Drawing.Point(473, 48);
            this.cboEmp3.Name = "cboEmp3";
            this.cboEmp3.Size = new System.Drawing.Size(100, 20);
            this.cboEmp3.TabIndex = 4;
            // 
            // cboEmp1
            // 
            this.cboEmp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp1.FormattingEnabled = true;
            this.cboEmp1.Location = new System.Drawing.Point(79, 47);
            this.cboEmp1.Name = "cboEmp1";
            this.cboEmp1.Size = new System.Drawing.Size(98, 20);
            this.cboEmp1.TabIndex = 3;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(300, 20);
            this.txtClient.MaxLength = 20;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 21);
            this.txtClient.TabIndex = 3;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpPayDate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numMoney);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(12, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 126);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消费及打折";
            // 
            // numMoney
            // 
            this.numMoney.DecimalPlaces = 2;
            this.numMoney.Location = new System.Drawing.Point(177, 32);
            this.numMoney.Maximum = new decimal(new int[] {
            99999000,
            0,
            0,
            0});
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(100, 21);
            this.numMoney.TabIndex = 3;
            this.numMoney.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "本次消费应收金额：￥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "会员卡号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSubtract);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dgvPayDetails);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 198);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消费明细项目";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(89, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除(&Del)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "浏览添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "会员姓名：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(522, 556);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.ForeColor = System.Drawing.Color.Red;
            this.lblMemName.Location = new System.Drawing.Point(77, 47);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(29, 12);
            this.lblMemName.TabIndex = 12;
            this.lblMemName.Text = "散客";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Number";
            this.Column4.HeaderText = "数量";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.lblLastTime);
            this.grpMember.Controls.Add(this.label12);
            this.grpMember.Controls.Add(this.label9);
            this.grpMember.Controls.Add(this.lblMemBalance);
            this.grpMember.Controls.Add(this.lblMemName);
            this.grpMember.Controls.Add(this.label10);
            this.grpMember.Controls.Add(this.label4);
            this.grpMember.Controls.Add(this.txtClient);
            this.grpMember.Controls.Add(this.txtCode);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Controls.Add(this.label1);
            this.grpMember.Location = new System.Drawing.Point(12, 4);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(585, 68);
            this.grpMember.TabIndex = 20;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "基本信息";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(441, 556);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "确认结算";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "挂单";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPays_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPays_Add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "消费单据";
            this.Load += new System.EventHandler(this.frmPays_Add_Load);
            this.cmnuDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblSubtract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem cmnuDetails_Bonus;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.ContextMenuStrip cmnuDetails;
        private System.Windows.Forms.DataGridView dgvPayDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMemBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEmp2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboEmp3;
        private System.Windows.Forms.ComboBox cboEmp1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPref3;
        private System.Windows.Forms.TextBox txtPref2;
        private System.Windows.Forms.TextBox txtPref1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtProj3;
        private System.Windows.Forms.TextBox txtProj2;
        private System.Windows.Forms.TextBox txtProj1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labBonus3;
        private System.Windows.Forms.Label labBonus2;
        private System.Windows.Forms.Label labBonus1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown numMoney;
    }
}