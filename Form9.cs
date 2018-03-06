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
    }
}
