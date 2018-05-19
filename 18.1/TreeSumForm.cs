using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _18._1
{
    public partial class TreeSumForm : Form
    {
        /*
         *  Идеи по задаче
         *  1)Синий цвет узла - были в нем
         *  2)Красный - узел который нам нужен, складываем
         *  3)Желтый - нужный узел, который посетили когда то
         *  
         *  Будет как в прошлой задачи массив битмапов
         *  Можно будет по шагам отрисовывать работу
         * 
        */
        public TreeSumForm()
        {
            InitializeComponent();
            //   this.CreateGraphics().DrawEllipse(new Pen(Color.Black), 50, 50, 50, 50);
            //TreeLib.NumericTree t = new TreeLib.NumericTree(1);
            //t.Generate(4);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (editKTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите k");
                return;
            }

            uint NeedHandleLevel = 0;

            if (!uint.TryParse(editKTextBox.Text, out NeedHandleLevel))
            {
                MessageBox.Show("Введите положительное число");
                return;
            }

            if (NeedHandleLevel == 0)
            {
                MessageBox.Show("Минимальный уровень для вычисления = 1");
                return;
            }


            TreeLib.NumericTree nt = new TreeLib.NumericTree();
            nt.Random(6, 0.7);
            Graphics graph = this.CreateGraphics();
            graph.FillRectangle(new SolidBrush(this.BackColor), 150, 1, nt.BitmapWidth, nt.BitmapHeight);
            graph.DrawImage(nt.Draw(NeedHandleLevel), 150, 1, nt.BitmapWidth, nt.BitmapHeight);
            SumLabel.Text = String.Format("Сумма на k-уровне : {0}", nt.Walk(NeedHandleLevel));
        }
    }
}
