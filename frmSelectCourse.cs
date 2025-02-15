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
    public partial class frmSelectCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        protected void SetBind()
        {
            try
            {
                sql = "SELECT ryc_sname AS 姓名,ryc_cname AS 课程,ryc_ccredit AS 学分 FROM ruanyc_credit";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBind()
        {
            try
            {   //对下拉框绑定教师信息           
                cBox.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox.Items.Clear();
                ds = con.Getds("SELECT DISTINCT ryc_sname AS 姓名 FROM ruanyc_credit");
                cBox.DisplayMember = "姓名";
                cBox.ValueMember = "姓名";
                cBox.DataSource = ds.Tables[0];
                cBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmSelectCourse()
        {
            InitializeComponent();
            SetBind();
            ComBoxBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT ryc_sname AS 姓名,ryc_cname AS 课程,ryc_ccredit AS 学分 " +
                    "FROM ruanyc_credit WHERE ryc_sname='" 
                    +cBox.SelectedValue.ToString() + "'";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmSelectCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
