using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TblUrun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl7.Text = (from x in db.TblUrun select x.MARKA).Distinct().Count().ToString();
            labelControl2.Text = db.TblUrun.Count().ToString();
            labelControl15.Text = (from x in db.TblUrun orderby x.SATISFIYAT descending select x.MARKA).FirstOrDefault();
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }
    }
}