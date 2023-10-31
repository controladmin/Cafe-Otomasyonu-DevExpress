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
    public partial class FrmMasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        private int? _masaid;
        private int? _menuid;
        private int? _urunid;
        private CafeContext context = new CafeContext();
        DalMasaHareketleri masaharektleridal = new DalMasaHareketleri();
        public FrmMasaHareketleri(int? masaid=null,int? menuid=null,int? urunid=null)
        {
            InitializeComponent();
            _masaid = masaid;
            _menuid = menuid;
            _urunid = urunid;
            if (_masaid != null)
            {
                gridControl1.DataSource = masaharektleridal.GetAll(context, m => m.MasaID == _masaid);
                return;
            }
            else if (_menuid != null)
            {
                gridControl1.DataSource = masaharektleridal.GetAll(context, m => m.Urun.MenuID == _menuid);
                return;
            }
            else if (_urunid != null)
            {
                gridControl1.DataSource = masaharektleridal.GetAll(context, u=>urunid == _urunid);
                return;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}