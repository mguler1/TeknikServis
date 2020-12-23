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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();

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
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz","Uyarı");
            }
           
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            cmbKategori.Properties.DataSource = (from x in db.TblKategori select new { x.ID, x.AD }).ToList();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtAlisFiyati.Text = "";
            cmbKategori.Text = "";
            txtMarka.Text = "";
            txtSatisFiyati.Text = "";
            txtStok.Text = "";
            txtUrunAdi.Text = "";
        }

        private void txtUrunAdi_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtUrunAdi.Focus();
        }

        private void txtMarka_Click(object sender, EventArgs e)
        {
            txtMarka.Text = "";
            txtMarka.Focus();
        }

        private void txtAlisFiyati_EditValueChanged(object sender, EventArgs e)
        {
          //  txtAlisFiyati.Text = "";
            txtAlisFiyati.Focus();
        }

        private void txtSatisFiyati_EditValueChanged(object sender, EventArgs e)
        {
            txtSatisFiyati.Text = "";
            txtSatisFiyati.Focus();
        }

        private void txtStok_EditValueChanged(object sender, EventArgs e)
        {
            txtStok.Text = "";
            txtStok.Focus();
        }

        private void cmbKategori_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAlisFiyati_Click(object sender, EventArgs e)
        {
            txtAlisFiyati.Text = "";
        }

        private void txtSatisFiyati_Click(object sender, EventArgs e)
        {
            txtSatisFiyati.Text = "";
        }

        private void txtUrunAdi_EditValueChanged(object sender, EventArgs e)
        {
            txtUrunAdi.Text = txtUrunAdi.Text.ToUpper();
        }

        private void txtMarka_EditValueChanged(object sender, EventArgs e)
        {
            txtMarka.Text = txtMarka.Text.ToUpper();
        }
    }
}
