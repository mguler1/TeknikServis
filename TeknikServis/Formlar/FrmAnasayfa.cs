using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = (from x in db.TblUrun
                                       select new
                                       {
                                           x.AD,
                                           x.STOKSAYISI
                                       }).Where(x => x.STOKSAYISI < 20).ToList();

            gridControl3.DataSource = (from y in db.TblCari
                                       select new
                                       {
                                           y.AD,
                                           y.SOYAD,
                                           y.TELEFON
                                       }).ToList();

            gridControl4.DataSource = db.UrunKategori().ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from z in db.TblNotlar.OrderBy(a => a.TARİH)
                         where (z.TARİH == bugun)
                         select new
                         {
                             z.BASLIK,
                             z.ICERIK
                         }
                        ).ToList();
            gridControl5.DataSource = deger;

            String konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5,konu6,ad6,konu7,ad7,konu8,ad8,konu9,ad9,konu10,ad10;

            konu1 = db.Tbliletisim.First(x => x.ID == 1).KONU;
            ad1 = db.Tbliletisim.First(x => x.ID == 1).AD;
            labelControl1.Text = ad1 + "---- " + konu1;

            konu2 = db.Tbliletisim.First(x => x.ID == 2).KONU;
            ad2 = db.Tbliletisim.First(x => x.ID == 2).AD;
            labelControl2.Text = ad2 + "---- " + konu2;

            konu3 = db.Tbliletisim.First(x => x.ID == 3).KONU;
            ad3 = db.Tbliletisim.First(x => x.ID == 3).AD;
            labelControl3.Text = ad3 + "---- " + konu3;


            //konu4 = db.Tbliletisim.First(x => x.ID == 4).KONU;
            //ad4 = db.Tbliletisim.First(x => x.ID == 4).AD;
            //labelControl4.Text = ad4 + "---- " + konu4;

            //konu5 = db.Tbliletisim.First(x => x.ID == 5).KONU;
            //ad5 = db.Tbliletisim.First(x => x.ID == 5).AD;
            //labelControl5.Text = ad5 + "---- " + konu5;

            //konu6 = db.Tbliletisim.First(x => x.ID == 6).KONU;
            //ad6 = db.Tbliletisim.First(x => x.ID == 6).AD;
            //labelControl6.Text = ad6 + "---- " + konu6;

            //konu7 = db.Tbliletisim.First(x => x.ID == 7).KONU;
            //ad7 = db.Tbliletisim.First(x => x.ID == 7).AD;
            //labelControl7.Text = ad7 + "---- " + konu7;

            //konu8 = db.Tbliletisim.First(x => x.ID == 8).KONU;
            //ad8 = db.Tbliletisim.First(x => x.ID == 8).AD;
            //labelControl8.Text = ad8 + "---- " + konu8;

            //konu9 = db.Tbliletisim.First(x => x.ID == 9).KONU;
            //ad9 = db.Tbliletisim.First(x => x.ID == 9).AD;
            //labelControl9.Text = ad9 + "---- " + konu9;

            //konu10 = db.Tbliletisim.First(x => x.ID == 10).KONU;
            //ad10 = db.Tbliletisim.First(x => x.ID == 10).AD;
            //labelControl10.Text = ad10 + "---- " + konu10;
        }
    }
}