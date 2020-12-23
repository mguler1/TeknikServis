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
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        public int id;

        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            //label1.Text = id.ToString();
            DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
            gridControl1.DataSource = db.TblFaturaDetay.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TblFaturaBilgi.Where(x => x.ID == id).ToList();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "output.pdf";
            gridControl1.ExportToPdf(path);
            
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "output.Xls";
            gridControl1.ExportToXls(path);
        }
    }
}
