using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeLib
{
    internal class FileSystemNode
    {
        public FileSystemObject Object;
        public FileSystemNode Parent;
        public List<FileSystemNode> Nodes;

        public void AddNode(FileSystemNode node)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (String.Compare(node.Object.Name, Nodes[i].Object.Name, false) < 0)
                {
                    Nodes.Insert(i, node);
                    return;
                }
            }
            Nodes.Add(node);
        }

        public FileSystemNode(FileSystemObject obj, FileSystemNode parent)
        {
            Object = obj;
            Parent = parent;
            Nodes = new List<FileSystemNode>();
        }
    }

    public class FileSystemTree
    {
        private FileSystemNode Root; // root of tree

        private void SubBuild(FileSystemNode parent, DirectoryInfo[] dirs, FileInfo[] files)
        {
            FileSystemNode newNode = null;
            for (int i = 0; i < dirs.Length; i++)
            {
                newNode = new FileSystemNode(new FolderObject(dirs[i].FullName), parent);
                parent.AddNode(newNode);
                SubBuild(newNode, dirs[i].GetDirectories(), dirs[i].GetFiles());
            }
            for (int i = 0; i < files.Length; i++)
            {
                newNode = new FileSystemNode(new FileObject(files[i].FullName, files[i].LastAccessTime.ToFileTime()), parent);
                parent.AddNode(newNode);
            }
        }

        public void Build(DirectoryInfo dir)
        {
            Root = new FileSystemNode(new FolderObject(dir.FullName), null);
            SubBuild(Root, dir.GetDirectories(), dir.GetFiles());
        }

        private void SubToTreeView(List<FileSystemNode> nodes, TreeNode parent)
        {
            if (nodes.Count == 0)
                return;
            for (int i = 0; i < nodes.Count; i++)
            {
                //если нод папка
                if (nodes[i].Object.GetType() == typeof(FolderObject))
                {
                    TreeNode tmp = parent.Nodes.Add(nodes[i].Object.Name);
                    SubToTreeView(nodes[i].Nodes, tmp);
                }
                else //файл
                {
                    string name = nodes[i].Object.Name;
                    name = String.Format(name + " ({0})", DateTime.FromFileTime(((FileObject)nodes[i].Object).LastAccessDate));
                    parent.Nodes.Add(name);
                }
            }
        }

        public TreeNode ToTreeView()
        {
            TreeNode parent = new TreeNode(Root.Object.Name);
            SubToTreeView(Root.Nodes, parent);
            return parent;
        }

        private void SubDelete(FileSystemNode node, DateTime date)
        {
            if (node.Object.GetType() == typeof(FolderObject))
            {
                //начинаем с конца списка
                for (int i = node.Nodes.Count - 1; i >= 0; i--)
                {
                    SubDelete(node.Nodes[i], date);
                }

                //удаляем пустые папки кроме корня(его можно удалить в основном методе)
                if ((node.Nodes.Count == 0) && (node.Parent != null))
                {
                    node.Parent.Nodes.Remove(node);
                }
            }
            else
            {
                if (DateTime.FromFileTime(((FileObject)node.Object).LastAccessDate) < date)
                {
                    node.Parent.Nodes.Remove(node);
                }
            }
        }

        public void Delete(DateTime date)
        {
            if (Root == null)
                return;
            SubDelete(Root, date);
        }
    }
}
