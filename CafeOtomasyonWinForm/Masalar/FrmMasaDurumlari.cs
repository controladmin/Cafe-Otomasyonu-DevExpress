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
    public partial class FrmMasaDurumlari : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        private CheckButton btnsender;
        private SatisKodu modelsatiskodu;
        private string _SatisKodu;
        private int _Masaid;
        private Masa masalar;
        DalMasalar masadal = new DalMasalar();
        public FrmMasaDurumlari()
        {
            InitializeComponent();
            modelsatiskodu = context.SatisKodu.First();
            MasalarGetir();
        }

        public void MasalarGetir()
        {
            flowLayoutPanel1.Controls.Clear();
            context = new CafeContext();
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].ID.ToString();
                btn.Tag = model[i].SatisKodu;
                btn.Height = 100;
                btn.Width = 80;
                flowLayoutPanel1.Controls.Add(btn);
                if (model[i].Reservemi && !model[i].Durum)
                {
                    btn.Appearance.BackColor = Color.Yellow;
                }
                else if (model[i].Durum)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].Durum)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                btn.Click += Btn_Click;
            }
        }

        public void DurumlariYenile()
        {
            btnsiparisver.Enabled = false;
            btnmasaac.Enabled = false;
            btnrezerveet.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
             btnsender = sender as CheckButton;
            _Masaid = Convert.ToInt32(btnsender.Name);
            DurumlariYenile();
            if (btnsender.Appearance.BackColor == Color.Yellow)
            {
                btnmasaac.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.Green)
            {
                btnmasaac.Enabled = true;
                btnrezerveet.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.Red)
            {
                btnsiparisver.Enabled = true;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsiparisver_Click(object sender, EventArgs e)
        {
            _SatisKodu = btnsender.Tag.ToString();
            FrmMasaSiparisleri masasiparis = new FrmMasaSiparisleri(masaid: _Masaid,masaadi:btnsender.Text,satiskodu:_SatisKodu);
            masasiparis.ShowDialog();
            btnsender = null;
            DurumlariYenile();
            MasalarGetir();
        }

        private void btnmasaac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnsender.Text + " Açılsın mı?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                masalar = masadal.GetByFilter(context, m => m.ID == _Masaid);
                masalar.SatisKodu = modelsatiskodu.SatisTanimi + modelsatiskodu.Sayi;
                masalar.Durum = true;
                masalar.Reservemi = false;
                var sayiarttir = context.SatisKodu.First();
                sayiarttir.Sayi++;
                masadal.Save(context);
                btnsender = null;
                DurumlariYenile();
                MasalarGetir();
                modelsatiskodu = context.SatisKodu.First();
            }
        }

        private void btnrezerveet_Click(object sender, EventArgs e)
        {
            FrmMasaRezerve masarezervi = new FrmMasaRezerve(_Masaid);
            masarezervi.ShowDialog();
            DurumlariYenile();
            if(masarezervi.islemyapildi)
            {
                MasalarGetir();
            }
            btnsender = null;
        }
    }
}