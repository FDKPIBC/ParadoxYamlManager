using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using StellarisYaml.StellarisYamlModel;
using System.Diagnostics;

namespace StellarisYaml
{
    public partial class Start : Form
    {
        private string[] path;
        public Start()
        {
            InitializeComponent();
            Local.YamlFiles = new List<YamlFile>();
            path = new string[] { };
            Local.Native = new Dictionary<string, string[]>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) return;
            path = Directory.GetFiles(textBox1.Text,"*.yml");
            if (path.Length == 0)
            {
                MessageBox.Show("请选择一个正确的目录!");
                return;
            }
            button1.Enabled = true;
        }

        public Task<YamlFile> YamlToObject(string path)
        {
            YamlFile yf = new YamlFile();
            string[] content = File.ReadAllLines(path);
            yf.FullPath = path;
            yf.Header = content[0];
            yf.FileName = path.Substring(path.LastIndexOf("\\")+1);
            Local.Native.Add(yf.FileName,content);
            yf.Lines = new List<Line>();
            for (int i = 0; i < content.Length; i++)
            {
                if (!content[i].Trim().StartsWith("#") && !string.IsNullOrWhiteSpace(content[i]) && content[i] != "l_english:")
                {
                    yf.Lines.Add(new Line(content[i]) { LineNumber = i + 1 });
                }
            }
            return Task.FromResult(yf);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            foreach (var item in path)
            {
                YamlFile yf = YamlToObject(item).Result;
                if (yf != null)
                {
                    Local.YamlFiles.Add(yf);
                }
            }
            sw.Stop();
            MessageBox.Show(sw.Elapsed.ToString());
            StellarisYaml sy = new StellarisYaml();
            sy.ShowDialog();
            this.Close();
        }
    }
}
