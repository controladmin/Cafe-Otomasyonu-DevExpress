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

namespace CafeOtomasyonWinForm.Masalar
{
    public partial class FrmMasaRezerve : DevExpress.XtraEditors.XtraForm
    {
        private int _masaid;
        public bool islemyapildi;
        private Masa masalar;
        DalMasalar masalardal = new DalMasalar();
        CafeContext context = new CafeContext();
        public FrmMasaRezerve(int MasaId)
        {
            InitializeComponent();
            _masaid = MasaId;
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            masalar = masalardal.GetByFilter(context,m=>m.ID==_masaid);
            masalar.Islem = txtislem.Text;
            masalar.SonIslemTarihi =Convert.ToDateTime(dateedittarih.EditValue);
            masalar.KullaniciID = KullaniciAyarlari.Kullanciid;
            masalar.Reservemi = true;
            masalardal.Save(context);
            islemyapildi = true;
            this.Close();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}