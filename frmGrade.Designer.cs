namespace student
{
    partial class frmGrade
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox2 = new System.Windows.Forms.ComboBox();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(584, 416);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(160, 45);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(383, 421);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(163, 40);
            this.Average.TabIndex = 1;
            this.Average.Text = "课程平均分统计";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(25, 85);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(775, 323);
            this.dataGView.TabIndex = 2;
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.label2);
            this.gBox.Controls.Add(this.cBox2);
            this.gBox.Controls.Add(this.cBox1);
            this.gBox.Controls.Add(this.label1);
            this.gBox.Location = new System.Drawing.Point(30, 8);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(755, 71);
            this.gBox.TabIndex = 3;
            this.gBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "学年";
            // 
            // cBox2
            // 
            this.cBox2.FormattingEnabled = true;
            this.cBox2.Location = new System.Drawing.Point(508, 28);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(205, 26);
            this.cBox2.TabIndex = 2;
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Location = new System.Drawing.Point(112, 24);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(164, 26);
            this.cBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生名";
            // 
            // Rank
            // 
            this.Rank.Location = new System.Drawing.Point(196, 421);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(151, 41);
            this.Rank.TabIndex = 4;
            this.Rank.Text = "排名";
            this.Rank.UseVisualStyleBackColor = true;
            this.Rank.Click += new System.EventHandler(this.Rank_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(50, 423);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(120, 39);
            this.Select.TabIndex = 5;
            this.Select.Text = "成绩查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 490);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Cancel);
            this.Name = "frmGrade";
            this.Text = "学生成绩统计窗口";
            this.Load += new System.EventHandler(this.frmGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rank;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox2;
        private System.Windows.Forms.ComboBox cBox1;
    }
}