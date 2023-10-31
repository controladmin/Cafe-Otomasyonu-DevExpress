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

namespace CafeOtomasyonWinForm.Urunler
{
    public partial class FrmUrunSec : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        DalUrun urundal = new DalUrun();
        public Urun UrunModel;
        public bool secildi;
        public FrmUrunSec()
        {
            InitializeComponent();
            gridControl1.DataSource = urundal.GetAll(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int urunid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID));
                UrunModel = urundal.GetByFilter(context, u => u.ID == urunid);
                secildi = true;
                this.Close();
            }
        }
    }
}