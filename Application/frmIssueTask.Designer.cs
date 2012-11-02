namespace WorkStation
{
    partial class frmIssueTask
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
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.xtraUserControl2 = new DevExpress.XtraEditors.XtraUserControl();
            this.SuspendLayout();
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Location = new System.Drawing.Point(39, 33);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(144, 86);
            this.xtraUserControl1.TabIndex = 0;
            // 
            // xtraUserControl2
            // 
            this.xtraUserControl2.Location = new System.Drawing.Point(68, 61);
            this.xtraUserControl2.Name = "xtraUserControl2";
            this.xtraUserControl2.Size = new System.Drawing.Size(159, 120);
            this.xtraUserControl2.TabIndex = 1;
            // 
            // frmIssueTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 430);
            this.Controls.Add(this.xtraUserControl2);
            this.Controls.Add(this.xtraUserControl1);
            this.Name = "frmIssueTask";
            this.Text = "frmIssueTask";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl2;


    }
}