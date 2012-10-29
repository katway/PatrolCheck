namespace WorkStation
{
    partial class frmAddPlan_Add
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
            this.dtpIneffect = new System.Windows.Forms.DateTimePicker();
            this.dtpEffect = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblshixiao = new System.Windows.Forms.Label();
            this.lblshengxiao = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cboPost = new System.Windows.Forms.ComboBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblCycle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpIneffect
            // 
            this.dtpIneffect.Location = new System.Drawing.Point(124, 238);
            this.dtpIneffect.Name = "dtpIneffect";
            this.dtpIneffect.Size = new System.Drawing.Size(183, 21);
            this.dtpIneffect.TabIndex = 40;
            // 
            // dtpEffect
            // 
            this.dtpEffect.Location = new System.Drawing.Point(124, 205);
            this.dtpEffect.Name = "dtpEffect";
            this.dtpEffect.Size = new System.Drawing.Size(183, 21);
            this.dtpEffect.TabIndex = 39;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy\'年\'MM\'月\'dd\'日\' hh\':\'mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(124, 141);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(183, 21);
            this.dtpStart.TabIndex = 38;
            // 
            // cboRoute
            // 
            this.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Items.AddRange(new object[] {
            "选择路线"});
            this.cboRoute.Location = new System.Drawing.Point(124, 86);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(183, 20);
            this.cboRoute.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 35;
            // 
            // lblshixiao
            // 
            this.lblshixiao.AutoSize = true;
            this.lblshixiao.Location = new System.Drawing.Point(41, 242);
            this.lblshixiao.Name = "lblshixiao";
            this.lblshixiao.Size = new System.Drawing.Size(77, 12);
            this.lblshixiao.TabIndex = 34;
            this.lblshixiao.Text = "任务失效时间";
            // 
            // lblshengxiao
            // 
            this.lblshengxiao.AutoSize = true;
            this.lblshengxiao.Location = new System.Drawing.Point(41, 209);
            this.lblshengxiao.Name = "lblshengxiao";
            this.lblshengxiao.Size = new System.Drawing.Size(77, 12);
            this.lblshengxiao.TabIndex = 33;
            this.lblshengxiao.Text = "任务生效时间";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(5, 145);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(113, 12);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "第一次执行开始时间";
            // 
            // lblRount
            // 
            this.lblRount.AutoSize = true;
            this.lblRount.Location = new System.Drawing.Point(58, 89);
            this.lblRount.Name = "lblRount";
            this.lblRount.Size = new System.Drawing.Size(53, 12);
            this.lblRount.TabIndex = 30;
            this.lblRount.Text = "巡检路线";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "计划名称";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(124, 54);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(183, 21);
            this.txtAlias.TabIndex = 45;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(58, 57);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(53, 12);
            this.lblAlias.TabIndex = 44;
            this.lblAlias.Text = "计划别名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "第一次执行结束时间";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy\'年\'MM\'月\'dd\'日\' hh\':\'mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(124, 174);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(183, 21);
            this.dtpEnd.TabIndex = 46;
            // 
            // cboPost
            // 
            this.cboPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPost.FormattingEnabled = true;
            this.cboPost.Items.AddRange(new object[] {
            "选择路线"});
            this.cboPost.Location = new System.Drawing.Point(124, 112);
            this.cboPost.Name = "cboPost";
            this.cboPost.Size = new System.Drawing.Size(183, 20);
            this.cboPost.TabIndex = 49;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(58, 115);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(53, 12);
            this.lblPost.TabIndex = 48;
            this.lblPost.Text = "指派岗位";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(143, 272);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(46, 21);
            this.txtInterval.TabIndex = 52;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "选择路线"});
            this.cboUnit.Location = new System.Drawing.Point(195, 273);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(59, 20);
            this.cboUnit.TabIndex = 51;
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(58, 276);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(53, 12);
            this.lblCycle.TabIndex = 50;
            this.lblCycle.Text = "循环周期";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(66, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "新建";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(176, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddPlan_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(336, 387);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.cboPost);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.dtpIneffect);
            this.Controls.Add(this.dtpEffect);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cboRoute);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblshixiao);
            this.Controls.Add(this.lblshengxiao);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRount);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmAddPlan_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新建计划";
            this.Load += new System.EventHandler(this.frmAddPlan_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpIneffect;
        private System.Windows.Forms.DateTimePicker dtpEffect;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblshixiao;
        private System.Windows.Forms.Label lblshengxiao;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cboPost;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}