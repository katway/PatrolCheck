namespace WorkStation
{
    partial class frmItemNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboMachine = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labID = new System.Windows.Forms.Label();
            this.bkwItem = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(324, 31);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 2;
            this.lblAlias.Text = "别名";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(312, 79);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 12);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "值类型";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(18, 109);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(65, 12);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "所属巡检点";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(30, 152);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(29, 12);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "备注";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(383, 24);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(171, 21);
            this.txtAlias.TabIndex = 6;
            // 
            // cboValue
            // 
            this.cboValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValue.FormattingEnabled = true;
            this.cboValue.Location = new System.Drawing.Point(383, 71);
            this.cboValue.Name = "cboValue";
            this.cboValue.Size = new System.Drawing.Size(171, 20);
            this.cboValue.TabIndex = 7;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(101, 149);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(475, 65);
            this.txtRemarks.TabIndex = 9;
            // 
            // cboPoint
            // 
            this.cboPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPoint.FormattingEnabled = true;
            this.cboPoint.Items.AddRange(new object[] {
            "所选巡检点"});
            this.cboPoint.Location = new System.Drawing.Point(101, 109);
            this.cboPoint.Name = "cboPoint";
            this.cboPoint.Size = new System.Drawing.Size(171, 20);
            this.cboPoint.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(278, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "所属机器";
            // 
            // cboMachine
            // 
            this.cboMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMachine.FormattingEnabled = true;
            this.cboMachine.Location = new System.Drawing.Point(101, 68);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(171, 20);
            this.cboMachine.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(383, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(488, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColumn});
            this.dgvItems.Location = new System.Drawing.Point(14, 291);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 23;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(659, 236);
            this.dgvItems.TabIndex = 19;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "选择";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.ReadOnly = true;
            this.chkColumn.Width = 38;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(383, 116);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(53, 12);
            this.labID.TabIndex = 20;
            this.labID.Text = "巡检项ID";
            this.labID.Visible = false;
            // 
            // bkwItem
            // 
            this.bkwItem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwItem_DoWork);
            this.bkwItem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwItem_RunWorkerCompleted);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 586);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboMachine);
            this.Controls.Add(this.label1);
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
            this.MaximizeBox = false;
            this.Name = "frmAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新建巡检项";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMachine;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
        private System.Windows.Forms.Label labID;
        private System.ComponentModel.BackgroundWorker bkwItem;
    }
}