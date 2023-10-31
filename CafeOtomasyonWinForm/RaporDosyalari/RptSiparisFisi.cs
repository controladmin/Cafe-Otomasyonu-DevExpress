using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
using DevExpress.DataAccess.ObjectBinding; // ObjectDataSource ifadesini kullanabilmek için bu kütüphaneyi ekledik
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CafeOtomasyonWinForm.RaporDosyalari
{
    public partial class RptSiparisFisi : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        DalMasaHareketleri masahareketleridal = new DalMasaHareketleri();
        public RptSiparisFisi(string satiskodu,string bilgi,Satislar satislar=null)
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            xrlabelbilgi.Text = bilgi;
            source.DataSource = masahareketleridal.GetAll(context,m=>m.SatisKodu==satiskodu);
            this.DataSource = source;
            xrtableurunadi.DataBindings.Add("Text",DataSource, "Urun.UrunAdi");
            xrtablemiktar.DataBindings.Add("Text", DataSource, "Miktar");
            xrtablefiyat.DataBindings.Add("Text", DataSource, "BirimFiyat");
            xrtableindirim.DataBindings.Add("Text", DataSource, "IndirimTutari");
            xrlabelkalan.Text = satislar.Kalan.ToString("C2");
            xrlabelodenen.Text = satislar.Odenen.ToString("C2");

        }

    }
}
