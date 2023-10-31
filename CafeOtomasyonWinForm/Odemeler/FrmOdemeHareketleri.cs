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

namespace CafeOtomasyonWinForm.Odemeler
{
    public partial class FrmOdemeHareketleri : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        DalOdemeHareketleri odemehareketleridal = new DalOdemeHareketleri();
        public FrmOdemeHareketleri(string satiskodu=null)
        {
            InitializeComponent();
            if(satiskodu==null)
            {
                gridControl1.DataSource = odemehareketleridal.GetAll(context);
            }
            else if(satiskodu!=null)
            {
                gridControl1.DataSource = odemehareketleridal.GetAll(context, o=>o.SatisKodu==satiskodu);
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}