using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._1
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            //   this.CreateGraphics().DrawEllipse(new Pen(Color.Black), 50, 50, 50, 50);
            //TreeLib.NumericTree t = new TreeLib.NumericTree(1);
            //t.Generate(4);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            TreeLib.NumericTree t = new TreeLib.NumericTree(1);
            t.Generate(3);
            Pen pen = new Pen(new SolidBrush(Color.Black), 4);
            this.CreateGraphics().DrawImage(t.Draw(), 100, 10);
            //this.CreateGraphics().DrawEllipse(pen, 0, 100, 30, 30);
        }
    }
}
