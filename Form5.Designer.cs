namespace Exmo
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(667, 497);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://exmo.com/ctrl/getTemplate?name=main_big2&para=BCH_BTC&period=week&lang=en" +
        "", System.UriKind.Absolute);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "day",
            "week",
            "month",
            "year"});
            this.comboBox1.Location = new System.Drawing.Point(485, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "- PERIOD -";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "BTC_USD",
            "BTC_EUR",
            "BTC_RUB",
            "BTC_UAH",
            "BTC_PLN",
            "BCH_BTC",
            "BCH_USD",
            "BCH_RUB",
            "BCH_ETH",
            "DASH_BTC",
            "DASH_USD",
            "DASH_RUB",
            "ETH_BTC",
            "ETH_LTC",
            "ETH_USD",
            "ETH_EUR",
            "ETH_RUB",
            "ETH_UAH",
            "ETH_PLN",
            "ETC_BTC",
            "ETC_USD",
            "ETC_RUB",
            "LTC_BTC",
            "LTC_USD",
            "LTC_EUR",
            "LTC_RUB",
            "ZEC_BTC",
            "ZEC_USD",
            "ZEC_EUR",
            "ZEC_RUB",
            "XRP_BTC",
            "XRP_USD",
            "XRP_RUB",
            "XMR_BTC",
            "XMR_USD",
            "XMR_EUR",
            "BTC_USDT",
            "ETH_USDT",
            "USDT_USD",
            "USDT_RUB",
            "USD_RUB",
            "DOGE_BTC",
            "WAVES_BTC",
            "WAVES_RUB",
            "KICK_BTC",
            "KICK_ETH"});
            this.comboBox2.Location = new System.Drawing.Point(399, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "- PAIR -";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 497);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Chart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}