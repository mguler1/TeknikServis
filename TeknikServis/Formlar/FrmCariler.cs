using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeknikServis.Formlar
{
    public partial class FrmCariler : Form
    {
        public FrmCariler()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=DBTeknikServis;Integrated Security=True");
        private void FrmCariler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TblCari.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { Il = z.Key, TOPLAM = z.Count() }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL, COUNT(*) from TblCari group by IL",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               // chartControl1.Series["Series1"].Points.AddPoint(Convert.ToString( dr[0]),int.Parse( dr[1].ToString()));
                baglanti.Close();
            }
        }
    }
}
