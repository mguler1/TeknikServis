using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis.Formlar;
using TeknikServis.Formlar.Raporlar;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunListesi f = new FrmUrunListesi();
            
                f.MdiParent = this;
                f.Show();
            
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniUrun NEW = new FrmYeniUrun();
           
                NEW.Show();
          
            
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriListele k = new FrmKategoriListele();

           
                k.MdiParent = this;
                k.Show();
           
           
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunIstatistikleri ui = new FrmUrunIstatistikleri();
            
                ui.MdiParent = this;
                ui.Show();
           
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMarkalar marka = new FrmMarkalar();
          
                marka.MdiParent = this;
                marka.Show();
            
            
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariListesi cari = new FrmCariListesi();
          
            
                cari.MdiParent = this;
                cari.Show();
            
          
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmCariler c = new FrmCariler();
           
            //    c.MdiParent = this;
            //    c.Show();
            
            
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariEkle ce = new FrmCariEkle();
          
                ce.Show();
            
            
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartman dp = new FrmDepartman();
           
                dp.MdiParent = this;
                dp.Show();
            

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel personel = new FrmPersonel();
                 personel.MdiParent = this;
                personel.Show();
            
           
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoviz döviz = new FrmDoviz();
           
                döviz.MdiParent = this;
                döviz.Show();
            
            
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotlar not = new FrmNotlar();
            
                not.MdiParent = this;
                not.Show();
            
            
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaListesi a = new FrmArizaListesi();
           
                a.MdiParent = this;
                a.Show();
            
            
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunSatis satis = new FrmUrunSatis();
           
                satis.Show();
            
            
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatisListesi slist = new FrmSatisListesi();
            
                slist.MdiParent = this;
                slist.Show();
            
           
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaliUrunKaydi ariza = new FrmArizaliUrunKaydi();
            
                ariza.Show();
            
           
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaDetay detay = new FrmArizaDetay();
           
                detay.Show();
            
            
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaliUrunDetayListesi dt = new FrmArizaliUrunDetayListesi();
           
                dt.MdiParent = this;
                dt.Show();
            
            
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQRCode code = new FrmQRCode();
           
                code.ShowDialog();
            
            

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturaListesi fatlist = new FrmFaturaListesi();
            
                fatlist.MdiParent = this;
                fatlist.Show();
            
            
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturaKalem kalem = new FrmFaturaKalem();
           
                kalem.MdiParent = this;
                kalem.Show();
            
            
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKalemDetay kalem = new FrmKalemDetay();
           
                kalem.MdiParent = this;
                kalem.Show();
            
            
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporlar r = new FrmRaporlar();
           
                // r.MdiParent = this;
                r.Show();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmAnasayfa anaS = new FrmAnasayfa();
            anaS.MdiParent = this;
            anaS.Show();
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            FrmAnasayfa anaS = new FrmAnasayfa();
            
                anaS.MdiParent = this;
                anaS.Show();
            
           
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
