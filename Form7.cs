using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string rez = new API().ApiQuery("deposit_address", new Dictionary<string, string>());
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            }
            else
            {
                string[] tmp = rez.Split('"');
                int a = 1;
                int b = 3;

                while (b != tmp.Length-2)
                {
                    this.dataGridView1.Rows.Add(tmp[a+=4], tmp[b+=4]);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 client = new Form10();
            client.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 client = new Form9();
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
