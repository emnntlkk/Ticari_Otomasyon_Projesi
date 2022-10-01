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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        baglantiSinifi baglanti = new baglantiSinifi();

        void FBtemizle() {

            TxtId.Text= "";
            TxtSeri.Text = "";
            TxtSiraNo.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            TxtVergiAdresi.Text = "";
            TxtAlici.Text = "";
            TxtTeslimAlan.Text = "";
            TxtTeslimEden.Text = "";
        
        
        }


        void FaturaBilgilistele() {

            SqlCommand komut = new SqlCommand("select *from TBL_FATURABILGI", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;

        
        
        }

        void FaturaDetayListele()
        {
            SqlCommand komut2 = new SqlCommand("execute FDetayListele", baglanti.baglan());
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;


        }

        void FDtemizle()
        {

            TxtDetayID.Text = "";
            TxtUrunAd.Text = "";
            TxtMiktar.Text = "";
            TxtFiyat.Text = "";
            TxtTutar.Text = "";
            TxtFaturaID.Text = "";


        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            FaturaBilgilistele();
            FaturaDetayListele();
           
        }

      
      

        




        //Fatura bilgi bölümü
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["FATURABILGIID"].ToString();
            TxtSeri.Text = dr["SERI"].ToString();
            TxtSiraNo.Text = dr["SIRANO"].ToString();
            MskTarih.Text = dr["TARIH"].ToString();
            MskSaat.Text = dr["SAAT"].ToString();
            TxtVergiAdresi.Text = dr["VERGIDAIRE"].ToString();
            TxtAlici.Text = dr["ALICI"].ToString();
            TxtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
            TxtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
        }

       
        private void BtnKaydetFBilgi_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) " +
               "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.baglan());

            komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
            komut.Parameters.AddWithValue("@p2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtVergiAdresi.Text);
            komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Fatura bilgileri kaydedildi");
            FaturaBilgilistele();
            FBtemizle();
        }

        private void BtnListeleFBilgi_Click(object sender, EventArgs e)
        {
            FaturaBilgilistele();
        }

        private void BtnGuncelleFBilgi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3," +
                "SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
            komut.Parameters.AddWithValue("@p2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtVergiAdresi.Text);
            komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", int.Parse(TxtId.Text));
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Fatura bilgileri güncellendi");
            FaturaBilgilistele();
            FBtemizle();
        }

        private void BtnSilFBilgi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@p1 ", baglanti.baglan());

            komut.Parameters.AddWithValue("@p1", int.Parse(TxtId.Text));
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Fatura bilgileri güncellendi");
            FaturaBilgilistele();
            FBtemizle();
        }

        private void BtnTemizleFBilgi_Click(object sender, EventArgs e)
        {
            FBtemizle();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            TxtDetayID.Text = dr["FATURAURUNID"].ToString();
            TxtUrunAd.Text = dr["URUNAD"].ToString();
            TxtMiktar.Text = dr["MIKTAR"].ToString();
            TxtFiyat.Text = dr["FIYAT"].ToString();
            TxtTutar.Text = dr["TUTAR"].ToString();
            TxtFaturaID.Text = dr["FATURABILGIID"].ToString();
            
        }

        private void BtnKaydetFDetay_Click_1(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(TxtFiyat.Text);
            miktar = Convert.ToDouble(TxtMiktar.Text);
            tutar = miktar * fiyat;
            TxtTutar.Text = tutar.ToString();

            SqlCommand komut = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID)" +
             "values (@p1,@p2,@p3,@p4,@p5)", baglanti.baglan());

            komut.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", int.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p5", int.Parse(TxtFaturaID.Text));

            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Fatura bilgileri kaydedildi");
            FaturaDetayListele();
            FDtemizle();



            //hareket tablosuna veri girişi

           /*SqlCommand komut2 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", baglanti.baglan());
            komut2.Parameters.AddWithValue("@h1", TxtDetayID.Text);
            komut2.Parameters.AddWithValue("@h2", TxtMiktar.Text);
            komut2.Parameters.AddWithValue("@h3", TxtPersonel.Text);
            komut2.Parameters.AddWithValue("@h4", int.Parse(TxtFirma.Text));
            komut2.Parameters.AddWithValue("@h5",decimal.Parse(TxtFiyat.Text));
            komut2.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@h7", int.Parse(TxtFaturaID.Text));
            komut2.Parameters.AddWithValue("@h8", MskTarih.Text);
            komut2.ExecuteNonQuery();
            baglanti.baglan().Close();*/




        }

        private void BtnGuncelleFDetay_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURADETAY set URUNAD=@p1," +
                "MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4,FATURAID=@p5",baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p5", int.Parse(TxtFaturaID.Text));
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Fatura bilgisi güncellendi");
            FaturaDetayListele();
            FDtemizle();

        }

        private void BtnSilFDetay_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtDetayID.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Fatura bilgisi silindi");
            FaturaDetayListele();
            FDtemizle();
        }

        private void BtnTemizleFDetay_Click(object sender, EventArgs e)
        {
            FDtemizle();
        }

        private void BtnListeleFDetay_Click(object sender, EventArgs e)
        {
            FaturaDetayListele();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select URUNAD,SATISFIYAT from TBL_URUNLER where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtDetayID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAd.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();
            
            }
            baglanti.baglan().Close();
        }
    }
    
}
