﻿using System;
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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }

        baglantiSinifi baglanti = new baglantiSinifi();


        void FirmaHareketlistele() {

            SqlCommand komut = new SqlCommand("execute HareketGoruntule",baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl1.DataSource = dt;

     }


        void MusteriHareketListele() {
            SqlCommand komut = new SqlCommand("execute MusteriHareketler", baglanti.baglan());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            gridControl2.DataSource = dt;



        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            FirmaHareketlistele();
            MusteriHareketListele();
        }
    }
}
