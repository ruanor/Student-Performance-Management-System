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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent fStudent = new frmStudent();
            fStudent.ShowDialog();

        }

        private void 课程表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse fCourse = new frmCourse();
            fCourse.ShowDialog();

        }

        private void 系别表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDept fDept = new frmDept();
            fDept.ShowDialog();

        }

        private void 成绩表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport fReport = new frmReport();
            fReport.ShowDialog();

        }


        private void 调用存储过程演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcdure fProcdure = new frmProcdure();
            fProcdure.ShowDialog();

        }

        private void 教师课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherTable fProcdure = new frmTeacherTable();
            fProcdure.ShowDialog();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 班级课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassTable fProcdure = new frmClassTable();
            fProcdure.ShowDialog();
        }

        private void 生源信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSource fProcdure = new frmSource();
            fProcdure.ShowDialog();
        }

        private void 学生选课查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectCourse fProcdure = new frmSelectCourse();
            fProcdure.ShowDialog();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade fProcdure = new frmGrade();
            fProcdure.ShowDialog();
        }

        private void 教师表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacher fProcdure = new frmTeacher();
            fProcdure.ShowDialog();
        }

        private void 班级表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fProcdure = new frmClass();
            fProcdure.ShowDialog();
        }

        private void 教师授课表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeaCou fProcdure = new frmTeaCou();
            fProcdure.ShowDialog();
        }

        private void 班级开课表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClaCou fProcdure = new frmClaCou();
            fProcdure.ShowDialog();
        }

        private void 基本表维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
