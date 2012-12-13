namespace WorkStation
{
    partial class frmReportAnalysisByEmployee
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvPerson = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPost = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(48, 182);
            this.gridControl1.MainView = this.dgvPerson;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(744, 282);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPerson});
            // 
            // dgvPerson
            // 
            this.dgvPerson.GridControl = this.gridControl1;
            this.dgvPerson.Name = "dgvPerson";
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(405, 53);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(161, 20);
            this.cboOperator.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "人员名称";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy\'年\'MM\'月\'dd\'日\' HH\':\'mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(405, 13);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(161, 21);
            this.dtpEndTime.TabIndex = 15;
            this.dtpEndTime.Value = new System.DateTime(2012, 11, 29, 10, 14, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy\'年\'MM\'月\'dd\'日\' HH\':\'mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(141, 13);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(157, 21);
            this.dtpStart.TabIndex = 14;
            this.dtpStart.Value = new System.DateTime(2012, 11, 29, 10, 12, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "结束时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "开始时间";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "岗位";
            // 
            // cboPost
            // 
            this.cboPost.FormattingEnabled = true;
            this.cboPost.Location = new System.Drawing.Point(141, 53);
            this.cboPost.Name = "cboPost";
            this.cboPost.Size = new System.Drawing.Size(157, 20);
            this.cboPost.TabIndex = 20;
            this.cboPost.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmReportAnalysisByEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.cboPost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReportAnalysisByEmployee";
            this.Text = "人员统计率";
            this.Load += new System.EventHandler(this.frmPersonStatistics2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPerson;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPost;
    }
}