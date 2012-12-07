namespace WorkStation
{
    partial class frmCardEditDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.lblUse = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvCardDelete = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "编辑及删除标签卡";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(45, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 1);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "编辑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(426, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(426, 342);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 22;
            this.BtnRead.Text = "读取";
            this.BtnRead.UseVisualStyleBackColor = true;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(193, 420);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(184, 21);
            this.txtAlias.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 383);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 21);
            this.txtName.TabIndex = 23;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(193, 344);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(184, 21);
            this.txtCard.TabIndex = 21;
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Location = new System.Drawing.Point(121, 461);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(29, 12);
            this.lblUse.TabIndex = 31;
            this.lblUse.Text = "用途";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(121, 423);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 30;
            this.lblAlias.Text = "别名";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(121, 386);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "名称";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(121, 347);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(29, 12);
            this.lblCard.TabIndex = 28;
            this.lblCard.Text = "卡片";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(51, 24);
            this.gridControl1.MainView = this.dgvCardDelete;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(722, 200);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCardDelete});
            // 
            // dgvCardDelete
            // 
            this.dgvCardDelete.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_Check,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.dgvCardDelete.GridControl = this.gridControl1;
            this.dgvCardDelete.Name = "dgvCardDelete";
            // 
            // gridColumn_Check
            // 
            this.gridColumn_Check.Caption = "选择";
            this.gridColumn_Check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn_Check.FieldName = "Check";
            this.gridColumn_Check.Name = "gridColumn_Check";
            this.gridColumn_Check.Visible = true;
            this.gridColumn_Check.VisibleIndex = 0;
            this.gridColumn_Check.Width = 67;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "标签卡编号";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 125;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "名称";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 125;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "别名";
            this.gridColumn3.FieldName = "Alias";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 125;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "用途";
            this.gridColumn4.FieldName = "Meaning";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 125;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "标签卡唯一码";
            this.gridColumn5.FieldName = "RFID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 134;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "有效状态";
            this.gridColumn6.FieldName = "ValidState";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(193, 497);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(184, 20);
            this.cboState.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "有效状态";
            // 
            // frmCardEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
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
            this.Name = "frmCardEditDelete";
            this.Text = "编辑及删除标签卡";
            this.Load += new System.EventHandler(this.frmCardEditDelete2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCard;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCardDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label7;
    }
}