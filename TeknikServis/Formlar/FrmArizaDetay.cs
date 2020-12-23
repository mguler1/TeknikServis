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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblUrunTakip t = new TblUrunTakip();
                t.ACIKLAMA = richTextBox1.Text;
                t.SERINO = txtSeriNo.Text;
                t.TARIH = DateTime.Parse(txtTarih.Text);
                db.TblUrunTakip.Add(t);

                TblUrunKabul tb = new TblUrunKabul();
                tb.DURUMDETAY = comboBox1.Text;
                db.SaveChanges();
                MessageBox.Show("Success");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Alanları Doldurunuz");
            }
          

           
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtTarih.Text = "";
            richTextBox1.Text = "";
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        public string id;
        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = id;
        }
    }
}
