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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        void listele()
        {
            var degerler = from u in db.TblUrun select new { u.ID, u.DURUM ,u.AD, u.ALISFIYAT,  KATEGORİ=u.TblKategori.AD, u.MARKA, u.SATISFIYAT, u.STOKSAYISI };
            gridControl1.DataSource = degerler.ToList();
            cmbKategori.Properties.DataSource = (from x in db.TblKategori select new { x.ID, x.AD }).ToList();
         
        }
        void temizle()
        {
            txtId.Text = "";
            txtAlisFiyati.Text = "";
            txtMarka.Text = "";
            txtSatisFiyati.Text = "";
            txtStok.Text = "";
            txtUrunAdi.Text = "";
            cmbKategori.Text = "";
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblUrun t = new TblUrun();
                t.AD = txtUrunAdi.Text;
                t.MARKA = txtMarka.Text;
                t.ALISFIYAT = Convert.ToDecimal(txtAlisFiyati.Text);
                t.SATISFIYAT = Convert.ToDecimal(txtSatisFiyati.Text);
                t.STOKSAYISI = short.Parse(txtStok.Text);
                t.KATEGORI = byte.Parse(cmbKategori.EditValue.ToString());
                db.TblUrun.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Bilgileri Başarılı Bir Şekilde Kaydedildi");
                listele();
                temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İlgili Alanları Doldurun", "Uyarı");
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
                txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                txtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                txtSatisFiyati.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("STOKSAYISI").ToString();
              //  cmbKategori.EditValue= short.Parse(gridView1.GetFocusedRowCellValue("KATEGORI").ToString());
           
              
          
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblUrun.Find(id);
                db.TblUrun.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Silme İşlemi başarılı");
                listele();
                temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Silinecek Kayıt Seçiniz", "Uyarı");
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblUrun.Find(id);
                deger.AD = txtUrunAdi.Text;
                deger.STOKSAYISI = short.Parse(txtStok.Text);
                deger.MARKA = txtMarka.Text;
                deger.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
                deger.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
                deger.KATEGORI = byte.Parse(cmbKategori.EditValue.ToString());
                temizle();
                db.SaveChanges();
                listele();
                MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Güncellenecek Kaydı Seçiniz", "Uyarı");

            }

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAlisFiyati.Text = "";
            txtId.Text = "";
            txtMarka.Text = "";
            txtSatisFiyati.Text = "";
            txtStok.Text = "";
            txtUrunAdi.Text = "";
        }

        private void cmbKategori_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunAdi_EditValueChanged(object sender, EventArgs e)
        {
            txtUrunAdi.Text = txtUrunAdi.Text.ToUpper();
        }
    }
}
