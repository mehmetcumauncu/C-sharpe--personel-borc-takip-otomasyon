using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        formlar.personel frm1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//PERSONEL
        {
            if (frm1 == null)
            {
                frm1 = new formlar.personel();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }


        formlar.personelekle frm2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//PERSONEL EKLEME
        {
            if (frm2 == null)
            {
                frm2 = new formlar.personelekle();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }


        formlar.personelsil frm3;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//PERSONEL SİL
        {
            if (frm3 == null)
            {
                frm3 = new formlar.personelsil();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }


        formlar.personelguncelle frm4;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//PERSONEL GÜNCELLEME
        {
            if (frm4 == null)
            {
                frm4 = new formlar.personelguncelle();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }


        formlar.personelistatistik frm5;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//PERSONEL İSTATİSTİK
        {
            if (frm5 == null)
            {
                frm5 = new formlar.personelistatistik();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }


        formlar.gider frm6;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) //GİDERTABLOSU
        {
            if (frm6 == null)
            {
                frm6 = new formlar.gider();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }


        formlar.isyerigiderleri.giderekle frm7;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//gider ekle
        {
            if (frm7 == null)
            {
                frm7 = new formlar.isyerigiderleri.giderekle();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }



        formlar.isyerigiderleri.gidersil frm8;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//gider sil
        {
            if (frm8 == null)
            {
                frm8 = new formlar.isyerigiderleri.gidersil();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }


        formlar.isyerigiderleri.giderguncelle frm9;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//gider güncelle
        {
            if (frm9 == null)
            {
                frm9 = new formlar.isyerigiderleri.giderguncelle();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }


        formlar.police.policeekle frm10;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) //poliçe ekle 
        {
            if (frm10 == null)
            {
                frm10 = new formlar.police.policeekle();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }



        formlar.police.policeler frm11;
        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//policeler
        {
            if (frm11 == null)
            {
                frm11 = new formlar.police.policeler();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }


        formlar.urun.urunler frm12;  //ÜRÜNLER
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null)
            {
                frm12 = new formlar.urun.urunler();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }



        formlar.urun.urunekle frm13;  //ÜRÜN EKLE
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm13 == null)
            {
                frm13 = new formlar.urun.urunekle();
                frm13.MdiParent = this;
                frm13.Show();
            }
        }


        formlar.urun.urunsil frm14; //ÜRÜN SİL
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm14 == null)
            {
                frm14 = new formlar.urun.urunsil();
                frm14.MdiParent = this;
                frm14.Show();
            }
        }


        formlar.urun.urunguncelle frm15; //ÜRÜN GÜNCELLE
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm15 == null)
            {
                frm15 = new formlar.urun.urunguncelle();
                frm15.MdiParent = this;
                frm15.Show();
            }
        }


        formlar.urun.urunistatistik frm16;  //ÜRÜN İSTATİSTİK
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm16 == null)
            {
                frm16 = new formlar.urun.urunistatistik();
                frm16.MdiParent = this;
                frm16.Show();
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.borc.borclukisi frm = new formlar.borc.borclukisi();  
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }


        formlar.borc.borclar frm17;  //BORÇLAR LİSTELE
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm17 == null)
            {
                frm17 = new formlar.borc.borclar();
                frm17.MdiParent = this;
                frm17.Show();
            }
        }


        formlar.borc.borcekle frm18;  //BORÇ İŞLEMLERİ
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm18 == null)
            {
                frm18 = new formlar.borc.borcekle();
                frm18.MdiParent = this;
                frm18.Show();
            }
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.anasayfa.mailgonder frm = new formlar.anasayfa.mailgonder();
            frm.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            giris frm = new giris();
            frm.Show();
        }


        formlar.anasayfa.aramamotoru frm19;
        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm19 == null)
            {
                frm19 = new formlar.anasayfa.aramamotoru();
                frm19.MdiParent = this;
                frm19.Show();
            }
        }


        formlar.anasayfa.youtube frm20;
        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm20 == null)
            {
                frm20 = new formlar.anasayfa.youtube();
                frm20.MdiParent = this;
                frm20.Show();
            }
        }



        formlar.anasayfa.internethiz frm21;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm21 == null)
            {
                frm21 = new formlar.anasayfa.internethiz();
                frm21.MdiParent = this;
                frm21.Show();
            }
        }


        formlar.police.policeara frm22;
        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm22 == null)
            {
                frm22 = new formlar.police.policeara();
                frm22.MdiParent = this;
                frm22.Show();
            }
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm22 == null)
            {
                frm22 = new formlar.police.policeara();
                frm22.MdiParent = this;
                frm22.Show();
            }
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.anasayfa.takvim frm = new formlar.anasayfa.takvim();
            frm.Show();
        }



        formlar.sifreislemler.kullanicilar frm23;
        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

            if (frm23 == null)
            {
                frm23 = new formlar.sifreislemler.kullanicilar();
                frm23.MdiParent = this;
                frm23.Show();
                
            }
        }


        formlar.sifreislemler.kullaniciguncelle frm24;
        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm24 == null)
            {
                frm24 = new formlar.sifreislemler.kullaniciguncelle();
                frm24.MdiParent = this;
                frm24.Show();

            }
        }
    }
}
