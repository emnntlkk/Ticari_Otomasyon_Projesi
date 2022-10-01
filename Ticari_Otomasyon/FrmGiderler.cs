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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();


        void GiderlerListele() {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_GIDERLER", baglanti.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        
        
        }

        void temizle() {

            TxtID.Text = "";
            CmbAy.Text = "";
            MskYıl.Text = "";
            TxtDogalgaz.Text = "";
            TxtEkstra.Text = "";
            TxtElektrik.Text = "";
            TxtInternet.Text = "";
            TxtMaaslar.Text = "";
            TxtSu.Text = "";
            RichNotlar.Text ="";        
        
        
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GiderlerListele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           

                SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET," +
                    "MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.baglan());

                komut.Parameters.AddWithValue("@p1", CmbAy.Text);
                komut.Parameters.AddWithValue("@p2", MskYıl.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaaslar.Text));
                komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEkstra.Text));
                komut.Parameters.AddWithValue("@p9", RichNotlar.Text);
                komut.ExecuteNonQuery();
                baglanti.baglan().Close();
                MessageBox.Show("Gider kaydı eklendi");
                GiderlerListele();
                temizle();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["ID"].ToString();
            CmbAy.Text = dr["AY"].ToString();
            MskYıl.Text = dr["YIL"].ToString();
            TxtElektrik.Text = dr["ELEKTRIK"].ToString();
            TxtSu.Text = dr["SU"].ToString();
            TxtDogalgaz.Text = dr["DOGALGAZ"].ToString();
            TxtInternet.Text = dr["INTERNET"].ToString();
            TxtMaaslar.Text = dr["MAASLAR"].ToString();
            TxtEkstra.Text = dr["EKSTRA"].ToString();
            RichNotlar.Text = dr["NOTLAR"].ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4," +
                "DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            komut.Parameters.AddWithValue("@p2", MskYıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@p9", RichNotlar.Text);
            komut.Parameters.AddWithValue("@p10", TxtID.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Gider kayıtları güncellendi");
            GiderlerListele();
            temizle();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_GIDERLER where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Gider kaydı silindi");
            GiderlerListele();
            temizle();
        }
    }
}
