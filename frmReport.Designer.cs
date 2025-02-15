namespace student
{
    partial class frmReport
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.TxtGrad = new System.Windows.Forms.TextBox();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.cmbS = new System.Windows.Forms.ComboBox();
            this.laR = new System.Windows.Forms.Label();
            this.laC = new System.Windows.Forms.Label();
            this.laS = new System.Windows.Forms.Label();
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
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.TxtGrad);
            this.Gbox.Controls.Add(this.cmbC);
            this.Gbox.Controls.Add(this.cmbS);
            this.Gbox.Controls.Add(this.laR);
            this.Gbox.Controls.Add(this.laC);
            this.Gbox.Controls.Add(this.laS);
            this.Gbox.Location = new System.Drawing.Point(16, 9);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(731, 128);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            this.Gbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(503, 80);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(166, 37);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // TxtGrad
            // 
            this.TxtGrad.Location = new System.Drawing.Point(521, 25);
            this.TxtGrad.Name = "TxtGrad";
            this.TxtGrad.Size = new System.Drawing.Size(149, 28);
            this.TxtGrad.TabIndex = 5;
            // 
            // cmbC
            // 
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Location = new System.Drawing.Point(105, 79);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(145, 26);
            this.cmbC.TabIndex = 4;
            // 
            // cmbS
            // 
            this.cmbS.FormattingEnabled = true;
            this.cmbS.Location = new System.Drawing.Point(109, 24);
            this.cmbS.Name = "cmbS";
            this.cmbS.Size = new System.Drawing.Size(142, 26);
            this.cmbS.TabIndex = 3;
            this.cmbS.SelectedIndexChanged += new System.EventHandler(this.cmbS_SelectedIndexChanged);
            // 
            // laR
            // 
            this.laR.AutoSize = true;
            this.laR.Location = new System.Drawing.Point(440, 24);
            this.laR.Name = "laR";
            this.laR.Size = new System.Drawing.Size(44, 18);
            this.laR.TabIndex = 2;
            this.laR.Text = "成绩";
            this.laR.Click += new System.EventHandler(this.laR_Click);
            // 
            // laC
            // 
            this.laC.AutoSize = true;
            this.laC.Location = new System.Drawing.Point(27, 79);
            this.laC.Name = "laC";
            this.laC.Size = new System.Drawing.Size(44, 18);
            this.laC.TabIndex = 1;
            this.laC.Text = "课程";
            // 
            // laS
            // 
            this.laS.AutoSize = true;
            this.laS.Location = new System.Drawing.Point(23, 24);
            this.laS.Name = "laS";
            this.laS.Size = new System.Drawing.Size(44, 18);
            this.laS.TabIndex = 0;
            this.laS.Text = "学号";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(254, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(455, 389);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(146, 40);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(629, 392);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(117, 37);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(26, 146);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(707, 226);
            this.dataGView.TabIndex = 4;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Gbox);
            this.Name = "frmReport";
            this.Text = "成绩信息输入窗口";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox TxtGrad;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.ComboBox cmbS;
        private System.Windows.Forms.Label laR;
        private System.Windows.Forms.Label laC;
        private System.Windows.Forms.Label laS;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView dataGView;
    }
}