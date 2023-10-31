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
using DevExpress.XtraReports.UI; // XtraReport özelliğini kullanabilmek için bu kütüphaneyi ekledik

namespace CafeOtomasyonWinForm.RaporFormlari
{
    public partial class FrmRaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporGoruntule(XtraReport report)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }
    }
}