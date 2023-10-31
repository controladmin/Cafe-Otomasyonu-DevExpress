using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonWinForm.Masalar;
using CafeOtomasyonWinForm.Odemeler;
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

namespace CafeOtomasyonWinForm.Satis
{
    public partial class FrmSatislar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private DalSatislar satislardal = new DalSatislar();
        public FrmSatislar()
        {
            InitializeComponent();
            gridControl1.DataSource = satislardal.GetAll(context);
        }

        private void btnsiparisdetayi_Click(object sender, EventArgs e)
        {
            string satiskodu = gridView1.GetFocusedRowCellValue(colSatisKodu).ToString();
            bool _paketmi = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(colPaketmi));
            FrmMasaSiparisleri masasiparisleri = new FrmMasaSiparisleri(satiskodu:satiskodu,paketmi:_paketmi);
            masasiparisleri.ShowDialog();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnodemehareketleri_Click(object sender, EventArgs e)
        {
            string satiskodu = gridView1.GetFocusedRowCellValue(colSatisKodu).ToString();
            FrmOdemeHareketleri odemeHareketleri = new FrmOdemeHareketleri(satiskodu: satiskodu);
            odemeHareketleri.ShowDialog();
        }

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = e.Item.Tag.ToString();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                if(e.Item==btnexcellexport)
                {
                    gridView1.ExportToXlsx(dialog.FileName);
                }
                else if(e.Item==btnwordexport)
                {
                    gridView1.ExportToDocx(dialog.FileName);
                }
                else if (e.Item == btnpdfexport)
                {
                    gridView1.ExportToPdf(dialog.FileName);
                }
            }
        }
    }
}