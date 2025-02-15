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
    public partial class frmClassTable : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "SELECT ryc_clno AS 班级名,ryc_cname AS 课程名,ryc_cyear AS 学年," +
                    "ryc_cterm AS 学期,ryc_ccredit AS 学分 FROM ruanyc_classtable";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
                dataGView.Columns[4].ReadOnly = true;
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
                ds = con.Getds("SELECT DISTINCT ryc_clno FROM ruanyc_classtable");
                cBox.DisplayMember = "ryc_clno";
                cBox.ValueMember = "ryc_clno";
                cBox.DataSource = ds.Tables[0];
                cBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmClassTable()
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
                sql = "SELECT ryc_clno AS 班级名,ryc_cname AS 课程名,ryc_cyear AS 学年," +
                    "ryc_cterm AS 学期," +
                    "ryc_ccredit AS 学分 FROM ruanyc_classtable WHERE ryc_clno='" +
                    cBox.SelectedValue.ToString()+"'";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
                dataGView.Columns[4].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmClassTable_Load(object sender, EventArgs e)
        {

        }
    }
}
