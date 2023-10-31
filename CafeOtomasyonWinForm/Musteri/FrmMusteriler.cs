using CafeOtomasyonuEntities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity; // Load() metodunu kullanabilmek için bu kütüphaneyi yükledik
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonWinForm.Musteriler
{
    public partial class FrmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        public FrmMusteriler()
        {
            InitializeComponent();
            context.Musteriler.Load();
            gridControl1.DataSource = context.Musteriler.Local.ToBindingList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData(); // GridControlu refresh ediyor
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seçili Olan Müşteri Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }
    }
}