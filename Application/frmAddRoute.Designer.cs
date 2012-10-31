namespace WorkStation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建路线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除路线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRoute = new System.Windows.Forms.CheckBox();
            this.tvRoute = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labRouteID = new System.Windows.Forms.Label();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.chkPhysicalPoint = new System.Windows.Forms.CheckBox();
            this.chkLogicalPoint = new System.Windows.Forms.CheckBox();
            this.tvPhysicalPoint = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tvLogicalPoint = new System.Windows.Forms.TreeView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建路线ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.删除路线ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建路线ToolStripMenuItem
            // 
            this.新建路线ToolStripMenuItem.Name = "新建路线ToolStripMenuItem";
            this.新建路线ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.新建路线ToolStripMenuItem.Text = "新建路线";
            this.新建路线ToolStripMenuItem.Click += new System.EventHandler(this.新建路线ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "编辑路线";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 删除路线ToolStripMenuItem
            // 
            this.删除路线ToolStripMenuItem.Name = "删除路线ToolStripMenuItem";
            this.删除路线ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.删除路线ToolStripMenuItem.Text = "删除路线";
            this.删除路线ToolStripMenuItem.Click += new System.EventHandler(this.删除路线ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRoute);
            this.groupBox1.Controls.Add(this.tvRoute);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "巡检路线";
            // 
            // chkRoute
            // 
            this.chkRoute.AutoSize = true;
            this.chkRoute.Checked = true;
            this.chkRoute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoute.Location = new System.Drawing.Point(93, 458);
            this.chkRoute.Name = "chkRoute";
            this.chkRoute.Size = new System.Drawing.Size(72, 16);
            this.chkRoute.TabIndex = 1;
            this.chkRoute.Text = "自动展开";
            this.chkRoute.UseVisualStyleBackColor = true;
            this.chkRoute.CheckedChanged += new System.EventHandler(this.chkRoute_CheckedChanged);
            // 
            // tvRoute
            // 
            this.tvRoute.Location = new System.Drawing.Point(6, 20);
            this.tvRoute.Name = "tvRoute";
            this.tvRoute.Size = new System.Drawing.Size(211, 432);
            this.tvRoute.TabIndex = 0;
            this.tvRoute.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRoute_AfterSelect);
            this.tvRoute.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvRoute_NodeMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.labRouteID);
            this.groupBox2.Controls.Add(this.btnAddTemplate);
            this.groupBox2.Controls.Add(this.chkPhysicalPoint);
            this.groupBox2.Controls.Add(this.chkLogicalPoint);
            this.groupBox2.Controls.Add(this.tvPhysicalPoint);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbRoute);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tvLogicalPoint);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnMoveDown);
            this.groupBox2.Controls.Add(this.btnMoveUp);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(254, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 486);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "路线巡检点设置";
            // 
            // labRouteID
            // 
            this.labRouteID.AutoSize = true;
            this.labRouteID.Location = new System.Drawing.Point(273, 31);
            this.labRouteID.Name = "labRouteID";
            this.labRouteID.Size = new System.Drawing.Size(41, 12);
            this.labRouteID.TabIndex = 18;
            this.labRouteID.Text = "路线ID";
            this.labRouteID.Visible = false;
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Location = new System.Drawing.Point(202, 82);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnAddTemplate.TabIndex = 17;
            this.btnAddTemplate.Text = "添加模板";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            // 
            // chkPhysicalPoint
            // 
            this.chkPhysicalPoint.AutoSize = true;
            this.chkPhysicalPoint.Checked = true;
            this.chkPhysicalPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhysicalPoint.Location = new System.Drawing.Point(338, 458);
            this.chkPhysicalPoint.Name = "chkPhysicalPoint";
            this.chkPhysicalPoint.Size = new System.Drawing.Size(72, 16);
            this.chkPhysicalPoint.TabIndex = 16;
            this.chkPhysicalPoint.Text = "自动展开";
            this.chkPhysicalPoint.UseVisualStyleBackColor = true;
            this.chkPhysicalPoint.CheckedChanged += new System.EventHandler(this.chkPhysicalPoint_CheckedChanged);
            // 
            // chkLogicalPoint
            // 
            this.chkLogicalPoint.AutoSize = true;
            this.chkLogicalPoint.Checked = true;
            this.chkLogicalPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogicalPoint.Location = new System.Drawing.Point(50, 458);
            this.chkLogicalPoint.Name = "chkLogicalPoint";
            this.chkLogicalPoint.Size = new System.Drawing.Size(72, 16);
            this.chkLogicalPoint.TabIndex = 15;
            this.chkLogicalPoint.Text = "自动展开";
            this.chkLogicalPoint.UseVisualStyleBackColor = true;
            this.chkLogicalPoint.CheckedChanged += new System.EventHandler(this.chkLogicalPoint_CheckedChanged);
            // 
            // tvPhysicalPoint
            // 
            this.tvPhysicalPoint.Location = new System.Drawing.Point(282, 56);
            this.tvPhysicalPoint.Name = "tvPhysicalPoint";
            this.tvPhysicalPoint.Size = new System.Drawing.Size(197, 396);
            this.tvPhysicalPoint.TabIndex = 13;
            this.tvPhysicalPoint.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvPhysicalPoint_BeforeSelect);
            this.tvPhysicalPoint.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPhysicalPoint_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "巡检点";
            // 
            // tbRoute
            // 
            this.tbRoute.BackColor = System.Drawing.SystemColors.Control;
            this.tbRoute.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRoute.Location = new System.Drawing.Point(75, 23);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.ReadOnly = true;
            this.tbRoute.Size = new System.Drawing.Size(191, 21);
            this.tbRoute.TabIndex = 11;
            this.tbRoute.Text = "shenm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "当前路线：";
            // 
            // tvLogicalPoint
            // 
            this.tvLogicalPoint.Location = new System.Drawing.Point(6, 56);
            this.tvLogicalPoint.Name = "tvLogicalPoint";
            this.tvLogicalPoint.Size = new System.Drawing.Size(189, 396);
            this.tvLogicalPoint.TabIndex = 9;
            this.tvLogicalPoint.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvLogicalPoint_BeforeSelect);
            this.tvLogicalPoint.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLogicalPoint_NodeMouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(201, 207);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 6;
            this.btnMoveDown.Text = "下移";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(201, 171);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 5;
            this.btnMoveUp.Text = "上移";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(201, 140);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = ">";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(201, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(751, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmAddRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新建巡检路线";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddRoute_FormClosing);
            this.Load += new System.EventHandler(this.frmAddRoute_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建路线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除路线ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRoute;
        private System.Windows.Forms.TreeView tvRoute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.CheckBox chkPhysicalPoint;
        private System.Windows.Forms.CheckBox chkLogicalPoint;
        private System.Windows.Forms.TreeView tvPhysicalPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvLogicalPoint;
        private System.Windows.Forms.Label labRouteID;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;


    }
}