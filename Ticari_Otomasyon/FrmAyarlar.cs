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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();

        void listele() {
            SqlCommand komut = new SqlCommand("select *from TBL_ADMIN", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz");

            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN (Kullanci_Adi,Sifre) values (@p1,@p2)", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı kaydedildi");
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text=="")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");

            }

            else
            {
                SqlCommand komut = new SqlCommand("update TBL_ADMIN set Kullanci_Adi=@p1,Sifre=@p2 where ID=@p3", baglanti.baglan());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı bilgileri güncellendi");
                listele();
                temizle();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen ID alanını doldurun");

            }

            else
            {
                SqlCommand komut = new SqlCommand("delete from TBL_ADMIN where ID=@p3", baglanti.baglan());
                komut.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı bilgileri silindi");
                listele();
                temizle();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textBox1.Text = dr["Kullanci_Adi"].ToString();
            textBox2.Text = dr["Sifre"].ToString();
            textBox3.Text = dr["ID"].ToString();
            
        }
    }
}
