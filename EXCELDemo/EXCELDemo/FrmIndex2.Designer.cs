﻿namespace ExcelUp
{
    partial class FrmIndex2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndex2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GvList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperTol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerTol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XAxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZAxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblPage);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(768, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 60);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(117, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 60);
            this.panel4.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(64, 34);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(5, 34);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(50, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(44, 42);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(65, 12);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "100 OF 100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "页码：";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(131, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 12);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "项目号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "检测点";
            // 
            // GvList
            // 
            this.GvList.AllowUserToAddRows = false;
            this.GvList.AllowUserToDeleteRows = false;
            this.GvList.AllowUserToResizeRows = false;
            this.GvList.BackgroundColor = System.Drawing.Color.White;
            this.GvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PointNo,
            this.Direct,
            this.UpperTol,
            this.LowerTol,
            this.XAxis,
            this.YAxis,
            this.ZAxis,
            this.last});
            this.GvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvList.Location = new System.Drawing.Point(5, 60);
            this.GvList.Name = "GvList";
            this.GvList.RowTemplate.Height = 23;
            this.GvList.Size = new System.Drawing.Size(1004, 381);
            this.GvList.TabIndex = 3;
            this.GvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GvList_RowPostPaint);
            // 
            // id
            // 
            this.id.DataPropertyName = "MeasPointID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // PointNo
            // 
            this.PointNo.DataPropertyName = "PointNo";
            this.PointNo.HeaderText = "检测点";
            this.PointNo.Name = "PointNo";
            this.PointNo.ReadOnly = true;
            // 
            // Direct
            // 
            this.Direct.DataPropertyName = "Direct";
            this.Direct.HeaderText = "方向";
            this.Direct.Name = "Direct";
            this.Direct.ReadOnly = true;
            // 
            // UpperTol
            // 
            this.UpperTol.DataPropertyName = "UpperTol";
            this.UpperTol.HeaderText = "大公差";
            this.UpperTol.Name = "UpperTol";
            this.UpperTol.ReadOnly = true;
            // 
            // LowerTol
            // 
            this.LowerTol.DataPropertyName = "LowerTol";
            this.LowerTol.HeaderText = "小公差";
            this.LowerTol.Name = "LowerTol";
            this.LowerTol.ReadOnly = true;
            // 
            // XAxis
            // 
            this.XAxis.DataPropertyName = "XAxis";
            this.XAxis.HeaderText = "X坐标";
            this.XAxis.Name = "XAxis";
            // 
            // YAxis
            // 
            this.YAxis.DataPropertyName = "YAxis";
            this.YAxis.HeaderText = "Y坐标";
            this.YAxis.Name = "YAxis";
            // 
            // ZAxis
            // 
            this.ZAxis.DataPropertyName = "ZAxis";
            this.ZAxis.HeaderText = "Z坐标";
            this.ZAxis.Name = "ZAxis";
            // 
            // last
            // 
            this.last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last.HeaderText = "";
            this.last.Name = "last";
            // 
            // FrmIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 441);
            this.Controls.Add(this.GvList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIndex2";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上海赛科利质量测量数据管理平台系统 - 检测点";
            this.Load += new System.EventHandler(this.FrmIndex2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direct;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperTol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerTol;
        private System.Windows.Forms.DataGridViewTextBoxColumn XAxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZAxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}