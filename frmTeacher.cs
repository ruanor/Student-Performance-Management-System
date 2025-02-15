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
    public partial class frmTeacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {  //绑定DataGivdView数据
            try
            {
                sql = "select ryc_tno as 教师号,ryc_tname as 教师名,ryc_tsex as 性别," +
                    "ryc_tage as 年龄,ryc_ttitle as 职称,ryc_tphone as 电话" +
                    " from ruanyc_teachers";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmTeacher()
        {
            InitializeComponent();
            SetBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_teachers values( '" + txtTno.Text + "','" + txtName.Text +
                    "','" + txtSex.Text + "'," + txtAge.Text + ",'" + txtTitle.Text
                    + "','" + txtPhone.Text + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from ruanyc_teachers where ryc_tno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update ruanyc_teachers set ryc_tname='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                           "',ryc_tsex='" + dataGView.CurrentRow.Cells[2].Value.ToString() +
                           "',ryc_tage=" + dataGView.CurrentRow.Cells[3].Value.ToString() +
                           ",ryc_ttitle='" + dataGView.CurrentRow.Cells[4].Value.ToString() +
                           "',ryc_tphone='" + dataGView.CurrentRow.Cells[5].Value.ToString() +
                           "'" +" where ryc_tno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
