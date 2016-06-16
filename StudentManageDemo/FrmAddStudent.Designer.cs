namespace StudentManageDemo
{
    partial class FrmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnStartUpCamera = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnChoosePic = new System.Windows.Forms.Button();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAttendenceNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdentityNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "添加新学员";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(481, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 24);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmAdd.Image")));
            this.btnConfirmAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmAdd.Location = new System.Drawing.Point(383, 36);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(82, 24);
            this.btnConfirmAdd.TabIndex = 11;
            this.btnConfirmAdd.Text = "确认添加";
            this.btnConfirmAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // pbCamera
            // 
            this.pbCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCamera.Location = new System.Drawing.Point(29, 82);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(199, 174);
            this.pbCamera.TabIndex = 12;
            this.pbCamera.TabStop = false;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(393, 82);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(199, 174);
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            // 
            // btnStartUpCamera
            // 
            this.btnStartUpCamera.Location = new System.Drawing.Point(250, 96);
            this.btnStartUpCamera.Name = "btnStartUpCamera";
            this.btnStartUpCamera.Size = new System.Drawing.Size(120, 23);
            this.btnStartUpCamera.TabIndex = 14;
            this.btnStartUpCamera.Text = "启动摄像头";
            this.btnStartUpCamera.UseVisualStyleBackColor = true;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Location = new System.Drawing.Point(250, 130);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(120, 23);
            this.btnTakePhoto.TabIndex = 15;
            this.btnTakePhoto.Text = "开始拍照";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.Location = new System.Drawing.Point(250, 225);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(120, 23);
            this.btnChoosePic.TabIndex = 17;
            this.btnChoosePic.Text = "直接选择照片";
            this.btnChoosePic.UseVisualStyleBackColor = true;
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.Location = new System.Drawing.Point(250, 165);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(120, 23);
            this.btnClearPhoto.TabIndex = 16;
            this.btnClearPhoto.Text = "清除照片";
            this.btnClearPhoto.UseVisualStyleBackColor = true;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.txtAddress);
            this.gbStudentInfo.Controls.Add(this.label9);
            this.gbStudentInfo.Controls.Add(this.txtTel);
            this.gbStudentInfo.Controls.Add(this.label8);
            this.gbStudentInfo.Controls.Add(this.txtAttendenceNo);
            this.gbStudentInfo.Controls.Add(this.label7);
            this.gbStudentInfo.Controls.Add(this.txtIdentityNo);
            this.gbStudentInfo.Controls.Add(this.label6);
            this.gbStudentInfo.Controls.Add(this.cbClass);
            this.gbStudentInfo.Controls.Add(this.label5);
            this.gbStudentInfo.Controls.Add(this.dtpBirthday);
            this.gbStudentInfo.Controls.Add(this.label4);
            this.gbStudentInfo.Controls.Add(this.rbtnFemale);
            this.gbStudentInfo.Controls.Add(this.rbtnMale);
            this.gbStudentInfo.Controls.Add(this.label3);
            this.gbStudentInfo.Controls.Add(this.txtStudentName);
            this.gbStudentInfo.Controls.Add(this.label2);
            this.gbStudentInfo.Location = new System.Drawing.Point(29, 276);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(563, 192);
            this.gbStudentInfo.TabIndex = 18;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "[学员基本信息]";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(85, 143);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(461, 21);
            this.txtAddress.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "家庭住址：";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(297, 102);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(249, 21);
            this.txtTel.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "联系电话：";
            // 
            // txtAttendenceNo
            // 
            this.txtAttendenceNo.Location = new System.Drawing.Point(85, 102);
            this.txtAttendenceNo.Name = "txtAttendenceNo";
            this.txtAttendenceNo.Size = new System.Drawing.Size(126, 21);
            this.txtAttendenceNo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "考勤卡号：";
            // 
            // txtIdentityNo
            // 
            this.txtIdentityNo.Location = new System.Drawing.Point(297, 65);
            this.txtIdentityNo.Name = "txtIdentityNo";
            this.txtIdentityNo.Size = new System.Drawing.Size(249, 21);
            this.txtIdentityNo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "身份证号：";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(89, 65);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(113, 20);
            this.cbClass.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "所在班级：";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(433, 27);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(113, 21);
            this.dtpBirthday.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "出生日期：";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(319, 30);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(35, 16);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(276, 30);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "性别：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(85, 27);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(126, 21);
            this.txtStudentName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生姓名：";
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 495);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.btnChoosePic);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.btnStartUpCamera);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddStudent";
            this.Text = "FrmAddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnStartUpCamera;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnChoosePic;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAttendenceNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
    }
}