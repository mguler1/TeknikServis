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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            Lmusteri.Properties.DataSource = (from x in db.TblCari select new { x.ID, Ad=x.AD+" "+x.SOYAD }).ToList();
            Lpersonel.Properties.DataSource = (from y in db.TblPersonel select new { y.ID,AD= y.AD+" "+ y.SOYAD }).ToList();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblUrunKabul t = new TblUrunKabul();
                t.CARI = byte.Parse(Lmusteri.EditValue.ToString());
                t.GELISTARIHI = DateTime.Parse(txtTarih.Text);
                t.PERSONEL = byte.Parse(Lpersonel.EditValue.ToString());
                t.URUNSERINO = txtSeriNo.Text;
                t.DURUMDETAY = "Kabul Bekliyor";
                db.TblUrunKabul.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Arıza Kaydı Yapıldı");
            }
            catch (Exception)
            {

               MessageBox.Show("Lütfen İlgili Alanları Doldurunuz","Uyarı");
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Lmusteri.EditValue = "";
            Lpersonel.Text = "";
            txtSeriNo.Text = "";
            txtTarih.Text = "";
       }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtSeriNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
        }
    }
}
