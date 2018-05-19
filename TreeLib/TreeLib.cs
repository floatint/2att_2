using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TreeLib
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Parent;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T value)
        {
            Value = value;
        }
    }

    public class Tree<T>
    {
        protected Node<T> Root;
        //for drawing
        protected int Level;

    }

    //Дерево разбора выражений
    public class ExpressionTree : Tree<string>
    {
        //Проверка валидности
        private bool CheckExpression(ref string[] lexems, ref int pos)
        {
            /*
             * <выражение>  ::= T | F | And (<операнды>) | Or (<операнды>)
             * <операнды>  ::= <выражение>,<выражение>
             */

            //Исключение тут может быть только одно - выход за границы массива, т.к.
            //При рекурсии будет возвращаться pos++, при проверке последней скобки корневого выра
            //жения произойдет выход за границы массива, что означает дизбаланс скобо == несоответсвие грамматике
            try
            {
                if ((lexems[pos] == "T") || (lexems[pos] == "F"))
                {
                    pos++;
                    return true;
                }

                if ((lexems[pos] == "Or") || (lexems[pos] == "And"))
                {
                    pos++;
                    if (lexems[pos] == "(")
                    {
                        pos++;
                        //рекурсивная проверка
                        if (CheckExpression(ref lexems, ref pos))
                        {
                            if (lexems[pos] == ",")
                            {
                                pos++;
                                if (CheckExpression(ref lexems, ref pos))
                                {
                                    if (lexems[pos] == ")")
                                    {
                                        pos++;
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        //Рекурсивная сборка дерева
        private void SubTreeBuild(ref Node<string> root, ref string[] lexems, ref int pos)
        {
            if (pos >= lexems.Length)
                return;
            if (lexems[pos] == "")
            {
                pos++;
                SubTreeBuild(ref root, ref lexems, ref pos);
                return;
            }
            root = new Node<string>(lexems[pos]);
            if (root.Value == "T" || root.Value == "F")
            {
                pos++;
                return;
            }
            else
            {
                pos++;
                SubTreeBuild(ref root.Left, ref lexems, ref pos);
                SubTreeBuild(ref root.Right, ref lexems, ref pos);
            }

        }

        //Сборка дерева
        public bool BuildTree(string str)
        {
            string tmp = "";
            string[] lexems = new string[0];
            for (int i = 0; i < str.Length; i++)
            {
                /*if (str[i] == ' ')
                    break;
                if (!(str[i] == '(' || str[i] == ')' || str[i] == ','))
                {
                    tmp += str[i];
                    continue;
                }
                if (tmp.Length != 0)
                {
                    Array.Resize<string>(ref lexems, lexems.Length + 1);
                    lexems[lexems.Length - 1] = tmp;
                    tmp = "";
                }
                Array.Resize<string>(ref lexems, lexems.Length + 1);
                lexems[lexems.Length - 1] = str[i].ToString() ;
                */

                switch (str[i])
                {
                    case ' ':
                        break;
                    case '(':
                        {
                            if (tmp.Length != 0)
                            {
                                Array.Resize<string>(ref lexems, lexems.Length + 1);
                                lexems[lexems.Length - 1] = tmp;
                                tmp = "";
                            }
                            Array.Resize<string>(ref lexems, lexems.Length + 1);
                            lexems[lexems.Length - 1] = "(";
                            break;
                        }
                    case ',':
                        {
                            if (tmp.Length != 0)
                            {
                                Array.Resize<string>(ref lexems, lexems.Length + 1);
                                lexems[lexems.Length - 1] = tmp;
                                tmp = "";
                            }
                            Array.Resize<string>(ref lexems, lexems.Length + 1);
                            lexems[lexems.Length - 1] = ",";
                            break;
                        }
                    case ')':
                        {
                            if (tmp.Length != 0)
                            {
                                Array.Resize<string>(ref lexems, lexems.Length + 1);
                                lexems[lexems.Length - 1] = tmp;
                                tmp = "";
                            }
                            Array.Resize<string>(ref lexems, lexems.Length + 1);
                            lexems[lexems.Length - 1] = ")";
                            break;
                        }
                    default:
                        {
                            tmp += str[i];
                            break;
                        }
                }
            }
            if (tmp.Length != 0)
            {
                Array.Resize<string>(ref lexems, lexems.Length + 1);
                lexems[lexems.Length - 1] = tmp;
                tmp = "";
            }
            //Разбили на токены, нужно проверить последовательность на соответствие грамматике
            int pos = 0; //начальная позиция в буфере лексем
            bool state = false; //результат проверки

            state = CheckExpression(ref lexems, ref pos);
            //если остались еще скобки или элементы в буфере
            state &= (pos == lexems.Length);
            if (!state)
                return false;
            //Если выражение корректно, то можно выкинуть все лишнее из него (запятые и скобки)
            //Для упрощения построения дерева

            for (int i = 0; i < lexems.Length; i++)
            {
                if ((lexems[i] == "(") || (lexems[i] == ")") || (lexems[i] == ","))
                    lexems[i] = "";
            }
            pos = 0; //Обнулим счетчик лексем

            //Рекурсивная сборка дерева
            SubTreeBuild(ref Root, ref lexems, ref pos);
            return true;
        }

        //рекурсия обхода
        private bool SubWalk(Node<string> root)
        {
            if (root == null)
                return false;
            if (root.Value == "F")
                return false;
            if (root.Value == "T")
                return true;
            if (root.Value == "Or")
            {
                return (SubWalk(root.Left) || SubWalk(root.Right));
            }
            if (root.Value == "And")
            {
                return (SubWalk(root.Left) && SubWalk(root.Right));
            }
            return false;
        }

        //Обход дерева 
        public bool Walk()
        {
            return SubWalk(Root);
        }

    }

    public class NumericTree : Tree<int>
    {

        private void SubGen(Node<int> subRoot, int level, int maxLevel)
        {
            Random rnd = new Random();
            //рекурсивно
            if (level <= maxLevel)
            {
                //MessageBox.Show(String.Format("Уровень {0}. Создали левого потомка", level));
                subRoot.Left = new Node<int>(rnd.Next(10));
                //subRoot.Left.Value = rnd.Next(10);
                SubGen(subRoot.Left, level + 1, maxLevel);
                //MessageBox.Show(String.Format("Уровень {0}. Создали правого потомка", level));
                subRoot.Right = new Node<int>(rnd.Next(10));
                //subRoot.Right.Value = rnd.Next(10);
                SubGen(subRoot.Right, level + 1, maxLevel);
            }
        }


        //генерирует деревце, где все узлы имеют два потомка
        public void Generate(int maxLevel)
        {
            //Корень есть (1 ур, начинаем генерацию со 2 уровня)
            SubGen(Root, Level + 1, maxLevel);
            Level = maxLevel;
        }

        private void SubDraw(ref Bitmap map, Node<int> subRoot, int x, int y)
        {
            if (subRoot == null)
                return;
            Pen pen = new Pen(Brushes.Black, 3);
            Graphics a = Graphics.FromImage(map);
            a.DrawEllipse(pen, x, y, 30, 30);
            //SubDraw(ref map, subRoot.Left, x - (x / 2), y + 40);
            //SubDraw(ref map, subRoot.Right, x + (x / 2), y + 40);
            SubDraw(ref map, subRoot.Left, x - 50, y + 40);
            SubDraw(ref map, subRoot.Right, x + 50, y + 40);
        }

        public Bitmap Draw()
        {
            //определить размер битмапа
            Bitmap result = new Bitmap(1000,1000);
            SubDraw(ref result, Root, 450, 0);
            return result;
        }

        //Construct
        public NumericTree(int value)
        {
            Root = new Node<int>(value);
            //Root.Value = value;
            Root.Left = null;
            Root.Right = null;
            Level++;
        }
    }
}
