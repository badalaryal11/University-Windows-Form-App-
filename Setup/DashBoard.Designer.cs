namespace WindowsFormsApp2.Setup
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStudentSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTeacherSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStaffSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileInfoToolStripMenuItem,
            this.masterSetupToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.utilityToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1338, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileInfoToolStripMenuItem
            // 
            this.fileInfoToolStripMenuItem.Name = "fileInfoToolStripMenuItem";
            this.fileInfoToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.fileInfoToolStripMenuItem.Tag = "100";
            this.fileInfoToolStripMenuItem.Text = "File Info";
            // 
            // masterSetupToolStripMenuItem
            // 
            this.masterSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStudentSetup,
            this.MnuTeacherSetup,
            this.MnuStaffSetup});
            this.masterSetupToolStripMenuItem.Name = "masterSetupToolStripMenuItem";
            this.masterSetupToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.masterSetupToolStripMenuItem.Tag = "200";
            this.masterSetupToolStripMenuItem.Text = "Master Setup";
            // 
            // MnuStudentSetup
            // 
            this.MnuStudentSetup.Image = ((System.Drawing.Image)(resources.GetObject("MnuStudentSetup.Image")));
            this.MnuStudentSetup.Name = "MnuStudentSetup";
            this.MnuStudentSetup.Size = new System.Drawing.Size(180, 24);
            this.MnuStudentSetup.Tag = "201";
            this.MnuStudentSetup.Text = "Student Setup";
            this.MnuStudentSetup.Click += new System.EventHandler(this.MnuStudentSetup_Click);
            // 
            // MnuTeacherSetup
            // 
            this.MnuTeacherSetup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MnuTeacherSetup.BackgroundImage")));
            this.MnuTeacherSetup.Image = ((System.Drawing.Image)(resources.GetObject("MnuTeacherSetup.Image")));
            this.MnuTeacherSetup.Name = "MnuTeacherSetup";
            this.MnuTeacherSetup.Size = new System.Drawing.Size(180, 24);
            this.MnuTeacherSetup.Text = "Teacher Setup";
            this.MnuTeacherSetup.Click += new System.EventHandler(this.MnuTeacherSetup_Click);
            // 
            // MnuStaffSetup
            // 
            this.MnuStaffSetup.Image = ((System.Drawing.Image)(resources.GetObject("MnuStaffSetup.Image")));
            this.MnuStaffSetup.Name = "MnuStaffSetup";
            this.MnuStaffSetup.Size = new System.Drawing.Size(180, 24);
            this.MnuStaffSetup.Text = "Staff Setup";
            this.MnuStaffSetup.Click += new System.EventHandler(this.MnuStaffSetup_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 675);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1338, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.reportToolStripMenuItem.Text = "Report ";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1338, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStudentSetup;
        private System.Windows.Forms.ToolStripMenuItem MnuTeacherSetup;
        private System.Windows.Forms.ToolStripMenuItem MnuStaffSetup;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
    }
}



