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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TblDepartman select new { u.ID, u.AD, u.ACIKLAMA };
            gridControl1.DataSource = degerler.ToList();
            labelControl14.Text = db.TblDepartman.Count().ToString();
            labelControl18.Text = db.TblPersonel.Count().ToString();
        }
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            if (txtDepartmanAdi.Text.Length>=5 && txtDepartmanAdi.Text!="")
            {
                TblDepartman d = new TblDepartman();
                d.AD = txtDepartmanAdi.Text;
                d.ACIKLAMA = txtAciklama.Text;
                db.TblDepartman.Add(d);
                db.SaveChanges();
                MessageBox.Show("Departman Başarı ile Eklendi");
                gridControl1.DataSource = db.TblDepartman.ToList();

            }
            else
            {
                MessageBox.Show( "Departman Adı 5 Karakterden Azdır", "Hata", MessageBoxButtons.OK);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtDepartmanAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TblDepartman.Find(id);
            db.TblDepartman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarı ile Silindi");
            gridControl1.DataSource = db.TblDepartman.ToList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TblDepartman.Find(id);
            deger.AD = txtDepartmanAdi.Text;
            deger.ACIKLAMA = txtAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarı ile Güncellendi");
            gridControl1.DataSource = db.TblDepartman.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = "";
            txtDepartmanAdi.Text = "";
            txtId.Text = "";
        }

        private void txtDepartmanAdi_EditValueChanged(object sender, EventArgs e)
        {
            txtDepartmanAdi.Text = txtDepartmanAdi.Text.ToUpper();
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            //txtAciklama.Text = txtAciklama.Text.ToUpper(); texteditin multilene çevir
        }
    }
}
