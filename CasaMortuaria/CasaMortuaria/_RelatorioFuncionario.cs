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
    public partial class _RelatorioFuncionario : MetroFramework.Forms.MetroForm
    {
        public _RelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void lk_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
