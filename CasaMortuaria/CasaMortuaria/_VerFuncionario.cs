using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaMortuaria.Model;
using CasaMortuaria.Bll;

namespace CasaMortuaria
{
    public partial class _VerFuncionario : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public _VerFuncionario()
        {
            InitializeComponent();
            listar();
        }

        // metodo de a listar Funcionario 
        private void listar()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            gd_F.DataSource = pessoaBLL.listarUsu();
            #region Dados da colunas 
            gd_F.Columns[0].HeaderText = "NIF";
            gd_F.Columns[0].Width = 80;
            gd_F.Columns[1].HeaderText = "Nome";
            gd_F.Columns[1].Width = 230;
            gd_F.Columns[2].HeaderText = "NBI";
            gd_F.Columns[2].Width = 110;
            gd_F.Columns[3].HeaderText = "Sexo";
            gd_F.Columns[3].Width = 110;
            gd_F.Columns[4].HeaderText = "Data Nas";
            gd_F.Columns[4].Width = 110;
            gd_F.Columns[5].Visible = false;
            gd_F.Columns[6].Visible = false;
            gd_F.Columns[7].HeaderText = "Telefone";
            gd_F.Columns[7].Width = 80;
            gd_F.Columns[8].HeaderText = "Papel";
            gd_F.Columns[8].Width = 95;
            gd_F.Columns[9].Visible = false;
            #endregion
        }
        // Metodo para pegar dados do Usuario
        public void pegarUs(Usuario pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarUs(codigo);

            DadosEditar.EditarDados.v = true;

            DadosEditar.EditarDados.id_fun = pessoa.id_usuario.ToString();
            DadosEditar.EditarDados._nomeF = pessoa._nome;
            DadosEditar.EditarDados._nbiF = pessoa._nbi;
            DadosEditar.EditarDados._sexoF = pessoa._sexo;
            DadosEditar.EditarDados._dataF = pessoa._data_nascimento;
            DadosEditar.EditarDados._emailF = pessoa._email;
            DadosEditar.EditarDados._senhaF = pessoa._senha;
            DadosEditar.EditarDados._telefoneF = pessoa._telefone;
            DadosEditar.EditarDados._papelF = pessoa._papel;
            DadosEditar.EditarDados._imgF = pessoa._img;
        }

        // Meto para consultar um registro
        private void consultarF()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            gd_F.DataSource = pessoaBll.consultarF(txt_pesquisar.Text);
        }
        
        private void metroLink1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gd_F_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigo = Convert.ToInt32(gd_F.Rows[e.RowIndex].Cells[0].Value);

            Usuario Usuario = new Usuario();
            pegarUs(Usuario);

            _CadastrarFuncionario cadastrarfuncionario = new _CadastrarFuncionario();
            cadastrarfuncionario.ShowDialog();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            _CadastrarFuncionario CadastrarFuncionario = new _CadastrarFuncionario();
            CadastrarFuncionario.ShowDialog();
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            consultarF();
        }

        private void txt_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void lk_Atualizar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
