namespace WorkStation
{
    partial class frmPointChoseRfid
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
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.btnChose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRfid = new System.Windows.Forms.DataGridView();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRfid)).BeginInit();
            this.SuspendLayout();
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(25, 22);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(152, 20);
            this.cboItem.TabIndex = 0;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // btnChose
            // 
            this.btnChose.Location = new System.Drawing.Point(220, 20);
            this.btnChose.Name = "btnChose";
            this.btnChose.Size = new System.Drawing.Size(75, 23);
            this.btnChose.TabIndex = 1;
            this.btnChose.Text = "选择";
            this.btnChose.UseVisualStyleBackColor = true;
            this.btnChose.Click += new System.EventHandler(this.btnChose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(335, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRfid
            // 
            this.dgvRfid.AllowUserToAddRows = false;
            this.dgvRfid.AllowUserToDeleteRows = false;
            this.dgvRfid.AllowUserToResizeRows = false;
            this.dgvRfid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRfid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColumn});
            this.dgvRfid.Location = new System.Drawing.Point(7, 75);
            this.dgvRfid.Name = "dgvRfid";
            this.dgvRfid.ReadOnly = true;
            this.dgvRfid.RowTemplate.Height = 23;
            this.dgvRfid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRfid.Size = new System.Drawing.Size(512, 342);
            this.dgvRfid.TabIndex = 11;
            this.dgvRfid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRfid_CellClick);
            this.dgvRfid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRfid_CellContentDoubleClick);
            this.dgvRfid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRfid_CellDoubleClick);
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "选择";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.ReadOnly = true;
            this.chkColumn.Width = 38;
            // 
            // frmChoseRfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 429);
            this.Controls.Add(this.dgvRfid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChose);
            this.Controls.Add(this.cboItem);
            this.Name = "frmChoseRfid";
            this.Text = "选择标签卡";
            this.Load += new System.EventHandler(this.frmChoseRfid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRfid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Button btnChose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRfid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
    }
}