
namespace CafeOtomasyonWinForm.Odemeler
{
    partial class FrmOdemeHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeHareketleri));
            this.lblbaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.lblbaslik.TabIndex = 11;
            this.lblbaslik.Text = "ÖDEME HAREKETLERİ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnyenile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 568);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 100);
            this.groupControl1.TabIndex = 12;
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
            // btnyenile
            // 
            this.btnyenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.Image")));
            this.btnyenile.Location = new System.Drawing.Point(12, 38);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(120, 46);
            this.btnyenile.TabIndex = 0;
            this.btnyenile.Text = "YENİLE\r\nLİSTELE";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(998, 541);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSatisKodu,
            this.colOdemeTuru,
            this.colOdenen,
            this.colAciklama,
            this.colTarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.Caption = "SATIŞ KODU";
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SatisKodu", "Kayit:{0}")});
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "ÖDEME TÜRÜ";
            this.colOdemeTuru.FieldName = "OdemeTuru";
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 2;
            // 
            // colOdenen
            // 
            this.colOdenen.Caption = "ÖDENEN";
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odenen", "Ödenen:{0:C2}")});
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 3;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "AÇIKLAMA";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "TARİH";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            // 
            // FrmOdemeHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblbaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDEME HAREKETLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblbaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
    }
}