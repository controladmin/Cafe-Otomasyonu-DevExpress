
namespace CafeOtomasyonWinForm.Kullanicilar
{
    partial class FrmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanicilar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btndurumdegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenikullanici = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktifmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1164, 33);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "KULLANICI LİSTESİ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btndurumdegistir);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnyenile);
            this.groupControl1.Controls.Add(this.btnduzenle);
            this.groupControl1.Controls.Add(this.btnyenikullanici);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 453);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1164, 123);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İŞLMELER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(1030, 48);
            this.btnkapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(117, 55);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            // 
            // btndurumdegistir
            // 
            this.btndurumdegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndurumdegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndurumdegistir.ImageOptions.Image")));
            this.btndurumdegistir.Location = new System.Drawing.Point(769, 47);
            this.btndurumdegistir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndurumdegistir.Name = "btndurumdegistir";
            this.btndurumdegistir.Size = new System.Drawing.Size(127, 57);
            this.btndurumdegistir.TabIndex = 0;
            this.btndurumdegistir.Text = "DURUMU\r\nDEĞİŞTİR";
            this.btndurumdegistir.Click += new System.EventHandler(this.btndurumdegistir_Click);
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(904, 48);
            this.btnsil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(118, 57);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "SİL";
            // 
            // btnyenile
            // 
            this.btnyenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.Image")));
            this.btnyenile.Location = new System.Drawing.Point(264, 47);
            this.btnyenile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(118, 57);
            this.btnyenile.TabIndex = 0;
            this.btnyenile.Text = "YENİLE";
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnduzenle.ImageOptions.Image")));
            this.btnduzenle.Location = new System.Drawing.Point(139, 47);
            this.btnduzenle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(118, 57);
            this.btnduzenle.TabIndex = 0;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnyenikullanici
            // 
            this.btnyenikullanici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenikullanici.ImageOptions.Image")));
            this.btnyenikullanici.Location = new System.Drawing.Point(14, 48);
            this.btnyenikullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnyenikullanici.Name = "btnyenikullanici";
            this.btnyenikullanici.Size = new System.Drawing.Size(118, 57);
            this.btnyenikullanici.TabIndex = 0;
            this.btnyenikullanici.Text = "YENİ\r\nKULLANICI";
            this.btnyenikullanici.Click += new System.EventHandler(this.btnyenikullanici_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1164, 420);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAdSoyad,
            this.colTelefon,
            this.colEmail,
            this.colAdres,
            this.colGorevi,
            this.colKullaniciAdi,
            this.colKayitTarihi,
            this.colAktifmi,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.Caption = "AD SOYAD";
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 2;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "TELEFON";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "EMAİL";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "ADRES";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 5;
            // 
            // colGorevi
            // 
            this.colGorevi.Caption = "GÖREVİ";
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 6;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "KULLANICI ADI";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 7;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "KAYIT TARİHİ";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 8;
            // 
            // colAktifmi
            // 
            this.colAktifmi.Caption = "AKTİF Mİ";
            this.colAktifmi.FieldName = "Aktifmi";
            this.colAktifmi.Name = "colAktifmi";
            this.colAktifmi.Visible = true;
            this.colAktifmi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "AÇIKLAMA";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            // 
            // FrmKullanicilar
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 576);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI LİSTESİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btndurumdegistir;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnyenikullanici;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAktifmi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}