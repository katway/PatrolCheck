namespace WorkStation
{
    partial class frmItemEditDelete
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cboValue = new System.Windows.Forms.ComboBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(48, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 175);
            this.listView1.TabIndex = 13;
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
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.Width = 86;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(450, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 26);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(560, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "所选巡检点"});
            this.comboBox1.Location = new System.Drawing.Point(183, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(183, 435);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(173, 65);
            this.txtRemarks.TabIndex = 24;
            // 
            // cboValue
            // 
            this.cboValue.FormattingEnabled = true;
            this.cboValue.Items.AddRange(new object[] {
            "正常/不正常",
            "数值"});
            this.cboValue.Location = new System.Drawing.Point(185, 364);
            this.cboValue.Name = "cboValue";
            this.cboValue.Size = new System.Drawing.Size(171, 20);
            this.cboValue.TabIndex = 23;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(183, 324);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(173, 21);
            this.txtAlias.TabIndex = 22;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(114, 467);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(29, 12);
            this.lblRemarks.TabIndex = 21;
            this.lblRemarks.Text = "备注";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(78, 409);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(65, 12);
            this.lblPoints.TabIndex = 20;
            this.lblPoints.Text = "所属巡检点";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(102, 372);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 12);
            this.lblValue.TabIndex = 19;
            this.lblValue.Text = "值类型";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(114, 333);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 18;
            this.lblAlias.Text = "别名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 288);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 21);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(114, 291);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "名称";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(532, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmEditOrDeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 532);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cboValue);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listView1);
            this.Name = "frmEditOrDeleteItem";
            this.Text = "编辑及删除巡检项";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cboValue;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
    }
}