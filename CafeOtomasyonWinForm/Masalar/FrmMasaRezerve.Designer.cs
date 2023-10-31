
namespace CafeOtomasyonWinForm.Masalar
{
    partial class FrmMasaRezerve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaRezerve));
            this.lblbaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtislem = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateedittarih = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnonayla = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtislem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.lblbaslik.Size = new System.Drawing.Size(386, 27);
            this.lblbaslik.TabIndex = 4;
            this.lblbaslik.Text = "MASA REZERVİ";
            // 
            // txtislem
            // 
            this.txtislem.Location = new System.Drawing.Point(81, 87);
            this.txtislem.Name = "txtislem";
            this.txtislem.Size = new System.Drawing.Size(293, 130);
            this.txtislem.TabIndex = 14;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl10.Location = new System.Drawing.Point(12, 134);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 37);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "İşlem:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(12, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 28);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Tarih:";
            // 
            // dateedittarih
            // 
            this.dateedittarih.EditValue = null;
            this.dateedittarih.Location = new System.Drawing.Point(81, 53);
            this.dateedittarih.Name = "dateedittarih";
            this.dateedittarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateedittarih.Properties.Appearance.Options.UseFont = true;
            this.dateedittarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedittarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedittarih.Size = new System.Drawing.Size(293, 22);
            this.dateedittarih.TabIndex = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnonayla);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 228);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 100);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "İŞLMELER";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.Location = new System.Drawing.Point(271, 39);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 45);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnonayla
            // 
            this.btnonayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnonayla.ImageOptions.Image")));
            this.btnonayla.Location = new System.Drawing.Point(12, 39);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(101, 46);
            this.btnonayla.TabIndex = 0;
            this.btnonayla.Text = "ONAYLA";
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // FrmMasaRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 328);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dateedittarih);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtislem);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.lblbaslik);
            this.Name = "FrmMasaRezerve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMasaRezerve";
            ((System.ComponentModel.ISupportInitialize)(this.txtislem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedittarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblbaslik;
        private DevExpress.XtraEditors.MemoEdit txtislem;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateedittarih;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnonayla;
    }
}