using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Tanks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            string url = txtSite.Text;

            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(new Uri(url));
            
            txtResultado.Text = html;
        }
    }
}
