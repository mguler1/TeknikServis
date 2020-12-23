using DevExpress.XtraEditors;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin where  x.KULLANICIAD == textEdit1.Text & x.SIFRE == textBox1.Text  select x;
            if(sorgu.Any())
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
