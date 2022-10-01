using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        public string ad;
        

        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmUrunler fr = new FrmUrunler();

            fr.MdiParent = this;
            fr.Show();
            
        }

        private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.MdiParent = this;
            fr.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.MdiParent = this;
            fr.Show();
        }
        
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmalar fr = new FrmFirmalar();
            fr.MdiParent = this;
            fr.Show();

        }

        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRehber fr = new FrmRehber();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGiderler fr = new FrmGiderler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBankalar fr = new FrmBankalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturalar fr = new FrmFaturalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotlar fr = new FrmNotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHareketler fr = new FrmHareketler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAyarlar fr = new FrmAyarlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            FrmKasa fr = new FrmKasa();
            fr.Kullanici = ad;
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
