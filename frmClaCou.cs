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
    public partial class frmClaCou : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        protected void SetBind()
        {
            try
            {
                sql = "select ryc_clno as 班级,ryc_cno as 课程号,ryc_tno as 教师号 from ruanyc_cla_cou";
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
            {   //对下拉框绑定班级,课程,教师         
                cBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox1.Items.Clear();
                ds = con.Getds("SELECT ryc_clno FROM ruanyc_classes");
                cBox1.DisplayMember = "ryc_clno";
                cBox1.ValueMember = "ryc_clno";
                cBox1.DataSource = ds.Tables[0];
                cBox1.SelectedIndex = 0;

                cBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox2.Items.Clear();
                ds = con.Getds("SELECT ryc_cno FROM ruanyc_courses");
                cBox2.DisplayMember = "ryc_cno";
                cBox2.ValueMember = "ryc_cno";
                cBox2.DataSource = ds.Tables[0];
                cBox2.SelectedIndex = 0;

                cBox3.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox3.Items.Clear();
                ds = con.Getds("SELECT ryc_tno FROM ruanyc_teachers");
                cBox3.DisplayMember = "ryc_tno";
                cBox3.ValueMember = "ryc_tno";
                cBox3.DataSource = ds.Tables[0];
                cBox3.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmClaCou()
        {
            InitializeComponent();
            SetBind();
            ComBoxBind();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClaCou_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_cla_cou values( '" + cBox1.SelectedValue.ToString() 
                    + "','" + cBox2.SelectedValue.ToString() + "','"+
                    cBox3.SelectedValue.ToString() +"')";
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
                    sql = "delete from ruanyc_cla_cou where ryc_clno='" +
                        dataGView.CurrentRow.Cells[0].Value.ToString() + "'"+
                        " and ryc_cno='"+ dataGView.CurrentRow.Cells[1].Value.ToString()+"'";
                    con.OperateData(sql);
                    SetBind();
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
                sql = "update ruanyc_cla_cou set ryc_tno='" + dataGView.CurrentRow.Cells[2].Value.ToString() +
                           "' where ryc_clno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "' and "+
                           "ryc_cno='"+ dataGView.CurrentRow.Cells[1].Value.ToString()+"'";
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
