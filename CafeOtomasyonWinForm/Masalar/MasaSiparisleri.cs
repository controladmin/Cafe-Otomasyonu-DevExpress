using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonWinForm.Odemeler;
using CafeOtomasyonWinForm.RaporDosyalari;
using CafeOtomasyonWinForm.RaporFormlari;
using CafeOtomasyonWinForm.Urunler;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonWinForm.Masalar
{
    public partial class FrmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private DalMusteriler musterilerdal = new DalMusteriler();
        private DalMasaHareketleri masahareketleridal = new DalMasaHareketleri();
        private DalOdemeHareketleri odemehareketdal = new DalOdemeHareketleri();
        private Satislar satislar;
        private DalSatislar satislardal = new DalSatislar();
        private Masa masalar;
        private DalMasalar masalardal = new DalMasalar();
        private DalUrun urundal = new DalUrun();
        private int? _MasaID = null;
        private string _SatisKodu = null;
        private bool _Paketmi = false;
        private bool yazdir;
        private void Hesapla()
        {
            calindirimtoplami.Value =Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue);
            calindirimlitoplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calodenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
            calkalan.Value = Convert.ToDecimal(calindirimlitoplam.Value - calodenen.Value);
            caltoplam.Value = Convert.ToDecimal(calindirimtoplami.Value + calindirimlitoplam.Value);

            // İndirim Oranı
            if(caltoplam.Value!=0)
            {
                calindirimorani.Value = 100 * Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue) /
                    (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) +
                    Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue));
            }
            else if(caltoplam.Value==0)
            {
                calindirimorani.Value = 0;
            }
        }
        public FrmMasaSiparisleri(int? masaid = null, string masaadi = null, string satiskodu = null,bool paketmi=false)
        {
            InitializeComponent();
            _MasaID = masaid;
            _SatisKodu = satiskodu;
            _Paketmi = paketmi;
            context.MasaHareketleri.Where(m => m.SatisKodu == _SatisKodu).Load();
            context.OdemeHareketleri.Where(o => o.SatisKodu == _SatisKodu).Load();
            context.Urun.Load();
            gridcontrolsiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridcontrolodemeler.DataSource = context.OdemeHareketleri.Local.ToBindingList();
            lookupmusteri.Properties.DataSource = musterilerdal.GetAll(context);
            if (_MasaID != null)
            {
                lblbaslik.Text = masaadi + " Siparişleri";
                masalar = masalardal.GetByFilter(context, m => m.ID == _MasaID);
            }
            else if(_MasaID==null)
            {
                lblbaslik.Text = "Paket Siparişi Veya Veresiye İşlemleri";
            }
            satislar = satislardal.GetByFilter(context, s => s.SatisKodu == _SatisKodu);
            if(satislar!=null)
            {
                lookupmusteri.EditValue = satislar.MusteriID;
                txtsatisaciklama.Text = satislar.Aciklama;
                dateedittarih.Text =satislar.SonIslemTarihi.ToString("dd.MM.yyyy");
            }           
        }

        private void btnmusterisil_Click(object sender, EventArgs e)
        {
            lookupmusteri.EditValue = null;
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(MessageBox.Show("Seçili Sipariş Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                gridviewsiparisler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Ödeme Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                gridviewodemeler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void btnsiparisver_Click(object sender, EventArgs e)
        {
            FrmUrunSec urunsec = new FrmUrunSec();
            urunsec.ShowDialog();
            if (urunsec.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _SatisKodu,
                    MasaID = _MasaID,
                    UrunID = urunsec.UrunModel.ID,
                    Miktar = 1,
                    BirimFiyat = urunsec.UrunModel.BirimFiyat1,
                    IndirimTutari = 0,
                    Aciklama = " ",
                    Tarih = DateTime.Now
                };
                masahareketleridal.AddOrUpdate(context, entity);
            }
        }

        private void gridviewsiparisler_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Hesapla();
        }

        private void gridviewsiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (gridviewsiparisler.RowCount > 0)
            {
                if (dateedittarih.EditValue != null)
                {
                    if (satislar == null)
                    {
                        satislar = new Satislar();
                        satislar.SatisKodu = _SatisKodu;
                    }
                    satislar.MusteriID = (int?)lookupmusteri.EditValue;
                    satislar.Aciklama = txtsatisaciklama.Text;
                    satislar.SonIslemTarihi = (DateTime)dateedittarih.EditValue;
                    satislar.Kalan = calkalan.Value;
                    satislar.Odenen = calodenen.Value;
                    satislar.Tutar = caltoplam.Value;
                    satislar.IndirimTutari = calindirimtoplami.Value;
                    satislar.Paketmi = _Paketmi;
                    satislardal.AddOrUpdate(context, satislar);
                    context.SaveChanges();
                    yazdir = true;
                }
                else
                {
                    MessageBox.Show("Tarih Seçmediniz!!!", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
               
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
        private void odemeler_Click(object sender, EventArgs e)
        {
            if (gridviewsiparisler.RowCount>0)
            {
                var btn = sender as SimpleButton;
                FrmOdemeler odeme = new FrmOdemeler(btn.Text, _SatisKodu, calkalan.Value);
                odeme.ShowDialog();
                if (odeme.kaydedildi)
                {
                    if (odemehareketdal.AddOrUpdate(context, odeme.odemehareketleri))
                    {
                        gridviewodemeler.RefreshData();
                        Hesapla();
                    }
                }
            }
        }

        private void gridviewodemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }
        private void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.Durum = false;
            masalar.Islem = null;
            masalar.KullaniciID = null;
            masalardal.AddOrUpdate(context, masalar);
            masalardal.Save(context);
        }

        private void btnsonuclandir_Click(object sender, EventArgs e)
        {
            if (gridviewsiparisler.RowCount>0)
            {
                if (_MasaID != null)
                {
                    if (calkalan.Value > 0)
                    {
                        if (MessageBox.Show("Bu İşlemi Onaylarsanız Müşteriye Borç İşlemi Kaydedilecektir", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (satislar != null)
                            {
                                if (satislar.MusteriID == null)
                                {
                                    MessageBox.Show("Önce Müşteri Seçiniz!!!", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    Sonuclandir();
                                    this.Close();
                                }
                            }
                        }

                    }
                    else if (calkalan.Value == 0)
                    {
                        Sonuclandir();
                        this.Close();
                    }
                }
            }
        }

        private void repositoryfiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int urunid = Convert.ToInt32(gridviewsiparisler.GetFocusedRowCellValue(colUrunID));
            var model = urundal.GetByFilter(context,u=>u.ID==urunid);
            barfiyat1.Caption = model.BirimFiyat1.ToString();
            barfiyat2.Caption = model.BirimFiyat2.ToString();
            barfiyat3.Caption = model.BirimFiyat3.ToString();
            radialMenu1.ShowPopup(MousePosition);
        }

        private void fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridviewsiparisler.SetFocusedRowCellValue(colBirimFiyat,e.Item.Caption);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnyazdir_Click(object sender, EventArgs e)
        {
            btnkaydet.PerformClick(); // Kaydet demeyi unutursak burada bu komut ile kaydetme işlemini gerçekleştiriyoruz
            if (yazdir)
            {
                if (_MasaID != null)
                {
                    RptSiparisFisi rptsiparisfisi = new RptSiparisFisi(_SatisKodu, masalar.MasaAdi, satislar);
                    FrmRaporGoruntule raporgoruntule = new FrmRaporGoruntule(rptsiparisfisi);
                    raporgoruntule.ShowDialog();
                }
                else if (_MasaID == null)
                {
                    if(satislar.MusteriID==null)
                    {
                        RptSiparisFisi rptsiparisfisi = new RptSiparisFisi(_SatisKodu, _SatisKodu, satislar);
                        FrmRaporGoruntule raporgoruntule = new FrmRaporGoruntule(rptsiparisfisi);
                        raporgoruntule.ShowDialog();
                    }
                    else if(satislar.MusteriID!=null)
                    {
                        RptSiparisFisi rptsiparisfisi = new RptSiparisFisi(_SatisKodu, _SatisKodu+"---> "+satislar.Musteriler.AdSoyad, satislar);
                        //RptSiparisFisi rptsiparisfisi = new RptSiparisFisi(_SatisKodu, _SatisKodu + "\n"+ satislar.Musteriler.AdSoyad, satislar);
                        FrmRaporGoruntule raporgoruntule = new FrmRaporGoruntule(rptsiparisfisi);
                        raporgoruntule.ShowDialog();
                    }                  
                }
            }
        }
    }
}
