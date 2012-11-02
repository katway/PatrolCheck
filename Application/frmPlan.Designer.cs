namespace WorkStation
{
    partial class frmPlan
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
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUnSub = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cboShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColumn});
            this.dgvPlan.Location = new System.Drawing.Point(6, 89);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlan.Size = new System.Drawing.Size(686, 460);
            this.dgvPlan.TabIndex = 34;
            this.dgvPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellClick);
            this.dgvPlan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlan_CellMouseDoubleClick);
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "选择";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.ReadOnly = true;
            this.chkColumn.Width = 38;
            // 
            // btnUnSub
            // 
            this.btnUnSub.Location = new System.Drawing.Point(590, 31);
            this.btnUnSub.Name = "btnUnSub";
            this.btnUnSub.Size = new System.Drawing.Size(75, 23);
            this.btnUnSub.TabIndex = 41;
            this.btnUnSub.Text = "撤销提交";
            this.btnUnSub.UseVisualStyleBackColor = true;
            this.btnUnSub.Click += new System.EventHandler(this.btnUnSub_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(497, 31);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(411, 31);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 39;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(322, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(235, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 37;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cboShow
            // 
            this.cboShow.FormattingEnabled = true;
            this.cboShow.Location = new System.Drawing.Point(51, 34);
            this.cboShow.Name = "cboShow";
            this.cboShow.Size = new System.Drawing.Size(152, 20);
            this.cboShow.TabIndex = 43;
            this.cboShow.SelectedIndexChanged += new System.EventHandler(this.cboShow_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "显示";
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(238, 14);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(29, 12);
            this.labState.TabIndex = 44;
            this.labState.Text = "状态";
            // 
            // frmAddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 556);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.cboShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnSub);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Name = "frmAddPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddPlan";
            this.Load += new System.EventHandler(this.frmAddPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
        private System.Windows.Forms.Button btnUnSub;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cboShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labState;
    }
}