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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TblFaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARİ = u.TblCari.AD + " " + u.TblCari.SOYAD,
                               PERSONEL = u.TblPersonel.AD + " " + u.TblPersonel.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
            cmbCari.Properties.DataSource = (from x in db.TblCari
                                             select new
                                             {
                                                 x.ID,
                                                 Ad = x.AD + " " + x.SOYAD,

                                             }).ToList();
            
            cmbPersonel.Properties.DataSource = (from y in db.TblPersonel
                                                 select new
                                                 {
                                                     y.ID,
                                                     pAd = y.AD + " " + y.SOYAD
                                                 }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblFaturaBilgi t = new TblFaturaBilgi();
                t.SERI = txtSeri.Text;
                t.SIRANO = txtSıra.Text;
                t.TARIH = DateTime.Parse(txtTarih.Text);
                t.SAAT = txtSaat.Text;
                t.VERGIDAIRE = txtVergiDaire.Text;
                t.CARI = int.Parse(cmbCari.EditValue.ToString());
                t.PERSONEL = short.Parse(cmbPersonel.EditValue.ToString());
                db.TblFaturaBilgi.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Başarılı Bir Şekilde Kaydedilmiştir");
                gridControl1.DataSource = db.TblFaturaBilgi.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz");
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtSıra.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            txtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            txtVergiDaire.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
          //  cmbCari.EditValue = gridView1.GetFocusedRowCellValue("CARI").ToString();
            cmbPersonel.EditValue = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSaat.Text = "";
            txtSeri.Text = "";
            txtSıra.Text = "";
            txtTarih.Text = "";
            txtVergiDaire.Text = "";
            cmbCari.EditValue= "";
            cmbPersonel.Text = "";
        }
        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id =int.Parse( gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblFaturaBilgi.Find(id);
                deger.CARI = int.Parse(cmbCari.EditValue.ToString());
                deger.PERSONEL = short.Parse(cmbPersonel.EditValue.ToString());
                deger.SAAT = txtSaat.Text;
                deger.SERI = txtSeri.Text;
                deger.SIRANO = txtSıra.Text;
                deger.VERGIDAIRE = txtVergiDaire.Text;
                deger.TARIH = Convert.ToDateTime(txtTarih.Text);
                db.SaveChanges();
                MessageBox.Show("Güncelleme Baaşrılı");
                gridControl1.DataSource = db.TblFaturaBilgi.ToList();
            }
            catch (Exception)
            {

               
            }
           
        }

        private void txtSeri_EditValueChanged(object sender, EventArgs e)
        {
            txtSeri.Text = txtSeri.Text.ToUpper();
        }

        private void txtVergiDaire_EditValueChanged(object sender, EventArgs e)
        {
            txtVergiDaire.Text = txtVergiDaire.Text.ToUpper();
        }
    }
}
