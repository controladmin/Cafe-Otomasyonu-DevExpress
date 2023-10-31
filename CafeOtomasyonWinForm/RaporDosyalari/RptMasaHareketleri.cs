using CafeOtomasyonuEntities.DAL;
using CafeOtomasyonuEntities.Models;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CafeOtomasyonWinForm.RaporDosyalari
{
    public partial class RptMasaHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private DalMasaHareketleri masahareketleridal = new DalMasaHareketleri();
        public RptMasaHareketleri()
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = masahareketleridal.GetAll(context);
            DataSource = source;
            xrtableid.DataBindings.Add("Test", DataSource, "ID");
            xrtablesatiskodu.DataBindings.Add("Test", DataSource, "SatisKodu");
            xrtablemasaadi.DataBindings.Add("Test", DataSource, "Masa.MasaAdi");
            xrtablemenu.DataBindings.Add("Test", DataSource, "Urun.Menu.MenuAdi");
            xrtableurunadi.DataBindings.Add("Test", DataSource, "Urun.UrunAdi");
            xrtablemiktar.DataBindings.Add("Test", DataSource, "Miktar");
            xrtablefiyat.DataBindings.Add("Test", DataSource, "BirimFiyat");
            xrtableindirimtutari.DataBindings.Add("Test", DataSource, "IndirimTutari");
            xrtableaciklama.DataBindings.Add("Test", DataSource, "Aciklama");
            xrtabletarih.DataBindings.Add("Test", DataSource, "tarih");
        }

    }
}
