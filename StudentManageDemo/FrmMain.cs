using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManageDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region Display form
        /// <summary>
        /// Close the previous form in the Control(SplitContainer.Panel2)
        /// </summary>
        private void CloseForm()
        {
            //Find a form control by traversing all the controls in the form and then close it
            //because the form is not sure, traversal method is applied
            foreach (Control item in spcLayout.Panel2.Controls)
            {
                if (item is Form)
                {
                    (item as Form).Close();
                }
            }
        }
        /// <summary>
        /// Open a new form in the Control(SplitContainer.Panel2)
        /// </summary>
        /// <param name="objForm">object opened</param>
        private void OpenForm(Form objForm)
        {
            this.CloseForm();//Close the prior form before opening a next form

            this.lbTitle.Visible = false;
            objForm.TopLevel = false;//设置子控件为非顶级控件
            objForm.FormBorderStyle = FormBorderStyle.None;//设置样式为无边框
            objForm.Parent = this.spcLayout.Panel2;//设置父窗体为Panel2
            objForm.Dock = DockStyle.Fill;//设置如果子窗体没有填满Panel2，自动填满
            objForm.Show();//显示窗体
        }
        #endregion

        #region button operation
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.OpenForm(new FrmAddStudent());
        }

        private void btnBatchImport_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentManage_Click(object sender, EventArgs e)
        {
            this.OpenForm(new FrmStudentManage());
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {

        }

        private void btnScoreAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnScoreBrowsing_Click(object sender, EventArgs e)
        {

        }

        private void btnPwdModified_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
