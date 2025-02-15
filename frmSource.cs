using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace student
{
    public partial class frmSource : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public void My_Conbobox()
        {
            cBox.Items.Add("河北");//选择项1
            cBox.Items.Add("山西");
            cBox.Items.Add("辽宁");
            cBox.Items.Add("浙江");
            cBox.Items.Add("安徽");
            cBox.Items.Add("福建");
            cBox.Items.Add("湖北");
            cBox.Items.Add("湖南");
            cBox.Items.Add("广东");
            cBox.Items.Add("云南");
            cBox.Items.Add("陕西");
            cBox.Items.Add("甘肃");
            cBox.Items.Add("吉林");
            cBox.Items.Add("黑龙江");
            cBox.Items.Add("江苏");
            cBox.Items.Add("江西");
            cBox.Items.Add("山东");
            cBox.Items.Add("河南");
            cBox.Items.Add("海南");
            cBox.Items.Add("四川");
            cBox.Items.Add("贵州");
            cBox.Items.Add("青海");
            cBox.Items.Add("台湾");
            cBox.Items.Add("北京");
            cBox.Items.Add("天津");
            cBox.Items.Add("上海");
            cBox.Items.Add("重庆");
            cBox.Items.Add("香港");
            cBox.Items.Add("澳门");
            cBox.Items.Add("内蒙古");
            cBox.Items.Add("广西");
            cBox.Items.Add("西藏");
            cBox.Items.Add("宁夏");
            cBox.Items.Add("新疆");
        }
        protected void SetBind()
        {
            try
            {
                sql = "SELECT 生源,数量 FROM ruanyc_source";
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
        public frmSource()
        {
            InitializeComponent();
            My_Conbobox();
            SetBind();
        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT 生源,数量 FROM ruanyc_source WHERE 生源='" + 
                    cBox.SelectedItem.ToString()+"'";
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

        private void frmSource_Load(object sender, EventArgs e)
        {

        }
    }
}
