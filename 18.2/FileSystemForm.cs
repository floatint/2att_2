using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _18._2
{
    public partial class FileSystemForm : Form
    {
        private TreeLib.FileSystemTree FileSystem;

        public FileSystemForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            AccessTreeView.Nodes.Clear();
            FileSystem = new TreeLib.FileSystemTree();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Выберете папку для построения дерева.");
                return;
            }
            FileSystem.Build(new DirectoryInfo(fbd.SelectedPath));
            AccessTreeView.Nodes.Add(FileSystem.ToTreeView());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FileSystem == null)
                return;
            AccessTreeView.Nodes.Clear();
            FileSystem.Delete(DatePicker.Value);
            AccessTreeView.Nodes.Add(FileSystem.ToTreeView());
        }
    }
}
