using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saodkur
{
    public partial class Form1 : Form
    {
        static bool Perebor = false;
        public Form1()
        {
            InitializeComponent();
            WeiButton.Text = "10";
            itt = new items();
            openFileDialog1.Filter = "Text files(*.sav)|*.sav|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.sav)|*.sav|All files(*.*)|*.*";
        }
        //List<int> check = new List<int>();
        bool[] check;
        int Wid;
        public class items
        {
            private List<int> w=new List<int>();
            private List<int> v=new List<int>();
            private List<double> udsum = new List<double>();
            public void Add(int tw,int tv)
            {
               double  tub = tv / (double)tw;
                if (udsum.Count == 0)
                {
                    w.Add(tw);
                    v.Add(tv);
                    udsum.Add(tub);
                }
                else
                {
                    int ik = 0;
                    while(ik<udsum.Count && tub<udsum[ik])
                    {
                        ik++;
                    }
                    if(ik==udsum.Count)
                    {
                        w.Add(tw);
                        v.Add(tv);
                        udsum.Add(tub);
                    }
                    else
                    {
                        w.Insert(ik, tw);
                        v.Insert(ik, tv);
                        udsum.Insert(ik,tub);
                    }
                }
            }
            public int V(int i)
            {
                return v[i];
            }
            public void Clear()
            {
                v.Clear();
                w.Clear();
                udsum.Clear();
            }
            public int Count()
            {
                return v.Count;
            }
            public int W(int i)
            {
                return w[i];
            }
            public int size()
            {
                return v.Count();
            }
            //public void sort()
            //{
            //    //Array.Sort();
            //}
        }
        public static int W ,N;
        public class tree
        {
            int w=0;
            int v=0;
            int ub;
            int lastitem;
            static int maxub = 0;
            static int maxv = 0;
            
            tree left;//добавление предмета
            static items it;
            tree right;
            static Stack<tree> next = new Stack<tree>();

            public void show(object sender, PaintEventArgs e,int Xcord,int Ycord,double LEVEL)
            {
                int flag = 0;
                //Font drawfont (); 
                Pen penfont = new Pen(Color.DarkCyan, 3.5F);
                if (maxv == v && maxv==ub)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.PaleGoldenrod), Xcord - 75, Ycord, 80, 45);
                    e.Graphics.DrawRectangle(penfont, Xcord - 75, Ycord + 45 / 2, 80, 45 / 2);
                    e.Graphics.DrawRectangle(penfont, Xcord - 75, Ycord, 80, 45);
                }
                else if(left==null && right== null)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightSlateGray), Xcord - 75, Ycord, 80, 45);
                    e.Graphics.DrawRectangle(penfont, Xcord - 75, Ycord + 45 / 2, 80, 45 / 2);
                    e.Graphics.DrawRectangle(penfont, Xcord - 75, Ycord, 80, 45);
                }
                else
                {
                    e.Graphics.DrawRectangle(penfont, Xcord - 75, Ycord + 45 / 2, 80, 45/2);
                    e.Graphics.DrawRectangle(penfont, Xcord - 75, Ycord, 80, 45);                
                }
                e.Graphics.DrawString("W=" + Convert.ToString(w), new Font("Times New Roman", 9,FontStyle.Bold), Brushes.Indigo, Xcord - 85+12, Ycord + 4);
                e.Graphics.DrawString("V=" + Convert.ToString(v), new Font("Times New Roman", 9, FontStyle.Bold), Brushes.Indigo, Xcord - 85 + 43, Ycord + 4);
                e.Graphics.DrawString("UB=" + Convert.ToString(ub), new Font("Times New Roman", 9, FontStyle.Bold), Brushes.Indigo, Xcord - 85 + 25, Ycord + 8 + 16);
                int constanta;
                if (it.Count() <= 5) constanta = 500;
                else constanta=1500;
                if (left!=null)
                {
                    flag = 1;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.DarkOrange),2F), Xcord-45, Ycord+45, Xcord -Convert.ToInt32(constanta * (1 / LEVEL)) - 45, Ycord + 100);
                    left.show(sender, e, Xcord - Convert.ToInt32(constanta * (1/LEVEL)), Ycord + 100,LEVEL*2);
                }
                if(right!=null)
                {
                    flag = 1;
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.DarkOrange), 2F), Xcord-45, Ycord+45, Xcord + Convert.ToInt32(constanta * (1 / LEVEL)) - 45, Ycord + 100);
                    right.show(sender, e, Xcord + Convert.ToInt32(constanta * (1/LEVEL)), Ycord + 100,LEVEL*2);
                }
                
            }
            public void findmax(object sender, PaintEventArgs e, int Xcord, int Ycord, double LEVEL)
            {
                int flag = 0;
                if(maxv==v)
                {
                    Pen penfont = new Pen(Color.DarkOrange, 3.5F);
                   
                    
                    e.Graphics.FillRectangle(new SolidBrush(Color.Violet), Xcord - 90, Ycord, 100, 45);
                    e.Graphics.DrawRectangle(penfont, Xcord - 90, Ycord, 100, 45);
                    e.Graphics.DrawString("W=" + Convert.ToString(w), new Font("Times New Roman", 13), Brushes.DarkOrange, Xcord - 85, Ycord + 8);
                    e.Graphics.DrawString("V=" + Convert.ToString(v), new Font("Times New Roman", 13), Brushes.DarkOrange, Xcord - 85 + 45, Ycord + 8);
                    e.Graphics.DrawString("UB=" + Convert.ToString(ub), new Font("Times New Roman", 13), Brushes.Red, Xcord - 86 + 13, Ycord + 8 + 14);
                }
                //Font drawfont (); 
                /*Pen penfont = new Pen(Color.DarkOrange, 3.5F);
                e.Graphics.DrawRectangle(penfont, Xcord - 90, Ycord, 100, 45);
                e.Graphics.DrawString("W=" + Convert.ToString(w), new Font("Times New Roman", 13), Brushes.DarkOrange, Xcord - 85, Ycord + 8);
                e.Graphics.DrawString("V=" + Convert.ToString(v), new Font("Times New Roman", 13), Brushes.DarkOrange, Xcord - 85 + 45, Ycord + 8);
                e.Graphics.DrawString("UB=" + Convert.ToString(ub), new Font("Times New Roman", 13), Brushes.Red, Xcord - 86 + 13, Ycord + 8 + 14);*/
                if (left != null)
                {
                    flag = 1;
                    //e.Graphics.DrawLine(Pens.PaleVioletRed, Xcord - 45, Ycord + 45, Xcord - Convert.ToInt32(140 * LEVEL) - 45, Ycord + 100);
                    left.show(sender, e, Xcord - Convert.ToInt32(140 * LEVEL), Ycord + 100, LEVEL * 0.9);
                }
                if (right != null)
                {
                    flag = 1;
                    //e.Graphics.DrawLine(Pens.PaleVioletRed, Xcord - 45, Ycord + 45, Xcord + Convert.ToInt32(140 * LEVEL) - 45, Ycord + 100);
                    right.show(sender, e, Xcord + Convert.ToInt32(140 * LEVEL), Ycord + 100, LEVEL * 0.9);
                }

            }
            public int start(items item,int tw=0,int tv=0)
            {
                lastitem = -1;
                w += tw;
                maxv = 0;
                maxub = 0;
                v += tv;
                it = item;
                setub(0);
               
                    insert(0);
                    tree temp;
                    temp=next.Pop();
                   return temp.doing();
            }
            public int doing()
            {
                //if (j == N)
                    //return v;
                insert(lastitem);

                if (next.Count() > 0)
                {
                    tree temp;
                    while (true)
                    {
                        if (next.Count() == 0) return maxv;
                        temp = next.Pop();
                        if (Perebor) break;
                        if (temp.ub > maxv)//ограничение
                            break;
                    }
                        //if(temp.ub<maxv)
                    return temp.doing();
                }
                else
                    return maxv; 
            }
            public void insert(int i)
            {
                if (i >= it.size())
                    return;
                left = new tree();
                right = new tree();

                left.set(w+it.W(i),v+it.V(i),i+1);
                right.set(w, v, i+1);

                if (left.v > maxv && left.w<W) maxv = left.v;
                if (right.v > maxv && right.w < W) maxv = right.v;
                if (left.v > maxub && left.w < W) maxub = left.ub;
                if (right.v > maxub && right.w < W) maxub = right.ub;

                if (left.w > W)
                {
                    next.Push(right);
                }
                else
                {
                    if (right.ub > left.ub)
                    {
                        next.Push(left);
                        next.Push(right);
                    }
                    else
                    {
                        next.Push(right);
                        next.Push(left);
                    }
                }
            }
            public void set(int tw,int tv,int i)
            {
                w = tw;
                v = tv;
                lastitem = i;
                if (i < it.size())
                    setub(i);
                else
                    ub = v;
            }
            public void setub(int i)
            {
                int tmp=1;
                for (int j = i; j < it.size(); j++)
                {
                    if (it.V(j) / it.W(j) > tmp) tmp = it.V(j) / it.W(j);
                }
              ub = v + (W - w) * (tmp);
            }
        }


        int checksum=0;
        tree map;
        items itt;

        private void ClearIt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            itt.Clear();
            checksum = 0;
        }

        private void NewIt_Click(object sender, EventArgs e)
        {
            try
            {
                check = new bool[itt.Count() + 1];
                itt.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                listBox1.Items.Add("Предмет: Вес("+textBox1.Text+"); Цена("+textBox2.Text+");");
                listBox2.Items.Clear(); checksum = 0;
                
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            Wid =pictureBox1.Size.Width;
            if(map!=null)
            {
                map.show(sender, e, Wid / 2, 20,1);
            }
        }

        private void сохранитьПредметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            string text= ""; string temp;
            for (int i=0;i<itt.Count();i++)
            {
                temp = "";
                temp +=Convert.ToString(itt.W(i))+","+ Convert.ToString(itt.V(i))+";";
                text += temp;
            }
            System.IO.File.WriteAllText(filename, text);
            MessageBox.Show("Предметы сохранены","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void загрузитьПредметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            itt.Clear();
            listBox1.Items.Clear();
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename); int ttv=0,ttw; int startpos = 0;
            for (int i = 0; i < fileText.Length; i++)
            {
                
                if (fileText[i] == ',')
                {
                    ttv = Convert.ToInt32(fileText.Substring(startpos, i - startpos));
                    startpos=i+1;
                }
                else if(fileText[i] == ';')
                {
                    ttw = Convert.ToInt32(fileText.Substring(startpos, i   - startpos));
                    itt.Add(ttv, ttw);
                    listBox1.Items.Add("Предмет: Вес(" +Convert.ToString(ttv) + "); Цена(" + Convert.ToString(ttw) + ");");
                    startpos = i + 1;
                }
            }
            MessageBox.Show("Предметы загружены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            check = new bool[itt.Count()];
        }

        private void описаниеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 info=new Form2();
            info.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    itt.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    listBox1.Items.Add("Предмет: Вес(" + textBox1.Text + "); Цена(" + textBox2.Text + ");");
                    listBox2.Items.Clear(); checksum = 0;
                }
                catch
                {
                    MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (check[listBox1.SelectedIndex] == true)
                        return;
                listBox2.Items.Add(listBox1.SelectedItem);
                check[listBox1.SelectedIndex] = true;
                string tmp = listBox1.SelectedItem.ToString(); int strpos = 0; int flag = 0;
                for (int j = 0; j < tmp.Length; j++)
                {
                    if (tmp[j] == 'а' && tmp[j + 1] == '(')
                    {
                        flag = 1;
                        strpos = j + 1;
                    }
                    if (tmp[j] == ')' && flag == 1)
                    {
                        checksum += Convert.ToInt32(tmp.Substring(strpos + 1, j - strpos-1));
                        break;
                    }
                }
            }
            catch
            {

            }
          
        }

        private void ClearCheck_Click(object sender, EventArgs e)
        {
            checksum = 0;
            listBox2.Items.Clear();
            check = new bool[itt.Count()];
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                W = Convert.ToInt32(WeiButton.Text);
                N = listBox1.Items.Count;
                map = new tree();
                if (itt.Count() == 0)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ans = map.start(itt);
            if(ans==checksum)MessageBox.Show("Это правилное решение!", "Решение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Это неправилное решение!", "Решение", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void показатьДеревоРешенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perebor = false;
            try
            {
                W = Convert.ToInt32(WeiButton.Text);
                N = listBox1.Items.Count;
                map = new tree();
                if (itt.Count() == 0)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            //itt.Add(4, 40);//отсортрровать
            //itt.Add(7, 42);
            //itt.Add(5, 25);
            //itt.Add(3, 12);
            int ans = map.start(itt);
            //panel1.Refresh();
            //panel1.HorizontalScroll.Value = pictureBox1.Size.Width / 2 -500;
            pictureBox1.Refresh();
            sw.Stop();
            MessageBox.Show("Максимально возможная ценность предметов = " + Convert.ToString(ans) + ". " + '\n' + " Затраченное время : " + (sw.ElapsedMilliseconds).ToString()+"мс", "Решение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        ////////////////////////////////////////////
        ////////////////////////////////////////////


        int[,] a;
        int answer;
        private void показатьРешениеДинамикойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                W = Convert.ToInt32(WeiButton.Text);
                N = listBox1.Items.Count;
                if (itt.Count() == 0)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            a = new int[itt.size() + 1, W + 1];
            //textBox1.Text = Convert.ToString(solve());
            dinamic();
            anss = "";
            findwaydinamic(itt.size(), W);
           
            //textBox1.Text = Convert.ToString(answer);
            textBox3.Text = anss;

            sw.Stop();
            MessageBox.Show("Максимально возможная ценность предметов = " + Convert.ToString(answer) + ". "+'\n' +"Затраченное время : " + (sw.ElapsedMilliseconds).ToString() + "мс", "Решение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ////заполнение a
            string tempstr; listBox3.Items.Clear(); int lastinp = 0;
            for (int i = 1; i <= itt.size(); i++)
            {
                tempstr = "";
                for (int j = 1; j <= W; j++)
                {
                    tempstr +=Convert.ToString(a[i,j])+"; ";
                    for (int ki = 1; ki < 5 - Convert.ToString(a[i, j]).Length; ki++)
                        tempstr=tempstr.Insert(lastinp," ");
                    lastinp = tempstr.Length;
                }
                lastinp = 0;
                listBox3.Items.Add(tempstr);
            }

        }

        private void dinamic()
        {
            //int ans = 0;
            for (int i = 1; i <= itt.size(); i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    if (j >= itt.W(i - 1))
                    {
                        a[i, j] = Math.Max(a[i - 1, j], a[i - 1, j - itt.W(i - 1)] + itt.V(i - 1));
                    }
                    else
                        a[i, j] = a[i - 1, j];
                }
            }
            answer = a[itt.size(), W];
            //return ans;
        }
        string anss;

        private void показатьРешениеПереборомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perebor = true;
            try
            {
                W = Convert.ToInt32(WeiButton.Text);
                N = listBox1.Items.Count;
                map = new tree();
                if (itt.Count() == 0)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка (" + new Random().Next(152) + ")", "Упс....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            //itt.Add(4, 40);//отсортрровать
            //itt.Add(7, 42);
            //itt.Add(5, 25);
            //itt.Add(3, 12);
            int ans = map.start(itt);
            //panel1.Refresh();
            //panel1.HorizontalScroll.Value = pictureBox1.Size.Width / 2 -500;
            pictureBox1.Refresh();
            sw.Stop();
            MessageBox.Show("Максимально возможная ценность предметов = " + Convert.ToString(ans) + ". " + '\n' + " Затраченное время : " + (sw.ElapsedMilliseconds).ToString() + "мс", "Решение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void findwaydinamic(int k, int s)
        {
            if (a[k, s] == 0)
                return;
            if (a[k - 1, s] == a[k, s])
                findwaydinamic(k - 1, s);
            else
            {
                findwaydinamic(k - 1, s - itt.W(k-1));
                anss += "( W = "+Convert.ToString(itt.W(k-1))+"; V =  "+ Convert.ToString(itt.V(k-1)) + ") ";
            }
        }
    }
}
