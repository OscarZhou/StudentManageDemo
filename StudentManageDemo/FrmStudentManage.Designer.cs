namespace StudentManageDemo
{
    partial class FrmStudentManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentManage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbQueryByClass = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnNameDesc = new System.Windows.Forms.Button();
            this.btnStudentIdDesc = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbQueryByStudentId = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnSubmitQuery = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbQueryByClass.SuspendLayout();
            this.gbQueryByStudentId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "学员信息管理";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(625, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 24);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // gbQueryByClass
            // 
            this.gbQueryByClass.Controls.Add(this.btnDelete);
            this.gbQueryByClass.Controls.Add(this.btnModify);
            this.gbQueryByClass.Controls.Add(this.btnStudentIdDesc);
            this.gbQueryByClass.Controls.Add(this.btnNameDesc);
            this.gbQueryByClass.Controls.Add(this.btnQuery);
            this.gbQueryByClass.Controls.Add(this.cbClass);
            this.gbQueryByClass.Controls.Add(this.label2);
            this.gbQueryByClass.Location = new System.Drawing.Point(31, 80);
            this.gbQueryByClass.Name = "gbQueryByClass";
            this.gbQueryByClass.Size = new System.Drawing.Size(676, 67);
            this.gbQueryByClass.TabIndex = 10;
            this.gbQueryByClass.TabStop = false;
            this.gbQueryByClass.Text = "[按照班级查询]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学员班级：";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(89, 27);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(113, 20);
            this.cbClass.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(217, 27);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查  询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnNameDesc
            // 
            this.btnNameDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnNameDesc.Image")));
            this.btnNameDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameDesc.Location = new System.Drawing.Point(298, 27);
            this.btnNameDesc.Name = "btnNameDesc";
            this.btnNameDesc.Size = new System.Drawing.Size(82, 23);
            this.btnNameDesc.TabIndex = 3;
            this.btnNameDesc.Text = "姓名降序";
            this.btnNameDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNameDesc.UseVisualStyleBackColor = true;
            // 
            // btnStudentIdDesc
            // 
            this.btnStudentIdDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentIdDesc.Image")));
            this.btnStudentIdDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentIdDesc.Location = new System.Drawing.Point(384, 27);
            this.btnStudentIdDesc.Name = "btnStudentIdDesc";
            this.btnStudentIdDesc.Size = new System.Drawing.Size(82, 23);
            this.btnStudentIdDesc.TabIndex = 4;
            this.btnStudentIdDesc.Text = "学号降序";
            this.btnStudentIdDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentIdDesc.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(505, 27);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "修  改";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(590, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删  除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbQueryByStudentId
            // 
            this.gbQueryByStudentId.Controls.Add(this.btnSubmitQuery);
            this.gbQueryByStudentId.Controls.Add(this.txtStudentId);
            this.gbQueryByStudentId.Controls.Add(this.label3);
            this.gbQueryByStudentId.Location = new System.Drawing.Point(31, 156);
            this.gbQueryByStudentId.Name = "gbQueryByStudentId";
            this.gbQueryByStudentId.Size = new System.Drawing.Size(380, 67);
            this.gbQueryByStudentId.TabIndex = 11;
            this.gbQueryByStudentId.TabStop = false;
            this.gbQueryByStudentId.Text = "按学号精确查询";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入学号：";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(99, 28);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(157, 21);
            this.txtStudentId.TabIndex = 1;
            // 
            // btnSubmitQuery
            // 
            this.btnSubmitQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitQuery.Location = new System.Drawing.Point(280, 26);
            this.btnSubmitQuery.Name = "btnSubmitQuery";
            this.btnSubmitQuery.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitQuery.TabIndex = 7;
            this.btnSubmitQuery.Text = "提交查询";
            this.btnSubmitQuery.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(563, 182);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "打印当前学员信息";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.ClassId});
            this.dataGridView1.Location = new System.Drawing.Point(31, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(665, 237);
            this.dataGridView1.TabIndex = 13;
            // 
            // StudentNo
            // 
            this.StudentNo.HeaderText = "学号";
            this.StudentNo.Name = "StudentNo";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            // 
            // ClassId
            // 
            this.ClassId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassId.HeaderText = "所在班级";
            this.ClassId.Name = "ClassId";
            // 
            // FrmStudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbQueryByStudentId);
            this.Controls.Add(this.gbQueryByClass);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentManage";
            this.Text = "学员信息管理";
            this.gbQueryByClass.ResumeLayout(false);
            this.gbQueryByClass.PerformLayout();
            this.gbQueryByStudentId.ResumeLayout(false);
            this.gbQueryByStudentId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbQueryByClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnStudentIdDesc;
        private System.Windows.Forms.Button btnNameDesc;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbQueryByStudentId;
        private System.Windows.Forms.Button btnSubmitQuery;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
    }
}