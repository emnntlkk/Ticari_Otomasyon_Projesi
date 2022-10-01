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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        baglantiSinifi baglanti = new baglantiSinifi();

        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTC.Text = "";
            TxtMail.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtVergiDairesi.Text = "";
            TxtMail.Text = "";
            RichAdres.Text = "";

        }


        void listele() {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_MUSTERILER", baglanti.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        
        }

        void ILListe() {

            SqlCommand komut = new SqlCommand("select distinct IL from TBL_IL_ILCE",baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CmbIl.Properties.Items.Add(dr[0]);
                
            
            }

            baglanti.baglan().Close();
        
        
        
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            ILListe();
            temizle();
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_IL_ILCE where KOD=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", CmbIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CmbIlce.Properties.Items.Add(dr[0]);
           
            }
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || MskTelefon1.Text == "" ||
                MskTelefon2.Text == "" || MskTC.Text == "" || TxtMail.Text == ""
                || CmbIl.Text == "" || CmbIlce.Text == "" || TxtVergiDairesi.Text == ""
                || RichAdres.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else {

                SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRE,ADRES)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
                komut.Parameters.AddWithValue("@p5", MskTC.Text);
                komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                komut.Parameters.AddWithValue("@p7", CmbIl.Text);
                komut.Parameters.AddWithValue("@p8", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p9", TxtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@p10", RichAdres.Text);
                komut.ExecuteNonQuery();
                baglanti.baglan().Close();
                MessageBox.Show("Müşteri eklendi");
                listele();
                temizle();
                
            
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@p1," +
                "SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7," +
                "ILCE=@p8,VERGIDAIRE=@p9,ADRES=@p10 where ID=@p11",baglanti.baglan());
            komut.Parameters.AddWithValue("@p11", TxtId.Text);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", CmbIl.Text);
            komut.Parameters.AddWithValue("@p8", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", TxtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p10", RichAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Müşteri bilgileri güncellendi");
            listele();
            temizle();


            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_MUSTERILER where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1",TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Müşteri kaydı silindi");
            listele();
            temizle();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("select *from TBL_MUSTERILER where AD like '%" + TxtAra.Text + "%'", baglanti.baglan());


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                gridControl1.DataSource = dt;
            
       }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                RichAdres.Text = dr["ADRES"].ToString();
            }
            
            

        }
    }

