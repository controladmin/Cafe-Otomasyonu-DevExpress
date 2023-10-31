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
    public partial class FrmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private DalMasalar masalardal = new DalMasalar();
        private Masa _entity;
        public bool kaydet = false;

        public FrmMasaKaydet(Masa entity)
        {
            InitializeComponent();
            _entity = entity;
            this.txtmasaadi.DataBindings.Add("text", _entity, "MasaAdi");
            this.txtaciklama.DataBindings.Add("text", _entity, "Aciklama");
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (_entity.ID == 0)            
            {
                _entity.Durum = false;
                _entity.Reservemi = false;
                _entity.EklemeTarihi = DateTime.Now;
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Yeni Masa Eklendi";
            }
            else if(_entity.ID!=0)
            {
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Masa Güncellendi";
            }
            if (masalardal.AddOrUpdate(context, _entity))
            {
                masalardal.Save(context);
                kaydet = true;
                this.Close();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}