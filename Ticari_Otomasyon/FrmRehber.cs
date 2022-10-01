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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        baglantiSinifi baglanti = new baglantiSinifi();
        void MusteriBilgileri() {

            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBL_MUSTERILER", baglanti.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        }

        void FirmaBilgileri()
        {

            SqlDataAdapter da = new SqlDataAdapter("select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR", baglanti.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }

        private void FrmRehber_Load(object sender, EventArgs e)
        {
            MusteriBilgileri();
            FirmaBilgileri();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail fr = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            fr.mail = dr["MAIL"].ToString();
            fr.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail fr = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            fr.mail = dr["MAIL"].ToString();
            fr.Show();
        }
    }
}
