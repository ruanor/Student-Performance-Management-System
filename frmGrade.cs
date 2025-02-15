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
    public partial class frmGrade : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "SELECT ryc_sno AS 学号,ryc_sname AS 姓名,ryc_cname AS 课程," +
                    "ryc_cyear AS 学年" +
                    ",ryc_tname AS 教师,ryc_grade AS 成绩 FROM ruanyc_gradecount";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
                dataGView.Columns[4].ReadOnly = true;
                dataGView.Columns[5].ReadOnly = true;
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
                cBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox1.Items.Clear();
                ds = con.Getds("SELECT DISTINCT ryc_sno,ryc_sname FROM ruanyc_gradecount");
                cBox1.DisplayMember = "ryc_sname";
                cBox1.ValueMember = "ryc_sno";
                cBox1.DataSource = ds.Tables[0];
                cBox1.SelectedIndex = 0;

                cBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox2.Items.Clear();
                cBox2.Items.Add("1");//学年选择项1
                cBox2.Items.Add("2");
                cBox2.Items.Add("3");
                cBox2.Items.Add("4");
                cBox2.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmGrade()
        {
            InitializeComponent();
            SetBind();
            ComBoxBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {

        }

        private void Average_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT ruanyc_avggrade.ryc_cno AS 课程号,ruanyc_courses.ryc_cname AS " +
                    "课程名,ruanyc_avggrade.avg AS 平均分 FROM ruanyc_courses,ruanyc_avggrade " +
                    "WHERE ruanyc_courses.ryc_cno=ruanyc_avggrade.ryc_cno";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT ryc_sno AS 学号,ryc_sname AS 姓名,ryc_cname AS 课程," +
                    "ryc_cyear AS 学年" +
                    ",ryc_tname AS 教师,ryc_grade AS 成绩 FROM ruanyc_gradecount WHERE "+
                    "ryc_sno='"+cBox1.SelectedValue.ToString()+"' AND ryc_cyear="+
                    cBox2.SelectedItem.ToString();
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
                dataGView.Columns[4].ReadOnly = true;
                dataGView.Columns[5].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Rank_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT ryc_clno AS 班级,ryc_sno AS 学号,ryc_sname AS 姓名," +
                    "sum(ryc_grade) AS 总分 FROM ruanyc_gradecount GROUP BY ryc_sno," +
                    "ryc_sname,ryc_cyear,ryc_clno HAVING ryc_cyear="+cBox2.SelectedItem.ToString()+
                    " ORDER BY 总分 DESC";
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
