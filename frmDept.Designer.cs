namespace student
{
    partial class frmDept
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.laDno = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.txtDno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.Gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(321, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 28);
            this.txtName.TabIndex = 0;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(125, 104);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(595, 237);
            this.dataGView.TabIndex = 2;
            this.dataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGView_CellContentClick);
            // 
            // laDno
            // 
            this.laDno.AutoSize = true;
            this.laDno.Location = new System.Drawing.Point(6, 24);
            this.laDno.Name = "laDno";
            this.laDno.Size = new System.Drawing.Size(44, 18);
            this.laDno.TabIndex = 3;
            this.laDno.Text = "系号";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(239, 24);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(44, 18);
            this.laName.TabIndex = 4;
            this.laName.Text = "系名";
            this.laName.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(438, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 48);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(408, 365);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(125, 29);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(608, 367);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 26);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.txtDno);
            this.Gbox.Controls.Add(this.btnInsert);
            this.Gbox.Controls.Add(this.laDno);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Location = new System.Drawing.Point(155, 34);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(546, 64);
            this.Gbox.TabIndex = 9;
            this.Gbox.TabStop = false;
            this.Gbox.Enter += new System.EventHandler(this.Gbox_Enter);
            // 
            // txtDno
            // 
            this.txtDno.Location = new System.Drawing.Point(95, 21);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(79, 28);
            this.txtDno.TabIndex = 10;
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Name = "frmDept";
            this.Text = "系别信息输入窗口";
            this.Load += new System.EventHandler(this.frmDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label laDno;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtDno;
    }
}