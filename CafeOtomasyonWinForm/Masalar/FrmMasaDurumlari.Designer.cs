
namespace CafeOtomasyonWinForm.Masalar
{
    partial class FrmMasaDurumlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaDurumlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnrezerveet = new DevExpress.XtraEditors.SimpleButton();
            this.btnmasaac = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnsiparisver = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "MASA DURUMLARI";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnrezerveet);
            this.groupControl1.Controls.Add(this.btnmasaac);
            this.groupControl1.Controls.Add(this.btnyenile);
            this.groupControl1.Controls.Add(this.btnsiparisver);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 568);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 100);
            this.groupControl1.TabIndex = 7;
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
            // 
            // btnrezerveet
            // 
            this.btnrezerveet.Enabled = false;
            this.btnrezerveet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrezerveet.ImageOptions.Image")));
            this.btnrezerveet.Location = new System.Drawing.Point(226, 38);
            this.btnrezerveet.Name = "btnrezerveet";
            this.btnrezerveet.Size = new System.Drawing.Size(101, 46);
            this.btnrezerveet.TabIndex = 0;
            this.btnrezerveet.Text = "REZERVE\r\nET";
            this.btnrezerveet.Click += new System.EventHandler(this.btnrezerveet_Click);
            // 
            // btnmasaac
            // 
            this.btnmasaac.Enabled = false;
            this.btnmasaac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnmasaac.ImageOptions.Image")));
            this.btnmasaac.Location = new System.Drawing.Point(119, 38);
            this.btnmasaac.Name = "btnmasaac";
            this.btnmasaac.Size = new System.Drawing.Size(101, 46);
            this.btnmasaac.TabIndex = 0;
            this.btnmasaac.Text = "MASA\r\nAÇ";
            this.btnmasaac.Click += new System.EventHandler(this.btnmasaac_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.Image")));
            this.btnyenile.Location = new System.Drawing.Point(333, 38);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(101, 46);
            this.btnyenile.TabIndex = 0;
            this.btnyenile.Text = "YENİLE\r\nLİSTELE";
            // 
            // btnsiparisver
            // 
            this.btnsiparisver.Enabled = false;
            this.btnsiparisver.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsiparisver.ImageOptions.Image")));
            this.btnsiparisver.Location = new System.Drawing.Point(12, 39);
            this.btnsiparisver.Name = "btnsiparisver";
            this.btnsiparisver.Size = new System.Drawing.Size(101, 46);
            this.btnsiparisver.TabIndex = 0;
            this.btnsiparisver.Text = "SİPARİŞ\r\nVER";
            this.btnsiparisver.Click += new System.EventHandler(this.btnsiparisver_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(998, 541);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // FrmMasaDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMasaDurumlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASA DURUMLARI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnrezerveet;
        private DevExpress.XtraEditors.SimpleButton btnmasaac;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraEditors.SimpleButton btnsiparisver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}