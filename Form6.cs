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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void Cancel()
        {
            string rez = new API().ApiQuery("order_cancel", new Dictionary<string, string> { { "order_id", textBox1.Text } });
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
