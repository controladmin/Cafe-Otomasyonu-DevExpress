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

namespace CafeOtomasyonWinForm.Kullanicilar
{
    public partial class FrmSifremiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private DalKullanicilar kullanicilardal = new DalKullanicilar();
        KullaniciHareketleri kullanicihareket = new KullaniciHareketleri();
        DalKullaniciHareketleri kullanicihareketdal = new DalKullaniciHareketleri();
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            var entity = kullanicilardal.GetByFilter(context,k=>k.KullaniciAdi==txtkullaniciadiveyaemail.Text||k.Email==txtkullaniciadiveyaemail.Text);
            if(entity!=null)
            {
                if(entity.HatirlatmaSorusu==txtsoru.Text&&entity.Cevap==txtcevap.Text)
                {
                    if(txtparola.Text==txtparolatekrar.Text)
                    {
                        entity.Sifre = txtparola.Text;
                        if(kullanicilardal.AddOrUpdate(context,entity))
                        {
                            kullanicilardal.Save(context);
                            kullanicihareket.KullaniciID = entity.ID;
                            string aciklama = entity.KullaniciAdi + " Adlı Kullanıcının Parolası Yenilendi";
                            kullanicihareketdal.KullaniciHareketleriEkle(context,kullanicihareket, aciklama);


                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar Birbirinden Farklı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Soru Ve Cevap Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}