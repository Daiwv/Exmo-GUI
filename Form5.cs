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
    }
}
