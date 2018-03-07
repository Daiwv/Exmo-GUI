using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string rez = new API().ApiQuery("user_info", new Dictionary<string, string>());
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            }
            else
            {
                string[] tmp = rez.Split('"');
                int a = 7;
                int b = 9;

                while (b != 77)
                {
                    this.dataGridView1.Rows.Add(tmp[a += 4], tmp[b += 4]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 client = new Form4();
            client.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 client = new Form7();
            client.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 client = new Form10();
            client.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 client = new Form5();
            client.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 client = new Form6();
            client.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 client = new Form8();
            client.ShowDialog();
            this.Close();
        }
    }
}
