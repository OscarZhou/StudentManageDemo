namespace StudentManageDemo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.spcLayout = new System.Windows.Forms.SplitContainer();
            this.mcldTime = new System.Windows.Forms.MonthCalendar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPwdModified = new System.Windows.Forms.Button();
            this.btnScoreBrowsing = new System.Windows.Forms.Button();
            this.btnScoreAnalysis = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnStudentManage = new System.Windows.Forms.Button();
            this.btnBatchImport = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLayout)).BeginInit();
            this.spcLayout.Panel1.SuspendLayout();
            this.spcLayout.Panel2.SuspendLayout();
            this.spcLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.学员管理MToolStripMenuItem,
            this.成绩管理JToolStripMenuItem,
            this.考勤管理AToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(S)";
            // 
            // 学员管理MToolStripMenuItem
            // 
            this.学员管理MToolStripMenuItem.Name = "学员管理MToolStripMenuItem";
            this.学员管理MToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.学员管理MToolStripMenuItem.Text = "学员管理(M)";
            // 
            // 成绩管理JToolStripMenuItem
            // 
            this.成绩管理JToolStripMenuItem.Name = "成绩管理JToolStripMenuItem";
            this.成绩管理JToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.成绩管理JToolStripMenuItem.Text = "成绩管理(J)";
            // 
            // 考勤管理AToolStripMenuItem
            // 
            this.考勤管理AToolStripMenuItem.Name = "考勤管理AToolStripMenuItem";
            this.考勤管理AToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.考勤管理AToolStripMenuItem.Text = "考勤管理(A)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(93, 17);
            this.tsslVersion.Text = "当前版本：V1.0";
            // 
            // tsslCurrentUser
            // 
            this.tsslCurrentUser.Name = "tsslCurrentUser";
            this.tsslCurrentUser.Size = new System.Drawing.Size(96, 17);
            this.tsslCurrentUser.Text = "[当前用户登录：";
            // 
            // spcLayout
            // 
            this.spcLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLayout.Location = new System.Drawing.Point(0, 25);
            this.spcLayout.Name = "spcLayout";
            // 
            // spcLayout.Panel1
            // 
            this.spcLayout.Panel1.Controls.Add(this.mcldTime);
            this.spcLayout.Panel1.Controls.Add(this.btnExit);
            this.spcLayout.Panel1.Controls.Add(this.btnPwdModified);
            this.spcLayout.Panel1.Controls.Add(this.btnScoreBrowsing);
            this.spcLayout.Panel1.Controls.Add(this.btnScoreAnalysis);
            this.spcLayout.Panel1.Controls.Add(this.btnAttendence);
            this.spcLayout.Panel1.Controls.Add(this.btnStudentManage);
            this.spcLayout.Panel1.Controls.Add(this.btnBatchImport);
            this.spcLayout.Panel1.Controls.Add(this.btnAddStudent);
            // 
            // spcLayout.Panel2
            // 
            this.spcLayout.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spcLayout.Panel2.BackgroundImage")));
            this.spcLayout.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spcLayout.Panel2.Controls.Add(this.lbTitle);
            this.spcLayout.Size = new System.Drawing.Size(1062, 511);
            this.spcLayout.SplitterDistance = 274;
            this.spcLayout.TabIndex = 2;
            // 
            // mcldTime
            // 
            this.mcldTime.Location = new System.Drawing.Point(9, 17);
            this.mcldTime.Name = "mcldTime";
            this.mcldTime.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(123, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出系统";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPwdModified
            // 
            this.btnPwdModified.Image = ((System.Drawing.Image)(resources.GetObject("btnPwdModified.Image")));
            this.btnPwdModified.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPwdModified.Location = new System.Drawing.Point(13, 429);
            this.btnPwdModified.Name = "btnPwdModified";
            this.btnPwdModified.Size = new System.Drawing.Size(82, 33);
            this.btnPwdModified.TabIndex = 7;
            this.btnPwdModified.Text = "密码修改";
            this.btnPwdModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPwdModified.UseVisualStyleBackColor = true;
            this.btnPwdModified.Click += new System.EventHandler(this.btnPwdModified_Click);
            // 
            // btnScoreBrowsing
            // 
            this.btnScoreBrowsing.Image = ((System.Drawing.Image)(resources.GetObject("btnScoreBrowsing.Image")));
            this.btnScoreBrowsing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoreBrowsing.Location = new System.Drawing.Point(123, 319);
            this.btnScoreBrowsing.Name = "btnScoreBrowsing";
            this.btnScoreBrowsing.Size = new System.Drawing.Size(82, 33);
            this.btnScoreBrowsing.TabIndex = 6;
            this.btnScoreBrowsing.Text = "成绩浏览";
            this.btnScoreBrowsing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScoreBrowsing.UseVisualStyleBackColor = true;
            this.btnScoreBrowsing.Click += new System.EventHandler(this.btnScoreBrowsing_Click);
            // 
            // btnScoreAnalysis
            // 
            this.btnScoreAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnScoreAnalysis.Image")));
            this.btnScoreAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoreAnalysis.Location = new System.Drawing.Point(13, 319);
            this.btnScoreAnalysis.Name = "btnScoreAnalysis";
            this.btnScoreAnalysis.Size = new System.Drawing.Size(82, 33);
            this.btnScoreAnalysis.TabIndex = 5;
            this.btnScoreAnalysis.Text = "成绩分析";
            this.btnScoreAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScoreAnalysis.UseVisualStyleBackColor = true;
            this.btnScoreAnalysis.Click += new System.EventHandler(this.btnScoreAnalysis_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendence.Image")));
            this.btnAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendence.Location = new System.Drawing.Point(123, 266);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(82, 33);
            this.btnAttendence.TabIndex = 4;
            this.btnAttendence.Text = "考勤打卡";
            this.btnAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendence.UseVisualStyleBackColor = true;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentManage.Image")));
            this.btnStudentManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentManage.Location = new System.Drawing.Point(13, 266);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(82, 33);
            this.btnStudentManage.TabIndex = 3;
            this.btnStudentManage.Text = "学员管理";
            this.btnStudentManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentManage.UseVisualStyleBackColor = true;
            this.btnStudentManage.Click += new System.EventHandler(this.btnStudentManage_Click);
            // 
            // btnBatchImport
            // 
            this.btnBatchImport.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchImport.Image")));
            this.btnBatchImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatchImport.Location = new System.Drawing.Point(123, 215);
            this.btnBatchImport.Name = "btnBatchImport";
            this.btnBatchImport.Size = new System.Drawing.Size(82, 33);
            this.btnBatchImport.TabIndex = 2;
            this.btnBatchImport.Text = "批量导入";
            this.btnBatchImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatchImport.UseVisualStyleBackColor = true;
            this.btnBatchImport.Click += new System.EventHandler(this.btnBatchImport_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(13, 215);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(82, 33);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "添加学员";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑 Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.Location = new System.Drawing.Point(59, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(503, 52);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "欢迎使用学员信息管理系统";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 558);
            this.Controls.Add(this.spcLayout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "学员信息管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spcLayout.Panel1.ResumeLayout(false);
            this.spcLayout.Panel2.ResumeLayout(false);
            this.spcLayout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLayout)).EndInit();
            this.spcLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理JToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrentUser;
        private System.Windows.Forms.SplitContainer spcLayout;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnBatchImport;
        private System.Windows.Forms.Button btnScoreBrowsing;
        private System.Windows.Forms.Button btnScoreAnalysis;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Button btnStudentManage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPwdModified;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.MonthCalendar mcldTime;
    }
}