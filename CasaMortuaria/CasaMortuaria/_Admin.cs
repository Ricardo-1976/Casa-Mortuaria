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
    public partial class _Admin : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public _Admin()
        {
            InitializeComponent();
            lb_nMs.Text = Convert.ToString(DadosEditar.EditarDados.totalM);
            lb_nHomem.Text = Convert.ToString(DadosEditar.EditarDados.nM);
            lb_nMulher.Text = Convert.ToString(DadosEditar.EditarDados.nF);
            lb_totalsi.Text = Convert.ToString(DadosEditar.EditarDados.totalMs);
            lb_Hsi.Text = Convert.ToString(DadosEditar.EditarDados.nMs);
            lb_Msi.Text = Convert.ToString(DadosEditar.EditarDados.nFs);
            listarM();
            listarMs();
        }
        #region Metodos para pegar dados 
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
        #endregion
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
            dg_morto.Columns[3].Visible = false;
            dg_morto.Columns[4].Visible = false;
            dg_morto.Columns[5].HeaderText = "Sexo";
            dg_morto.Columns[5].Width = 90;
            dg_morto.Columns[6].Visible = false;
            dg_morto.Columns[7].HeaderText = "Data Nasc";
            dg_morto.Columns[7].Width = 90;
            dg_morto.Columns[8].HeaderText = "Data Morte";
            dg_morto.Columns[8].Width = 90;
            dg_morto.Columns[9].Visible = false;
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
        #region Mortos com identidade
        private void mostrarano()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_morto.DataSource = pessoaBll.mostrarano(txt_ano.Text.Trim());
        }
        private void mostrarmes()
        {
            DadosEditar.EditarDados.anom = txt_ano.Text.Trim();
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_morto.DataSource = pessoaBll.mostrarmes(txt_mes.Text.Trim());
        }
        private void mostrardia()
        {
            DadosEditar.EditarDados.anom = txt_ano.Text.Trim();
            DadosEditar.EditarDados.mesm = txt_mes.Text.Trim();
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_morto.DataSource = pessoaBll.mostrardia(txt_dia.Text.Trim());
        }
        public void Contano(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.ano = txt_ano.Text;

            pessoaBll.contano(pessoa);

            lb_homemano.Text = Convert.ToString(DadosEditar.EditarDados.NMM);
            lb_Mulherano.Text = Convert.ToString(DadosEditar.EditarDados.NMF);
            int result = (DadosEditar.EditarDados.NMM) + (DadosEditar.EditarDados.NMF);
            lb_totalano.Text = result.ToString();
                

        }
        public void Contmes(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.ano = txt_ano.Text;
            pessoa.mes = txt_mes.Text;

            pessoaBll.contmes(pessoa);

            lb_Hm.Text = Convert.ToString(DadosEditar.EditarDados.NMMm);
            lb_Mm.Text = Convert.ToString(DadosEditar.EditarDados.NMFm);
            int result = (DadosEditar.EditarDados.NMMm) + (DadosEditar.EditarDados.NMFm);
            lb_totalmes.Text = result.ToString();


        }
        public void Contdia(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.ano = txt_ano.Text;
            pessoa.mes = txt_mes.Text;
            pessoa.dia = txt_dia.Text;

            pessoaBll.contdia(pessoa);

            lb_Hd.Text = Convert.ToString(DadosEditar.EditarDados.NMMd);
            lb_Md.Text = Convert.ToString(DadosEditar.EditarDados.NMFd);
            int result = (DadosEditar.EditarDados.NMMd) + (DadosEditar.EditarDados.NMFd);
            lb_totaldia.Text = result.ToString();


        }
        #endregion
        #region Morto Sem Identidade
        public void Contanos(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.ano = txt_anos.Text;

            pessoaBll.contanos(pessoa);

            lb_Homems.Text = Convert.ToString(DadosEditar.EditarDados.NMMs);
            lb_Mulheres.Text = Convert.ToString(DadosEditar.EditarDados.NMFs);
            int result = (DadosEditar.EditarDados.NMMs) + (DadosEditar.EditarDados.NMFs);
            lb_totalanos.Text = result.ToString();


        }
        public void Contmess(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.ano = txt_anos.Text;
            pessoa.mes = txt_mess.Text;

            pessoaBll.contmess(pessoa);

            lb_Hms.Text = Convert.ToString(DadosEditar.EditarDados.NMMms);
            lb_Mms.Text = Convert.ToString(DadosEditar.EditarDados.NMFms);
            int result = (DadosEditar.EditarDados.NMMms) + (DadosEditar.EditarDados.NMFms);
            lb_totalmess.Text = result.ToString();


        }
        public void Contdias(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.ano = txt_anos.Text;
            pessoa.mes = txt_mess.Text;
            pessoa.dia = txt_dias.Text;

            pessoaBll.contdias(pessoa);

            lb_Hds.Text = Convert.ToString(DadosEditar.EditarDados.NMMds);
            lb_Mds.Text = Convert.ToString(DadosEditar.EditarDados.NMFds);
            int result = (DadosEditar.EditarDados.NMMds) + (DadosEditar.EditarDados.NMFds);
            lb_totaldias.Text = result.ToString();

        }

        private void mostraranos()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos.DataSource = pessoaBll.mostraranos(txt_anos.Text.Trim());
        }
        private void mostrarmess()
        {
            DadosEditar.EditarDados.anoms = txt_anos.Text.Trim();
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos.DataSource = pessoaBll.mostrarmess(txt_mess.Text.Trim());
        }
        private void mostrardias()
        {
            DadosEditar.EditarDados.anoms = txt_anos.Text.Trim();
            DadosEditar.EditarDados.mesms = txt_mess.Text.Trim();
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_mortos.DataSource = pessoaBll.mostrardias(txt_dias.Text.Trim());
        }
        #endregion

        private void lk_sair_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void txt_ano_TextChanged(object sender, EventArgs e)
        {
            morto morto = new morto();
            Contano(morto);
            lb_ano.Text = txt_ano.Text.Trim();
            mostrarano();
            DadosEditar.EditarDados.NMF = 0;
            DadosEditar.EditarDados.NMM = 0;
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

        private void txt_mes_TextChanged(object sender, EventArgs e)
        {
            morto morto = new morto();
            Contmes(morto);
            lbanom.Text = txt_ano.Text.Trim();
            lb_mes.Text = txt_mes.Text.Trim();
            mostrarmes();
            DadosEditar.EditarDados.NMFm = 0;
            DadosEditar.EditarDados.NMMm = 0;
        }

        private void txt_dia_TextChanged(object sender, EventArgs e)
        {
            morto morto = new morto();
            Contdia(morto);
            lb_dia.Text = txt_dia.Text.Trim();
            lb_mesd.Text = txt_mes.Text.Trim();
            lb_anod.Text = txt_ano.Text.Trim();
            mostrardia();
            DadosEditar.EditarDados.NMFd= 0;
            DadosEditar.EditarDados.NMMd = 0;
        }

        private void txt_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void metroLink12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_anos_TextChanged(object sender, EventArgs e)
        {
            mortoSem morto = new mortoSem();
            Contanos(morto);
            lb_anos.Text = txt_anos.Text.Trim();
            mostraranos();
            DadosEditar.EditarDados.NMFs = 0;
            DadosEditar.EditarDados.NMMs = 0;
        }

        private void txt_mess_TextChanged(object sender, EventArgs e)
        {
            mortoSem morto = new mortoSem();
            Contmess(morto);
            lb_anosm.Text = txt_anos.Text.Trim();
            lb_mess.Text = txt_mess.Text.Trim();
            mostrarmess();
            DadosEditar.EditarDados.NMFms = 0;
            DadosEditar.EditarDados.NMMms = 0;
        }

        private void txt_dias_TextChanged(object sender, EventArgs e)
        {
            mortoSem morto = new mortoSem();
            Contdias(morto);
            lb_dias.Text = txt_dias.Text.Trim();
            lb_mesds.Text = txt_mess.Text.Trim();
            lb_anods.Text = txt_anos.Text.Trim();
            mostrardias();
            DadosEditar.EditarDados.NMFds = 0;
            DadosEditar.EditarDados.NMMds = 0;
        }
    }
}
