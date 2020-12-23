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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblUrunHareket x = new TblUrunHareket();
            x.URUN = int.Parse(cmbUrunID.EditValue.ToString());
            x.MUSTERI = int.Parse(cmbMusteri.EditValue.ToString());
            x.PERSONEL = short.Parse(cmbPersonel.EditValue.ToString());
            x.TARIH = DateTime.Parse(txtTarih.Text);
            x.ADET = short.Parse(txtAdet.Text);
            x.FIYAT = decimal.Parse(txtISatis.Text);
            x.URUNSERINO = txtSeriNo.Text;
            db.TblUrunHareket.Add(x);
            db.SaveChanges();
            MessageBox.Show("Satış İşlemi Başarılı Bir Şekilde Gerçekleştirildi");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtISatis.Text = "";
            cmbPersonel.Text = "";
            txtSeriNo.Text = "";
            txtTarih.Text = "";
            cmbMusteri.Text = "";
            cmbPersonel.Text = "";
        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            cmbUrunID.Properties.DataSource = (from x in db.TblUrun select new { x.ID,ad= x.AD }).ToList();
            cmbMusteri.Properties.DataSource = (from a in db.TblCari select new { a.ID,ad= a.AD+" "+a.SOYAD }).ToList();
            cmbPersonel.Properties.DataSource = (from p in db.TblPersonel select new { p.ID, Ad=p.AD+" "+p.SOYAD }).ToList();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            DateTime.Now.ToShortDateString();
        }
    }
}
