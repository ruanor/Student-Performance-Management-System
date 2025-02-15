namespace student
{
    partial class frmStudent
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
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.laCredit = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laClno = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtCredit);
            this.Gbox.Controls.Add(this.txtSource);
            this.Gbox.Controls.Add(this.label3);
            this.Gbox.Controls.Add(this.label2);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.txtAge);
            this.Gbox.Controls.Add(this.txtSex);
            this.Gbox.Controls.Add(this.label1);
            this.Gbox.Controls.Add(this.cBox);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtSno);
            this.Gbox.Controls.Add(this.laCredit);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laClno);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Location = new System.Drawing.Point(39, 17);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(746, 134);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(475, 93);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(101, 28);
            this.txtCredit.TabIndex = 14;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(292, 92);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(93, 28);
            this.txtSource.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "生源";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "年龄";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(594, 76);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 54);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(648, 21);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(92, 28);
            this.txtAge.TabIndex = 10;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(454, 21);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(107, 28);
            this.txtSex.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "性别";
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(66, 91);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(130, 26);
            this.cBox.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(98, 28);
            this.txtName.TabIndex = 5;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(78, 19);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(98, 28);
            this.txtSno.TabIndex = 4;
            // 
            // laCredit
            // 
            this.laCredit.AutoSize = true;
            this.laCredit.Location = new System.Drawing.Point(391, 93);
            this.laCredit.Name = "laCredit";
            this.laCredit.Size = new System.Drawing.Size(71, 18);
            this.laCredit.TabIndex = 3;
            this.laCredit.Text = "学分(0)";
            this.laCredit.Click += new System.EventHandler(this.laTime_Click);
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(216, 24);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(44, 18);
            this.laName.TabIndex = 2;
            this.laName.Text = "姓名";
            // 
            // laClno
            // 
            this.laClno.AutoSize = true;
            this.laClno.Location = new System.Drawing.Point(16, 91);
            this.laClno.Name = "laClno";
            this.laClno.Size = new System.Drawing.Size(44, 18);
            this.laClno.TabIndex = 1;
            this.laClno.Text = "班级";
            this.laClno.Click += new System.EventHandler(this.laDept_Click);
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(16, 24);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(44, 18);
            this.laSno.TabIndex = 0;
            this.laSno.Text = "学号";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(39, 157);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(740, 274);
            this.dataGView.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(58, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(258, 437);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(166, 52);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(493, 444);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(181, 40);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "退出";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 522);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Name = "frmStudent";
            this.Text = "学生信息输入窗口";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label laCredit;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laClno;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label1;
    }
}