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
    public partial class frmCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {  //绑定DataGivdView数据
            try
            {
                sql = "select ryc_cno as 课程号,ryc_cname as 课程名称,ryc_cyear as 学年," +
                    "ryc_cterm as 学期,ryc_chour as 学时,ryc_ccredit as 学分,ryc_cexam as" +
                    " 检测方式 from ruanyc_courses";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public frmCourse()
        {
            InitializeComponent();
            SetBind();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_courses values( '" + txtCno.Text + "','" + txtName.Text +
                    "'," + txtYear.Text + ",'" + txtTerm.Text + "'," + txtHour.Text 
                    + ","+ txtCredit.Text+ ",'" + txtExam.Text + "')";
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
                    sql = "delete from ruanyc_courses where ryc_cno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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
                sql = "update ruanyc_courses set ryc_cname='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                           "',ryc_cyear=" + dataGView.CurrentRow.Cells[2].Value.ToString() +
                           ",ryc_cterm='" + dataGView.CurrentRow.Cells[3].Value.ToString() +
                           "',ryc_chour=" + dataGView.CurrentRow.Cells[4].Value.ToString() +
                           ",ryc_ccredit=" + dataGView.CurrentRow.Cells[5].Value.ToString() +
                           ",ryc_cexam='" + dataGView.CurrentRow.Cells[6].Value.ToString() +
                           "' where ryc_cno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
