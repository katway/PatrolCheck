namespace Application
{
    partial class frmAddRoute
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
            this.lblGenus = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGenus = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(206, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(206, 99);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 1;
            this.lblAlias.Text = "别名";
            // 
            // lblGenus
            // 
            this.lblGenus.AutoSize = true;
            this.lblGenus.Location = new System.Drawing.Point(182, 133);
            this.lblGenus.Name = "lblGenus";
            this.lblGenus.Size = new System.Drawing.Size(53, 12);
            this.lblGenus.TabIndex = 2;
            this.lblGenus.Text = "所属厂区";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(158, 169);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(77, 12);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "包含的巡检点";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(295, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtGenus
            // 
            this.txtGenus.Location = new System.Drawing.Point(295, 124);
            this.txtGenus.Name = "txtGenus";
            this.txtGenus.Size = new System.Drawing.Size(224, 21);
            this.txtGenus.TabIndex = 5;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(295, 90);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(224, 21);
            this.txtAlias.TabIndex = 6;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(295, 160);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(224, 21);
            this.txtPoint.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(106, 231);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 180);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "巡检路线编号";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "别名";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "所属厂区";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "包含的巡检点";
            this.columnHeader5.Width = 111;
            // 
            // frmAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 457);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtGenus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblGenus);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddRoute";
            this.Text = "新建巡检路线";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblGenus;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGenus;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}