namespace WorkStation
{
    partial class frmRoutAdd
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
            this.cboSiteArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRouteName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRouteAlias = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboInOrder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboSiteArea
            // 
            this.cboSiteArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSiteArea.FormattingEnabled = true;
            this.cboSiteArea.Location = new System.Drawing.Point(85, 21);
            this.cboSiteArea.Name = "cboSiteArea";
            this.cboSiteArea.Size = new System.Drawing.Size(183, 20);
            this.cboSiteArea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所在厂区";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "路线名称";
            // 
            // tbRouteName
            // 
            this.tbRouteName.Location = new System.Drawing.Point(85, 57);
            this.tbRouteName.Name = "tbRouteName";
            this.tbRouteName.Size = new System.Drawing.Size(183, 21);
            this.tbRouteName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "路线别名";
            // 
            // tbRouteAlias
            // 
            this.tbRouteAlias.Location = new System.Drawing.Point(85, 86);
            this.tbRouteAlias.Name = "tbRouteAlias";
            this.tbRouteAlias.Size = new System.Drawing.Size(183, 21);
            this.tbRouteAlias.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(85, 155);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(75, 23);
            this.btnTrue.TabIndex = 7;
            this.btnTrue.Text = "添加";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "顺序巡检";
            // 
            // cboInOrder
            // 
            this.cboInOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInOrder.FormattingEnabled = true;
            this.cboInOrder.Location = new System.Drawing.Point(85, 115);
            this.cboInOrder.Name = "cboInOrder";
            this.cboInOrder.Size = new System.Drawing.Size(183, 20);
            this.cboInOrder.TabIndex = 9;
            // 
            // frmAddRoutName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(313, 225);
            this.Controls.Add(this.cboInOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbRouteAlias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRouteName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSiteArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddRoutName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "路线详细信息";
            this.Load += new System.EventHandler(this.frmAddRoutName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cboSiteArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbRouteName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbRouteAlias;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboInOrder;
    }
}