using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonWinForm.WinTools;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonWinForm.Kullanicilar
{
    public partial class FrmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context = new CafeContext();
        private DalKullaniciHareketleri kullanicihareketdal = new DalKullaniciHareketleri();
        private KullaniciHareketleri _entity = new KullaniciHareketleri();
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        void BilgileriGetir()
        {
            // Projeye sağclick yapıp setting bölümüne yazıyoruz bu bilgileri ve oradan okuyoruz
            if(Properties.Settings.Default.BeniHatirla==true)
            {
                txtkullaniciadi.Text = Properties.Settings.Default.KullaniciAdi;
                txtsifre.Text = Properties.Settings.Default.Sifre;
                chbenihatirla.Checked = true;
            }
            else
            {
                txtkullaniciadi.Text = null;
                txtsifre.Text = null;
                chbenihatirla.Checked = false;
            }
        }
        void BilgileriKaydet()
        {
            if(chbenihatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtkullaniciadi.Text;
                Properties.Settings.Default.Sifre = txtsifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Sifre = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if(!giris)
            {
                Application.Exit();
            }
        }

        private void FrmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtkullaniciadi.Text && k.Sifre==txtsifre.Text);
            if(model!=null)
            {
                giris = true;
                BilgileriKaydet();
                KullaniciAyarlari.Kullanciid = model.ID;
                _entity.KullaniciID = model.ID;
                string aciklama = model.KullaniciAdi + " Adlı Kullanıcı Sisteme Giriş Yaptı";
                kullanicihareketdal.KullaniciHareketleriEkle(context, _entity, aciklama);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcıadı veya şifre yanlış", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void lblkaydol_Click(object sender, EventArgs e)
        {
            FrmKaydol kayitol = new FrmKaydol(new Kullanici());
            kayitol.ShowDialog();
        }

        private void btnsifremiunuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum sifremiunuttum = new FrmSifremiUnuttum();
            sifremiunuttum.ShowDialog();
        }
    }
}