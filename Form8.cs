using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        void CreatePayment()
        {
            string rez = new API().ApiQuery("withdraw_crypt", new Dictionary<string, string> { { "amount", textBox1.Text }, { "currency", comboBox1.SelectedItem.ToString() }, { "address", textBox5.Text }, { "invoice", textBox7.Text } });
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            }
            else
            {
                MessageBox.Show("Successful");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CreatePayment();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            CreatePayment();
        }
    }
}
