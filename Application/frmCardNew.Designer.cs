namespace WorkStation
{
    partial class frmCardNew
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
            this.lblCard = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblUse = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.BtnRead = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bwkLoadData = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvCardNew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardNew)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(22, 37);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(53, 12);
            this.lblCard.TabIndex = 0;
            this.lblCard.Text = "卡片编号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "名称";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(22, 117);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 2;
            this.lblAlias.Text = "别名";
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Location = new System.Drawing.Point(22, 153);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(29, 12);
            this.lblUse.TabIndex = 3;
            this.lblUse.Text = "用途";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(90, 32);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(184, 21);
            this.txtCard.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(90, 114);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(184, 21);
            this.txtAlias.TabIndex = 6;
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(306, 32);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 8;
            this.BtnRead.Text = "读取";
            this.BtnRead.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // bwkLoadData
            // 
            this.bwkLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkLoadData_DoWork);
            this.bwkLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkLoadData_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 1);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "录入新标签卡";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(9, 259);
            this.gridControl1.MainView = this.dgvCardNew;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(626, 200);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCardNew});
            // 
            // dgvCardNew
            // 
            this.dgvCardNew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.dgvCardNew.GridControl = this.gridControl1;
            this.dgvCardNew.Name = "dgvCardNew";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "标签卡编号";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "名称";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "别名";
            this.gridColumn3.FieldName = "Alias";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "用途";
            this.gridColumn4.FieldName = "Meaning";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "标签卡唯一码";
            this.gridColumn5.FieldName = "RFID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "有效状态";
            this.gridColumn6.FieldName = "ValidState";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(90, 178);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(184, 20);
            this.cboState.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "有效状态";
            // 
            // frmCardNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 471);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.lblUse);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCard);
            this.Name = "frmCardNew";
            this.Text = "录入新标签卡";
            this.Load += new System.EventHandler(this.frmAddCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker bwkLoadData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCardNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label7;
    }
}