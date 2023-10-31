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
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonuEntities.DAL;

namespace CafeOtomasyonWinForm.Kullanicilar
{
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        private DalKullanicilar kullanicilardal = new DalKullanicilar();
        public FrmKullanicilar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = kullanicilardal.KullanicilariListele(context);
        }
        private void btnyenikullanici_Click(object sender, EventArgs e)
        {
            FrmKaydol kaydol = new FrmKaydol(new Kullanici());
            kaydol.ShowDialog();
        }

        private void btndurumdegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
                var masalar = kullanicilardal.GetByFilter(context, m => m.ID == seciliid);
                if (masalar.Aktifmi)
                {
                    masalar.Aktifmi = false;
                }
                else if (!masalar.Aktifmi)
                {
                    masalar.Aktifmi = true;
                }
                kullanicilardal.Save(context);
                Listele();
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            var yenikullanici = kullanicilardal.GetByFilter(context, m => m.ID == seciliid);
            FrmKaydol kullanicikaydet = new FrmKaydol(yenikullanici);
            kullanicikaydet.ShowDialog();
            
                Listele();
        }
    }
}