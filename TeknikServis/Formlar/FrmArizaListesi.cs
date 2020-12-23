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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TblUrunKabul.Count(X=>X.URUNDURUM==false).ToString();
            labelControl15.Text = db.TblUrunKabul.Count(X => X.URUNDURUM == true).ToString();
            labelControl7.Text = db.TblUrun.Count().ToString();
            labelControl24.Text = db.TblUrunKabul.Count(x => x.DURUMDETAY == "Parça Bekliyor").ToString();
            labelControl24.Text = db.TblUrunKabul.Count(x => x.DURUMDETAY == "Mesaj Bekliyor").ToString();
            labelControl24.Text = db.TblUrunKabul.Count(x => x.DURUMDETAY == "iptal Bekliyor").ToString();

        }

        private void labelControl24_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //FrmArizaDetay fr = new FrmArizaDetay();
            //fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            //fr.Show();
        }
    }
}
