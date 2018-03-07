using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
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

        void GetOrders()
        {
            string rez = new API().ApiQuery("user_open_orders", new Dictionary<string, string>());
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            }
            else
            {
                if (rez.Length < 5)
                {
                    MessageBox.Show("No active orders...");
                } else {
                    string[] tm = rez.Split('"');


                    int o_id = 5;
                    int o_time = 9;
                    int o_name = 1;
                    int o_type = 13;
                    int o_price = 21;
                    int o_count = 25;
                    
                    for (int i = 0; i != rez.Length/30; i++)
                    {
                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(tm[o_time]));

                        dataGridView1.Rows.Add(tm[o_id], tm[o_name], tm[o_count], tm[o_price], tm[o_type], dateTimeOffset);
                        o_id += 30;
                        o_time += 30;
                        o_name += 30;
                        o_type += 30;
                        o_price += 30;
                        o_count += 30;
                    }
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
    }
}
