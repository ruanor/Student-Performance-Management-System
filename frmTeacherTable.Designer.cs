namespace student
{
    partial class frmTeacherTable
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
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.laTname = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(32, 102);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(740, 246);
            this.dataGView.TabIndex = 0;
            this.dataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGView_CellContentClick);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(286, 366);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(130, 54);
            this.Select.TabIndex = 1;
            this.Select.Text = "查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(488, 367);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(123, 53);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // laTname
            // 
            this.laTname.AutoSize = true;
            this.laTname.Location = new System.Drawing.Point(85, 30);
            this.laTname.Name = "laTname";
            this.laTname.Size = new System.Drawing.Size(62, 18);
            this.laTname.TabIndex = 3;
            this.laTname.Text = "教师名";
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(190, 28);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(148, 26);
            this.cBox.TabIndex = 4;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.cBox_SelectedIndexChanged);
            // 
            // frmTeacherTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.laTname);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.dataGView);
            this.Name = "frmTeacherTable";
            this.Text = "教师课表查询窗口";
            this.Load += new System.EventHandler(this.frmTeacherTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label laTname;
        private System.Windows.Forms.ComboBox cBox;
    }
}