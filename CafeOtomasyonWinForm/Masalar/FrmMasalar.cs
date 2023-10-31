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

namespace CafeOtomasyonWinForm.Masalar
{
    public partial class FrmMasalar : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        DalMasalar masalardal = new DalMasalar();
        public FrmMasalar()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            gridControl1.DataSource = masalardal.MasalariListele(context);
        }
        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            FrmMasaKaydet masakaydet = new FrmMasaKaydet(new Masa());
            masakaydet.ShowDialog();
            if(masakaydet.kaydet)
            {
                Listele();
            }
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            var masalar = masalardal.GetByFilter(context,m=>m.ID==seciliid);
            FrmMasaKaydet masakaydet = new FrmMasaKaydet(masalar);
            masakaydet.ShowDialog();
            if (masakaydet.kaydet)
            {
                Listele();
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            if(MessageBox.Show("Seçili kayıt silinecek onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                masalardal.Delete(context, m => m.ID == seciliid);
                masalardal.Save(context);
                Listele();
            }
        }

        private void btndurumdegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
                var masalar = masalardal.GetByFilter(context, m => m.ID == seciliid);
                if (masalar.Durum)
                {
                    masalar.Durum = false;
                }
                else if(!masalar.Durum)
                {
                    masalar.Durum = true;
                }
                masalardal.Save(context);
                Listele();
            }
           
        }

        private void btnrezervedegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
                var masalar = masalardal.GetByFilter(context, m => m.ID == seciliid);
                if (masalar.Reservemi)
                {
                    masalar.Reservemi = false;
                }
                else if (!masalar.Reservemi)
                {
                    masalar.Reservemi = true;
                }
                masalardal.Save(context);
                Listele();
            }
           
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmasaharaketleri_Click(object sender, EventArgs e)
        {
            int masaid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            FrmMasaHareketleri masahareketleri = new FrmMasaHareketleri(masaid:masaid);
            masahareketleri.ShowDialog();
        }
    }
}