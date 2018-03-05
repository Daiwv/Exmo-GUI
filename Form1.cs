using System;
using System.IO;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("exmo.dat"))
            {
                this.Hide();
                Form2 login = new Form2();
                login.ShowDialog();
                this.Close();
            } else {
                this.Hide();
                Form3 reg = new Form3();
                reg.ShowDialog();
                this.Close();
            }
        }
    }
}
