namespace WorkStation
{
    partial class frmAddPlanToTask
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
            this.btnDown = new System.Windows.Forms.Button();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(209, 13);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "生成任务";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColumn});
            this.dgvPlan.Location = new System.Drawing.Point(12, 42);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(785, 245);
            this.dgvPlan.TabIndex = 35;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "选择";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.ReadOnly = true;
            this.chkColumn.Width = 38;
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(12, 304);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowTemplate.Height = 23;
            this.dgvTask.Size = new System.Drawing.Size(785, 277);
            this.dgvTask.TabIndex = 36;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(63, 14);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 20);
            this.cboState.TabIndex = 37;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "显示";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(459, 18);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(89, 12);
            this.labID.TabIndex = 39;
            this.labID.Text = "已下发任务的ID";
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(388, 17);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(53, 12);
            this.labState.TabIndex = 40;
            this.labState.Text = "所选状态";
            // 
            // frmAddPlanToTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 607);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.btnDown);
            this.Name = "frmAddPlanToTask";
            this.Text = "任务下发";
            this.Load += new System.EventHandler(this.frmAddPlanToTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labState;
    }
}