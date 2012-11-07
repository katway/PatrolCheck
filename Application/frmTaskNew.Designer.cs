namespace WorkStation
{
    partial class frmTaskNew
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
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblRount = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCycle = new System.Windows.Forms.Label();
            this.lblshengxiao = new System.Windows.Forms.Label();
            this.lblshixiao = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEffect = new System.Windows.Forms.DateTimePicker();
            this.dtpIneffect = new System.Windows.Forms.DateTimePicker();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPost = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labPlanID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUnSub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboShow = new System.Windows.Forms.ComboBox();
            this.labState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "计划名称";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(378, 27);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(53, 12);
            this.lblAlias.TabIndex = 1;
            this.lblAlias.Text = "计划别名";
            // 
            // lblRount
            // 
            this.lblRount.AutoSize = true;
            this.lblRount.Location = new System.Drawing.Point(68, 64);
            this.lblRount.Name = "lblRount";
            this.lblRount.Size = new System.Drawing.Size(53, 12);
            this.lblRount.TabIndex = 2;
            this.lblRount.Text = "巡检路线";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(378, 64);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(53, 12);
            this.lblPost.TabIndex = 3;
            this.lblPost.Text = "指派岗位";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(44, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 12);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "执行开始时间";
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(68, 183);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(53, 12);
            this.lblCycle.TabIndex = 5;
            this.lblCycle.Text = "循环周期";
            // 
            // lblshengxiao
            // 
            this.lblshengxiao.AutoSize = true;
            this.lblshengxiao.Location = new System.Drawing.Point(44, 142);
            this.lblshengxiao.Name = "lblshengxiao";
            this.lblshengxiao.Size = new System.Drawing.Size(77, 12);
            this.lblshengxiao.TabIndex = 6;
            this.lblshengxiao.Text = "任务生效时间";
            // 
            // lblshixiao
            // 
            this.lblshixiao.AutoSize = true;
            this.lblshixiao.Location = new System.Drawing.Point(354, 142);
            this.lblshixiao.Name = "lblshixiao";
            this.lblshixiao.Size = new System.Drawing.Size(77, 12);
            this.lblshixiao.TabIndex = 7;
            this.lblshixiao.Text = "任务失效时间";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 8;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(447, 22);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(183, 21);
            this.txtAlias.TabIndex = 9;
            // 
            // cboRoute
            // 
            this.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Items.AddRange(new object[] {
            "选择路线"});
            this.cboRoute.Location = new System.Drawing.Point(127, 61);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(183, 20);
            this.cboRoute.TabIndex = 18;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy\'年\'MM\'月\'dd\'日\' hh\':\'mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(127, 101);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(183, 21);
            this.dtpStart.TabIndex = 19;
            // 
            // dtpEffect
            // 
            this.dtpEffect.Location = new System.Drawing.Point(127, 138);
            this.dtpEffect.Name = "dtpEffect";
            this.dtpEffect.Size = new System.Drawing.Size(183, 21);
            this.dtpEffect.TabIndex = 22;
            // 
            // dtpIneffect
            // 
            this.dtpIneffect.Location = new System.Drawing.Point(447, 138);
            this.dtpIneffect.Name = "dtpIneffect";
            this.dtpIneffect.Size = new System.Drawing.Size(183, 21);
            this.dtpIneffect.TabIndex = 23;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "选择路线"});
            this.cboUnit.Location = new System.Drawing.Point(179, 177);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(59, 20);
            this.cboUnit.TabIndex = 24;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy\'年\'MM\'月\'dd\'日\' hh\':\'mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(447, 101);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(183, 21);
            this.dtpEnd.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "执行结束时间";
            // 
            // cboPost
            // 
            this.cboPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPost.FormattingEnabled = true;
            this.cboPost.Items.AddRange(new object[] {
            "选择路线"});
            this.cboPost.Location = new System.Drawing.Point(447, 61);
            this.cboPost.Name = "cboPost";
            this.cboPost.Size = new System.Drawing.Size(183, 20);
            this.cboPost.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(364, 209);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(445, 209);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 31;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(127, 177);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(46, 21);
            this.txtInterval.TabIndex = 32;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColumn});
            this.dgvPlan.Location = new System.Drawing.Point(24, 245);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlan.Size = new System.Drawing.Size(686, 305);
            this.dgvPlan.TabIndex = 33;
            this.dgvPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellClick);
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "选择";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.ReadOnly = true;
            this.chkColumn.Width = 38;
            // 
            // labPlanID
            // 
            this.labPlanID.AutoSize = true;
            this.labPlanID.Location = new System.Drawing.Point(268, 181);
            this.labPlanID.Name = "labPlanID";
            this.labPlanID.Size = new System.Drawing.Size(41, 12);
            this.labPlanID.TabIndex = 34;
            this.labPlanID.Text = "计划ID";
            this.labPlanID.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(526, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUnSub
            // 
            this.btnUnSub.Location = new System.Drawing.Point(607, 208);
            this.btnUnSub.Name = "btnUnSub";
            this.btnUnSub.Size = new System.Drawing.Size(75, 23);
            this.btnUnSub.TabIndex = 36;
            this.btnUnSub.Text = "撤销提交";
            this.btnUnSub.UseVisualStyleBackColor = true;
            this.btnUnSub.Click += new System.EventHandler(this.btnUnSub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "显示";
            // 
            // cboShow
            // 
            this.cboShow.FormattingEnabled = true;
            this.cboShow.Location = new System.Drawing.Point(127, 210);
            this.cboShow.Name = "cboShow";
            this.cboShow.Size = new System.Drawing.Size(121, 20);
            this.cboShow.TabIndex = 38;
            this.cboShow.SelectedIndexChanged += new System.EventHandler(this.cboShow_SelectedIndexChanged);
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(354, 181);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(29, 12);
            this.labState.TabIndex = 39;
            this.labState.Text = "状态";
            // 
            // frmTaskNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 562);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.cboShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnSub);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labPlanID);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.dtpIneffect);
            this.Controls.Add(this.dtpEffect);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cboRoute);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblshixiao);
            this.Controls.Add(this.lblshengxiao);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblRount);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "frmTaskNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "计划管理";
            this.Load += new System.EventHandler(this.frmAddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblRount;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Label lblshengxiao;
        private System.Windows.Forms.Label lblshixiao;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEffect;
        private System.Windows.Forms.DateTimePicker dtpIneffect;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
        private System.Windows.Forms.Label labPlanID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUnSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboShow;
        private System.Windows.Forms.Label labState;
    }
}