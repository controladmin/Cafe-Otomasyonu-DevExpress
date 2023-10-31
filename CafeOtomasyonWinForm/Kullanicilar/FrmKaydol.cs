using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
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
    public partial class FrmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private DalKullanicilar dalkullanicilar = new DalKullanicilar();
        private Kullanici _entity;
        KullaniciHareketleri kullanicihareket = new KullaniciHareketleri();
        DalKullaniciHareketleri kullanicihareketdal = new DalKullaniciHareketleri();
        public FrmKaydol(Kullanici entity)
        {
            InitializeComponent();
            _entity = entity;

            //tgaktifmi.DataBindings.Add("EditValue", _entity, "Aktifmi");
            //txtadsoyad.DataBindings.Add("Test", _entity, "AdSoyad");
            //txttelefon.DataBindings.Add("Test", _entity, "Telefon");
            //txtemail.DataBindings.Add("Test", _entity, "Email");
            //txtgorev.DataBindings.Add("Test", _entity, "Gorevi");
            //txtadres.DataBindings.Add("Test", _entity, "Adres");
            //txtsoru.DataBindings.Add("Test", _entity, "HatirlatmaSorusu");
            //txtcevap.DataBindings.Add("Test", _entity, "Cevap");
            //txtkullaniciadi.DataBindings.Add("Test", _entity, "KullaniciAdi");
            //txtsifre.DataBindings.Add("Test", _entity, "Sifre");
            //txtaciklama.DataBindings.Add("Test", _entity, "Aciklama");

            txtadsoyad.Text = _entity.AdSoyad;
            txttelefon.Text = _entity.Telefon;
            txtemail.Text = _entity.Email;
            txtgorev.Text = _entity.Gorevi;
            txtadres.Text = _entity.Adres;
            txtaciklama.Text = _entity.Aciklama;
            txtkullaniciadi.Text = _entity.KullaniciAdi;
            txtsifre.Text = _entity.Sifre;
            txtsoru.Text = _entity.HatirlatmaSorusu;
            txtcevap.Text = _entity.Cevap;
            tgaktifmi.EditValue = _entity.Aktifmi;
        }

        private void btnyenikullanici_Click(object sender, EventArgs e)
        {
            if (_entity.ID == 0)
            {
                _entity.AdSoyad = txtadsoyad.Text;
                _entity.Telefon = txttelefon.Text;
                _entity.Email = txtemail.Text;
                _entity.Gorevi = txtgorev.Text;
                _entity.HatirlatmaSorusu = txtsoru.Text;
                _entity.Cevap = txtcevap.Text;
                _entity.KullaniciAdi = txtkullaniciadi.Text;
                _entity.Sifre = txtsifre.Text;
                _entity.Adres = txtadres.Text;
                _entity.Aciklama = txtaciklama.Text;
                //_entity.Aktifmi = tgaktifmi.

                if (txtsifre.Text == txtsifretekrar.Text)
                {
                    _entity.KayitTarihi = DateTime.Now;
                    if (dalkullanicilar.AddOrUpdate(context, _entity))
                    {
                        dalkullanicilar.Save(context);
                        var model = context.Kullanicilar.Max(k => k.ID);
                        kullanicihareket.KullaniciID = model;
                        string aciklama = "Yeni Kullanıcı Eklendi";
                        kullanicihareketdal.KullaniciHareketleriEkle(context, kullanicihareket, aciklama);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler farklı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if(_entity.ID!=0)
            {
                _entity.AdSoyad = txtadsoyad.Text;
                _entity.Telefon = txttelefon.Text;
                _entity.Email = txtemail.Text;
                _entity.Gorevi = txtgorev.Text;
                _entity.HatirlatmaSorusu = txtsoru.Text;
                _entity.Cevap = txtcevap.Text;
                _entity.KullaniciAdi = txtkullaniciadi.Text;
                _entity.Sifre = txtsifre.Text;
                _entity.Adres = txtadres.Text;
                _entity.Aciklama = txtaciklama.Text;
                //_entity.Aktifmi = tgaktifmi.

                if (txtsifre.Text == txtsifretekrar.Text)
                {
                    _entity.KayitTarihi = DateTime.Now;
                    if (dalkullanicilar.AddOrUpdate(context, _entity))
                    {
                        dalkullanicilar.Save(context);
                        var model = context.Kullanicilar.Max(k => k.ID);
                        kullanicihareket.KullaniciID = model;
                        string aciklama = "Yeni Kullanıcı Eklendi";
                        kullanicihareketdal.KullaniciHareketleriEkle(context, kullanicihareket, aciklama);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler farklı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}