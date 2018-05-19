using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TreeLib
{
    public class NumericTree : BaseTree<int>
    {

        //private
        private void SubRandom(Node<int> node, int level, double probality, Random random)
        {
            //Random random = new Random();
            if (level == 0)
            {
                node = null;
                return;
            }
            node.Value = random.Next(10);
            if (random.NextDouble() <= probality && level > 1)
            {
                node.Left = new Node<int>(0, node, node.Level + 1);
                SubRandom(node.Left, level - 1, probality, random);
            }
            if (random.NextDouble() <= probality && level > 1)
            {
                node.Right = new Node<int>(0, node, node.Level + 1);
                SubRandom(node.Right, level - 1, probality, random);
            }
        }


        //public
        public void Random(int level, double probality)
        {
            Level = level;
            Random random = new Random();
            Root = new Node<int>(random.Next(10), null, 1);
            if (random.NextDouble() <= probality && level > 1)
            {
                Root.Left = new Node<int>(0, Root, Root.Level + 1);
                SubRandom(Root.Left, level - 1, probality, random);
            }
            if (random.NextDouble() <= probality && level > 1)
            {
                Root.Right = new Node<int>(0, Root, Root.Level + 1);
                SubRandom(Root.Right, level - 1, probality, random);
            }
        }


        private int SubWalk(Node<int> node, uint neededLevel)
        {
            if (node == null)
                return 0;
            int tmp = 0;
            //MessageBox.Show(node.Level.ToString());
            if (node.Level == neededLevel)
                tmp += node.Value;
            tmp += SubWalk(node.Left, neededLevel) + SubWalk(node.Right, neededLevel);
            return tmp;
        }

        public int Walk(uint neededLevel)
        {
            return SubWalk(Root, neededLevel);
        }

        public Bitmap Draw(uint handledLevel)
        {
            Bitmap bitmap = new Bitmap(BitmapWidth, BitmapHeight);
            DrawLine(bitmap, Root, DrawX, DrawY, DrawH);
            DrawInfo di;
            di.HandledNodeColor = HandledNodeColor;
            di.NodeColor = NodeColor;
            di.HandledLevel = handledLevel;
            DrawNode(bitmap, Root, DrawX, DrawY, DrawH, di);
            return bitmap;
        }



        //construct
        public NumericTree()
        {
            R = 15; //радиус для чисел = 15
            //настройка отрисовки
            //CurrentNodeColor = Color.Blue;
            NodeColor = Color.BurlyWood;
            HandledNodeColor = Color.Yellow;
            BitmapWidth = 600;
            BitmapHeight = 600;
            DrawX = 20;
            DrawY = 580;
            DrawH = 60;
        }
    }
}
