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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TblNotlar.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TblNotlar.Where(y => y.DURUM == true).ToList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblNotlar not = new TblNotlar();
            not.BASLIK = txtBaslik.Text;
            not.ICERIK = txtIçerik.Text;
            not.TARİH = DateTime.Parse(txtTarih.Text);
            not.DURUM = false;
            db.TblNotlar.Add(not);
            db.SaveChanges();
            MessageBox.Show("Not Başarı ile Eklendi");
            gridControl1.DataSource = db.TblNotlar.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TblNotlar.Where(y => y.DURUM == true).ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TblNotlar.Find(id);
            db.TblNotlar.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Not Başarı ile Silindi");
            gridControl1.DataSource = db.TblNotlar.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TblNotlar.Where(y => y.DURUM == true).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtBaslik.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            txtIçerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            txtTarih.Text= gridView1.GetFocusedRowCellValue("TARIH").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            //txtBaslik.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            //txtIçerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TblNotlar.Find(id);
                deger.BASLIK = txtBaslik.Text;
                deger.ICERIK = txtIçerik.Text;
             //   deger.TARİH = Convert.ToDateTime( txtTarih.Text);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Başarı ile Güncellendi");
                gridControl1.DataSource = db.TblNotlar.Where(x => x.DURUM == false).ToList();
                gridControl2.DataSource = db.TblNotlar.Where(y => y.DURUM == true).ToList();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtBaslik.Text = "";
            txtId.Text = "";
            txtIçerik.Text = "";
            txtTarih.Text = "";
        }
    }
}
