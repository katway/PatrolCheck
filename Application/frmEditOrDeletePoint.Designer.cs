namespace WorkStation
{
    partial class frmEditOrDeletePoint
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRelated = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(34, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 163);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "巡检点编号";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "别名";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "关联标签卡";
            this.columnHeader4.Width = 108;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(507, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(398, 355);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(132, 355);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(237, 21);
            this.txtRelation.TabIndex = 15;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(132, 319);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(237, 21);
            this.txtAlias.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 276);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 21);
            this.txtName.TabIndex = 13;
            // 
            // lblRelated
            // 
            this.lblRelated.AutoSize = true;
            this.lblRelated.Location = new System.Drawing.Point(33, 364);
            this.lblRelated.Name = "lblRelated";
            this.lblRelated.Size = new System.Drawing.Size(65, 12);
            this.lblRelated.TabIndex = 12;
            this.lblRelated.Text = "关联标签卡";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(69, 322);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 12);
            this.lblAlias.TabIndex = 11;
            this.lblAlias.Text = "别名";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 279);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "名称";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(470, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(583, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmEditOrDeletePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 464);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtRelation);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRelated);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listView1);
            this.Name = "frmEditOrDeletePoint";
            this.Text = "编辑及删除巡检点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRelated;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}