namespace WorkStation
{
    partial class frmAddItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.cboValue = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cboPoint = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cboMachine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(161, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(161, 78);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 2;
            this.lblAlias.Text = "别名";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(149, 155);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 12);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "值类型";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(125, 187);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(65, 12);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "所属巡检点";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(161, 230);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(29, 12);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "备注";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(232, 69);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(171, 21);
            this.txtAlias.TabIndex = 6;
            // 
            // cboValue
            // 
            this.cboValue.FormattingEnabled = true;
            this.cboValue.Items.AddRange(new object[] {
            "正常/不正常",
            "数值"});
            this.cboValue.Location = new System.Drawing.Point(232, 147);
            this.cboValue.Name = "cboValue";
            this.cboValue.Size = new System.Drawing.Size(171, 20);
            this.cboValue.TabIndex = 7;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(230, 227);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(173, 65);
            this.txtRemarks.TabIndex = 9;
            // 
            // cboPoint
            // 
            this.cboPoint.FormattingEnabled = true;
            this.cboPoint.Items.AddRange(new object[] {
            "所选巡检点"});
            this.cboPoint.Location = new System.Drawing.Point(232, 184);
            this.cboPoint.Name = "cboPoint";
            this.cboPoint.Size = new System.Drawing.Size(171, 20);
            this.cboPoint.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(501, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(27, 322);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 175);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "别名";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "值类型";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "所属巡检点";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "所属机器";
            // 
            // cboMachine
            // 
            this.cboMachine.FormattingEnabled = true;
            this.cboMachine.Items.AddRange(new object[] {
            "正常/不正常",
            "数值"});
            this.cboMachine.Location = new System.Drawing.Point(232, 110);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(171, 20);
            this.cboMachine.TabIndex = 15;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 586);
            this.Controls.Add(this.cboMachine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboPoint);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cboValue);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddItem";
            this.Text = "新建巡检项";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.ComboBox cboValue;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cboPoint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMachine;
    }
}