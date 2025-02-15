using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace student
{
    public partial class frmClass : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        protected void SetBind()
        {
            try
            {
                sql = "select ryc_dno as 系号,ryc_clno as 班级名 from ruanyc_classes";
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
            {   //对下拉框绑定学生         
                cBox.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox.Items.Clear();
                ds = con.Getds("SELECT ryc_dno,ryc_dname FROM ruanyc_depts");
                cBox.DisplayMember = "ryc_dname";
                cBox.ValueMember = "ryc_dno";
                cBox.DataSource = ds.Tables[0];
                cBox.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public frmClass()
        {
            InitializeComponent();
            SetBind();
            ComBoxBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_classes values( '" +  txtCname.Text + "','" + cBox.SelectedValue.ToString() + "')";
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
                    sql = "delete from ruanyc_classes where ryc_clno='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmClass_Load(object sender, EventArgs e)
        {

        }
    }
}
