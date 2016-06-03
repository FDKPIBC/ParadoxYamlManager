namespace StellarisYaml
{
    partial class LineDetails
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
            this.tbxLineContent = new System.Windows.Forms.TextBox();
            this.btnSaveLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLineTag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLineNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxLineContent
            // 
            this.tbxLineContent.Location = new System.Drawing.Point(12, 53);
            this.tbxLineContent.Multiline = true;
            this.tbxLineContent.Name = "tbxLineContent";
            this.tbxLineContent.Size = new System.Drawing.Size(631, 50);
            this.tbxLineContent.TabIndex = 0;
            // 
            // btnSaveLine
            // 
            this.btnSaveLine.Location = new System.Drawing.Point(569, 24);
            this.btnSaveLine.Name = "btnSaveLine";
            this.btnSaveLine.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLine.TabIndex = 1;
            this.btnSaveLine.Text = "保存";
            this.btnSaveLine.UseVisualStyleBackColor = true;
            this.btnSaveLine.Click += new System.EventHandler(this.btnSaveLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "编号:";
            // 
            // lbLineTag
            // 
            this.lbLineTag.AutoSize = true;
            this.lbLineTag.Location = new System.Drawing.Point(54, 9);
            this.lbLineTag.Name = "lbLineTag";
            this.lbLineTag.Size = new System.Drawing.Size(0, 12);
            this.lbLineTag.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "行号:";
            // 
            // lbLineNumber
            // 
            this.lbLineNumber.AutoSize = true;
            this.lbLineNumber.Location = new System.Drawing.Point(54, 32);
            this.lbLineNumber.Name = "lbLineNumber";
            this.lbLineNumber.Size = new System.Drawing.Size(0, 12);
            this.lbLineNumber.TabIndex = 6;
            // 
            // LineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 115);
            this.Controls.Add(this.lbLineNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLineTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveLine);
            this.Controls.Add(this.tbxLineContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LineDetails";
            this.Text = "Create By FDKPIBC";
            this.Load += new System.EventHandler(this.LineDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLineContent;
        private System.Windows.Forms.Button btnSaveLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLineTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLineNumber;
    }
}