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
    public partial class _Reciclagem : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public _Reciclagem()
        {
            InitializeComponent();
            listarrecUsu();
            listarMortorec();
        }
        #region Dados funcioários
        // metodo de a listar Funcionario 
        private void listarrecUsu()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            gd_rec_f.DataSource = pessoaBLL.listarRecUsu();
            #region Dados da colunas 
            gd_rec_f.Columns[0].HeaderText = "NIF";
            gd_rec_f.Columns[0].Width = 80;
            gd_rec_f.Columns[1].HeaderText = "Nome";
            gd_rec_f.Columns[1].Width = 230;
            gd_rec_f.Columns[2].HeaderText = "NBI";
            gd_rec_f.Columns[2].Width = 95;
            gd_rec_f.Columns[3].HeaderText = "Sexo";
            gd_rec_f.Columns[3].Width = 100;
            gd_rec_f.Columns[4].HeaderText = "Data Nas";
            gd_rec_f.Columns[4].Width = 100;
            gd_rec_f.Columns[5].Visible = false;
            gd_rec_f.Columns[6].Visible = false;
            gd_rec_f.Columns[7].HeaderText = "Telefone";
            gd_rec_f.Columns[7].Width = 80;
            gd_rec_f.Columns[8].HeaderText = "Papel";
            gd_rec_f.Columns[8].Width = 90;
            gd_rec_f.Columns[9].Visible = false;
            #endregion
        }


        // Metodo para pegar dados do Usuario
        public void PegarRecF(Usuario pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.PegarRecF(codigo);

            

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
        private void consultarRecF()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            gd_rec_f.DataSource = pessoaBll.consultarRecF(txt_pesquisar_rec.Text);
        }
        #endregion

        #region Dados do morto

        // metodo de a listar Funcionario 
        private void listarMortorec()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            dg_Mortorec.DataSource = pessoaBLL.listarMortorec();
            #region Dados da colunas 

            dg_Mortorec.Columns[0].HeaderText = "NIM";
            dg_Mortorec.Columns[1].HeaderText = "Nome";
            dg_Mortorec.Columns[1].Width = 200;
            dg_Mortorec.Columns[2].HeaderText = "NBI";
            dg_Mortorec.Columns[3].HeaderText = "Natural";
            dg_Mortorec.Columns[4].HeaderText = "Provincia";
            dg_Mortorec.Columns[5].HeaderText = "Sexo";
            dg_Mortorec.Columns[6].Visible = false;
            dg_Mortorec.Columns[7].HeaderText = "Data NAsc";
            dg_Mortorec.Columns[8].HeaderText = "Data Morte";
            dg_Mortorec.Columns[9].Visible = false;
            dg_Mortorec.Columns[10].Visible = false;


            #endregion
        }

        // Meto para consultar um registro
        private void consultarRecM()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_Mortorec.DataSource = pessoaBll.consultarRecM(txt_pesquisar_rec.Text);
        }

        //========================================================

        // Metodo para pegar dados do morto para editar 
        public void pegarMrec(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarMrec(codigo);

            DadosEditar.EditarDados._codigo = codigo;

            DadosEditar.EditarDados.id_morto = pessoa.id_Morto.ToString();
            DadosEditar.EditarDados._nomeM = pessoa._nome;
            DadosEditar.EditarDados._nbiM = pessoa._nbi;
            DadosEditar.EditarDados._naturalM = pessoa._natural;
            DadosEditar.EditarDados._provinciaM = pessoa._provincia;
            DadosEditar.EditarDados._sexoM = pessoa._sexo;
            DadosEditar.EditarDados._estadocivilM = pessoa._esta_civil;
            DadosEditar.EditarDados._datanascimentoM = pessoa._data_nascimento;
            DadosEditar.EditarDados._datamorteM = pessoa._data_morte;
            DadosEditar.EditarDados._imgmortoM = pessoa._img_morto;

        }

        // Metodo para pegar dados do pai para editar 
        public void pegarPrec(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarPrec(codigo);

            DadosEditar.EditarDados._nomePai = pessoa._nome_pai;
            DadosEditar.EditarDados._nomeMae = pessoa._nome_mae;
        }

        // Metodo para pegar dados do Esposso \ a para editar 
        public void pegarErec(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarErec(codigo);

            DadosEditar.EditarDados._nomeEs = pessoa._nome;
        }

        // Metodo para pegar dados da Causa da Morte
        public void pegarCMrec(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarCMrec(codigo);

            DadosEditar.EditarDados._id_morto = pessoa.id_Morto;
            DadosEditar.EditarDados._local_morte = pessoa._local_morte;
            DadosEditar.EditarDados._causa_morte = pessoa._causa_morte;
            DadosEditar.EditarDados._descr_morte = pessoa._descr_morte;
        }

        #endregion
        private void lk_sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void gd_rec_f_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigo = Convert.ToInt32(gd_rec_f.Rows[e.RowIndex].Cells[0].Value);
            
            Usuario Usuario = new Usuario();
            PegarRecF(Usuario);

            DadosEditar.EditarDados.v1 = 2;

            new _CadastrarFuncionario().ShowDialog();
        }

        private void txt_pesquisar_rec_TextChanged(object sender, EventArgs e)
        {
            consultarRecM();
            consultarRecF();
        }

        private void dg_Mortorec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigo = Convert.ToInt32(dg_Mortorec.Rows[e.RowIndex].Cells[0].Value);

            morto morto = new morto();
            pegarMrec(morto);

            pais pais = new pais();
            pegarPrec(pais);

            EstadoCivil EstadoCivil = new EstadoCivil();
            pegarErec(EstadoCivil);

            CausaMorte CausaMorte = new CausaMorte();
            pegarCMrec(CausaMorte);


            DadosEditar.EditarDados.v2 = 3;

            new _CadastrarMorto().ShowDialog();
        }

        private void lk_Atualizar_Click(object sender, EventArgs e)
        {
            listarrecUsu();
            listarMortorec();
        }

        private void txt_pesquisar_rec_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
