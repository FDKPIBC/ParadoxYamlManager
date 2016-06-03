using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StellarisYaml.StellarisYamlModel;

namespace StellarisYaml
{
    public partial class LineDetails : Form
    {
        string filename;
        int linenumber;
        Line line;
        public LineDetails(string FileName,int LineNumber)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            filename = FileName;
            linenumber = LineNumber;
            line = Local.YamlFiles.Find(t => t.FileName == filename).Lines.Find(l => l.LineNumber == linenumber);
            if (line == null)
            {
                MessageBox.Show("未找到所选行!");
                this.Close();
            }
        }

        private void LineDetails_Load(object sender, EventArgs e)
        {
            this.Text = $"{filename}:第{line.LineNumber.ToString()}行";
            //btnSaveLine.Enabled = false;
            lbLineNumber.Text = linenumber.ToString();
            lbLineTag.Text = line.Tag;
            tbxLineContent.Text = line.Content;
        }

        private void btnSaveLine_Click(object sender, EventArgs e)
        {
            var text = this.tbxLineContent.Text;
            string isIconCode = @"^.*£[^\u4e00-\u9fbb]+ .*$";
            if (text.IndexOf("£")>-1)
            {
                if (Regex.IsMatch(text.Substring(text.IndexOf("£") + 1), isIconCode))
                {
                    MessageBox.Show("文本中有:\"£xxxx \"格式的代码(该段代码结束后必须加一个空格分隔)...请勿修改!");
                    tbxLineContent.Text = line.Content;
                } 
            }
            Local.Native[filename][linenumber-1] = $"{line.Tag}:{line.Number} \"{text}\"";
            Local.YamlFiles.Find(t => t.FileName == filename).Lines.Find(l => l.LineNumber == linenumber).Content = text;
            Local.YamlFiles.Find(t => t.FileName == filename).Lines.Find(l => l.LineNumber == linenumber).IsChanged = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
