namespace Ticari_Otomasyon
{
    partial class FrmBankalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtBankaAdi = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtHesapTuru = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtHesapNo = new System.Windows.Forms.TextBox();
            this.MskIBAN = new System.Windows.Forms.TextBox();
            this.CmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSube = new System.Windows.Forms.TextBox();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 878);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookFirma);
            this.groupControl1.Controls.Add(this.TxtBankaAdi);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.MskTarih);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtHesapTuru);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtYetkili);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtHesapNo);
            this.groupControl1.Controls.Add(this.MskIBAN);
            this.groupControl1.Controls.Add(this.CmbIlce);
            this.groupControl1.Controls.Add(this.CmbIl);
            this.groupControl1.Controls.Add(this.MskTelefon);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TxtSube);
            this.groupControl1.Controls.Add(this.TxtAra);
            this.groupControl1.Controls.Add(this.BtnAra);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Location = new System.Drawing.Point(980, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 878);
            this.groupControl1.TabIndex = 3;
            // 
            // lookFirma
            // 
            this.lookFirma.Location = new System.Drawing.Point(194, 415);
            this.lookFirma.Name = "lookFirma";
            this.lookFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookFirma.Properties.Appearance.Options.UseFont = true;
            this.lookFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFirma.Size = new System.Drawing.Size(158, 22);
            this.lookFirma.TabIndex = 50;
            // 
            // TxtBankaAdi
            // 
            this.TxtBankaAdi.Location = new System.Drawing.Point(191, 66);
            this.TxtBankaAdi.Name = "TxtBankaAdi";
            this.TxtBankaAdi.Size = new System.Drawing.Size(162, 21);
            this.TxtBankaAdi.TabIndex = 49;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(101, 66);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(77, 19);
            this.labelControl9.TabIndex = 48;
            this.labelControl9.Text = "Banka Adı:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(138, 344);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(43, 19);
            this.labelControl12.TabIndex = 47;
            this.labelControl12.Text = "Tarih:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(194, 344);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(162, 21);
            this.MskTarih.TabIndex = 46;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(138, 416);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 19);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Firma:";
            // 
            // TxtHesapTuru
            // 
            this.TxtHesapTuru.Location = new System.Drawing.Point(193, 379);
            this.TxtHesapTuru.Name = "TxtHesapTuru";
            this.TxtHesapTuru.Size = new System.Drawing.Size(162, 21);
            this.TxtHesapTuru.TabIndex = 43;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(132, 273);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 19);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Yetkili:";
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(190, 273);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(162, 21);
            this.TxtYetkili.TabIndex = 41;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(107, 236);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Hesap No:";
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.Location = new System.Drawing.Point(190, 236);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Size = new System.Drawing.Size(162, 21);
            this.TxtHesapNo.TabIndex = 39;
            // 
            // MskIBAN
            // 
            this.MskIBAN.Location = new System.Drawing.Point(191, 198);
            this.MskIBAN.Name = "MskIBAN";
            this.MskIBAN.Size = new System.Drawing.Size(162, 21);
            this.MskIBAN.TabIndex = 38;
            // 
            // CmbIlce
            // 
            this.CmbIlce.Location = new System.Drawing.Point(192, 127);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIlce.Size = new System.Drawing.Size(160, 20);
            this.CmbIlce.TabIndex = 37;
            // 
            // CmbIl
            // 
            this.CmbIl.Location = new System.Drawing.Point(190, 94);
            this.CmbIl.Name = "CmbIl";
            this.CmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIl.Size = new System.Drawing.Size(162, 20);
            this.CmbIl.TabIndex = 36;
            this.CmbIl.SelectedIndexChanged += new System.EventHandler(this.CmbIl_SelectedIndexChanged);
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(192, 309);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(162, 21);
            this.MskTelefon.TabIndex = 33;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(136, 196);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(43, 19);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "IBAN:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(96, 381);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(88, 19);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = "Hesap Türü:";
            // 
            // TxtSube
            // 
            this.TxtSube.Location = new System.Drawing.Point(190, 161);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Size = new System.Drawing.Size(162, 21);
            this.TxtSube.TabIndex = 29;
            // 
            // TxtAra
            // 
            this.TxtAra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.Location = new System.Drawing.Point(24, 465);
            this.TxtAra.Multiline = true;
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(160, 34);
            this.TxtAra.TabIndex = 28;
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnAra.Appearance.Options.UseFont = true;
            this.BtnAra.Appearance.Options.UseForeColor = true;
            this.BtnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.ImageOptions.Image")));
            this.BtnAra.Location = new System.Drawing.Point(190, 465);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(163, 34);
            this.BtnAra.TabIndex = 27;
            this.BtnAra.Text = "Ara";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.Appearance.Options.UseForeColor = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(193, 577);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(163, 37);
            this.BtnTemizle.TabIndex = 26;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Appearance.Options.UseForeColor = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(24, 577);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(163, 37);
            this.BtnSil.TabIndex = 24;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Appearance.Options.UseForeColor = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(193, 525);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(163, 37);
            this.BtnGuncelle.TabIndex = 23;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.Appearance.Options.UseForeColor = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(24, 525);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(163, 37);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(149, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "İlçe:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(161, 95);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 19);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "İl:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(138, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 19);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Şube:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(121, 309);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Telefon:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(190, 40);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(163, 20);
            this.TxtId.TabIndex = 2;
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 581);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBankalar";
            this.Text = "FrmBankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox MskIBAN;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIl;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox TxtSube;
        private System.Windows.Forms.TextBox TxtAra;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox TxtHesapTuru;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox TxtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox TxtHesapNo;
        private System.Windows.Forms.TextBox TxtBankaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookFirma;
    }
}