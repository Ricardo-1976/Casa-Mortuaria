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
    public partial class _RelatoriodosMortos : MetroFramework.Forms.MetroForm
    {
        public _RelatoriodosMortos()
        {
            InitializeComponent();
        }

        private void lk_sairtabela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
