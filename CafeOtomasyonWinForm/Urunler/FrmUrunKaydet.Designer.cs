
namespace CafeOtomasyonWinForm.Urunler
{
    partial class FrmUrunKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunKaydet));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txturunkodu = new DevExpress.XtraEditors.TextEdit();
            this.txturunadi = new DevExpress.XtraEditors.TextEdit();
            this.calcbirimfiyat1 = new DevExpress.XtraEditors.CalcEdit();
            this.calcbirimfiyat2 = new DevExpress.XtraEditors.CalcEdit();
            this.calcbirimfiyat3 = new DevExpress.XtraEditors.CalcEdit();
            this.txtaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dttarih = new DevExpress.XtraEditors.DateEdit();
            this.pbresim = new DevExpress.XtraEditors.PictureEdit();
            this.lookupmenu = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txturunkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcbirimfiyat1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcbirimfiyat2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcbirimfiyat3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupmenu.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(637, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ÜRÜN KAYDET";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 368);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(637, 100);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İŞLMELER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(522, 39);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 45);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(12, 39);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(101, 46);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(36, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 27);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Menü:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(36, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 27);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ürün Kodu:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(36, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 27);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ürün Adı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(36, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 27);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Birim Fiyat 1:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(36, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 27);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Birim Fiyat 2:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(36, 199);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(94, 27);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Birim Fiyat 3:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(36, 229);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(94, 67);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Açıklama:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(36, 299);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(94, 27);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Tarih:";
            // 
            // txturunkodu
            // 
            this.txturunkodu.Location = new System.Drawing.Point(152, 81);
            this.txturunkodu.Name = "txturunkodu";
            this.txturunkodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunkodu.Properties.Appearance.Options.UseFont = true;
            this.txturunkodu.Size = new System.Drawing.Size(216, 22);
            this.txturunkodu.TabIndex = 13;
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(152, 111);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.Properties.Appearance.Options.UseFont = true;
            this.txturunadi.Size = new System.Drawing.Size(216, 22);
            this.txturunadi.TabIndex = 14;
            // 
            // calcbirimfiyat1
            // 
            this.calcbirimfiyat1.Location = new System.Drawing.Point(152, 141);
            this.calcbirimfiyat1.Name = "calcbirimfiyat1";
            this.calcbirimfiyat1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcbirimfiyat1.Properties.Appearance.Options.UseFont = true;
            this.calcbirimfiyat1.Properties.Appearance.Options.UseTextOptions = true;
            this.calcbirimfiyat1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcbirimfiyat1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcbirimfiyat1.Properties.DisplayFormat.FormatString = "C2";
            this.calcbirimfiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcbirimfiyat1.Properties.NullText = "0,00";
            this.calcbirimfiyat1.Size = new System.Drawing.Size(216, 22);
            this.calcbirimfiyat1.TabIndex = 15;
            // 
            // calcbirimfiyat2
            // 
            this.calcbirimfiyat2.Location = new System.Drawing.Point(152, 171);
            this.calcbirimfiyat2.Name = "calcbirimfiyat2";
            this.calcbirimfiyat2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcbirimfiyat2.Properties.Appearance.Options.UseFont = true;
            this.calcbirimfiyat2.Properties.Appearance.Options.UseTextOptions = true;
            this.calcbirimfiyat2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcbirimfiyat2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcbirimfiyat2.Properties.DisplayFormat.FormatString = "C2";
            this.calcbirimfiyat2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcbirimfiyat2.Properties.NullText = "0,00";
            this.calcbirimfiyat2.Size = new System.Drawing.Size(216, 22);
            this.calcbirimfiyat2.TabIndex = 16;
            // 
            // calcbirimfiyat3
            // 
            this.calcbirimfiyat3.Location = new System.Drawing.Point(152, 201);
            this.calcbirimfiyat3.Name = "calcbirimfiyat3";
            this.calcbirimfiyat3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcbirimfiyat3.Properties.Appearance.Options.UseFont = true;
            this.calcbirimfiyat3.Properties.Appearance.Options.UseTextOptions = true;
            this.calcbirimfiyat3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcbirimfiyat3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcbirimfiyat3.Properties.DisplayFormat.FormatString = "C2";
            this.calcbirimfiyat3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcbirimfiyat3.Properties.NullText = "0,00";
            this.calcbirimfiyat3.Size = new System.Drawing.Size(216, 22);
            this.calcbirimfiyat3.TabIndex = 17;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(152, 230);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaciklama.Properties.Appearance.Options.UseFont = true;
            this.txtaciklama.Size = new System.Drawing.Size(454, 66);
            this.txtaciklama.TabIndex = 18;
            // 
            // dttarih
            // 
            this.dttarih.EditValue = null;
            this.dttarih.Location = new System.Drawing.Point(152, 301);
            this.dttarih.Name = "dttarih";
            this.dttarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dttarih.Properties.Appearance.Options.UseFont = true;
            this.dttarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dttarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dttarih.Size = new System.Drawing.Size(216, 22);
            this.dttarih.TabIndex = 19;
            // 
            // pbresim
            // 
            this.pbresim.Location = new System.Drawing.Point(385, 51);
            this.pbresim.Name = "pbresim";
            this.pbresim.Properties.NullText = "Resim Seçilmedi";
            this.pbresim.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbresim.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pbresim.Size = new System.Drawing.Size(221, 172);
            this.pbresim.TabIndex = 20;
            // 
            // lookupmenu
            // 
            this.lookupmenu.Location = new System.Drawing.Point(152, 51);
            this.lookupmenu.Name = "lookupmenu";
            this.lookupmenu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookupmenu.Properties.Appearance.Options.UseFont = true;
            this.lookupmenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupmenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuAdi", "Menü")});
            this.lookupmenu.Properties.DisplayMember = "MenuAdi";
            this.lookupmenu.Properties.NullText = "Menü Seçiniz";
            this.lookupmenu.Properties.NullValuePrompt = "Menü Seçiniz";
            this.lookupmenu.Properties.ValueMember = "ID";
            this.lookupmenu.Size = new System.Drawing.Size(216, 22);
            this.lookupmenu.TabIndex = 21;
            // 
            // FrmUrunKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 468);
            this.Controls.Add(this.lookupmenu);
            this.Controls.Add(this.pbresim);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.calcbirimfiyat3);
            this.Controls.Add(this.calcbirimfiyat2);
            this.Controls.Add(this.calcbirimfiyat1);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.txturunkodu);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrunKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kaydet";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txturunkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcbirimfiyat1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcbirimfiyat2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcbirimfiyat3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupmenu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txturunkodu;
        private DevExpress.XtraEditors.TextEdit txturunadi;
        private DevExpress.XtraEditors.CalcEdit calcbirimfiyat1;
        private DevExpress.XtraEditors.CalcEdit calcbirimfiyat2;
        private DevExpress.XtraEditors.CalcEdit calcbirimfiyat3;
        private DevExpress.XtraEditors.MemoEdit txtaciklama;
        private DevExpress.XtraEditors.DateEdit dttarih;
        private DevExpress.XtraEditors.PictureEdit pbresim;
        private DevExpress.XtraEditors.LookUpEdit lookupmenu;
    }
}