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
    }
}
