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
    public partial class frmDept : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select ryc_dno as 系号,ryc_dname as 系名 from ruanyc_Depts";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    public frmDept()
        {
            InitializeComponent();
            SetBind();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDept_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_Depts values( '" + txtDno.Text + "','" + txtName.Text + "')";
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
                    sql = "delete from ruanyc_Depts where ryc_dno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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
                sql = "update ruanyc_Depts set ryc_dname='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "' where ryc_dno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void Gbox_Enter(object sender, EventArgs e)
        {

        }

        private void dataGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
