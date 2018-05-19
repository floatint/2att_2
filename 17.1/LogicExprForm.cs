using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._1
{
    public partial class LogicExprForm : Form
    {
        public LogicExprForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            /*
                And(T, Or(T, Or(F, And(T, F))))
                And(T, Or(T, Or(F, T)))
                And(F, Or(T,T))
                And(F, Or(T, And(F, T)))             
             */
            if (exprTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите выражение.");
                return;
            }
            TreeLib.ExpressionTree expr = new TreeLib.ExpressionTree();

            if (!expr.BuildTree(exprTextBox.Text))
            {
                MessageBox.Show("Выражение не соответствует грамматике.");
                return;
            }

            if (expr.Walk())
                MessageBox.Show("True");
            else
                MessageBox.Show("False");


        }
    }
}
