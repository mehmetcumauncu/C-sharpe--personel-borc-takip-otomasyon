using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_otomasyon.formlar.anasayfa
{
    public partial class aramamotoru : Form
    {
        public aramamotoru()
        {
            InitializeComponent();
        }

        private void aramamotoru_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }
    }
}
