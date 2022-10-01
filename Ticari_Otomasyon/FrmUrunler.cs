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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();


        void listele() {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_URUNLER", baglanti.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        }

        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            MskYil.Text = "";
            TxtAdet.Text = "";
            TxtAlisFiyat.Text = "";
            TxtSatisFiyat.Text = "";
            RichDetay.Text = "";

        }

        

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text == "" || TxtMarka.Text == "" || TxtModel.Text == "" || MskYil.Text == ""
                || TxtAdet.Text == "" || TxtAlisFiyat.Text == "" || TxtSatisFiyat.Text == ""
                || RichDetay.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }

            else
            {

                SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,URUNMARKA,URUNMODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
                komut.Parameters.AddWithValue("@p3", TxtModel.Text);
                komut.Parameters.AddWithValue("@p4", MskYil.Text);
                komut.Parameters.AddWithValue("@p5", TxtAdet.Text);
                komut.Parameters.AddWithValue("@p6", decimal.Parse((TxtAlisFiyat.Text).ToString()));
                komut.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatisFiyat.Text).ToString()));
                komut.Parameters.AddWithValue("@p8", RichDetay.Text);
                komut.ExecuteNonQuery();
                baglanti.baglan().Close();
                MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,URUNMARKA=@p2," +
                "URUNMODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", TxtAdet.Text);
            komut.Parameters.AddWithValue("@p6", decimal.Parse((TxtAlisFiyat.Text)));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatisFiyat.Text)));
            komut.Parameters.AddWithValue("@p8", RichDetay.Text);
            komut.Parameters.AddWithValue("@p9", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_URUNLER where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["URUNMARKA"].ToString();
            TxtModel.Text = dr["URUNMODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            TxtAdet.Text = dr["ADET"].ToString();
            TxtSatisFiyat.Text = dr["ALISFIYAT"].ToString();
            TxtAlisFiyat.Text = dr["SATISFIYAT"].ToString();
            RichDetay.Text = dr["DETAY"].ToString();


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from TBL_URUNLER where URUNAD like '%"+TxtAra.Text+"%'",baglanti.baglan());
            
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            
            

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
