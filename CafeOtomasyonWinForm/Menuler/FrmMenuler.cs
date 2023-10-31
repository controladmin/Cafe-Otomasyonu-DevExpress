using CafeOtomasyonuEntities.Models;
using CafeOtomasyonWinForm.Masalar;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity; // Load ifadesini kullanabilmek için bu kütüphaneyi ekledik
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonWinForm.Menuler
{
    public partial class FrmMenuler : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        public FrmMenuler()
        {
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource = context.Menu.Local.ToBindingList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seçili olan menü silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmasaharaketleri_Click(object sender, EventArgs e)
        {
            int menuid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
            FrmMasaHareketleri masahareketleri = new FrmMasaHareketleri(menuid: menuid);
            masahareketleri.ShowDialog();
        }
    }
}