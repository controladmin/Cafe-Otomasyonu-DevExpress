
namespace CafeOtomasyonWinForm.Urunler
{
    partial class FrmUrunler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenikayit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnmasaharaketleri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
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
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ÜRÜNLER";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnmasaharaketleri);
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnyenile);
            this.groupControl1.Controls.Add(this.btnduzenle);
            this.groupControl1.Controls.Add(this.btnyenikayit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 368);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 100);
            this.groupControl1.TabIndex = 2;
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
            this.btnyenikayit.Text = "YENİ ÜRÜN";
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.urunBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(998, 341);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(CafeOtomasyonuEntities.Models.Urun);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMenuID,
            this.colUrunKodu,
            this.colUrunAdi,
            this.colBirimFiyat1,
            this.colBirimFiyat2,
            this.colBirimFiyat3,
            this.colAciklama,
            this.colTarih,
            this.colResim,
            this.colMenu,
            this.colMenuAdi});
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
            // colMenuID
            // 
            this.colMenuID.Caption = "Menu ID";
            this.colMenuID.FieldName = "MenuID";
            this.colMenuID.Name = "colMenuID";
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 2;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 3;
            // 
            // colBirimFiyat1
            // 
            this.colBirimFiyat1.Caption = "Birim Fiyatı 1";
            this.colBirimFiyat1.FieldName = "BirimFiyat1";
            this.colBirimFiyat1.Name = "colBirimFiyat1";
            this.colBirimFiyat1.Visible = true;
            this.colBirimFiyat1.VisibleIndex = 4;
            // 
            // colBirimFiyat2
            // 
            this.colBirimFiyat2.Caption = "Birim Fiyatı 2";
            this.colBirimFiyat2.FieldName = "BirimFiyat2";
            this.colBirimFiyat2.Name = "colBirimFiyat2";
            this.colBirimFiyat2.Visible = true;
            this.colBirimFiyat2.VisibleIndex = 5;
            // 
            // colBirimFiyat3
            // 
            this.colBirimFiyat3.Caption = "Birim Fiyatı 3";
            this.colBirimFiyat3.FieldName = "BirimFiyat3";
            this.colBirimFiyat3.Name = "colBirimFiyat3";
            this.colBirimFiyat3.Visible = true;
            this.colBirimFiyat3.VisibleIndex = 6;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            // 
            // colResim
            // 
            this.colResim.Caption = "Resim";
            this.colResim.FieldName = "Resim";
            this.colResim.Name = "colResim";
            this.colResim.Visible = true;
            this.colResim.VisibleIndex = 9;
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menü";
            this.colMenuAdi.FieldName = "Menu";
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 1;
            // 
            // btnmasaharaketleri
            // 
            this.btnmasaharaketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnmasaharaketleri.ImageOptions.Image")));
            this.btnmasaharaketleri.Location = new System.Drawing.Point(333, 39);
            this.btnmasaharaketleri.Name = "btnmasaharaketleri";
            this.btnmasaharaketleri.Size = new System.Drawing.Size(126, 46);
            this.btnmasaharaketleri.TabIndex = 1;
            this.btnmasaharaketleri.Text = "MASA\r\nHAREKETLERİ";
            this.btnmasaharaketleri.Click += new System.EventHandler(this.btnmasaharaketleri_Click);
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 468);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnyenikayit;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuID;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat3;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
        private DevExpress.XtraEditors.SimpleButton btnmasaharaketleri;
    }
}