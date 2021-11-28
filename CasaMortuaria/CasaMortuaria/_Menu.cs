using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMortuaria
{
    public partial class _Menu : MetroFramework.Controls.MetroUserControl
    {

        private static _Menu _instance;
        public static _Menu Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new _Menu();
                return _instance;
            }
        }

        public _Menu()
        {
            InitializeComponent();
        }

        private void tl_cadastrarFuncio_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
                new _CadastrarFuncionario().ShowDialog();
            }
            else
            {
                return;
            }
            
        }

        private void tl_verfuncionario_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
                new _VerFuncionario().ShowDialog();
            }
            else
            {
                return;
            }
            
        }

        private void tl_alteralpasse_Click(object sender, EventArgs e)
        {
            new _AlterarPasse().ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
                new _Admin().ShowDialog();
            }
            else
            {
                return;
            }

        }

        private void tl_relatoriodosmorto_Click(object sender, EventArgs e)
        {
            new _Bloquear().ShowDialog();
        }

        private void tl_pesquisaM_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
                new _Tabelas().ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void tl_reciclagem_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
                new _Reciclagem().ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void tl_reiniciarBD_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
             new _ReiniciarBD().ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void tl_salvarBD_Click(object sender, EventArgs e)
        {
            if (DadosEditar.EditarDados.papelflong == "Administrador")
            {
                new _SalvarBD().ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void tl_relatorioFuncionario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tl_cadastrarMorto_Click(object sender, EventArgs e)
        {
             new _CadastrarMorto().ShowDialog();
        }

        private void tl_informacao_Click(object sender, EventArgs e)
        {
            new _Informacao().ShowDialog();
        }
    }
}
