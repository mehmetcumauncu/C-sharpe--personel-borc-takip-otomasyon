using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace muhasebe_otomasyon.formlar.anasayfa
{
    public partial class mailgonder : Form
    {
        public mailgonder()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            string kime = textBox1.Text.ToString();
            string konu = textBox3.Text.ToString() ;
            string icerik = textBox2.Text.ToString() ;

            sc.Credentials = new NetworkCredential("patrondanmesajvar@gmail.com", "mehmetcuma2001");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("patrondanmesajvar@gmail.com", "PATRON MAİLİ");
            mail.To.Add(kime);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            sc.Send(mail);
            MessageBox.Show("mesaj gitti");
        }
        string DosyaYolu;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "DOSYA";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            labelControl4.Text = "Dosya Eklendi";
        }
    }
}
