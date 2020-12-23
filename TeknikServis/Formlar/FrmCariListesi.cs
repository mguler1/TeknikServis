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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        int secilen;
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCari
                                      select new
                                      {
                                          x.ID,
                                          x.AD,
                                          x.SOYAD,
                                          x.STATU,
                                          x.IL,
                                          x.ILCE,
                                          x.MAIL,
                                          x.TELEFON,
                                          x.VERGIDAIRESI,
                                          x.VERGINO,
                                          x.BANKA,
                                          x.ADRES
                                      }).ToList();
            labelControl14.Text = db.TblCari.Count().ToString();
            labelControl22.Text = db.TblCari.Select(x => x.IL).Distinct().Count().ToString();
            labelControl34.Text = db.TblCari.Select(x => x.ILCE).Distinct().Count().ToString();

            cmbIl.Properties.DataSource = (from x in  db.Tbliller select new {x.id, x.sehir}).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblCari c = new TblCari();
                c.AD = txtCariAdi.Text;
                c.SOYAD = txtCariSoyadı.Text;
                c.TELEFON = txtTelefon.Text;
                c.MAIL = txtMail.Text;
                c.IL = cmbIl.Text;
                c.ILCE = cmbIlce.Text;
                c.BANKA = txtBanka.Text;
                c.VERGIDAIRESI = txtVergiDairesi.Text;
                c.VERGINO = txtVergiNo.Text;
                c.STATU = txtStatu.Text;
                c.ADRES = txtAdres.Text;
                db.TblCari.Add(c);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Kaydı Başarı ile Tamamlanmıştır.");
            }
            catch (Exception)
            {

                MessageBox.Show("İlgili Alaları Doldurunuz");
            }
           
        }

        private void cmbIl_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(cmbIl.EditValue.ToString());
            cmbIlce.Properties.DataSource = (from y in db.Tblilceler select new { y.id, y.ilce,y.sehir }).Where(z=>z.sehir==secilen).ToList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl23_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text= gridView1.GetFocusedRowCellValue("ID").ToString();
            txtCariAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtCariSoyadı.Text= gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            txtTelefon.Text= gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            txtMail.Text= gridView1.GetFocusedRowCellValue("MAIL").ToString();
           // cmbIl.EditValue= gridView1.GetFocusedRowCellValue("IL").ToString();
           // cmbIlce.EditValue=gridView1.GetFocusedRowCellValue("ILCE").ToString();
            txtBanka.Text= gridView1.GetFocusedRowCellValue("BANKA").ToString();
            txtVergiDairesi.Text= gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
            txtVergiNo.Text= gridView1.GetFocusedRowCellValue("VERGINO").ToString();
            txtStatu.Text= gridView1.GetFocusedRowCellValue("STATU").ToString();
            txtAdres.Text= gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblCari.Find(id);
                deger.AD = txtCariAdi.Text;
                deger.SOYAD = txtCariSoyadı.Text;
                deger.ADRES = txtAdres.Text;
                deger.BANKA = txtBanka.Text;
                deger.IL = cmbIl.EditValue.ToString();
                deger.ILCE = cmbIlce.EditValue.ToString();
                deger.MAIL = txtMail.Text;
                deger.STATU = txtStatu.Text;
                deger.TELEFON = txtTelefon.Text;
                deger.VERGIDAIRESI = txtVergiDairesi.Text;
                deger.VERGINO = txtVergiNo.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Güncellenecek Kaydı Seçiniz");
            }
           
            
        }

        private void txtCariAdi_EditValueChanged(object sender, EventArgs e)
        {
            txtCariAdi.Text = txtCariAdi.Text.ToUpper();

        }

        private void txtCariSoyadı_EditValueChanged(object sender, EventArgs e)
        {
            txtCariSoyadı.Text = txtCariSoyadı.Text.ToUpper();
        }

        private void txtBanka_EditValueChanged(object sender, EventArgs e)
        {
            txtBanka.Text = txtBanka.Text.ToUpper();
        }

        private void txtVergiDairesi_EditValueChanged(object sender, EventArgs e)
        {
            txtVergiDairesi.Text = txtVergiDairesi.Text.ToUpper();
        }

        private void txtStatu_EditValueChanged(object sender, EventArgs e)
        {
            txtStatu.Text = txtStatu.Text.ToUpper();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAdres.Text = "";
            txtBanka.Text = "";
            txtCariAdi.Text = "";
            txtCariSoyadı.Text = "";
            txtId.Text = "";
            txtMail.Text = "";
            txtStatu.Text = "";
            txtTelefon.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            
        }
    }
}
