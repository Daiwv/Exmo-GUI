using System;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form4 : Form
    {
        public string api_key = "";
        public string api_sec = "";
        public string username = "";


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            api_key = Form2.ApiKey;
            api_sec = Form2.ApiSec;
            username = Form2.Username;
        }
    }
}
