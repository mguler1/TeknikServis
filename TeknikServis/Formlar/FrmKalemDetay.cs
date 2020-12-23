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
    public partial class FrmKalemDetay : Form
    {
        public FrmKalemDetay()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFaturaId.Text);
            var degerler = (from x in db.TblFaturaDetay
                           select new
                           {
                               x.FATURADETAYID,
                               x.URUN,
                               x.ADET,
                               x.FIYAT,
                               x.TUTAR,
                               x.FATURAID
                           }).Where(x=>x.FATURAID==id);
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
