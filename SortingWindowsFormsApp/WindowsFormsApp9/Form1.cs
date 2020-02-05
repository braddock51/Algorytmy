using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string cyfryS = tbCyfry.Text;
            int[] cyfryTabI = Konwersja(cyfryS);
            cyfryTabI = SortowanieB(cyfryTabI);
            

            

            tbCyfry.Text = string.Join(" ", cyfryTabI);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            bbox.AppendText($"{ts.TotalMilliseconds}");

        }

        private void btnCos_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.UpArrow;
        }

        private void btnCos_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        int[] SortowanieB(int[] tab)
        {
            bool czyZamiana = false;
            do
            {
                czyZamiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        var tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        czyZamiana = true;
                    }
                }
            } while (czyZamiana);

            return tab;
        }

        int[] Konwersja(string cyfryS)
        {
            string[] cyfryTabS = cyfryS.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] cyfryTabI = new int[cyfryTabS.Length];

            for (int i = 0; i < cyfryTabS.Length; i++)
            {
                cyfryTabI[i] = int.Parse(cyfryTabS[i].Trim());
            }

            return cyfryTabI;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] insert_sort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int key = tab[i];
                int j = i - 1;
                while (j > -1 && tab[j] > key)
                {
                    tab[j + 1] = tab[j];
                    tab[j] = key;
                    j--;
                }
            }
            return tab;
        }

        int[] select_sort(int[] tab)
        {


            for (int i = 0; i < tab.Length - 1; i++)
            {
                int imin = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[imin])
                        imin = j;
                }
                if (imin != i)
                {
                    int temp = tab[imin];
                    tab[imin] = tab[i];
                    tab[i] = temp;

                }
            }
            return tab;
        }

        int[] counting_sort(int[] tab)
        {
            int max = tab[0];
            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (max < tab[i])
                    max = tab[i];
                else if (min > tab[i])
                    min = tab[i];
            }
            int[] count = new int[max + 1];

            for (int i = 0; i < tab.Length; i++)
                count[tab[i]]++;


            for (int i = 1; i < max + 1; i++)
                count[i] += count[i - 1];

            int[] output = new int[tab.Length];

            for (int i = tab.Length - 1; i >= 0; i--)
            {
                output[count[tab[i]] - 1] = tab[i];
                count[tab[i]] -= 1;
            }


            return output;

        }

        private void insert_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string cyfryS = tbCyfry.Text;
            int[] cyfryTabI = Konwersja(cyfryS);
            cyfryTabI = insert_sort(cyfryTabI);

            tbCyfry.Text = string.Join(" ", cyfryTabI);
            Random los = new Random();
            int[] tab = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                tab[i] = los.Next(1, 1000);

            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ibox.AppendText($"{ts.TotalMilliseconds}");
        }

        private void select_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string cyfryS = tbCyfry.Text;
            int[] cyfryTabI = Konwersja(cyfryS);
            cyfryTabI = select_sort(cyfryTabI);

            tbCyfry.Text = string.Join(" ", cyfryTabI);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            sbox.AppendText($"{ts.TotalMilliseconds}");
        }

        private void count_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string cyfryS = tbCyfry.Text;
            int[] cyfryTabI = Konwersja(cyfryS);
            cyfryTabI = counting_sort(cyfryTabI);


            tbCyfry.Text = string.Join(" ", cyfryTabI);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            cbox.AppendText($"{ts.TotalMilliseconds}");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbCyfry_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       


        private void rndm_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = 0;
            

            
            for (int i = 0; i < 10000; i++)
            {
                num = rnd.Next(0, 1001);
                tbCyfry.Text+= num.ToString()+" ";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCyfry.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cbox.Text = null;
            sbox.Text = null;
            bbox.Text = null;
            ibox.Text = null;
        }
    }
}
