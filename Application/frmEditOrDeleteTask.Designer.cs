namespace Application
{
    partial class frmEditOrDeleteTask
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
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtgangwei = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblRount = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblshixiao = new System.Windows.Forms.Label();
            this.lblshengxiao = new System.Windows.Forms.Label();
            this.lblCycle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 219);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 266);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(178, 269);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "名称";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "选择路线"});
            this.comboBox1.Location = new System.Drawing.Point(262, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // txtgangwei
            // 
            this.txtgangwei.Location = new System.Drawing.Point(262, 346);
            this.txtgangwei.Name = "txtgangwei";
            this.txtgangwei.Size = new System.Drawing.Size(183, 21);
            this.txtgangwei.TabIndex = 24;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(262, 293);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(183, 21);
            this.txtAlias.TabIndex = 23;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(154, 355);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(53, 12);
            this.lblPost.TabIndex = 22;
            this.lblPost.Text = "指派岗位";
            // 
            // lblRount
            // 
            this.lblRount.AutoSize = true;
            this.lblRount.Location = new System.Drawing.Point(154, 320);
            this.lblRount.Name = "lblRount";
            this.lblRount.Size = new System.Drawing.Size(53, 12);
            this.lblRount.TabIndex = 21;
            this.lblRount.Text = "巡检路线";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(178, 296);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 20;
            this.lblAlias.Text = "别名";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(262, 495);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker3.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(262, 455);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker2.TabIndex = 33;
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
            this.listBox1.Location = new System.Drawing.Point(346, 400);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 40);
            this.listBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 21);
            this.textBox1.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // lblshixiao
            // 
            this.lblshixiao.AutoSize = true;
            this.lblshixiao.Location = new System.Drawing.Point(154, 499);
            this.lblshixiao.Name = "lblshixiao";
            this.lblshixiao.Size = new System.Drawing.Size(53, 12);
            this.lblshixiao.TabIndex = 29;
            this.lblshixiao.Text = "失效时间";
            this.lblshixiao.Click += new System.EventHandler(this.lblshixiao_Click);
            // 
            // lblshengxiao
            // 
            this.lblshengxiao.AutoSize = true;
            this.lblshengxiao.Location = new System.Drawing.Point(154, 455);
            this.lblshengxiao.Name = "lblshengxiao";
            this.lblshengxiao.Size = new System.Drawing.Size(53, 12);
            this.lblshengxiao.TabIndex = 28;
            this.lblshengxiao.Text = "生效时间";
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(154, 417);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(53, 12);
            this.lblCycle.TabIndex = 27;
            this.lblCycle.Text = "巡检周期";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(154, 382);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "巡检时间";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(477, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(510, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 27);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(628, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmEditOrDeleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 529);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblshixiao);
            this.Controls.Add(this.lblshengxiao);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtgangwei);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblRount);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listView1);
            this.Name = "frmEditOrDeleteTask";
            this.Text = "编辑及删除任务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.ColumnHeader ColumnHeader6;
        private System.Windows.Forms.ColumnHeader ColumnHeader7;
        private System.Windows.Forms.ColumnHeader ColumnHeader8;
        private System.Windows.Forms.ColumnHeader ColumnHeader9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtgangwei;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblRount;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblshixiao;
        private System.Windows.Forms.Label lblshengxiao;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}