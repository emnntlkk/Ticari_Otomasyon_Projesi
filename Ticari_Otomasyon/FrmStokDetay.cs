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
    public partial class FrmStokDetay : Form
    {
        public FrmStokDetay()
        {
            InitializeComponent();
        }
        public string ad;
        baglantiSinifi baglanti = new baglantiSinifi();
        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_URUNLER where URUNAD='" + ad + "'", baglanti.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
