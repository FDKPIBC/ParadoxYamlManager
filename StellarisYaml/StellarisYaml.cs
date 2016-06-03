using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StellarisYaml.StellarisYamlModel;

namespace StellarisYaml
{
    public partial class StellarisYaml : Form
    {
        //bool isrefresh = false;

        public List<ListViewItem> ItemCache { get;private set; }

        /// <summary>
        /// 窗体初始化
        /// </summary>
        public StellarisYaml()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ItemCache = new List<ListViewItem>();
            foreach (var item in Local.YamlFiles)
            {
                lbFiles.Items.Add(item.FileName);
            }
            tbxContent.Enabled = false;
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex < 0) return;
            lvcontent.Items.Clear();
            this.BeginInvoke(new Action(() =>
            {
                var yaml = Local.YamlFiles.Find(t => t.FileName == lbFiles.SelectedItem.ToString());
                SetItemCache(yaml.Lines);
            }));
        }

        private void lvcontent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvcontent.SelectedIndices.Count < 1) return;
            var index = lvcontent.SelectedIndices[0];
            LineDetails ld = new LineDetails(lbFiles.SelectedItem.ToString(),int.Parse(ItemCache[0].Text));
            if (ld.ShowDialog() == DialogResult.OK) lbFiles_SelectedIndexChanged(null, e);
        }

        private void tbxContent_TextChanged(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex < 0) return;
            var text = tbxContent.Text;
            switch (cbQueryType.SelectedItem.ToString())
            {
                case "行号":
                    SetItemCache(t => t.LineNumber.ToString().Contains(text));
                    break;
                case "Tag":
                    SetItemCache(t => t.Tag.ToString().Contains(text));
                    break;
                case "文本":
                    SetItemCache(t => t.Content.ToString().Contains(text));
                    break;
            }
        }

        private void cbQueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex < 0) return;
            if (cbQueryType.SelectedIndex < 0) return;
            tbxContent.Enabled = true;
        }

        private void StellarisYaml_FormClosing(object sender, FormClosingEventArgs e)
        {
            Task.Factory.StartNew(new Action(() =>
            {
                if (MessageBox.Show("是否保存所有操作?", "StellarisYaml", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var item in Local.YamlFiles)
                    {
                        File.WriteAllLines(item.FullPath, Local.Native[item.FileName]);
                    }
                }
            }));
        }

        public Task<object> SetItemCache(Func<Line,bool> math)
        {
            var l = Local.YamlFiles.Find(t => t.FileName == lbFiles.SelectedItem.ToString()).Lines.Where(math).ToList();
            return SetItemCache(l);
        }

        private Task<object> SetItemCache(List<Line> lines)
        {
            ItemCache = new List<ListViewItem>();
            foreach (var line in lines)
            {
                var item = new ListViewItem();
                if (line.IsChanged)
                {
                    item.BackColor = Color.MediumVioletRed;
                }
                item.SubItems[0].Text = line.LineNumber.ToString();
                item.SubItems.Add(line.Tag);
                item.SubItems.Add(line.Content);;
                ItemCache.Add(item);
            }
            lvcontent.VirtualListSize = ItemCache.Count;
            return Task.FromResult<object>(null);
        }

        private void lvcontent_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (ItemCache == null && ItemCache.Count == 0) return;
            e.Item = ItemCache[e.ItemIndex];
        }

        private ListViewItem GetSelectItemByIndex(int index) => ItemCache[index];

        private string GetSelectItemTextByIndex(int index) => ItemCache[index].Text;
    }
}
