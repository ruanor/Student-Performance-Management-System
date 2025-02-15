using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPwd.Text == "")
                MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txtName.Text != "阮扬程" || txtPwd.Text != "123456")
                MessageBox.Show("用户名或密码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmMain fmain = new frmMain();
                fmain.Show();
                this.Hide();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void laName_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
