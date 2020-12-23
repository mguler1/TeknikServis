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
    public partial class FrmKategoriListele : Form
    {
        public FrmKategoriListele()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblKategori t = new TblKategori();
            t.AD = txtKategoriAdi.Text;
            db.TblKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarı ile kaydedildi");
            var degerler = from k in db.TblKategori select new { k.ID, k.AD };
            gridControl1.DataSource = degerler.ToList();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        void listele()
        {
            var degerler = from k in db.TblKategori select new { k.ID, k.AD };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategoriListele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtKategoriAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TblKategori.Find(id);
            db.TblKategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi başarılı");
            var degerler = from k in db.TblKategori select new { k.ID, k.AD };
            gridControl1.DataSource = degerler.ToList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblKategori.Find(id);
                deger.AD = txtKategoriAdi.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı");
                var degerler = from k in db.TblKategori select new { k.ID, k.AD };
                gridControl1.DataSource = degerler.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Güncellenecek Kaydı Seçiniz","Uyarı");
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = "";
            txtId.Text = "";
        }

        private void txtKategoriAdi_EditValueChanged(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = txtKategoriAdi.Text.ToUpper();
        }
    }
}
