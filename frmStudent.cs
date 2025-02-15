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
    public partial class frmStudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select ryc_sno as 学号,ryc_sname as 姓名,ryc_clno as 班级," +
                    "ryc_ssex as 性别,ryc_sage as 年龄,ryc_sposition as 生源,ryc_scredit as" +
                    " 学分 from ruanyc_students";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[6].ReadOnly = true;
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
            {   //对下拉框绑定学院信息           
                cBox.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox.Items.Clear();
                ds = con.Getds("select  ryc_clno  from ruanyc_classes");
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

        public frmStudent()
        {
            InitializeComponent();
            ComBoxBind();
            SetBind();
        }


        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_students values( '" + txtSno.Text + "','" + txtName.Text +
                    "','" + cBox.SelectedValue.ToString() + "','" + txtSex.Text + "'," + txtAge.Text
                    + ",'" + txtSource.Text + "'," + txtCredit.Text + ")";
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
                    sql = "delete from ruanyc_students where ryc_sno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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
                sql = "update ruanyc_students set ryc_sname='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                           "',ryc_ssex='" + dataGView.CurrentRow.Cells[3].Value.ToString() +
                           "',ryc_sage=" + dataGView.CurrentRow.Cells[4].Value.ToString() +
                           ",ryc_sposition='" + dataGView.CurrentRow.Cells[5].Value.ToString() +
                           "' where ryc_sno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void laDept_Click(object sender, EventArgs e)
        {

        }

        private void laTime_Click(object sender, EventArgs e)
        {

        }
    }
}
