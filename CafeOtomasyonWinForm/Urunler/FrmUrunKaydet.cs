using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
using DevExpress.XtraEditors;
using System;
using System.IO;
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
    public partial class FrmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private DalMenu menudal = new DalMenu();
        DalUrun urundal = new DalUrun();
        private Urun _entity;
        public bool kaydet = false;
        private CafeContext context = new CafeContext();
        public FrmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            lookupmenu.Properties.DataSource = menudal.GetAll(context);
            lookupmenu.DataBindings.Add("EditValue", _entity, "MenuID");
            txturunadi.DataBindings.Add("Text", _entity, "UrunAdi");
            txturunkodu.DataBindings.Add("Text", _entity, "UrunKodu");
            txtaciklama.DataBindings.Add("Text", _entity, "Aciklama");
            calcbirimfiyat1.DataBindings.Add("Text", _entity, "BirimFiyat1",true); // true demessem başka textboxa geçersem yazdığım textboxı 0 yapar tekrar
            calcbirimfiyat2.DataBindings.Add("Text", _entity, "BirimFiyat2",true);
            calcbirimfiyat3.DataBindings.Add("Text", _entity, "BirimFiyat3",true);
            dttarih.DataBindings.Add("Text", _entity, "Tarih",true);
            if(_entity.ID!=0)
            {
                if(_entity.Resim!=null)
                {
                    pbresim.EditValue=Image.FromFile(_entity.Resim);
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (pbresim.GetLoadedImageLocation()!="")
            {
                string hedefyol = $"{Application.StartupPath}\\Image\\{txturunadi.Text}-{txturunkodu.Text}.png";
                File.Copy(pbresim.GetLoadedImageLocation(), hedefyol);
                _entity.Resim = $"Image\\{txturunadi.Text}-{txturunkodu.Text}.png"; // Sql içine resim yolunu kaydediyor
            }
            if(urundal.AddOrUpdate(context,_entity))
            {
                urundal.Save(context);
                kaydet = true;
                this.Close();
            }
        }
    }
}