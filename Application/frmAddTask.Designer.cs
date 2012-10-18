namespace WorkStation
{
    partial class frmAddTask
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
            this.txtgangwei = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(179, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(179, 68);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 1;
            this.lblAlias.Text = "别名";
            this.lblAlias.Click += new System.EventHandler(this.lblAlias_Click);
            // 
            // lblRount
            // 
            this.lblRount.AutoSize = true;
            this.lblRount.Location = new System.Drawing.Point(155, 95);
            this.lblRount.Name = "lblRount";
            this.lblRount.Size = new System.Drawing.Size(53, 12);
            this.lblRount.TabIndex = 2;
            this.lblRount.Text = "巡检路线";
            this.lblRount.Click += new System.EventHandler(this.lblRount_Click);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(155, 124);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(53, 12);
            this.lblPost.TabIndex = 3;
            this.lblPost.Text = "指派岗位";
            this.lblPost.Click += new System.EventHandler(this.lblPost_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(155, 152);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "巡检时间";
            this.lblTime.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(155, 187);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(53, 12);
            this.lblCycle.TabIndex = 5;
            this.lblCycle.Text = "巡检周期";
            this.lblCycle.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblshengxiao
            // 
            this.lblshengxiao.AutoSize = true;
            this.lblshengxiao.Location = new System.Drawing.Point(155, 223);
            this.lblshengxiao.Name = "lblshengxiao";
            this.lblshengxiao.Size = new System.Drawing.Size(53, 12);
            this.lblshengxiao.TabIndex = 6;
            this.lblshengxiao.Text = "生效时间";
            this.lblshengxiao.Click += new System.EventHandler(this.lblshengxiao_Click);
            // 
            // lblshixiao
            // 
            this.lblshixiao.AutoSize = true;
            this.lblshixiao.Location = new System.Drawing.Point(155, 260);
            this.lblshixiao.Name = "lblshixiao";
            this.lblshixiao.Size = new System.Drawing.Size(53, 12);
            this.lblshixiao.TabIndex = 7;
            this.lblshixiao.Text = "失效时间";
            this.lblshixiao.Click += new System.EventHandler(this.lblshixiao_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(263, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(263, 59);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(183, 21);
            this.txtAlias.TabIndex = 9;
            this.txtAlias.TextChanged += new System.EventHandler(this.txtAlias_TextChanged);
            // 
            // txtgangwei
            // 
            this.txtgangwei.Location = new System.Drawing.Point(263, 115);
            this.txtgangwei.Name = "txtgangwei";
            this.txtgangwei.Size = new System.Drawing.Size(183, 21);
            this.txtgangwei.TabIndex = 11;
            this.txtgangwei.TextChanged += new System.EventHandler(this.txtgangwei_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 283);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 219);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "编号";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "名称";
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "别名";
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "巡检路线";
            this.ColumnHeader4.Width = 109;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "指派岗位";
            this.ColumnHeader5.Width = 105;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "巡检时间";
            this.ColumnHeader6.Width = 100;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "巡检周期";
            this.ColumnHeader7.Width = 75;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "生效时间";
            this.ColumnHeader8.Width = 75;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "失效时间";
            this.ColumnHeader9.Width = 80;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(592, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "选择路线"});
            this.comboBox1.Location = new System.Drawing.Point(263, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 20);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 21);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "时",
            "天",
            "周",
            "月",
            "年"});
            this.listBox1.Location = new System.Drawing.Point(347, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 40);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 223);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(263, 256);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker3.TabIndex = 23;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 562);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtgangwei);
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
            this.Name = "frmAddTask";
            this.Text = "新建任务";
            this.Load += new System.EventHandler(this.frmAddTask_Load);
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
        private System.Windows.Forms.TextBox txtgangwei;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.ColumnHeader ColumnHeader6;
        private System.Windows.Forms.ColumnHeader ColumnHeader7;
        private System.Windows.Forms.ColumnHeader ColumnHeader8;
        private System.Windows.Forms.ColumnHeader ColumnHeader9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}