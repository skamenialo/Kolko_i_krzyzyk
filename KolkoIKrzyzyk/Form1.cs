using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoIKrzyzyk
{
    public partial class Form1 : Form
    {
        const Int32 k = 3;
        Char[][] t;
        Char gracz;
        Boolean siX, siO;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            siX = false;
            siO = false;
            Random r = new Random();
            if (r.Next(2) == 0)
                gracz = 'O';
            else
                gracz = 'X';
            for (int i = 0; i < k; i++)
            {
                AddAColumn(i);
            }
            dataGridView1.RowHeadersDefaultCellStyle.Padding = new Padding(3);
            for (int i = 0; i < k; i++)
            {
                AddARow(i);
            }

            t = new Char[dataGridView1.RowCount][];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Char[dataGridView1.ColumnCount];
                for (int j = 0; j < t[i].Length; j++)
                {
                    t[i][j] = ' ';
                    dataGridView1.Rows[i].Cells[j].Value = t[i][j].ToString();
                }
            }
            label2.Text = gracz.ToString();
            dataGridView1.ClearSelection();
        }
        private void AddARow(int i)
        {
            DataGridViewRow Arow = new DataGridViewRow();
            Arow.HeaderCell.Value = i.ToString();
            Arow.Height = dataGridView1.Height / k;
            dataGridView1.Rows.Add(Arow);
        }
        private void AddAColumn(int i)
        {
            DataGridViewTextBoxColumn Acolumn = new DataGridViewTextBoxColumn();
            Acolumn.Name = i.ToString();
            Acolumn.Width = dataGridView1.Width / k;
            Acolumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns.Add(Acolumn);
        }

        void Restart()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                    t[i][j] = ' ';
                }
            }
            dataGridView1.Enabled = true;
            Random r = new Random();
            if (r.Next(2) == 0)
            {
                gracz = 'O';
            }
            else
            {
                if (siX && !siO)
                {
                    Ruch(t, 'X');
                }
                else
                {
                    gracz = 'X';
                }
            }
            label1.Text = "Gracz";
            label2.Text = gracz.ToString();
            if (siX && siO)
                sIVsSI();
        }

        bool Wygrana(Char[][] t, Char g, bool cisza)
        {
            bool test = false;

            for (int i = 0; i < t.Length; i++)
            {
                if (test == false)
                {
                    test = (t[i][0] == g && t[i][1] == g && t[i][2] == g);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (test == false)
                {
                    test = (t[0][i] == g && t[1][i] == g && t[2][i] == g);
                }
            }
            if (test == false)
            {
                test = true;
                for (int i = 0; i < t.Length; i++)
                {
                    test = (test && t[i][i] == g);
                }
            }
            if (test == false)
            {
                test = true;
                for (int i = 0, j = t[i].Length - 1; i < t.Length; i++, j--)
                {
                    test = (test && t[i][j] == g);
                }
            }
            if (test)
            {
                if (!cisza)
                {
                    label1.Text = "Wygrywa";
                }
            }
            return test;
        }
        bool Remis(Char[][] t, bool cisza)
        {
            for (int i = 0; i < t.Length; i++)
                for (int j = 0; j < t[i].Length; j++)
                    if (t[i][j] == ' ')
                        return false;

            if (!cisza)
            {
                label1.Text = "Remis";
                label2.Text = "";
            }
            return true;
        }
        int MiniMax(ref List<Point> l, Char[][] t, Char g, int poz)
        {
            int m, mmx;
            mmx = (g == 'X') ? 2 : -2;
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < t[i].Length; j++)
                {
                    if (t[i][j] == ' ')
                    {
                        t[i][j] = g;
                        if (Wygrana(t, g, true))
                        {
                            m = (g == 'X') ? -1 : 1;
                        }
                        else if (Remis(t, true))
                        {
                            m = 0;
                        }
                        else
                        {
                            m = MiniMax(ref l, t, (g == 'X') ? 'O' : 'X', poz + 1);
                        }
                        if (((g == 'X') && (m < mmx)) || ((g == 'O') && (m > mmx)))
                        {
                            mmx = m;
                            if (!Convert.ToBoolean(poz))
                            {
                                l.Clear();
                            }
                        }
                        if (m == mmx)
                        {
                            if (!Convert.ToBoolean(poz))
                            {
                                l.Add(new Point(i, j));
                            }
                        }
                        t[i][j] = ' ';
                    }
                }
            }
            return mmx;
        }
        void Ruch(Char[][] t, Char g)
        {
            List<Point> lista = new List<Point>();
            Point wybor;
            MiniMax(ref lista, t, g, 0);
            Random rand = new Random();
            wybor = lista[rand.Next(lista.Count)];
            t[wybor.X][wybor.Y] = g;
            dataGridView1.Rows[wybor.X].Cells[wybor.Y].Value = g.ToString();
            if (!Wygrana(t, 'X', false) && !Wygrana(t, 'O', false))
            {
            }
            else if (Remis(t, false))
            {
            }
            else
            {
                label2.Text = g.ToString();
                dataGridView1.Enabled = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (t[e.RowIndex][e.ColumnIndex] == ' ')
            {

                dataGridView1.CurrentCell.Value = gracz;
                t[e.RowIndex][e.ColumnIndex] = Convert.ToChar(gracz);
                if (!Wygrana(t, 'X', false) && !Wygrana(t, 'O', false) && !Remis(t, false))
                {
                    if (gracz == 'O')
                        if (siX == false)
                        {   
                            gracz = 'X';
                            label2.Text = gracz.ToString();
                        }
                        else
                        {
                            Ruch(t, 'X');
                        }
                    else
                    {
                        if (siO == false)
                        {
                            gracz = 'O';
                            label2.Text = gracz.ToString();
                        }
                        else
                            Ruch(t, 'O');
                    }
                }
                else
                {
                    dataGridView1.Enabled = false;
                }
            }
            dataGridView1.CurrentCell.Selected = false;
        }
        async void sIVsSI()
        {
            bool test = true;
            do
            {
                await Task.Delay(1000);
                if (!Wygrana(t, 'X', false) && !Wygrana(t, 'O', false) && !Remis(t, false))
                {
                    if (gracz == 'O')
                    {
                        Ruch(t, 'O');
                        gracz = 'X';
                    }
                    else
                    {
                        Ruch(t, 'X');
                        gracz = 'O';
                    }
                }
                else
                {
                    test = false;
                }

            } while (test);
        }
        private void graczVsSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!siX || siO)
            {
                siX = true;
                siO = false;
                graczVsSIToolStripMenuItem.Checked = true;
                sIVsSIToolStripMenuItem.Checked = false;
                Restart();
            }
            else
            {
                siX = false;
                siO = false;
                graczVsSIToolStripMenuItem.Checked = false;
                sIVsSIToolStripMenuItem.Checked = false;
                Restart();
            }
        }

        private void restartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled)
            {
                if (MessageBox.Show("Czy napewno chcesz przerwać grę?", "Zakończ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void sIVsSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!siX && !siO)
            {
                siX = true;
                siO = true;
                graczVsSIToolStripMenuItem.Checked = false;
                sIVsSIToolStripMenuItem.Checked = true;
                Restart();
                sIVsSI();
            }
            else
            {
                siX = false;
                siO = false;
                graczVsSIToolStripMenuItem.Checked = false;
                sIVsSIToolStripMenuItem.Checked = false;
                Restart();
            }
        }
    }
}
