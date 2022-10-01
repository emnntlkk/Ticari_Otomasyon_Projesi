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


namespace Ticari_Otomasyon
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        baglantiSinifi baglanti = new baglantiSinifi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,sum(ADET) as 'Miktar' from TBL_URUNLER group by URUNAD", baglanti.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            //charta stok miktarı listeleme

            SqlCommand komut = new SqlCommand("select URUNAD,sum(ADET) as 'Miktar' from TBL_URUNLER group by URUNAD", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                chartControl1.Series["Seri1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString())) ;

                /**/
            }

            baglanti.baglan().Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Tıkladığımız satırdaki ürün isminin ad değişkenine atanması için kullanılan kod

            FrmStokDetay fr = new FrmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
            
            }
            fr.Show();
        }
    }
}
