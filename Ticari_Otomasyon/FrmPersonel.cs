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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();

        void temizle() {

            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTelefon1.Text = "";
            MskTC.Text = "";
            TxtMail.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtGorev.Text = "";
            RichAdres.Text = "";


        }


        void listele() {

            SqlCommand komut = new SqlCommand("select *from TBL_PERSONELLER", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (TxtAd.Text == "" || TxtSoyad.Text == "" || MskTelefon1.Text == "" || MskTC.Text == ""
                || MskTC.Text == "" || TxtMail.Text == "" || CmbIl.Text == "" || CmbIlce.Text == ""
                || TxtGorev.Text == "" || RichAdres.Text == "") {
                MessageBox.Show("Boş alan bırakmayınız");

            }


            else {
                SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values" +
                    "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                komut.Parameters.AddWithValue("@p6", CmbIl.Text);
                komut.Parameters.AddWithValue("@p7", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p8", TxtGorev.Text);
                komut.Parameters.AddWithValue("@p9", RichAdres.Text);
                komut.ExecuteNonQuery();
                baglanti.baglan().Close();
                MessageBox.Show("Personel bilgisi eklendi");
                listele();
                temizle();
            }
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();
            temizle();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4," +
                "MAIL=@p5,IL=@p6,ILCE=@p7,GOREV=@p8,ADRES=@p9 where ID=@p10", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbIl.Text);
            komut.Parameters.AddWithValue("@p7", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p9", RichAdres.Text);
            komut.Parameters.AddWithValue("@p10", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Personel kaydı güncellendi");
            listele();
            temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["AD"].ToString();
            TxtSoyad.Text = dr["SOYAD"].ToString();
            MskTelefon1.Text = dr["TELEFON"].ToString();
            MskTC.Text = dr["TC"].ToString();
            TxtMail.Text = dr["MAIL"].ToString();
            CmbIl.Text = dr["IL"].ToString();
            CmbIlce.Text = dr["ILCE"].ToString();
            TxtGorev.Text = dr["GOREV"].ToString();
            RichAdres.Text = dr["ADRES"].ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_PERSONELLER where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Personel kaydı silindi");
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

            if (TxtAra.Text == "")
            {
                MessageBox.Show("Lütfen bir isim giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {


                SqlCommand komut = new SqlCommand("select AD from TBL_PERSONELLER where AD like '%" + TxtAra.Text + "%'", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand komut2 = new SqlCommand("select *from TBL_PERSONELLER where AD like '%" + TxtAra.Text + "%'", baglanti.baglan());


                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut2);
                    da.Fill(dt);
                    gridControl1.DataSource = dt;

                }

                else { MessageBox.Show("Bu isimde bir personel bulunamadı"); }

            }

                

            
            
               


          

          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
