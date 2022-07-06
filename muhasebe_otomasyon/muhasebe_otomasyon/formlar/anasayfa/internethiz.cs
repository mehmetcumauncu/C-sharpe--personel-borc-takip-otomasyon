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
    public partial class internethiz : Form
    {
        public internethiz()
        {
            InitializeComponent();
        }

        private void internethiz_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://hiztesti.turktelekom.com.tr/");
        }
    }
}
