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
using DevExpress.Charts;
namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        public string Kullanici;

        void MusteriHareketler() {

            SqlDataAdapter da = new SqlDataAdapter("execute MusteriHareketler", baglanti.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        
        }

        void FirmaHareketler() {
            SqlDataAdapter da = new SqlDataAdapter("execute HareketGoruntule", baglanti.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;


        }

        void FaturaDetay() {

            SqlCommand komut = new SqlCommand("select sum(TUTAR) from TBL_FATURADETAY", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamTutar.Text = dr[0].ToString();
            
            }
            baglanti.baglan().Close();
        }

        void Odemeler() {
            SqlCommand komut = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+MAASLAR+EKSTRA) from TBL_GIDERLER order by ID asc", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblOdemeler.Text = dr[0].ToString();

            }
            baglanti.baglan().Close();
        }

        void PersonelMaaslari()
        {

            SqlCommand komut = new SqlCommand("select MAASLAR from TBL_GIDERLER order by ID asc",baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblPersonelMaas.Text = dr[0].ToString();

            }
            baglanti.baglan().Close();
        }

        void MusteriSayisi() {
            SqlCommand komut = new SqlCommand("select count(*) from TBL_MUSTERILER", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblMusteriSayi.Text = dr[0].ToString();

            }

            baglanti.baglan().Close();


        }

        void FirmaSayisi() {

            SqlCommand komut = new SqlCommand("select COUNT(*) from TBL_FIRMALAR", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblFirmaSayisi.Text = dr[0].ToString();

            }
            baglanti.baglan().Close();
        }

        void FirmaSehir() {

            SqlCommand komut = new SqlCommand("select count(distinct(IL))  from TBL_FIRMALAR", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblFSehirSayisi.Text = dr[0].ToString();

            }

            baglanti.baglan().Close();

        }

        void MusteriSehir() {

            SqlCommand komut = new SqlCommand("select count(distinct(IL))  from TBL_MUSTERILER", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblMSehirSayisi.Text = dr[0].ToString();

            }
            baglanti.baglan().Close();
        }


        void PersoneSayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*)  from TBL_PERSONELLER", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblPersonelSayisi.Text = dr[0].ToString();

            }

            baglanti.baglan().Close();

        }

        void Stoksayisi() {

            SqlCommand komut = new SqlCommand("select SUM(ADET)  from TBL_URUNLER", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblStokSayisi.Text = dr[0].ToString();

            }

            baglanti.baglan().Close();

        }

        baglantiSinifi baglanti = new baglantiSinifi();
        private void FrmKasa_Load(object sender, EventArgs e)
        {

            MusteriHareketler();
            FirmaHareketler();
            FaturaDetay();
            Odemeler();
            PersonelMaaslari();
            MusteriSayisi();
            FirmaSayisi();
            FirmaSehir();
            MusteriSehir();
            PersoneSayisi();
            Stoksayisi();
            LblAktifKullanici.Text = Kullanici;

            //1.chart controle elektrik faturası son 4 ay listeleme


        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

                if (sayac > 0 && sayac < 5)
                {


                    groupControl10.Text = "ELEKTRİK";
                    SqlCommand komut = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID desc", baglanti.baglan());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {

                        chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));

                    }
                    baglanti.baglan().Close();

                }

                if (sayac > 5 && sayac < 10)
                {


                    groupControl10.Text = "SU";
                    SqlCommand komut = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID desc", baglanti.baglan());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {

                        chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));

                    }

                    baglanti.baglan().Close();
                }
                if (sayac > 11 && sayac < 15)
                {


                    groupControl10.Text = "DOĞALGAZ";
                    SqlCommand komut = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID desc", baglanti.baglan());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {

                        chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));

                    }

                    baglanti.baglan().Close();
                }

                if (sayac > 16 && sayac < 20)
                {


                    groupControl10.Text = "İNTERNET";
                    SqlCommand komut = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", baglanti.baglan());
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {

                        chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));

                    }

                    baglanti.baglan().Close();
                }
            if (sayac > 20)
            {
                sayac = 0;
            }

            
        }

        private void groupControl9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

