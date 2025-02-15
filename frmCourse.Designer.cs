namespace student
{
    partial class frmCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.laName = new System.Windows.Forms.Label();
            this.laCno = new System.Windows.Forms.Label();
            this.laCredit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.label4);
            this.Gbox.Controls.Add(this.txtExam);
            this.Gbox.Controls.Add(this.txtHour);
            this.Gbox.Controls.Add(this.label3);
            this.Gbox.Controls.Add(this.txtTerm);
            this.Gbox.Controls.Add(this.txtYear);
            this.Gbox.Controls.Add(this.label2);
            this.Gbox.Controls.Add(this.label1);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtCredit);
            this.Gbox.Controls.Add(this.txtCno);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laCno);
            this.Gbox.Controls.Add(this.laCredit);
            this.Gbox.Location = new System.Drawing.Point(38, 15);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(802, 114);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "检测方式";
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(550, 62);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(61, 28);
            this.txtExam.TabIndex = 14;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(337, 62);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(113, 28);
            this.txtHour.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "学时";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(705, 21);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(77, 28);
            this.txtTerm.TabIndex = 11;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(538, 21);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 28);
            this.txtYear.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "学期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "学年";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(617, 78);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(185, 30);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 28);
            this.txtName.TabIndex = 6;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(102, 61);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(125, 28);
            this.txtCredit.TabIndex = 5;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(99, 24);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(129, 28);
            this.txtCno.TabIndex = 4;
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(264, 24);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(62, 18);
            this.laName.TabIndex = 3;
            this.laName.Text = "课程名";
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(22, 24);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(62, 18);
            this.laCno.TabIndex = 2;
            this.laCno.Text = "课程号";
            // 
            // laCredit
            // 
            this.laCredit.AutoSize = true;
            this.laCredit.Location = new System.Drawing.Point(23, 57);
            this.laCredit.Name = "laCredit";
            this.laCredit.Size = new System.Drawing.Size(44, 18);
            this.laCredit.TabIndex = 1;
            this.laCredit.Text = "学分";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 48);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(451, 381);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(142, 47);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(631, 379);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(122, 48);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(43, 135);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(797, 238);
            this.dataGView.TabIndex = 4;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 484);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Gbox);
            this.Name = "frmCourse";
            this.Text = "课程信息输入窗口";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laCno;
        private System.Windows.Forms.Label laCredit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}