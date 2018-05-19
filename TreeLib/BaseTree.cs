using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TreeLib
{

    public struct DrawInfo
    {
        //public bool IsBaseDraw;
        //public Color CurrentNode;
        public Color HandledNodeColor;
        public Color NodeColor;
        public uint HandledLevel;
    }

    public class Node<T>
    {
        public T Value;
        public Node<T> Parent;
        public Node<T> Previous;
        public Node<T> Next;
        public Node<T> Left;
        public Node<T> Right;
        public int Level;
        public Node(T value, Node<T> parent)
        {
            Value = value;
            Parent = parent;
        }
        public Node(T value, Node<T> parent, int level)
        {
            Value = value;
            Parent = parent;
            Level = level;
        }
        public Node(T value)
        {
            Value = value;
        }
        public Node()
        {

        }
    }


    public class BaseTree<T>
    {
        protected Node<T> Root;
        //protected Bitmap BaseMap;
        public int Level;
        protected int R;
        //drawing
        public int BitmapWidth;
        public int BitmapHeight;
        public Color HandledNodeColor;
        public Color NodeColor;
        protected int DrawX;
        protected int DrawY;
        protected int DrawH;


        protected void DrawNode(Bitmap bitmap, Node<T> node, int x, int y, int h, DrawInfo info)
        {
            if (node == null)
            {
                return;
            }

            int mid = (x + y) / 2;
            int rad = mid - x > R ? R : (y - x) / 2;
            Graphics graphics = Graphics.FromImage(bitmap);
            if (node.Level == info.HandledLevel)
                graphics.FillEllipse(new SolidBrush(info.HandledNodeColor), mid - rad, h - rad, rad * 2, rad * 2);
            else
                graphics.FillEllipse(new SolidBrush(info.NodeColor), mid - rad, h - rad, rad * 2, rad * 2);
            //graphics.FillEllipse(Brushes.CadetBlue, mid - rad, h - rad, rad * 2, rad * 2);
            graphics.DrawEllipse(Pens.Black, mid - rad, h - rad, rad * 2, rad * 2);
            graphics.DrawString(Convert.ToString(node.Value), new Font("Arial", (int)(rad * 1.1)), Brushes.Black, (float)(mid - rad / 1.2), (float)(h - rad / 1.2));
            DrawNode(bitmap, node.Left, x, mid, h + 40, info);
            DrawNode(bitmap, node.Right, mid, y, h + 40, info);
        }



        protected void DrawLine(Bitmap bitmap, Node<T> node, int x, int y, int h)
        {
            if (node == null)
            {
                return;
            }
            int mid = (x + y) / 2;
            Graphics graphics = Graphics.FromImage(bitmap);
            if (node.Left != null)
            {
                graphics.DrawLine(Pens.Black, mid, h, (x + mid) / 2, h + 40);
            }
            if (node.Right != null)
            {
                graphics.DrawLine(Pens.Black, mid, h, (y + mid) / 2, h + 40);
            }
            DrawLine(bitmap, node.Left, x, mid, h + 40);
            DrawLine(bitmap, node.Right, mid, y, h + 40);
        }

        //public BaseTree(T value)
        //{
        //    Root = new Node<T>(value);
        //    Root.Level++;
        //    Level++;
        //}
    }
}
