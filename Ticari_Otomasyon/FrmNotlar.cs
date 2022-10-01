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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();

        private void RichAdres_TextChanged(object sender, EventArgs e)
        {

        }
        void listele() {

            SqlCommand komut = new SqlCommand("select *from TBL_NOTLAR", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;



        }

        void temizle() {
            TxtId.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            TxtBaslik.Text = "";
            TxtOlusturan.Text = "";
            TxtHitap.Text = "";
            RichDetay.Text = "";
        
        
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            MskTarih.Text = dr["TARIH"].ToString();
            MskSaat.Text = dr["SAAT"].ToString();
            TxtBaslik.Text = dr["BASLIK"].ToString();
            TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
            TxtHitap.Text = dr["HITAP"].ToString();
            RichDetay.Text = dr["DETAY"].ToString();
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,OLUSTURAN,HITAP,DETAY) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p5", TxtHitap.Text);
            komut.Parameters.AddWithValue("@p6", RichDetay.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Not oluşturuldu");
            listele();
            temizle();

            
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARIH=@p2,SAAT=@p3,BASLIK=@p4," +
                "OLUSTURAN=@p5,HITAP=@p6,DETAY=@p7 where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p2", MskTarih.Text);
            komut.Parameters.AddWithValue("@p3", MskSaat.Text);
            komut.Parameters.AddWithValue("@p4", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
            komut.Parameters.AddWithValue("@p7", RichDetay.Text);
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Not oluşturuldu");
            listele();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_NOTLAR where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Not silindi");
            listele();
            temizle();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

           
                fr.metin = dr["DETAY"].ToString();
            
            fr.Show();
        }
    }
}
