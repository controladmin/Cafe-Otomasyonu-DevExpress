
namespace CafeOtomasyonWinForm.Masalar
{
    partial class FrmMasalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasalar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btndurumdegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnrezervedegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenikayit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReservemi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklemeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnmasaharaketleri = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(998, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "MASALAR";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btndurumdegistir);
            this.groupControl1.Controls.Add(this.btnrezervedegistir);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnmasaharaketleri);
            this.groupControl1.Controls.Add(this.btnyenile);
            this.groupControl1.Controls.Add(this.btnduzenle);
            this.groupControl1.Controls.Add(this.btnyenikayit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 368);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 100);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İŞLMELER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(883, 39);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 45);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btndurumdegistir
            // 
            this.btndurumdegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndurumdegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndurumdegistir.ImageOptions.Image")));
            this.btndurumdegistir.Location = new System.Drawing.Point(553, 38);
            this.btndurumdegistir.Name = "btndurumdegistir";
            this.btndurumdegistir.Size = new System.Drawing.Size(109, 46);
            this.btndurumdegistir.TabIndex = 0;
            this.btndurumdegistir.Text = "DURUMU\r\nDEĞİŞTİR";
            this.btndurumdegistir.Click += new System.EventHandler(this.btndurumdegistir_Click);
            // 
            // btnrezervedegistir
            // 
            this.btnrezervedegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrezervedegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrezervedegistir.ImageOptions.Image")));
            this.btnrezervedegistir.Location = new System.Drawing.Point(668, 38);
            this.btnrezervedegistir.Name = "btnrezervedegistir";
            this.btnrezervedegistir.Size = new System.Drawing.Size(101, 46);
            this.btnrezervedegistir.TabIndex = 0;
            this.btnrezervedegistir.Text = "REZERVE\r\nDEĞİŞTİR";
            this.btnrezervedegistir.Click += new System.EventHandler(this.btnrezervedegistir_Click);
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(775, 39);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(101, 46);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.Image")));
            this.btnyenile.Location = new System.Drawing.Point(226, 38);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(101, 46);
            this.btnyenile.TabIndex = 0;
            this.btnyenile.Text = "YENİLE";
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnduzenle.ImageOptions.Image")));
            this.btnduzenle.Location = new System.Drawing.Point(119, 38);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(101, 46);
            this.btnduzenle.TabIndex = 0;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenikayit.ImageOptions.Image")));
            this.btnyenikayit.Location = new System.Drawing.Point(12, 39);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(101, 46);
            this.btnyenikayit.TabIndex = 0;
            this.btnyenikayit.Text = "YENİ MASA";
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(998, 341);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMasaAdi,
            this.colAciklama,
            this.colDurum,
            this.colReservemi,
            this.colEklemeTarihi,
            this.colSonIslemTarihi,
            this.colIslem,
            this.colKullaniciID,
            this.colMasaHareketleri});
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
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "MASA";
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 2;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "AÇIKLAMA";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            // 
            // colDurum
            // 
            this.colDurum.Caption = "DURUM";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 4;
            // 
            // colReservemi
            // 
            this.colReservemi.Caption = "RESERVE";
            this.colReservemi.FieldName = "Reservemi";
            this.colReservemi.Name = "colReservemi";
            this.colReservemi.Visible = true;
            this.colReservemi.VisibleIndex = 5;
            // 
            // colEklemeTarihi
            // 
            this.colEklemeTarihi.Caption = "EKLEME TARİHİ";
            this.colEklemeTarihi.FieldName = "EklemeTarihi";
            this.colEklemeTarihi.Name = "colEklemeTarihi";
            this.colEklemeTarihi.Visible = true;
            this.colEklemeTarihi.VisibleIndex = 6;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.Caption = "SON İŞLEM TARİHİ";
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.VisibleIndex = 7;
            // 
            // colIslem
            // 
            this.colIslem.Caption = "İŞLEM";
            this.colIslem.FieldName = "Islem";
            this.colIslem.Name = "colIslem";
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 8;
            // 
            // colKullaniciID
            // 
            this.colKullaniciID.Caption = "KULLANICI";
            this.colKullaniciID.FieldName = "Kullanici";
            this.colKullaniciID.Name = "colKullaniciID";
            this.colKullaniciID.Visible = true;
            this.colKullaniciID.VisibleIndex = 1;
            // 
            // colMasaHareketleri
            // 
            this.colMasaHareketleri.FieldName = "MasaHareketleri";
            this.colMasaHareketleri.Name = "colMasaHareketleri";
            // 
            // btnmasaharaketleri
            // 
            this.btnmasaharaketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnmasaharaketleri.Location = new System.Drawing.Point(333, 38);
            this.btnmasaharaketleri.Name = "btnmasaharaketleri";
            this.btnmasaharaketleri.Size = new System.Drawing.Size(126, 46);
            this.btnmasaharaketleri.TabIndex = 0;
            this.btnmasaharaketleri.Text = "MASA\r\nHAREKETLERİ";
            this.btnmasaharaketleri.Click += new System.EventHandler(this.btnmasaharaketleri_Click);
            // 
            // FrmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 468);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMasalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASALAR";
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
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnyenikayit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colReservemi;
        private DevExpress.XtraGrid.Columns.GridColumn colEklemeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaHareketleri;
        private DevExpress.XtraEditors.SimpleButton btndurumdegistir;
        private DevExpress.XtraEditors.SimpleButton btnrezervedegistir;
        private DevExpress.XtraEditors.SimpleButton btnmasaharaketleri;
    }
}