
namespace CafeOtomasyonWinForm.Kullanicilar
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnsifremiunuttum = new DevExpress.XtraEditors.SimpleButton();
            this.btngirisyap = new DevExpress.XtraEditors.SimpleButton();
            this.lblkaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chbenihatirla = new DevExpress.XtraEditors.CheckEdit();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.txtkullaniciadi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbenihatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(522, 27);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "KULLANICI GİRİŞİ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnsifremiunuttum);
            this.groupControl1.Controls.Add(this.btngirisyap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(180, 168);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(342, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İŞLEMLER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(227, 39);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 45);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnsifremiunuttum
            // 
            this.btnsifremiunuttum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsifremiunuttum.ImageOptions.Image")));
            this.btnsifremiunuttum.Location = new System.Drawing.Point(119, 38);
            this.btnsifremiunuttum.Name = "btnsifremiunuttum";
            this.btnsifremiunuttum.Size = new System.Drawing.Size(101, 46);
            this.btnsifremiunuttum.TabIndex = 0;
            this.btnsifremiunuttum.Text = "ŞİFREMİ\r\nUNUTTUM";
            this.btnsifremiunuttum.Click += new System.EventHandler(this.btnsifremiunuttum_Click);
            // 
            // btngirisyap
            // 
            this.btngirisyap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngirisyap.ImageOptions.Image")));
            this.btngirisyap.Location = new System.Drawing.Point(12, 39);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(101, 46);
            this.btngirisyap.TabIndex = 0;
            this.btngirisyap.Text = "GİRİŞ\r\nYAP";
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // lblkaydol
            // 
            this.lblkaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkaydol.Appearance.Options.UseFont = true;
            this.lblkaydol.Appearance.Options.UseTextOptions = true;
            this.lblkaydol.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblkaydol.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblkaydol.Location = new System.Drawing.Point(425, 132);
            this.lblkaydol.Name = "lblkaydol";
            this.lblkaydol.Size = new System.Drawing.Size(82, 21);
            this.lblkaydol.TabIndex = 8;
            this.lblkaydol.Text = "KAYDOL";
            this.lblkaydol.Click += new System.EventHandler(this.lblkaydol_Click);
            // 
            // chbenihatirla
            // 
            this.chbenihatirla.Location = new System.Drawing.Point(192, 133);
            this.chbenihatirla.Name = "chbenihatirla";
            this.chbenihatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbenihatirla.Properties.Appearance.Options.UseFont = true;
            this.chbenihatirla.Properties.Caption = "BENİ HATIRLA";
            this.chbenihatirla.Size = new System.Drawing.Size(110, 20);
            this.chbenihatirla.TabIndex = 9;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(192, 88);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Properties.Appearance.Options.UseFont = true;
            this.txtsifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtsifre.Properties.ContextImageOptions.Image")));
            this.txtsifre.Properties.NullText = "Şifrenizi Giriniz";
            this.txtsifre.Properties.NullValuePrompt = "Şifrenizi Giriniz";
            this.txtsifre.Properties.UseSystemPasswordChar = true;
            this.txtsifre.Size = new System.Drawing.Size(315, 22);
            this.txtsifre.TabIndex = 7;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(192, 50);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Properties.Appearance.Options.UseFont = true;
            this.txtkullaniciadi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtkullaniciadi.Properties.ContextImageOptions.Image")));
            this.txtkullaniciadi.Properties.NullText = "Kullanıcı Adınızı Giriniz";
            this.txtkullaniciadi.Properties.NullValuePrompt = "Kullanıcı Adınızı Giriniz";
            this.txtkullaniciadi.Size = new System.Drawing.Size(315, 22);
            this.txtkullaniciadi.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 27);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(180, 241);
            this.pictureEdit1.TabIndex = 5;
            // 
            // FrmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 268);
            this.Controls.Add(this.chbenihatirla);
            this.Controls.Add(this.lblkaydol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI GİRİŞİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKullaniciGirisi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbenihatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btngirisyap;
        private DevExpress.XtraEditors.SimpleButton btnsifremiunuttum;
        private DevExpress.XtraEditors.TextEdit txtkullaniciadi;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblkaydol;
        private DevExpress.XtraEditors.CheckEdit chbenihatirla;
    }
}