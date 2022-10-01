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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();

        void StokGoruntule() {

            SqlCommand komut = new SqlCommand("select URUNAD, sum(ADET) as 'ADET' from TBL_URUNLER group by URUNAD " +
                "having sum(ADET) <= 20  order by sum(ADET)", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl2.DataSource = dt;
        
        
        }


        void ajandaGoruntule() {

            SqlCommand komut = new SqlCommand("select top 5 TARIH,SAAT,BASLIK from TBL_NOTLAR order by ID desc", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl3.DataSource = dt;

        }

        void MusteriHareketGoruntule() {
            SqlCommand komut = new SqlCommand("exec MusteriSonBes", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            StokGoruntule();
            ajandaGoruntule();
            MusteriHareketGoruntule();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");


        }
    }
}
