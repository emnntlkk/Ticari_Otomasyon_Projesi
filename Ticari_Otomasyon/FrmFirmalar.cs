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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();

        void cariKodAciklamalar()
        {

            SqlCommand komut = new SqlCommand("select FIRMAKOD1 from TBL_KODLAR", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) {

                RchKod1.Text = dr[0].ToString();
            
            }
            baglanti.baglan().Close();
        }

        void temizle() {

            TxtId.Text = "";
            TxtFirmaAd.Text = "";
            TxtSektor.Text = "";
            TxtYetkili.Text = "";
            TxtYetkiliStatu.Text = "";
            TxtTC.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTelefon3.Text = "";
            MskFax.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            RichAdres.Text = "";
            TxtOzelKod1.Text = "";
            TxtOzelKod2.Text = "";
            TxtOzelKod3.Text = "";
          


        
        
        }

        void ILListe()
        {

            SqlCommand komut = new SqlCommand("select distinct IL from TBL_IL_ILCE", baglanti.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CmbIl.Properties.Items.Add(dr[0]);


            }

            baglanti.baglan().Close();



        }

        void FirmaListesi() {

            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_FIRMALAR", baglanti.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            temizle();
            ILListe();
            cariKodAciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtFirmaAd.Text = dr["AD"].ToString();
            TxtTC.Text = dr["YETKILITC"].ToString();
            TxtYetkiliStatu.Text = dr["YETKILISTATU"].ToString();
            TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
            TxtSektor.Text = dr["SEKTOR"].ToString();
            MskTelefon1.Text = dr["TELEFON1"].ToString();
            MskTelefon2.Text = dr["TELEFON2"].ToString();
            MskTelefon3.Text = dr["TELEFON3"].ToString();
            TxtMail.Text = dr["MAIL"].ToString();
            MskFax.Text = dr["FAX"].ToString();
            CmbIl.Text = dr["IL"].ToString();
            CmbIlce.Text = dr["ILCE"].ToString();
            TxtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
            RichAdres.Text = dr["ADRES"].ToString();
            TxtOzelKod1.Text = dr["OZELKOD1"].ToString();
            TxtOzelKod2.Text = dr["OZELKOD2"].ToString();
            TxtOzelKod3.Text = dr["OZELKOD3"].ToString();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtFirmaAd.Text == "" || TxtTC.Text == "" || TxtYetkiliStatu.Text == "" || TxtYetkili.Text == ""
                || TxtSektor.Text == "" || MskTelefon1.Text == "" || MskTelefon2.Text == "" || MskTelefon3.Text == ""
                || TxtMail.Text == "" || MskFax.Text == "" || CmbIl.Text == "" || CmbIlce.Text == ""
                || TxtVergiDairesi.Text == "" || RichAdres.Text == "" || TxtOzelKod1.Text == ""
                || TxtOzelKod2.Text == "" || TxtOzelKod3.Text == ""

                )
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }

            else
            {

                SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILITC,YETKILISTATU," +
                    "YETKILIADSOYAD,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE," +
                    "ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11," +
                    "@p12,@p13,@p14,@p15,@p16,@p17)", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", TxtFirmaAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtTC.Text);
                komut.Parameters.AddWithValue("@p3", TxtYetkiliStatu.Text);
                komut.Parameters.AddWithValue("@p4", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
                komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
                komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
                komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
                komut.Parameters.AddWithValue("@p9", TxtMail.Text);
                komut.Parameters.AddWithValue("@p10", MskFax.Text);
                komut.Parameters.AddWithValue("@p11", CmbIl.Text);
                komut.Parameters.AddWithValue("@p12", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p13", TxtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@p14", RichAdres.Text);
                komut.Parameters.AddWithValue("@p15", TxtOzelKod1.Text);
                komut.Parameters.AddWithValue("@p16", TxtOzelKod2.Text);
                komut.Parameters.AddWithValue("@p17", TxtOzelKod3.Text);
                komut.ExecuteNonQuery();
                baglanti.baglan().Close();
                MessageBox.Show("Firma kaydı oluşturuldu");
                FirmaListesi();
                temizle();

            }

        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_IL_ILCE where KOD=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", CmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CmbIlce.Properties.Items.Add(dr[0]);

            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FIRMALAR where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Firma Kaydı silindi");
            FirmaListesi();
            temizle();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@p1," +
                "YETKILITC=@p2,YETKILISTATU=@p3,YETKILIADSOYAD=@p4," +
                "SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9," +
                "FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13," +
                "ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 where ID=@p18" , baglanti.baglan());

            komut.Parameters.AddWithValue("@p1", TxtFirmaAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtTC.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkiliStatu.Text);
            komut.Parameters.AddWithValue("@p4", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", MskFax.Text);
            komut.Parameters.AddWithValue("@p11", CmbIl.Text);
            komut.Parameters.AddWithValue("@p12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14", RichAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtOzelKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtOzelKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtOzelKod3.Text);
            komut.Parameters.AddWithValue("@p18", TxtId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma bilgileri güncellendi");
            FirmaListesi();
            temizle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (TxtAra.Text == "")
            {

                MessageBox.Show("Lütfen firma adı veya sektör bilgisini giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else {
                SqlCommand komut = new SqlCommand("select *from TBL_FIRMALAR where AD like '%" + TxtAra.Text + "%' or SEKTOR like '%" + TxtAra.Text + "%'", baglanti.baglan());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    SqlCommand komut2 = new SqlCommand("select *from TBL_FIRMALAR where AD like '%" + TxtAra.Text + "%' or SEKTOR like '%" + TxtAra.Text + "%'", baglanti.baglan());


                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut2);
                    da.Fill(dt);
                    gridControl1.DataSource = dt;

                }

                else { MessageBox.Show("Girdiğiniz firma adı veya sektöre ai bir bilgi bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }

            
        }
    }
}
