using System;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(String.Format("https://exmo.com/ctrl/getTemplate?name=main_big2&para={0}&period={1}&lang=en", comboBox2.SelectedItem, comboBox1.SelectedItem));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(String.Format("https://exmo.com/ctrl/getTemplate?name=main_big2&para={0}&period={1}&lang=en", comboBox2.SelectedItem, comboBox1.SelectedItem));
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 client = new Form9();
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
