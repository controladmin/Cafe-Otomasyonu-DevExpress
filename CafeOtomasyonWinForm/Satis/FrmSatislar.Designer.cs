
namespace CafeOtomasyonWinForm.Satis
{
    partial class FrmSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatislar));
            this.lblbaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnodemehareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnsiparisdetayi = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteriadsoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaketmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnexport = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnexcellexport = new DevExpress.XtraBars.BarButtonItem();
            this.btnwordexport = new DevExpress.XtraBars.BarButtonItem();
            this.btnpdfexport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbaslik
            // 
            this.lblbaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.Appearance.Options.UseFont = true;
            this.lblbaslik.Appearance.Options.UseTextOptions = true;
            this.lblbaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblbaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblbaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblbaslik.Location = new System.Drawing.Point(0, 0);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(998, 27);
            this.lblbaslik.TabIndex = 10;
            this.lblbaslik.Text = "SATIŞLAR";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnexport);
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnodemehareketleri);
            this.groupControl1.Controls.Add(this.btnyenile);
            this.groupControl1.Controls.Add(this.btnsiparisdetayi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 568);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 100);
            this.groupControl1.TabIndex = 11;
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
            // btnodemehareketleri
            // 
            this.btnodemehareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnodemehareketleri.ImageOptions.Image")));
            this.btnodemehareketleri.Location = new System.Drawing.Point(140, 39);
            this.btnodemehareketleri.Name = "btnodemehareketleri";
            this.btnodemehareketleri.Size = new System.Drawing.Size(120, 46);
            this.btnodemehareketleri.TabIndex = 0;
            this.btnodemehareketleri.Text = "ÖDEME\r\nHAREKETLERİ";
            this.btnodemehareketleri.Click += new System.EventHandler(this.btnodemehareketleri_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.Image")));
            this.btnyenile.Location = new System.Drawing.Point(268, 39);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(120, 46);
            this.btnyenile.TabIndex = 0;
            this.btnyenile.Text = "YENİLE\r\nLİSTELE";
            // 
            // btnsiparisdetayi
            // 
            this.btnsiparisdetayi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsiparisdetayi.ImageOptions.Image")));
            this.btnsiparisdetayi.Location = new System.Drawing.Point(12, 39);
            this.btnsiparisdetayi.Name = "btnsiparisdetayi";
            this.btnsiparisdetayi.Size = new System.Drawing.Size(120, 46);
            this.btnsiparisdetayi.TabIndex = 0;
            this.btnsiparisdetayi.Text = "SİPARİŞ\r\nDETAYLARI";
            this.btnsiparisdetayi.Click += new System.EventHandler(this.btnsiparisdetayi_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(998, 541);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSatisKodu,
            this.colmusteriadsoyad,
            this.colMusteriID,
            this.colTutar,
            this.colIndirimTutari,
            this.colOdenen,
            this.colKalan,
            this.colAciklama,
            this.colSonIslemTarihi,
            this.colPaketmi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.Caption = "SATIŞ KODU";
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.OptionsColumn.AllowEdit = false;
            this.colSatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SatisKodu", "Kayit:{0}")});
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 2;
            // 
            // colmusteriadsoyad
            // 
            this.colmusteriadsoyad.Caption = "MÜŞTERİ AD SOYAD";
            this.colmusteriadsoyad.FieldName = "Musteriler.AdSoyad";
            this.colmusteriadsoyad.Name = "colmusteriadsoyad";
            this.colmusteriadsoyad.OptionsColumn.AllowEdit = false;
            this.colmusteriadsoyad.Visible = true;
            this.colmusteriadsoyad.VisibleIndex = 1;
            // 
            // colMusteriID
            // 
            this.colMusteriID.FieldName = "MusteriID";
            this.colMusteriID.Name = "colMusteriID";
            this.colMusteriID.OptionsColumn.AllowEdit = false;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "TUTAR";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "Tutar:{0:C2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "İNDİRİM TUTARI";
            this.colIndirimTutari.DisplayFormat.FormatString = "C2";
            this.colIndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IndirimTutari", "İndirim Tutarı:{0:C2}")});
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 4;
            // 
            // colOdenen
            // 
            this.colOdenen.Caption = "ÖDENEN";
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.OptionsColumn.AllowEdit = false;
            this.colOdenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odenen", "Ödenen:{0:C2}")});
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 5;
            // 
            // colKalan
            // 
            this.colKalan.Caption = "KALAN";
            this.colKalan.DisplayFormat.FormatString = "C2";
            this.colKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.OptionsColumn.AllowEdit = false;
            this.colKalan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kalan", "Kalan:{0:C2}")});
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 6;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "AÇIKLAMA";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.Caption = "SON İŞLEM TARİHİ";
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.VisibleIndex = 8;
            // 
            // colPaketmi
            // 
            this.colPaketmi.Caption = "Paket Mi";
            this.colPaketmi.FieldName = "Paketmi";
            this.colPaketmi.Name = "colPaketmi";
            this.colPaketmi.OptionsColumn.AllowEdit = false;
            this.colPaketmi.Visible = true;
            this.colPaketmi.VisibleIndex = 9;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.DropDownControl = this.popupMenu1;
            this.btnexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.ImageOptions.Image")));
            this.btnexport.Location = new System.Drawing.Point(728, 39);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(149, 45);
            this.btnexport.TabIndex = 1;
            this.btnexport.Text = "EXPORT";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexcellexport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnwordexport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnpdfexport)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnexcellexport,
            this.btnwordexport,
            this.btnpdfexport});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(998, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 668);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(998, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 668);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(998, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 668);
            // 
            // btnexcellexport
            // 
            this.btnexcellexport.Caption = "Excell(*xlsx)";
            this.btnexcellexport.Id = 0;
            this.btnexcellexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexcellexport.ImageOptions.Image")));
            this.btnexcellexport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnexcellexport.ImageOptions.LargeImage")));
            this.btnexcellexport.Name = "btnexcellexport";
            this.btnexcellexport.Tag = "Excell(*xlsx)|*.xlsx";
            this.btnexcellexport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnwordexport
            // 
            this.btnwordexport.Caption = "Word(*doc)";
            this.btnwordexport.Id = 1;
            this.btnwordexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnwordexport.ImageOptions.Image")));
            this.btnwordexport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnwordexport.ImageOptions.LargeImage")));
            this.btnwordexport.Name = "btnwordexport";
            this.btnwordexport.Tag = "Word(*doc)|*.doc";
            this.btnwordexport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnpdfexport
            // 
            this.btnpdfexport.Caption = "Pdf(*pdf)";
            this.btnpdfexport.Id = 2;
            this.btnpdfexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpdfexport.ImageOptions.Image")));
            this.btnpdfexport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnpdfexport.ImageOptions.LargeImage")));
            this.btnpdfexport.Name = "btnpdfexport";
            this.btnpdfexport.Tag = "Pdf(*pdf)|*.pdf";
            this.btnpdfexport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // FrmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞLAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblbaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnodemehareketleri;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraEditors.SimpleButton btnsiparisdetayi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriID;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colKalan;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteriadsoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketmi;
        private DevExpress.XtraEditors.DropDownButton btnexport;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnexcellexport;
        private DevExpress.XtraBars.BarButtonItem btnwordexport;
        private DevExpress.XtraBars.BarButtonItem btnpdfexport;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}