namespace Ticari_Otomasyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmbAy = new DevExpress.XtraEditors.GroupControl();
            this.TxtMaaslar = new System.Windows.Forms.TextBox();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.MskYıl = new System.Windows.Forms.MaskedTextBox();
            this.TxtEkstra = new System.Windows.Forms.TextBox();
            this.CmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDogalgaz = new System.Windows.Forms.TextBox();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RichNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy)).BeginInit();
            this.CmbAy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 878);
            this.gridControl1.TabIndex = 3;
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
            // CmbAy
            // 
            this.CmbAy.Controls.Add(this.TxtMaaslar);
            this.CmbAy.Controls.Add(this.TxtInternet);
            this.CmbAy.Controls.Add(this.TxtSu);
            this.CmbAy.Controls.Add(this.TxtElektrik);
            this.CmbAy.Controls.Add(this.MskYıl);
            this.CmbAy.Controls.Add(this.TxtEkstra);
            this.CmbAy.Controls.Add(this.CmbIl);
            this.CmbAy.Controls.Add(this.labelControl11);
            this.CmbAy.Controls.Add(this.labelControl10);
            this.CmbAy.Controls.Add(this.TxtDogalgaz);
            this.CmbAy.Controls.Add(this.BtnTemizle);
            this.CmbAy.Controls.Add(this.BtnSil);
            this.CmbAy.Controls.Add(this.BtnGuncelle);
            this.CmbAy.Controls.Add(this.BtnKaydet);
            this.CmbAy.Controls.Add(this.RichNotlar);
            this.CmbAy.Controls.Add(this.labelControl9);
            this.CmbAy.Controls.Add(this.labelControl5);
            this.CmbAy.Controls.Add(this.labelControl6);
            this.CmbAy.Controls.Add(this.labelControl7);
            this.CmbAy.Controls.Add(this.labelControl3);
            this.CmbAy.Controls.Add(this.labelControl4);
            this.CmbAy.Controls.Add(this.labelControl2);
            this.CmbAy.Controls.Add(this.labelControl1);
            this.CmbAy.Controls.Add(this.TxtID);
            this.CmbAy.Location = new System.Drawing.Point(986, 2);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Size = new System.Drawing.Size(393, 878);
            this.CmbAy.TabIndex = 4;
            // 
            // TxtMaaslar
            // 
            this.TxtMaaslar.Location = new System.Drawing.Point(192, 289);
            this.TxtMaaslar.Name = "TxtMaaslar";
            this.TxtMaaslar.Size = new System.Drawing.Size(160, 21);
            this.TxtMaaslar.TabIndex = 43;
            // 
            // TxtInternet
            // 
            this.TxtInternet.Location = new System.Drawing.Point(192, 252);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(160, 21);
            this.TxtInternet.TabIndex = 42;
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(194, 173);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(160, 21);
            this.TxtSu.TabIndex = 41;
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(193, 135);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(160, 21);
            this.TxtElektrik.TabIndex = 40;
            // 
            // MskYıl
            // 
            this.MskYıl.Location = new System.Drawing.Point(193, 103);
            this.MskYıl.Mask = "0000";
            this.MskYıl.Name = "MskYıl";
            this.MskYıl.Size = new System.Drawing.Size(162, 21);
            this.MskYıl.TabIndex = 39;
            this.MskYıl.ValidatingType = typeof(int);
            // 
            // TxtEkstra
            // 
            this.TxtEkstra.Location = new System.Drawing.Point(196, 329);
            this.TxtEkstra.Name = "TxtEkstra";
            this.TxtEkstra.Size = new System.Drawing.Size(160, 21);
            this.TxtEkstra.TabIndex = 38;
            // 
            // CmbIl
            // 
            this.CmbIl.Location = new System.Drawing.Point(193, 72);
            this.CmbIl.Name = "CmbIl";
            this.CmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIl.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart ",
            "Nisan ",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.CmbIl.Size = new System.Drawing.Size(162, 20);
            this.CmbIl.TabIndex = 36;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(126, 252);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(62, 19);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "İnternet:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(139, 376);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 19);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = "Notlar:";
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Location = new System.Drawing.Point(194, 211);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Size = new System.Drawing.Size(160, 21);
            this.TxtDogalgaz.TabIndex = 29;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.Appearance.Options.UseForeColor = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(195, 560);
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
            this.BtnSil.Location = new System.Drawing.Point(26, 560);
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
            this.BtnGuncelle.Location = new System.Drawing.Point(195, 508);
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
            this.BtnKaydet.Location = new System.Drawing.Point(26, 508);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(163, 37);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RichNotlar
            // 
            this.RichNotlar.Location = new System.Drawing.Point(197, 376);
            this.RichNotlar.Name = "RichNotlar";
            this.RichNotlar.Size = new System.Drawing.Size(158, 96);
            this.RichNotlar.TabIndex = 21;
            this.RichNotlar.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(164, 173);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 19);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Su:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(140, 330);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Ekstra:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(130, 291);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 19);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Maaşlar:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(118, 213);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(71, 19);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Doğalgaz:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(131, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Elektrik:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(162, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Yıl:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(161, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ay:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(165, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(192, 40);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(163, 20);
            this.TxtID.TabIndex = 2;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 583);
            this.Controls.Add(this.CmbAy);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy)).EndInit();
            this.CmbAy.ResumeLayout(false);
            this.CmbAy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl CmbAy;
        private System.Windows.Forms.TextBox TxtMaaslar;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.MaskedTextBox MskYıl;
        private System.Windows.Forms.TextBox TxtEkstra;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIl;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox TxtDogalgaz;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RichNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtID;
    }
}