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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        baglantiSinifi baglanti = new baglantiSinifi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Kullanci_Adi,Sifre from TBL_ADMIN where Kullanci_Adi=@p1 and Sifre=@p2", baglanti.baglan());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                FrmAnaModul fr = new FrmAnaModul();
                fr.ad = TxtKullaniciAdi.Text;
                
                fr.Show();
                this.Hide();

            }

            else {

                MessageBox.Show("Uyarı","Yanlış kullanıcı adı veya şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
