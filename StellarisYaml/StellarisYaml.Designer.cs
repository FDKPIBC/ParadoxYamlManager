namespace StellarisYaml
{
    partial class StellarisYaml
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQueryType = new System.Windows.Forms.ComboBox();
            this.lvcontent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 12;
            this.lbFiles.Location = new System.Drawing.Point(12, 12);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(156, 544);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.tbxContent);
            this.gbFile.Controls.Add(this.label1);
            this.gbFile.Controls.Add(this.cbQueryType);
            this.gbFile.Controls.Add(this.lvcontent);
            this.gbFile.Location = new System.Drawing.Point(174, 5);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(598, 551);
            this.gbFile.TabIndex = 1;
            this.gbFile.TabStop = false;
            // 
            // tbxContent
            // 
            this.tbxContent.Location = new System.Drawing.Point(200, 14);
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.Size = new System.Drawing.Size(392, 21);
            this.tbxContent.TabIndex = 7;
            this.tbxContent.TextChanged += new System.EventHandler(this.tbxContent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "查询类型:";
            // 
            // cbQueryType
            // 
            this.cbQueryType.FormattingEnabled = true;
            this.cbQueryType.Items.AddRange(new object[] {
            "行号",
            "Tag",
            "文本"});
            this.cbQueryType.Location = new System.Drawing.Point(72, 15);
            this.cbQueryType.Name = "cbQueryType";
            this.cbQueryType.Size = new System.Drawing.Size(121, 20);
            this.cbQueryType.TabIndex = 5;
            this.cbQueryType.SelectedIndexChanged += new System.EventHandler(this.cbQueryType_SelectedIndexChanged);
            // 
            // lvcontent
            // 
            this.lvcontent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvcontent.GridLines = true;
            this.lvcontent.Location = new System.Drawing.Point(6, 41);
            this.lvcontent.Name = "lvcontent";
            this.lvcontent.Size = new System.Drawing.Size(586, 504);
            this.lvcontent.TabIndex = 4;
            this.lvcontent.UseCompatibleStateImageBehavior = false;
            this.lvcontent.View = System.Windows.Forms.View.Details;
            this.lvcontent.VirtualMode = true;
            this.lvcontent.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvcontent_RetrieveVirtualItem);
            this.lvcontent.SelectedIndexChanged += new System.EventHandler(this.lvcontent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "行号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tag";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文本";
            this.columnHeader3.Width = 395;
            // 
            // StellarisYaml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gbFile);
            this.Controls.Add(this.lbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StellarisYaml";
            this.Text = "StellarisYaml";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StellarisYaml_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFile.ResumeLayout(false);
            this.gbFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.GroupBox gbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQueryType;
        private System.Windows.Forms.ListView lvcontent;
        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

