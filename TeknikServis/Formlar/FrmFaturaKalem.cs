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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TblFaturaDetay
                           select new
                           {
                               x.FATURADETAYID,
                               x.URUN,
                               x.ADET,
                               x.FIYAT,
                               x.TUTAR,
                               x.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblFaturaDetay t = new TblFaturaDetay();
            t.URUN = txtUrun.Text;
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT =decimal.Parse( txtFiyat.Text);
            t.TUTAR =decimal.Parse( txtTutar.Text);
            t.FATURAID =int.Parse( txtFaturaId.Text);
            db.TblFaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Başarılı Bir Şekilde Eklendi");
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtFaturaDetayId.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            txtUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            txtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            txtFaturaId.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtFaturaDetayId.Text = "";
            txtFaturaId.Text = "";
            txtFiyat.Text = "";
            txtTutar.Text = "";
            txtUrun.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtFaturaDetayId.Text);
                var deger = db.TblFaturaDetay.Find(id);
                deger.ADET = short.Parse(txtAdet.Text);
                deger.FIYAT = int.Parse(txtFiyat.Text);
                deger.TUTAR = int.Parse(txtTutar.Text);
                deger.URUN = txtUrun.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme İşlemi Baaşrı ile Gerçekleştirildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncellenecek Kayıt Seçiniz");


            }

        }
    }
}
