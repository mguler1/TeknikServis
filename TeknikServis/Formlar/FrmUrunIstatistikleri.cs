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
    public partial class FrmUrunIstatistikleri : Form
    {
        public FrmUrunIstatistikleri()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void labelControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmUrunIstatistikleri_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TblUrun.Count().ToString();
            labelControl3.Text = db.TblKategori.Count().ToString();
            labelControl5.Text = db.TblUrun.Sum(x=>x.STOKSAYISI).ToString();
            labelControl19.Text = (from x in db.TblUrun orderby x.STOKSAYISI descending select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.TblUrun orderby x.STOKSAYISI ascending select x.AD).FirstOrDefault();
            labelControl7.Text = "10";
            labelControl13.Text = (from x in db.TblUrun orderby x.SATISFIYAT descending select x.AD).FirstOrDefault();
            labelControl11.Text= (from x in db.TblUrun orderby x.SATISFIYAT ascending select x.AD).FirstOrDefault();
            // labelControl35.Text = db.TblUrun.Count(x => x.KATEGORI == 4).ToString(); ihtiyaç olursa açılacak kategoriler ayarlanarak
            // labelControl33.Text = db.TblUrun.Count(x => x.KATEGORI == 1).ToString();
            // labelControl31.Text = db.TblUrun.Count(x => x.KATEGORI == 2).ToString();
            labelControl29.Text = (from x in db.TblUrun select x.MARKA).Distinct().Count().ToString();
            labelControl35.Text = db.TblUrunKabul.Count().ToString();
            labelControl15.Text = db.maxUrunKategoriGetir().FirstOrDefault();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl29_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
