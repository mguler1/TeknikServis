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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
                TblCari c = new TblCari();
                c.AD = txtCariAdi.Text;
                c.SOYAD = txtSoyad.Text;
                c.TELEFON = txtTelefon.Text; 
                c.MAIL = txtMail.Text;
                c.IL = txtIl.Text;
                c.ILCE = txtIlce.Text;
                c.BANKA = txtBanka.Text;
                c.VERGIDAIRESI = txtVergiDairesi.Text;
                c.VERGINO = txtVergiNo.Text;
                c.STATU = txtStatü.Text;
                c.ADRES = txtAdres.Text;
                db.TblCari.Add(c);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Kaydı Başarı ile Tamamlanmıştır.");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz");
            }
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtAdres.Text = "";
            txtBanka.Text = "";
            txtCariAdi.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtStatü.Text = "";
            txtTelefon.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            

        }

        private void txtCariAdi_EditValueChanged(object sender, EventArgs e)
        {
            txtCariAdi.Text = txtCariAdi.Text.ToUpper();
        }

        private void txtSoyad_EditValueChanged(object sender, EventArgs e)
        {
            txtSoyad.Text = txtSoyad.Text.ToUpper();
        }

        private void txtBanka_EditValueChanged(object sender, EventArgs e)
        {
            txtBanka.Text = txtBanka.Text.ToUpper();
        }

        private void txtVergiDairesi_EditValueChanged(object sender, EventArgs e)
        {
            txtVergiDairesi.Text = txtVergiDairesi.Text.ToUpper();
        }

        private void txtStatü_EditValueChanged(object sender, EventArgs e)
        {
            txtStatü.Text = txtStatü.Text.ToUpper();
        }

        private void txtAdres_EditValueChanged(object sender, EventArgs e)
        {
            txtAdres.Text = txtAdres.Text.ToUpper();
        }
    }
}
