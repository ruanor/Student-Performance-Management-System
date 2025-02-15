namespace student
{
    partial class frmProcdure
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
            this.laCredit = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laCredit
            // 
            this.laCredit.AutoSize = true;
            this.laCredit.Location = new System.Drawing.Point(90, 183);
            this.laCredit.Name = "laCredit";
            this.laCredit.Size = new System.Drawing.Size(80, 18);
            this.laCredit.TabIndex = 1;
            this.laCredit.Text = "最小学分";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(299, 173);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(271, 28);
            this.txtCredit.TabIndex = 3;
            this.txtCredit.TextChanged += new System.EventHandler(this.txtCredit_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(80, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(426, 327);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(169, 44);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmProcdure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.laCredit);
            this.Name = "frmProcdure";
            this.Text = "调用存储过程窗口";
            this.Load += new System.EventHandler(this.frmProcdure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laCredit;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cancel;
    }
}