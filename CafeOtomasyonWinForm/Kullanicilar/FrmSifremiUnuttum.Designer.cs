
namespace CafeOtomasyonWinForm.Kullanicilar
{
    partial class FrmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttum));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtparola = new DevExpress.XtraEditors.TextEdit();
            this.txtcevap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoru = new DevExpress.XtraEditors.TextEdit();
            this.txtkullaniciadiveyaemail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtparolatekrar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtparola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadiveyaemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtparolatekrar.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(405, 27);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "PAROLAMI UNUTTUM";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 201);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(405, 100);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "İŞLMELER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(290, 39);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 45);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
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
            // txtparola
            // 
            this.txtparola.Location = new System.Drawing.Point(179, 134);
            this.txtparola.Name = "txtparola";
            this.txtparola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparola.Properties.Appearance.Options.UseFont = true;
            this.txtparola.Properties.NullText = "Yeni Parola";
            this.txtparola.Properties.NullValuePrompt = "Yeni Parola";
            this.txtparola.Properties.UseSystemPasswordChar = true;
            this.txtparola.Size = new System.Drawing.Size(216, 22);
            this.txtparola.TabIndex = 20;
            // 
            // txtcevap
            // 
            this.txtcevap.Location = new System.Drawing.Point(179, 106);
            this.txtcevap.Name = "txtcevap";
            this.txtcevap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcevap.Properties.Appearance.Options.UseFont = true;
            this.txtcevap.Properties.NullText = "Cevabınızı Giriniz";
            this.txtcevap.Properties.NullValuePrompt = "Cevabınızı Giriniz";
            this.txtcevap.Size = new System.Drawing.Size(216, 22);
            this.txtcevap.TabIndex = 21;
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
            this.labelControl7.Location = new System.Drawing.Point(10, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(159, 27);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Yeni Parola:";
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
            this.labelControl6.Location = new System.Drawing.Point(10, 104);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(159, 27);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Cevap:";
            // 
            // txtsoru
            // 
            this.txtsoru.Location = new System.Drawing.Point(179, 77);
            this.txtsoru.Name = "txtsoru";
            this.txtsoru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoru.Properties.Appearance.Options.UseFont = true;
            this.txtsoru.Properties.NullText = "Sorunuzu Giriniz";
            this.txtsoru.Properties.NullValuePrompt = "Sorunuzu Giriniz";
            this.txtsoru.Size = new System.Drawing.Size(216, 22);
            this.txtsoru.TabIndex = 22;
            // 
            // txtkullaniciadiveyaemail
            // 
            this.txtkullaniciadiveyaemail.Location = new System.Drawing.Point(178, 49);
            this.txtkullaniciadiveyaemail.Name = "txtkullaniciadiveyaemail";
            this.txtkullaniciadiveyaemail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadiveyaemail.Properties.Appearance.Options.UseFont = true;
            this.txtkullaniciadiveyaemail.Properties.NullText = "Kullanıcı Adı Veya Email";
            this.txtkullaniciadiveyaemail.Properties.NullValuePrompt = "Kullanıcı Adı Veya Email";
            this.txtkullaniciadiveyaemail.Size = new System.Drawing.Size(216, 22);
            this.txtkullaniciadiveyaemail.TabIndex = 23;
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
            this.labelControl4.Location = new System.Drawing.Point(10, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(159, 27);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Soru:";
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
            this.labelControl3.Location = new System.Drawing.Point(10, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(159, 27);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Kullanıcı Adı Veya Email:";
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
            this.labelControl2.Location = new System.Drawing.Point(10, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 27);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Yeni Parola Tekrar:";
            // 
            // txtparolatekrar
            // 
            this.txtparolatekrar.Location = new System.Drawing.Point(179, 162);
            this.txtparolatekrar.Name = "txtparolatekrar";
            this.txtparolatekrar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparolatekrar.Properties.Appearance.Options.UseFont = true;
            this.txtparolatekrar.Properties.NullText = "Yeni Parola Tekrar";
            this.txtparolatekrar.Properties.NullValuePrompt = "Yeni Parola Tekrar";
            this.txtparolatekrar.Properties.UseSystemPasswordChar = true;
            this.txtparolatekrar.Size = new System.Drawing.Size(216, 22);
            this.txtparolatekrar.TabIndex = 20;
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 301);
            this.Controls.Add(this.txtparolatekrar);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtcevap);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtsoru);
            this.Controls.Add(this.txtkullaniciadiveyaemail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİFREMİ UNUTTUM";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtparola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadiveyaemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtparolatekrar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.TextEdit txtparola;
        private DevExpress.XtraEditors.TextEdit txtcevap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtsoru;
        private DevExpress.XtraEditors.TextEdit txtkullaniciadiveyaemail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtparolatekrar;
    }
}