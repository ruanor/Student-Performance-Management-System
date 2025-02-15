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
    public partial class frmTeacherTable : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "SELECT ryc_tname AS 教师名,ryc_cname AS 课程名,ryc_cyear AS 学年,ryc_cterm AS 学期 FROM ruanyc_teachertable";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
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
                ds = con.Getds("SELECT DISTINCT ryc_tname FROM ruanyc_teachertable");
                cBox.DisplayMember = "ryc_tname";
                cBox.ValueMember = "ryc_tname";
                cBox.DataSource = ds.Tables[0];
                cBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public frmTeacherTable()
        {
            InitializeComponent();
            SetBind();
            ComBoxBind();
        }

        private void frmTeacherTable_Load(object sender, EventArgs e)
        {

        }

        private void dataGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT ryc_tname AS 教师名,ryc_cname AS 课程名,ryc_cyear AS 学年,ryc_cterm AS 学期 " +
                    "FROM ruanyc_teachertable WHERE ryc_tname='"+cBox.SelectedValue.ToString()+"'";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
