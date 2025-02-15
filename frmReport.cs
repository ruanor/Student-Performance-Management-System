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
    public partial class frmReport : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {//----绑定DataGivdView数据     
            try
            {
                sql = "select ryc_sno as 学号,ryc_cno as 课程,ryc_grade as 成绩 from ruanyc_reports";
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
        protected void CmbSBind()
        {
            try
            {
                cmbS.DropDownStyle = ComboBoxStyle.DropDownList;
                ds = con.Getds("select ryc_sno from ruanyc_students");
                cmbS.ValueMember = "ryc_sno";
                cmbS.DisplayMember = "ryc_sno";
                cmbS.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void CmbCBind()
        {
            try
            {
                cmbC.DropDownStyle = ComboBoxStyle.DropDownList;
                ds = con.Getds("select  ryc_cno from ruanyc_courses");
                cmbC.DisplayMember = "ryc_cno";
                cmbC.ValueMember = "ryc_cno";
                cmbC.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public frmReport()
        {
            InitializeComponent(); 
            SetBind();
            CmbSBind();
            CmbCBind();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into ruanyc_reports values( '" + cmbS.SelectedValue.ToString() + "','" + cmbC.SelectedValue.ToString() + "'," + TxtGrad.Text + ")";
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
                    sql = "delete from ruanyc_reports where ryc_sno='" + dataGView.CurrentRow.Cells[0].Value.ToString()
   + "' and ryc_cno='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
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
                sql = "update ruanyc_reports set ryc_grade=" + dataGView.CurrentRow.Cells[2].Value.ToString() + " where ryc_sno='" + dataGView.CurrentRow.Cells[0].Value.ToString()
                       + "' and ryc_cno='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
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

        private void cmbS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void laR_Click(object sender, EventArgs e)
        {

        }
    }
}
