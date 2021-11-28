using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaMortuaria.Model;
using CasaMortuaria.Bll;

namespace CasaMortuaria
{
    public partial class _Principal : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        string ano, mes, dia, dataMmor;
        string id_usu;
        #region Nenu Deslizante
        //==========================Control deslizante ====================================
        private static int[] dirmap = new int[] { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = new int[] { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        public enum Effect { Roll, Slide, Center, Blend }

        private static void AnimatePanel(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 020000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        //=====================================================================================
        #endregion
        public _Principal()
        {
            InitializeComponent();
            
            listarM();
            listarMs();
            
            lb_usuario.Text = DadosEditar.EditarDados.nome_flong;
            id_usu = Convert.ToString(DadosEditar.EditarDados.id_flong);

            
        }
        #region Dados para o grafico
        public void ContMF(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

         
            pessoaBll.contMF(pessoa);
            
            c_Mortos.Series["Homens"].Points.AddXY("Homens",DadosEditar.EditarDados.nM);
            c_Mortos.Series["Homens"].Points.AddXY("Mulheres",DadosEditar.EditarDados.nF);

        }

        public void ContMFs(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoaBll.contMFs(pessoa);

            c_Mortos.Series["Homens"].Points.AddXY("Homens sem Identidades", DadosEditar.EditarDados.nMs);
            c_Mortos.Series["Homens"].Points.AddXY("Mulheres sem Identidades", DadosEditar.EditarDados.nFs);

        }

        #endregion
        #region Dados do Morto
        #region Dados morto sem identidade
        private void excluirMs(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = Convert.ToInt32(txt_idMs.Text);
            pessoaBll.excluirMs(pessoa);

            MessageBox.Show(this, "O Morto foi Excluido com sucesso", "Arquivo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public void EditarMortos(mortoSem pessoa)
        {
            DateTime data1 = dt_datadamorteMs.Value;

            ano = data1.Year.ToString();
            mes = data1.Month.ToString();
            dia = data1.Day.ToString();

            dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;

            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = Convert.ToInt32(txt_idMs.Text.Trim());
            pessoa._sexo = cb_sexoMs.Text.Trim();
            pessoa._data_morte = dataMmor.Trim();
            pessoa._local_morte = txt_local_mortes.Text.Trim();
            pessoa._causa_morte = txt_causa_mortes.Text.Trim();
            pessoa._descr_morte = txt_desc_mortes.Text.Trim();
            pessoa.ano = ano;
            pessoa.mes = mes;
            pessoa.dia = dia;

            pessoaBll.EditarMortos(pessoa);

            MessageBox.Show(this, "O Morto foi Atualizado com sucesso", "Arquivo Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        #endregion
        private void consultarM()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_morto.DataSource = pessoaBll.consultarM(txt_pesquisarM.Text);
        }
        // metodo de a listar Morto
        private void listarM()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            dg_morto.DataSource = pessoaBLL.listarMorto();
            #region Dados da Coluna
            dg_morto.Columns[0].HeaderText = "NIM";
            dg_morto.Columns[0].Width = 100;
            dg_morto.Columns[1].HeaderText = "Nome";
            dg_morto.Columns[1].Width = 250;
            dg_morto.Columns[2].HeaderText = "NBI";
            dg_morto.Columns[2].Width = 120;
            dg_morto.Columns[3].HeaderText = "Natural";
            dg_morto.Columns[3].Width = 140;
            dg_morto.Columns[4].HeaderText = "Provincia";
            dg_morto.Columns[4].Width = 140;
            dg_morto.Columns[5].HeaderText = "Sexo";
            dg_morto.Columns[5].Width = 90;
            dg_morto.Columns[6].HeaderText = "Estado Civil";
            dg_morto.Columns[6].Width = 90;
            dg_morto.Columns[7].HeaderText = "Data Nasc";
            dg_morto.Columns[7].Width = 90;
            dg_morto.Columns[8].HeaderText = "Data Morte";
            dg_morto.Columns[8].Width = 90;
            dg_morto.Columns[9].HeaderText = "Data Cadastrada";
            dg_morto.Columns[9].Width = 110;
            dg_morto.Columns[10].Visible = false;
            dg_morto.Columns[11].Visible = false;
            dg_morto.Columns[12].Visible = false;
            dg_morto.Columns[13].Visible = false;
            dg_morto.Columns[14].Visible = false;
            #endregion
        }
        private void listarMs()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            dg_mortos.DataSource = pessoaBLL.listarMortos();
            #region Dados da Coluna
            dg_mortos.Columns[0].HeaderText = "NIM";
            dg_mortos.Columns[0].Width = 100;
            dg_mortos.Columns[1].HeaderText = "Sexo";
            dg_mortos.Columns[1].Width = 150;
            dg_mortos.Columns[2].HeaderText = "Data da Morte";
            dg_mortos.Columns[2].Width = 150;
            dg_mortos.Columns[3].HeaderText = "Data de Cadastro";
            dg_mortos.Columns[3].Width = 150;
            dg_mortos.Columns[4].Visible = false;
            dg_mortos.Columns[5].Visible = false;
            dg_mortos.Columns[6].Visible = false;
            dg_mortos.Columns[7].Visible = false;
            dg_mortos.Columns[8].Visible = false;
            dg_mortos.Columns[9].Visible = false;
            dg_mortos.Columns[10].Visible = false;
            dg_mortos.Columns[11].HeaderText = "ID do Funcinária";
            #endregion
        }
        private void verMortoscad()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_M_cadstra.DataSource = pessoaBll.listarMortoUsu(id_usu);
            #region Dados da Coluna
            dg_M_cadstra.Columns[0].Visible = false;
            dg_M_cadstra.Columns[1].HeaderText = "Nome";
            dg_M_cadstra.Columns[1].Width = 280;
            dg_M_cadstra.Columns[2].HeaderText = "NBI";
            dg_M_cadstra.Columns[2].Width = 130;
            dg_M_cadstra.Columns[3].Visible = false;
            dg_M_cadstra.Columns[4].Visible = false;
            dg_M_cadstra.Columns[5].HeaderText = "Sexo";
            dg_M_cadstra.Columns[5].Width = 90;
            dg_M_cadstra.Columns[6].Visible = false;
            dg_M_cadstra.Columns[7].Visible = false;
            dg_M_cadstra.Columns[8].Visible = false;
            dg_M_cadstra.Columns[9].Visible = false;
            dg_M_cadstra.Columns[10].Visible = false;
            dg_M_cadstra.Columns[11].Visible = false;
            dg_M_cadstra.Columns[12].Visible = false;
            dg_M_cadstra.Columns[13].Visible = false;
            dg_M_cadstra.Columns[14].Visible = false;
            #endregion
        }

        private void verMortoscadS()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos1.DataSource = pessoaBll.listarMortoUsuS(id_usu);
            #region Dados da Coluna
            dg_mortos1.Columns[0].HeaderText = "NIM";
            dg_mortos1.Columns[0].Width = 90;
            dg_mortos1.Columns[1].HeaderText = "Sexo";
            dg_mortos1.Columns[1].Width = 145;
            dg_mortos1.Columns[2].HeaderText = "Data da Morte";
            dg_mortos1.Columns[2].Width = 150;
            dg_mortos1.Columns[3].HeaderText = "Data de Cadastro";
            dg_mortos1.Columns[3].Width = 120;
            dg_mortos1.Columns[4].Visible = false;
            dg_mortos1.Columns[5].Visible = false;
            dg_mortos1.Columns[6].Visible = false;
            dg_mortos1.Columns[7].Visible = false;
            dg_mortos1.Columns[8].Visible = false;
            dg_mortos1.Columns[9].Visible = false;
            dg_mortos1.Columns[10].Visible = false;
            dg_mortos1.Columns[11].Visible = false;
            #endregion
        }

        // Metodo para pegar dados do morto para editar 
        public void pegarM(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarM(codigo);

            DadosEditar.EditarDados._codigo = codigo;

            DadosEditar.EditarDados.v = true;
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
        public void pegarMs(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarMs(codigo);

            txt_idMs.Text = pessoa.id_Morto.ToString();
            cb_sexoMs.Text = pessoa._sexo;
            dt_datadamorteMs.Text = pessoa._data_morte;
            txt_local_mortes.Text = pessoa._local_morte;
            txt_causa_mortes.Text = pessoa._causa_morte;
            txt_desc_mortes.Text = pessoa._descr_morte;
            picimgMs.ImageLocation = pessoa._img_morto;

        }

        // Metodo para pegar dados do pai para editar 
        public void pegarP(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarP(codigo);

            DadosEditar.EditarDados._nomePai = pessoa._nome_pai;
            DadosEditar.EditarDados._nomeMae = pessoa._nome_mae;
        }

        // Metodo para pegar dados do Esposso \ a para editar 
        public void pegarE(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarE(codigo);

            DadosEditar.EditarDados._nomeEs = pessoa._nome;
        }

        // Metodo para pegar dados da Causa da Morte
        public void pegarCM(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa = pessoaBll.pegarCM(codigo);

            DadosEditar.EditarDados._id_morto = pessoa.id_Morto;
            DadosEditar.EditarDados._local_morte = pessoa._local_morte;
            DadosEditar.EditarDados._causa_morte = pessoa._causa_morte;
            DadosEditar.EditarDados._descr_morte = pessoa._descr_morte;
        }

        public void atualizar()
        {
            #region Zerar Dados 
            DadosEditar.EditarDados.nM = 0;
            DadosEditar.EditarDados.nF = 0;
            DadosEditar.EditarDados.nMs = 0;
            DadosEditar.EditarDados.nFs = 0;

            DadosEditar.EditarDados.totalM = 0;
            DadosEditar.EditarDados.nM = 0;
            DadosEditar.EditarDados.nF = 0;
            DadosEditar.EditarDados.totalMs = 0;
            DadosEditar.EditarDados.nMs = 0;
            DadosEditar.EditarDados.nFs = 0;
            #endregion
            c_Mortos.Series.Clear();
            c_Mortos.Series.Add("Homens").Color = Color.Black;

            morto morto = new morto();
            mortoSem mortosem = new mortoSem();

            ContMF(morto);
            ContMFs(mortosem);
        }

        #endregion
        #region Morto Sem identidade
        private void mostraranos()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos.DataSource = pessoaBll.mostraranos(txt_ano.Text.Trim());
        }
        private void mostrarmess()
        {
            DadosEditar.EditarDados.anoms = txt_ano.Text.Trim();
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos.DataSource = pessoaBll.mostrarmess(txt_mes.Text.Trim());
        }
        private void mostrardias()
        {
            DadosEditar.EditarDados.anoms = txt_ano.Text.Trim();
            DadosEditar.EditarDados.mesms = txt_mes.Text.Trim();
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos.DataSource = pessoaBll.mostrardias(txt_dia.Text.Trim());
        }
        #endregion
        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lk_usuario_Click_1(object sender, EventArgs e)
        {
            ctm_usuario.Show(lk_usuario, 0, lk_usuario.Height);
        }

        private void lk_cadastrarM_Click(object sender, EventArgs e)
        {
            new _CadastrarMorto().ShowDialog();
        }

        private void lk_definicoes_Click(object sender, EventArgs e)
        {
            if (!pl_abrirmenu.Controls.Contains(_Menu.Instance))
            {
                pl_abrirmenu.Controls.Add(_Menu.Instance);
                _Menu.Instance.Dock = DockStyle.Fill;
                _Menu.Instance.BringToFront();
            }
            else
                _Menu.Instance.BringToFront();

            AnimatePanel(pl_abrirmenu, Effect.Roll, 900, 180);
            pl_abrirmenu.Visible = true;
            
            lk_definicoes.Visible = false;
            lk_voltar.Visible = true;
        }

        private void lk_voltar_Click(object sender, EventArgs e)
        {
            AnimatePanel(pl_abrirmenu, Effect.Roll, 200, 900);
            pl_abrirmenu.Visible = false;

            lk_voltar.Visible = false;
            lk_definicoes.Visible = true;
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _AlterarPasse().ShowDialog();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _Bloquear().ShowDialog();

        }

        private void dg_morto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigo = Convert.ToInt32(dg_morto.Rows[e.RowIndex].Cells[0].Value);

            morto morto = new morto();
            pegarM(morto);

            pais pais = new pais();
            pegarP(pais);

            EstadoCivil EstadoCivil = new EstadoCivil();
            pegarE(EstadoCivil);

            CausaMorte CausaMorte = new CausaMorte();
            pegarCM(CausaMorte);

            new _CadastrarMorto().ShowDialog();
        }

        private void terminarSesãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void _Principal_Load(object sender, EventArgs e)
        {
            morto morto = new morto();
            mortoSem mortosem = new mortoSem();
            ContMF(morto);
            ContMFs(mortosem);
            verMortoscad();
            verMortoscadS();


        }

        private void lk_Atualizar_Click(object sender, EventArgs e)
        {
            atualizar();
            listarM();
            listarMs();
            verMortoscad();
            verMortoscadS();
           
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            consultarM();
        }

        private void tp_atualizacao_Click(object sender, EventArgs e)
        {

        }

        private void txt_pesquisarM_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_ano_TextChanged(object sender, EventArgs e)
        {
            mostraranos();
        }

        private void txt_mes_TextChanged(object sender, EventArgs e)
        {
            mostrarmess();
        }

        private void txt_dia_TextChanged(object sender, EventArgs e)
        {
            mostrardias();
        }

        private void txt_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dg_mortos_SelectionChanged(object sender, EventArgs e)
        {
            this.codigo = Convert.ToInt32(dg_mortos.CurrentRow.Cells[0].Value);
            mortoSem mortosem = new mortoSem();
            pegarMs(mortosem);
        }

        private void lk_editarMs_Click(object sender, EventArgs e)
        {
            mortoSem mortosem = new mortoSem();
            EditarMortos(mortosem);
        }

        private void lk_eliminarMs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente Excluir esta pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                mortoSem mortosem = new mortoSem();
                excluirMs(mortosem);
            }
        }
    }
}
