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
    public partial class frmTeaCou : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        protected void SetBind()
        {
            try
            {
                sql = "select ryc_cno as 课程号,ryc_tno as 教师号 from ruanyc_tea_cou";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
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
            {   //对下拉框绑定教师,课程         
                cBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox1.Items.Clear();
                ds = con.Getds("SELECT ryc_tno FROM ruanyc_teachers");
                cBox1.DisplayMember = "ryc_tno";
                cBox1.ValueMember = "ryc_tno";
                cBox1.DataSource = ds.Tables[0];
                cBox1.SelectedIndex = 0;

                cBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox2.Items.Clear();
                ds = con.Getds("SELECT ryc_cno FROM ruanyc_courses");
                cBox2.DisplayMember = "ryc_cno";
                cBox2.ValueMember = "ryc_cno";
                cBox2.DataSource = ds.Tables[0];
                cBox2.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmTeaCou()
        {
            InitializeComponent();
            SetBind();
            ComBoxBind();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmTeaCou_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_tea_cou values( '" + cBox2.SelectedValue.ToString() + "','" + cBox1.SelectedValue.ToString() + "')";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from ruanyc_tea_cou where ryc_cno='" +
                        dataGView.CurrentRow.Cells[0].Value.ToString() + "'" +
                        " and ryc_tno='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
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
}
