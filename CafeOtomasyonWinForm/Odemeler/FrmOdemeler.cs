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

namespace CafeOtomasyonWinForm.Odemeler
{
    public partial class FrmOdemeler : DevExpress.XtraEditors.XtraForm
    {
        private string _SatisKodu;
        private string _OdemeTuru;
        public OdemeHareketleri odemehareketleri;
        public bool kaydedildi;
        public decimal _kalan;
        public FrmOdemeler(string odemeturu,string satiskodu,decimal kalan)
        {
            InitializeComponent();
            _SatisKodu = satiskodu;
            _OdemeTuru = odemeturu;
            _kalan = kalan;
            if(_OdemeTuru=="NAKİT")
            {
                lblbaslik.Text = "Nakit Ödeme";
            }
            else if(_OdemeTuru=="KREDİ KARTI")
            {
                lblbaslik.Text = "Kredi Kartı İle Ödeme";
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnonay_Click(object sender, EventArgs e)
        {
            if (dateedittarih.EditValue != null)
            {
                odemehareketleri = new OdemeHareketleri
                {
                    SatisKodu = _SatisKodu,
                    OdemeTuru = _OdemeTuru,
                    Odenen = calodenecektutar.Value,
                    Aciklama = txtaciklama.Text,
                    Tarih = Convert.ToDateTime(dateedittarih.Text)
                };
                kaydedildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tarih Seçmediniz!!!", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            calodenecektutar.Value = _kalan;
        }
    }
}