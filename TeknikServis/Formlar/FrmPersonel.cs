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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TblPersonel select new { u.ID, u.AD, u.SOYAD,u.MAIL,u.TELEFON,u.DEPARTMAN,u.FOTOGRAF };
            gridControl1.DataSource = degerler.ToList();
            cmbDepartman.Properties.DataSource =( from x in db.TblDepartman select new { x.ID, x.AD }).ToList();
            string ad1, soyad1;
            ad1 = db.TblPersonel.First(x => x.ID == 1).AD;
            soyad1 = db.TblPersonel.First(x => x.ID == 1).SOYAD;
            label4.Text = db.TblPersonel.First(x => x.ID == 1).TblDepartman.AD;
            label2.Text = ad1 + " " + soyad1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblPersonel p = new TblPersonel();
                p.AD = txtAd.Text;
                p.SOYAD = txtSoyad.Text;
                p.TELEFON = txtTelefon.Text;
                p.MAIL = txtMail.Text;
                p.DEPARTMAN = byte.Parse(cmbDepartman.EditValue.ToString());
                p.FOTOGRAF = txtFotograf.Text;
                db.TblPersonel.Add(p);
                db.SaveChanges();
                MessageBox.Show("Personel Başarı ile Eklendi");
                gridControl1.DataSource = db.TblPersonel.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz");
            }
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TblPersonel.Find(id);
            db.TblPersonel.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarı ile Silindi");
            gridControl1.DataSource = db.TblPersonel.ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            cmbDepartman.EditValue= gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
           // txtFotograf.Text = gridView1.GetFocusedRowCellValue("FOTOGRAF").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblPersonel.Find(id);
                deger.AD = txtAd.Text;
                deger.SOYAD = txtSoyad.Text;
                deger.TELEFON = txtTelefon.Text;
                deger.MAIL = txtMail.Text;
                deger.DEPARTMAN = byte.Parse(cmbDepartman.EditValue.ToString());
                deger.FOTOGRAF = txtFotograf.Text;
                db.SaveChanges();
                MessageBox.Show("Personel Başarı ile Güncellendi");
                gridControl1.DataSource = db.TblPersonel.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Güncellenecek Kayıt Seçiniz");
            }
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtFotograf.Text = "";
            txtId.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
        }

        private void txtAd_EditValueChanged(object sender, EventArgs e)
        {
            txtAd.Text = txtAd.Text.ToUpper();
        }

        private void txtSoyad_EditValueChanged(object sender, EventArgs e)
        {
            txtSoyad.Text = txtSoyad.Text.ToUpper();
        }
    }
}
