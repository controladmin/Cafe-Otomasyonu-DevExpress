using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CafeOtomasyonWinForm.Menuler;
using CafeOtomasyonWinForm.Urunler;
using CafeOtomasyonWinForm.Masalar;
using CafeOtomasyonWinForm.Kullanicilar;
using CafeOtomasyonWinForm.Musteriler;
using CafeOtomasyonWinForm.Satis;
using CafeOtomasyonWinForm.Odemeler;
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonWinForm.RaporFormlari;
using CafeOtomasyonWinForm.RaporDosyalari;

namespace CafeOtomasyonWinForm.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CafeContext context = new CafeContext();
        public FrmAnaMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;
            FrmKullaniciGirisi kullanicigirisi = new FrmKullaniciGirisi();
            kullanicigirisi.ShowDialog();
        }
       public void FormGetir(XtraForm form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void btnmenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMenuler menuler = new FrmMenuler();
            menuler.ShowDialog();
        }

        private void btnurunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUrunler urunler = new FrmUrunler();
            FormGetir(urunler);
            //urunler.Show();
        }

        private void btnmasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasalar masalar = new FrmMasalar();
            FormGetir(masalar);
        }

        private void btnmasasiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasaDurumlari masadurum = new FrmMasaDurumlari();
            FormGetir(masadurum);
        }

        private void btnkullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKullanicilar kullanicilistesi = new FrmKullanicilar();
            FormGetir(kullanicilistesi);
        }

        private void btnmusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMusteriler musteriler = new FrmMusteriler();
            FormGetir(musteriler);
        }

        private void btnsatislar_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSatislar satislar = new FrmSatislar();
            FormGetir(satislar);
        }

        private void btnodemehareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOdemeHareketleri odemehareketleri = new FrmOdemeHareketleri();
            FormGetir(odemehareketleri);
        }

        private void btnpaketsiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket Sipariş İşlemini Onaylıyor musunuz?","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                var model = context.SatisKodu.First();
                string _SatisKodu = model.SatisTanimi + model.Sayi;
                model.Sayi++;
                context.SaveChanges();
                FrmMasaSiparisleri masasiparisi = new FrmMasaSiparisleri(satiskodu: _SatisKodu,paketmi:true);
                masasiparisi.ShowDialog();
            }
        }

        private void btnmasahareketeriraporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptMasaHareketleri rptmasahareketler = new RptMasaHareketleri();
            FrmRaporGoruntule2 raporgoruntule2 = new FrmRaporGoruntule2(rptmasahareketler);
            raporgoruntule2.ShowDialog();
        }

        private void btnozelrapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOzelRapor ozelrapor = new FrmOzelRapor();
            ozelrapor.ShowDialog();
        }

        private void btnmasahareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasaHareketleri masahareketleri = new FrmMasaHareketleri();
            masahareketleri.ShowDialog();
        }

        private void btndashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDashBoard dashboard = new FrmDashBoard();
            FormGetir(dashboard);
        }
    }
}