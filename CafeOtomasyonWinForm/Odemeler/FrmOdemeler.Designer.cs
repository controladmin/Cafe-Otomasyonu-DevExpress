
namespace CafeOtomasyonWinForm.Odemeler
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.lblbaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnonay = new DevExpress.XtraEditors.SimpleButton();
            this.calodenecektutar = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateedittarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calodenecektutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties)).BeginInit();
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
            this.lblbaslik.Size = new System.Drawing.Size(416, 27);
            this.lblbaslik.TabIndex = 10;
            this.lblbaslik.Text = "ÖDEMELER";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnonay);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 233);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(416, 100);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "İŞLMELER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(301, 39);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 45);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnonay
            // 
            this.btnonay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnonay.ImageOptions.Image")));
            this.btnonay.Location = new System.Drawing.Point(12, 39);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(101, 46);
            this.btnonay.TabIndex = 0;
            this.btnonay.Text = "ONAY";
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // calodenecektutar
            // 
            this.calodenecektutar.Location = new System.Drawing.Point(121, 54);
            this.calodenecektutar.Name = "calodenecektutar";
            this.calodenecektutar.Properties.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.calodenecektutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calodenecektutar.Properties.Appearance.Options.UseBackColor = true;
            this.calodenecektutar.Properties.Appearance.Options.UseFont = true;
            this.calodenecektutar.Properties.Appearance.Options.UseTextOptions = true;
            this.calodenecektutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calodenecektutar.Properties.BeepOnError = false;
            this.calodenecektutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calodenecektutar.Properties.MaskSettings.Set("mask", "c");
            this.calodenecektutar.Properties.NullText = "0,00";
            this.calodenecektutar.Properties.NullValuePrompt = "0,00";
            this.calodenecektutar.Properties.UseMaskAsDisplayFormat = true;
            this.calodenecektutar.Size = new System.Drawing.Size(260, 22);
            this.calodenecektutar.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(7, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Ödenecek Tutar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl10.Location = new System.Drawing.Point(7, 119);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 37);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Açıklama:";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(121, 86);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(287, 102);
            this.txtaciklama.TabIndex = 15;
            // 
            // dateedittarih
            // 
            this.dateedittarih.EditValue = null;
            this.dateedittarih.Location = new System.Drawing.Point(121, 198);
            this.dateedittarih.Name = "dateedittarih";
            this.dateedittarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateedittarih.Properties.Appearance.Options.UseFont = true;
            this.dateedittarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedittarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedittarih.Size = new System.Drawing.Size(287, 22);
            this.dateedittarih.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl9.Location = new System.Drawing.Point(7, 198);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 23);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Tarih:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(387, 54);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(21, 23);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 333);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dateedittarih);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.calodenecektutar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblbaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDEMELER";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calodenecektutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblbaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnonay;
        private DevExpress.XtraEditors.CalcEdit calodenecektutar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit txtaciklama;
        private DevExpress.XtraEditors.DateEdit dateedittarih;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}