namespace student
{
    partial class frmSource
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(25, 87);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 62;
            this.dataGView.RowTemplate.Height = 30;
            this.dataGView.Size = new System.Drawing.Size(694, 258);
            this.dataGView.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(520, 381);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(138, 41);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(308, 382);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(135, 39);
            this.Select.TabIndex = 2;
            this.Select.Text = "查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "生源地";
            // 
            // cBox
            // 
            this.cBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(195, 26);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(174, 26);
            this.cBox.TabIndex = 4;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.cBox_SelectedIndexChanged);
            // 
            // frmSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.dataGView);
            this.Name = "frmSource";
            this.Text = "生源信息查询窗口";
            this.Load += new System.EventHandler(this.frmSource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox;
    }
}