using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Mapping;
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonWinForm.Masalar;
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

namespace CafeOtomasyonWinForm.Urunler
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private DalUrun urundal = new DalUrun();
        public FrmUrunler()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = urundal.UrunListele(context); // Control R+m diyerek bunu metot içine aldı
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            FrmUrunKaydet yeniurunkaydi = new FrmUrunKaydet(new Urun());
            yeniurunkaydi.ShowDialog();
            if (yeniurunkaydi.kaydet)
            {
                Listele();
            }
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            int secilenid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            FrmUrunKaydet yeniurunkaydi = new FrmUrunKaydet(urundal.GetByFilter(context, u => u.ID == secilenid));
            yeniurunkaydi.ShowDialog();
            if (yeniurunkaydi.kaydet)
            {
                Listele();
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            if(MessageBox.Show("Seçili kayıt silinecek onaylıyormusunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                urundal.Delete(context,u=>u.ID==seciliid);
                urundal.Save(context);
                Listele();
            }
        }

        private void btnmasaharaketleri_Click(object sender, EventArgs e)
        {
            int urunid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            FrmMasaHareketleri masahareketleri = new FrmMasaHareketleri(urunid: urunid);
            masahareketleri.ShowDialog();
        }
    }
}