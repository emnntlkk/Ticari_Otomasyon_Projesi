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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();

        void temizle() {
            TxtId.Text = "";
            TxtBankaAdi.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtSube.Text = "";
            MskIBAN.Text = "";
            TxtHesapNo.Text = "";
            TxtYetkili.Text = "";
            MskTelefon.Text = "";
            MskTarih.Text = "";
            TxtHesapTuru.Text = "";
            lookFirma.Text = "";
        
        
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

        void listele() {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute BankaBilgileri",baglanti.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        
        }

        void FirmaListesi() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from TBL_FIRMALAR",baglanti.baglan());
            da.Fill(dt);
            lookFirma.Properties.ValueMember = "ID";
            lookFirma.Properties.DisplayMember = "AD";
            lookFirma.Properties.DataSource = dt;
        
        
        
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            FirmaListesi();
            ILListe();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtBankaAdi.Text = dr["BANKAADI"].ToString();
            CmbIl.Text = dr["IL"].ToString();
            CmbIlce.Text = dr["ILCE"].ToString();
            TxtSube.Text = dr["SUBE"].ToString();
            MskIBAN.Text = dr["IBAN"].ToString();
            TxtHesapNo.Text = dr["HESAPNO"].ToString();
            TxtYetkili.Text = dr["YETKILI"].ToString();
            MskTelefon.Text = dr["TELEFON"].ToString();
            MskTarih.Text = dr["TARIH"].ToString();
            TxtHesapTuru.Text = dr["HESAPTURU"].ToString();
            
            
            
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtBankaAdi.Text == "" || CmbIl.Text == "" || CmbIlce.Text=="" || TxtSube.Text==""
                || MskIBAN.Text=="" || TxtHesapNo.Text=="" || TxtYetkili.Text=="" || MskTelefon.Text==""
                || MskTarih.Text=="" || TxtHesapTuru.Text=="" || lookFirma.Text=="" ) 
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }

            else {

                SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI," +
               "TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", TxtBankaAdi.Text);
                komut.Parameters.AddWithValue("@p2", CmbIl.Text);
                komut.Parameters.AddWithValue("@p3", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p4", TxtSube.Text);
                komut.Parameters.AddWithValue("@p5", MskIBAN.Text);
                komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
                komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p9", MskTarih.Text);
                komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
                komut.Parameters.AddWithValue("@p11", lookFirma.EditValue);
                komut.ExecuteNonQuery();
                MessageBox.Show("Banka kaydı eklendi");
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set BANKAADI=@p1, IL=@p2,ILCE=@p3," +
                "SUBE=@p4,IBAN=@p5, HESAPNO=@p6,YETKILI=@p7, TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10, FIRMAID=@p11 where ID=@p12",baglanti.baglan());
            komut.Parameters.AddWithValue("@p12", int.Parse(TxtId.Text));
            komut.Parameters.AddWithValue("@p1", TxtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", CmbIl.Text);
            komut.Parameters.AddWithValue("@p3", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", MskIBAN.Text);
            komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11",lookFirma.EditValue);
           
            komut.ExecuteNonQuery();
            baglanti.baglan().Close();
            listele();
            temizle();
            MessageBox.Show("Banka kaydı güncellendi");

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_BANKALAR where ID=@p1", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            MessageBox.Show("Banka bilgisi silindi");
            listele();
            temizle();

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from TBL_PERSONELLER where AD like '%" + TxtAra.Text + "%'", baglanti.baglan());


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
