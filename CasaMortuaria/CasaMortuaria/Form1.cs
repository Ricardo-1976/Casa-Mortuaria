using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMortuaria
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ReportParameter ImgM = new ReportParameter("ImgM", new Uri(DadosEditar.EditarDados._imgmortoM).AbsoluteUri);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ImgM,});

            this.reportViewer1.RefreshReport();
        }
    }
}
