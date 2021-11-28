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
using MetroFramework;

namespace CasaMortuaria
{
    public partial class _CadastrarMorto : MetroFramework.Forms.MetroForm
    {
        string dataMnas, dataMmor, imgM;
        int op,qtdF,cod;
        string ano, mes, dia;
        public _CadastrarMorto()
        {
            InitializeComponent();

            #region Pegar dados 

            if (DadosEditar.EditarDados.v == true)
            {
                btn_excluir.Visible = false;
                lk_salvarM.Visible = false;
                lk_editarM.Visible = true;
                lk_excluirM.Visible = true;
                lk_id_filho.Visible = true;
                txt_qtd_filhos.Visible = false;
                btn_qtd_Filhos.Visible = false;
                txt_idM_F.Visible = true;
                txt_nome_F.Visible = true;
                txt_id_filho.Visible = true;
                btn_guarda.Visible = false;
                btn_editar.Visible = true;
                btn_editar.Enabled = false;
                btn_cancelar.Visible = true;
                txt_local_morte.Enabled = true;
                txt_causa_morte.Enabled = true;
                txt_desc_morte.Enabled = true;
                btn_Salvar_CM.Visible = false;
                btn_editarCM.Visible = true;
                btn_cancelar_CM.Enabled = true;
                metroLabel1.Visible = false;
                txt_qtd_filhos.Visible = false;
                metroLabel13.Visible = true;
                metroLabel14.Visible = true;
                // Dados do Morto 
                txt_idM.Text = DadosEditar.EditarDados.id_morto;
                txt_nomeM.Text = DadosEditar.EditarDados._nomeM;
                txt_nbiM.Text = DadosEditar.EditarDados._nbiM;
                txt_naturalM.Text = DadosEditar.EditarDados._naturalM;
                txt_provinciaM.Text = DadosEditar.EditarDados._provinciaM;
                cb_sexoM.Text = DadosEditar.EditarDados._sexoM;
                cb_estadocivilM.Text = DadosEditar.EditarDados._estadocivilM;
                dt_nascimentoM.Text = DadosEditar.EditarDados._datanascimentoM;
                dt_datadamorteM.Text = DadosEditar.EditarDados._datamorteM;
                picimgM.ImageLocation = DadosEditar.EditarDados._imgmortoM;

                imgM = DadosEditar.EditarDados._imgmortoM;

                // Dados dos Pais 
                txt_PaiM.Text = DadosEditar.EditarDados._nomePai;
                txt_MaeM.Text = DadosEditar.EditarDados._nomeMae;
                // Dados do Esposso \ a
                txt_esposo_a.Text = DadosEditar.EditarDados._nomeEs;
                // Dados dos filhos 
                PegarF();
                // Dados da Causa da Morte
                txt_id_CM.Text = DadosEditar.EditarDados._id_morto;
                txt_local_morte.Text = DadosEditar.EditarDados._local_morte;
                txt_causa_morte.Text = DadosEditar.EditarDados._causa_morte;
                txt_desc_morte.Text = DadosEditar.EditarDados._descr_morte;
            }
            DadosEditar.EditarDados.v = false;
            #endregion

            #region Pegar dados da reciclagem

            if (DadosEditar.EditarDados.v2 == 3)
            {
                lk_restauraM.Visible = true;
                btn_salvarSis.Visible = true;
                btn_salvarSis.Enabled = false;
                lk_excluirRec.Visible = true;
                lk_salvarM.Visible = false;
                lk_editarM.Visible = false;
                lk_excluirM.Visible = false;
                lk_id_filho.Visible = true;
                txt_qtd_filhos.Visible = false;
                btn_qtd_Filhos.Visible = false;
                txt_idM_F.Visible = true;
                txt_nome_F.Visible = true;
                txt_id_filho.Visible = true;
                btn_guarda.Visible = false;
                btn_editar.Visible = false;
                btn_editar.Enabled = false;
                btn_cancelar.Visible = false; ;
                txt_local_morte.Enabled = true;
                txt_causa_morte.Enabled = true;
                txt_desc_morte.Enabled = true;
                btn_Salvar_CM.Visible = false;
                btn_editarCM.Visible = false;
                btn_cancelar_CM.Visible = false;
                metroLabel1.Visible = false;
                txt_qtd_filhos.Visible = false;
                metroLabel13.Visible = true;
                metroLabel14.Visible = true;
                btn_excluir.Visible = false;
                // Dados do Morto 
                txt_idM.Text = DadosEditar.EditarDados.id_morto;
                txt_nomeM.Text = DadosEditar.EditarDados._nomeM;
                txt_nbiM.Text = DadosEditar.EditarDados._nbiM;
                txt_naturalM.Text = DadosEditar.EditarDados._naturalM;
                txt_provinciaM.Text = DadosEditar.EditarDados._provinciaM;
                cb_sexoM.Text = DadosEditar.EditarDados._sexoM;
                cb_estadocivilM.Text = DadosEditar.EditarDados._estadocivilM;
                dt_nascimentoM.Text = DadosEditar.EditarDados._datanascimentoM;
                dt_datadamorteM.Text = DadosEditar.EditarDados._datamorteM;
                picimgM.ImageLocation = DadosEditar.EditarDados._imgmortoM;

                imgM = DadosEditar.EditarDados._imgmortoM;

                // Dados dos Pais 
                txt_PaiM.Text = DadosEditar.EditarDados._nomePai;
                txt_MaeM.Text = DadosEditar.EditarDados._nomeMae;
                // Dados do Esposso \ a
                txt_esposo_a.Text = DadosEditar.EditarDados._nomeEs;
                // Dados dos filhos 
                PegarFrec();
                // Dados da Causa da Morte
                txt_id_CM.Text = DadosEditar.EditarDados._id_morto;
                txt_local_morte.Text = DadosEditar.EditarDados._local_morte;
                txt_causa_morte.Text = DadosEditar.EditarDados._causa_morte;
                txt_desc_morte.Text = DadosEditar.EditarDados._descr_morte;

                DadosEditar.EditarDados.v2 = 0;
            }
            
            #endregion

        }
        #region dados morto
        #region Metodo para pegar dados dos Filhos para editar

        private void PegarFrec()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_filhos.DataSource = pessoaBll.PegarFrec(Convert.ToInt32( DadosEditar.EditarDados._codigo));
            dg_filhos.Columns[0].HeaderText = "NIF";
            dg_filhos.Columns[1].HeaderText = "Nome";
            dg_filhos.Columns[1].Width = 400;
            dg_filhos.Columns[2].HeaderText = "NIM";

        }
        private void PegarF()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_filhos.DataSource = pessoaBll.PegarF(DadosEditar.EditarDados._codigo);
            dg_filhos.Columns[0].HeaderText = "NIF";
            dg_filhos.Columns[1].HeaderText = "Nome";
            dg_filhos.Columns[1].Width = 400;
            dg_filhos.Columns[2].HeaderText = "NIM";

        }
        private void PegarFG()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_filhos.DataSource = pessoaBll.PegarFG(DadosEditar.EditarDados.id_PEFC);
            dg_filhos.Columns[0].HeaderText = "NIF";
            dg_filhos.Columns[1].HeaderText = "Nome";
            dg_filhos.Columns[1].Width = 400;
            dg_filhos.Columns[2].HeaderText = "NIM";
        }

        private void PegarFE()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_filhos.DataSource = pessoaBll.PegarFG(DadosEditar.EditarDados.id_MPE);
            dg_filhos.Columns[0].HeaderText = "NIF";
            dg_filhos.Columns[1].HeaderText = "Nome";
            dg_filhos.Columns[1].Width = 400;
            dg_filhos.Columns[2].HeaderText = "NIM";
        }

        private void PegarFER()
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            dg_filhos.DataSource = pessoaBll.PegarFrec(cod);
            dg_filhos.Columns[0].HeaderText = "NIF";
            dg_filhos.Columns[1].HeaderText = "Nome";
            dg_filhos.Columns[1].Width = 400;
            dg_filhos.Columns[2].HeaderText = "NIM";
        }

        #endregion
        #region Metodo para Excluir Morto
        private void excluirM(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = Convert.ToInt32(txt_idM.Text);
            pessoaBll.excluirM(pessoa);

            DadosEditar.EditarDados.id_MPE = Convert.ToInt32(txt_idM.Text);

            MessageBox.Show(this, "O Morte foi Excluido com sucesso", "Arquivo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void excluirP(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirP(pessoa);

        }
        private void excluirE(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirE(pessoa);

        }
        private void excluirF(Filhos pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Filhos =Convert.ToInt32(txt_id_filho.Text);

            pessoaBll.excluirF(pessoa);

        }
        private void excluirCM(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirCM(pessoa);

        }

        //===================================================

        private void excluirrecM(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = Convert.ToInt32(txt_idM.Text);
            pessoaBll.excluirrecM(pessoa);

            MessageBox.Show(this, "O Morte foi Excluido com sucesso", "Arquivo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
        private void excluirrecP(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirrecP(pessoa);

        }
        private void excluirrecE(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirrecE(pessoa);

        }
        private void excluirrecF(Filhos pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Filhos = Convert.ToInt32(txt_id_filho.Text);

            pessoaBll.excluirrecF(pessoa);
            MessageBox.Show(this, "O Filho foi Excluido com sucesso", "Arquivo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void excluirFR(Filhos pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirFR(pessoa);

        }
        private void excluirrecCM(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Morto = txt_idM.Text;

            pessoaBll.excluirrecCM(pessoa);


        }

        #endregion

        #region Salvar Morto na reciclagem 

        //Metodo pra salvar na reciclagem
        public void salvarMortoRec(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._nome = txt_nomeM.Text.Trim();
            pessoa._nbi = txt_nbiM.Text.Trim();
            pessoa._natural = txt_naturalM.Text.Trim();
            pessoa._provincia = txt_provinciaM.Text.Trim();
            pessoa._sexo = cb_sexoM.Text.Trim();
            pessoa._esta_civil = cb_estadocivilM.Text.Trim();
            pessoa._data_nascimento = dataMnas;
            pessoa._data_morte = dataMmor;
            pessoa._img_morto = imgM;

            pessoaBll.salvarMortoRec(pessoa);




        }

        // Metodo para Salvar Pais na reciclagem
        public void salvarPRec(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            if (txt_PaiM.Text != string.Empty || txt_MaeM.Text != string.Empty)
            {
                pessoa._nome_pai = txt_PaiM.Text.Trim();
                pessoa._nome_mae = txt_MaeM.Text.Trim();
                pessoa.id_Morto = DadosEditar.EditarDados.IdMrec.ToString();

                pessoaBll.salvarpaisRec(pessoa);

            }
            
        }

        // Metodo para Salvar Causa da Morte
        public void salvarCMRec(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            if (txt_local_morte.Text != string.Empty)
            {
                pessoa._local_morte = txt_local_morte.Text.Trim();
                pessoa._causa_morte = txt_causa_morte.Text.Trim();
                pessoa._descr_morte = txt_desc_morte.Text.Trim();
                pessoa.id_Morto = DadosEditar.EditarDados.IdMrec.ToString();

                pessoaBll.salvarCausaMorteRec(pessoa);

            }
            
        }

        // Metodo para Salvar Filhos na reciclagem
        public void salvarFiRec(Filhos pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();
           
            pessoa._nome = txt_nome_F.Text.Trim();
            pessoa.id_Morto = DadosEditar.EditarDados.IdMrec.ToString();

            pessoaBll.salvarFilhosRec(pessoa);


        }

        // Metodo para Salvar Esposso\a na reciclagem
        public void salvarERec(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            if (txt_esposo_a.Text != string.Empty)
            {
                pessoa._nome = txt_esposo_a.Text.Trim();
                pessoa.id_Morto = DadosEditar.EditarDados.IdMrec.ToString();

                pessoaBll.salvarEstadoCivilRec(pessoa);

            }
            
        }

        // Metodo para pegar id do morto na reciclagem
        public void pegarIdMRec(morto pessoa)
        {
            DadosEditar.EditarDados.nbi_morto = txt_nbiM.Text;

            pessoaBLL pessoaBll = new pessoaBLL();
            pessoaBll.pegarIdMRec(pessoa);

        }

        #endregion
        public void salvarM(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._nome = txt_nomeM.Text.Trim();
            pessoa._nbi = txt_nbiM.Text.Trim();
            pessoa._natural = txt_naturalM.Text.Trim();
            pessoa._provincia = txt_provinciaM.Text.Trim();
            pessoa._sexo = cb_sexoM.Text.Trim();
            pessoa._esta_civil = cb_estadocivilM.Text.Trim();
            pessoa._data_nascimento = dataMnas.Trim();
            pessoa._data_morte = dataMmor.Trim();
            pessoa._img_morto = imgM;
            pessoa.ano = ano;
            pessoa.mes = mes;
            pessoa.dia = dia;
            pessoa.id_Usuario =Convert.ToString(DadosEditar.EditarDados.id_flong);

            pessoaBll.salvarMorto(pessoa);

            MessageBox.Show(this, "O Morto foi Salvo com sucesso", "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txt_local_morte.Enabled = true;
            txt_causa_morte.Enabled = true;
            txt_qtd_filhos.Enabled = true;
            txt_desc_morte.Enabled = true;
            btn_Salvar_CM.Enabled = true;
            btn_cancelar_CM.Enabled = true;
            btn_qtd_Filhos.Enabled = true;

        }

        public void salvarMSem(mortoSem pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            
            pessoa._sexo = cb_sexoM.Text.Trim();
            pessoa._data_morte = dataMmor.Trim();
            pessoa._local_morte = txt_local_morte.Text.Trim();
            pessoa._causa_morte = txt_causa_morte.Text.Trim();
            pessoa._descr_morte = txt_desc_morte.Text.Trim();
            pessoa._img_morto = imgM;
            pessoa.ano = ano;
            pessoa.mes = mes;
            pessoa.dia = dia;
            pessoa.id_Usuario = Convert.ToString(DadosEditar.EditarDados.id_flong);

            pessoaBll.salvarSemMorto(pessoa);

            MessageBox.Show(this, "O Morto foi Salvo com sucesso", "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        // Metodo para Editarr Morto
        public void EditarMorto(morto pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();
            
            pessoa.id_Morto = Convert.ToInt32(txt_idM.Text.Trim());
            pessoa._nome = txt_nomeM.Text.Trim();
            pessoa._nbi = txt_nbiM.Text.Trim();
            pessoa._natural = txt_naturalM.Text.Trim();
            pessoa._provincia = txt_provinciaM.Text.Trim();
            pessoa._sexo = cb_sexoM.Text.Trim();
            pessoa._esta_civil = cb_estadocivilM.Text.Trim();
            pessoa._data_nascimento = dataMnas.Trim();
            pessoa._data_morte = dataMmor.Trim();
            pessoa._img_morto = imgM;
            pessoa.ano = ano;
            pessoa.mes = mes;
            pessoa.dia = dia;

            pessoaBll.EditarMorto(pessoa);

            MessageBox.Show(this, "O Morto foi Atualizado com sucesso", "Arquivo Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Metodo para Salvar Esposso\a
        public void salvarE(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._nome = txt_esposo_a.Text.Trim();
            pessoa.id_Morto = DadosEditar.EditarDados.id_PEFC.ToString();

            pessoaBll.salvarEstadoCivil(pessoa);

        }

        // Metodo para Editar Pais
        public void Editarpais(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Pais = DadosEditar.EditarDados.id_pais;
            pessoa._nome_pai = txt_PaiM.Text.Trim();
            pessoa._nome_mae = txt_MaeM.Text.Trim();

            pessoaBll.Editarpais(pessoa);

        }

        // Metodo para Editar Filhos
        public void Editarfilho(Filhos pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_Filhos = Convert.ToInt32(txt_id_filho.Text);
            pessoa._nome = txt_nome_F.Text.Trim();

            pessoaBll.Editarfilho(pessoa);

        
            MessageBox.Show(this, "O filho foi Atualizado com sucesso ", "Arquivo Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        // Metodo para Editar CausaMorte
        public void EditarCausaMorte(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_CausaMorte = DadosEditar.EditarDados.id_causamorte;

            pessoa._local_morte = txt_local_morte.Text.Trim();
            pessoa._causa_morte = txt_causa_morte.Text.Trim();
            pessoa._descr_morte = txt_desc_morte.Text.Trim();

            pessoaBll.EditarCausaMorte(pessoa);
            MessageBox.Show(this, "A Causa da Morte foi Atualizado com sucesso", "Arquivo Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        // Metodo para pegar id do morto
        public void pegarIdM(morto pessoa)
        {
            DadosEditar.EditarDados.nbi_morto = txt_nbiM.Text;

            pessoaBLL pessoaBll = new pessoaBLL();
            pessoaBll.pegarIdM(pessoa);

            txt_idM_F.Text = DadosEditar.EditarDados.id_PEFC.ToString();
            txt_id_CM.Text = DadosEditar.EditarDados.id_PEFC.ToString();
        }

        // Metodo permitir cadastrar morto
        public void permiM(morto pessoa)
        {
            DadosEditar.EditarDados.nbi_morto = txt_nbiM.Text;

            pessoaBLL pessoaBll = new pessoaBLL();
            pessoaBll.permiM(pessoa);

        }

        // Metodo para Limpar campos
        public void limparcampoM()
        {

            txt_idM.Text = string.Empty;
            txt_nomeM.Text = string.Empty;
            txt_nbiM.Text = (0).ToString();
            txt_PaiM.Text = string.Empty;
            txt_MaeM.Text = string.Empty;
            txt_provinciaM.Text = string.Empty;
            txt_naturalM.Text = string.Empty;
            txt_esposo_a.Text = string.Empty;
            cb_estadocivilM.Text = string.Empty; 
            cb_sexoM.Text = string.Empty;
            dt_nascimentoM.Text = string.Empty;
            dt_datadamorteM.Text = string.Empty;
            picimgM.ImageLocation = string.Empty;
        }

        //Limpar Filho
        public void limparF()
        {
            txt_nome_F.Text = string.Empty;
            
        }
        //Limpar Causa da morte
        public void limparCM()
        {
            txt_id_CM.Text = string.Empty;
            txt_local_morte.Text = string.Empty;
            txt_causa_morte.Text = string.Empty;
            txt_desc_morte.Text = string.Empty;
        }
        // Metodo para Salvar Pais
        public void salvarP(pais pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._nome_pai = txt_PaiM.Text.Trim();
            pessoa._nome_mae = txt_MaeM.Text.Trim();
            pessoa.id_Morto = DadosEditar.EditarDados.id_PEFC.ToString();

            pessoaBll.salvarpais(pessoa);

        }
        
        // Metodo para Salvar Filhos
        public void salvarFi(Filhos pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._nome = txt_nome_F.Text.Trim();
            pessoa.id_Morto = DadosEditar.EditarDados.id_PEFC.ToString();

            pessoaBll.salvarFilhos(pessoa);

            MessageBox.Show(this, "Filhos foi salvo com sucesso", "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Metodo para Salvar Causa da Morte
        public void salvarCM(CausaMorte pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._local_morte = txt_local_morte.Text.Trim();
            pessoa._causa_morte = txt_causa_morte.Text.Trim();
            pessoa._descr_morte = txt_desc_morte.Text.Trim();
            pessoa.id_Morto = DadosEditar.EditarDados.id_PEFC.ToString();

            pessoaBll.salvarCausaMorte(pessoa);

            MessageBox.Show(this, "Causa da Morte foi salvo com sucesso", "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        // Metodo para Editar Esposso\a
        public void EditarEstadoCivil(EstadoCivil pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_EstadoCivil = DadosEditar.EditarDados.id_esposo1;
            pessoa._nome = txt_esposo_a.Text.Trim();
            
            pessoaBll.EditarEstadoCivil(pessoa);

        }
        #endregion
        private void lk_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lk_excluirM_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Deseja realmente Excluir esta pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                
            

            DadosEditar.EditarDados.MostF = Convert.ToInt32(txt_idM.Text);
            DateTime data = dt_nascimentoM.Value;
            DateTime datav = metroDateTime1.Value;
            DateTime data1 = dt_datadamorteM.Value;


            if (data <= datav && data1 <= datav)
            {
                dataMnas = data.Year + "-" + data.Month + "-" + data.Day;

                dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;

                morto morto = new morto();
                salvarMortoRec(morto);
                pegarIdMRec(morto);
                excluirM(morto);

                btn_excluir.Visible = true;
                btn_editar.Visible = false;

                pais pais = new pais();
                salvarPRec(pais);
                excluirP(pais);

                EstadoCivil EstadoCivil = new EstadoCivil();
                salvarERec(EstadoCivil);
                excluirE(EstadoCivil);
                limparcampoM();
                
            

                CausaMorte Causamorte = new CausaMorte();
                salvarCMRec(Causamorte);
                excluirCM(Causamorte);
                limparCM();

            }

            }
        }

        private void lk_editarM_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_nomeM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_nbiM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_PaiM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_provinciaM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_naturalM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_MaeM.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_sexoM.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_estadocivilM.Text == string.Empty)
            {
                vazio = true;
            }
            if (dt_nascimentoM.Text == string.Empty)
            {
                vazio = true;
            }
            if (dt_datadamorteM.Text == string.Empty)
            {
                vazio = true;
            }
            if (op == 2)
            {
                if (txt_esposo_a.Text == string.Empty)
                {
                    vazio = true;
                }

            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime data = dt_nascimentoM.Value;
                DateTime datav = metroDateTime1.Value;
                DateTime data1 = dt_datadamorteM.Value;

                ano = data1.Year.ToString();
                mes = data1.Month.ToString();
                dia = data1.Day.ToString();

                if (data <= datav && data1 <= datav)
                {
                    dataMnas = data.Year + "-" + data.Month + "-" + data.Day;

                    dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;

                    morto morto = new morto();
                    
                    //Editar Morto
                    EditarMorto(morto);
                    //Editar Pais
                    pais pais = new pais();
                    Editarpais(pais);

                    
                        //Salvar Esposso\a
                        EstadoCivil EstadoCivil = new EstadoCivil();
                        EditarEstadoCivil(EstadoCivil);
                }
                else
                {
                    MessageBox.Show(this, "Ainda não estamos neste ano: " + data, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion
        }

        private void btn_guarda_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            if (qtdF != 0)
            {
                qtdF--;

                bool vazio = false;
                if (txt_nome_F.Text == string.Empty)
                {
                    vazio = true;
                }
                if (vazio)
                {
                    MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Filhos Filhos = new Filhos();
                    salvarFi(Filhos);
                    PegarFG();
                    limparF();
                }
            }
            if(qtdF == 0)
            {
                txt_nome_F.Visible = false;
                btn_cancelar.Visible = false;
                btn_guarda.Visible = false;
                txt_idM_F.Text = string.Empty;
                txt_id_filho.Text = string.Empty;
                txt_id_filho.Visible = false;
                txt_idM_F.Visible = false;
                lk_id_filho.Visible = false;
                metroLabel1.Visible = true;
                txt_qtd_filhos.Visible = true;
                txt_qtd_filhos.Text = string.Empty;
                btn_qtd_Filhos.Visible = true;
                
            }
            #endregion
        }

        private void btn_Salvar_CM_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_desc_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_local_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_causa_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_id_CM.Text == string.Empty)
            {
                vazio = true;
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CausaMorte CausaMorte = new CausaMorte();
                salvarCM(CausaMorte);
                limparCM();
                btn_Salvar_CM.Enabled = false;
                btn_cancelar_CM.Enabled = false;
            }
            #endregion
        }

        private void cb_estadocivilM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_estadocivilM.Text == "S")
            {
                op = 1;
                txt_esposo_a.Enabled = false;
            }
            else
            {
                txt_esposo_a.Enabled = true;
                op = 2;
            }
        }

        private void txt_esposo_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890!#$%&/{[()]}='?«»+*ºª_-,.;:><@£§|";
            if (n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_nbiM_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_cancelar_CM_Click(object sender, EventArgs e)
        {
            limparCM();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparF();
        }

        private void dg_filhos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_filho.Text = dg_filhos.CurrentRow.Cells[0].Value.ToString();
            txt_nome_F.Text = dg_filhos.CurrentRow.Cells[1].Value.ToString();
            txt_idM_F.Text = dg_filhos.CurrentRow.Cells[2].Value.ToString();
            cod = Convert.ToInt32(dg_filhos.CurrentRow.Cells[2].Value.ToString());
            txt_nome_F.Enabled = true;
            btn_guarda.Enabled = true;
            btn_editar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_salvarSis.Enabled = true;
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void cb_morto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_morto.Text == "Sem Identidade")
            {
                #region Cadastrar Morte sem Identidade

                txt_nomeM.Enabled = false; 
                txt_PaiM.Enabled = false; 
                txt_MaeM.Enabled = false; 
                txt_nbiM.Enabled = false; 
                txt_naturalM.Enabled = false; 
                txt_provinciaM.Enabled = false; 
                cb_estadocivilM.Enabled = false; 
                dt_nascimentoM.Enabled = false;
                lk_salvarM.Visible = false;
                lk_salvarMsdmID.Visible = true;
                txt_local_morte.Enabled = true;
                txt_causa_morte.Enabled = true;
                txt_desc_morte.Enabled = true;
                #endregion
            }
            if (cb_morto.Text == "Com Identidade")
            {
                #region Cadastrar Morte sem Identidade

                txt_nomeM.Enabled = true;
                txt_PaiM.Enabled = true;
                txt_MaeM.Enabled = true;
                txt_nbiM.Enabled = true;
                txt_naturalM.Enabled = true;
                txt_provinciaM.Enabled = true;
                cb_estadocivilM.Enabled = true;
                dt_nascimentoM.Enabled = true;
                lk_salvarMsdmID.Visible = false;
                lk_salvarM.Visible = true;
                lk_salvarMsdmID.Visible = false;
                txt_local_morte.Enabled = false;
                txt_causa_morte.Enabled = false;
                txt_desc_morte.Enabled = false;
                #endregion
            }
        }

        private void lk_salvarMsdmID_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (cb_sexoM.Text == string.Empty)
            {
                vazio = true;
            }
            if (dt_datadamorteM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_desc_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_local_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_causa_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime datav = metroDateTime1.Value;
                DateTime data1 = dt_datadamorteM.Value;

                ano = data1.Year.ToString();
                mes = data1.Month.ToString();
                dia = data1.Day.ToString();

                if (data1 <= datav)
                {
                    dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;
                    mortoSem mortos = new mortoSem();
                    salvarMSem(mortos);
                }
                else
                {
                    MessageBox.Show(this, "Ainda não estamos neste ano: " + data1, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos

                bool vazio = false;
                if (txt_nome_F.Text == string.Empty)
                {
                    vazio = true;
                }
                if (vazio)
                {
                    MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Editar Morto
                    Filhos Filhos = new Filhos();
                    Editarfilho(Filhos);
                    txt_idM_F.Text = string.Empty;
                    txt_id_filho.Text = string.Empty;
                    txt_nome_F.Text = string.Empty;
                    PegarF();
                }
            #endregion
        }

        private void btn_editarCM_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_desc_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_local_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_causa_morte.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_id_CM.Text == string.Empty)
            {
                vazio = true;
            }
            if (vazio)
            {
                MetroMessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CausaMorte CausaMorte = new CausaMorte();
                EditarCausaMorte(CausaMorte);
                limparCM();
                btn_editarCM.Enabled = false;
                btn_cancelar_CM.Enabled = false;
            }
            #endregion
        }

        private void lk_salvarEP_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Filhos Filhos = new Filhos();
            salvarFiRec(Filhos);
            excluirF(Filhos);
            PegarFE();
            txt_id_filho.Text = string.Empty;
            txt_nome_F.Text = string.Empty;
            txt_idM_F.Text = string.Empty;
        }

        private void lk_restauraM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente Restaurar esta pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                #region Verificação dos campos
                bool vazio = false;
                if (txt_nomeM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (txt_nbiM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (txt_PaiM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (txt_provinciaM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (txt_naturalM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (txt_MaeM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (cb_sexoM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (cb_estadocivilM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (dt_nascimentoM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (dt_datadamorteM.Text == string.Empty)
                {
                    vazio = true;
                }
                if (op == 2)
                {
                    if (txt_esposo_a.Text == string.Empty)
                    {
                        vazio = true;
                    }

                }
                if (vazio)
                {
                    MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DateTime data = dt_nascimentoM.Value;
                    DateTime datav = metroDateTime1.Value;
                    DateTime data1 = dt_datadamorteM.Value;

                    ano = data1.Year.ToString();
                    mes = data1.Month.ToString();
                    dia = data1.Day.ToString();

                    if (data <= datav && data1 <= datav)
                    {
                        dataMnas = data.Year + "-" + data.Month + "-" + data.Day;

                        dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;

                        morto morto = new morto();
                        
                        //Comfirmar Morto 
                        permiM(morto);
                        if (txt_nbiM.Text != DadosEditar.EditarDados.nbi_conf)
                        {
                            //Salvar Morto
                            salvarM(morto);
                            //Pegar ID morto
                            pegarIdM(morto);

                            excluirrecM(morto);

                            //Salvar Pais
                            pais pais = new pais();
                            salvarP(pais);

                            excluirrecP(pais);

                            #region Quardar Causa da morte

                            CausaMorte CausaMorte = new CausaMorte();
                            salvarCM(CausaMorte);
                            limparCM();

                            excluirrecCM(CausaMorte);

                            #endregion

                            #region Salvar Esposo\a
                            if (op == 1)
                            {
                                return;
                            }
                            if (op == 2)
                            {
                                //Salvar Esposso\a
                                EstadoCivil EstadoCivil = new EstadoCivil();
                                salvarE(EstadoCivil);

                              excluirrecE(EstadoCivil);

                            }
                            limparcampoM();
                            #endregion

                            

                        }
                        else
                        {
                            MessageBox.Show("O Morto já foi encontrado no Sistema com nome de " + DadosEditar.EditarDados.nome_conf, "O Morto ja Existe !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show(this, "Ainda não estamos neste ano: " + data, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                #endregion
            }
        }

        private void txt_nomeM_TextChanged(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pic_qrM.Image = qrcode.Draw(txt_nomeM.Text, 50);
        }

        private void txt_nbiM_TextChanged(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pic_brM.Image = barcode.Draw(txt_nbiM.Text, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void lk_excluirRec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente Excluir esta pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                DateTime data = dt_nascimentoM.Value;
                DateTime datav = metroDateTime1.Value;
                DateTime data1 = dt_datadamorteM.Value;


                if (data <= datav && data1 <= datav)
                {
                    dataMnas = data.Year + "-" + data.Month + "-" + data.Day;

                    dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;

                    morto morto = new morto();
                    excluirrecM(morto);

                    pais pais = new pais();
                    excluirrecP(pais);

                    EstadoCivil EstadoCivil = new EstadoCivil();
                    excluirrecE(EstadoCivil);
                    limparcampoM();

                    CausaMorte Causamorte = new CausaMorte();
                    excluirrecCM(Causamorte);
                    limparCM();

                    Filhos Filhos = new Filhos();
                    excluirFR(Filhos);

                    dg_filhos.DataSource = "";
                    limparcampoM();
                }


            }
        }

        private void btn_excluirRec_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvarSis_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos

                bool vazio = false;
                if (txt_nome_F.Text == string.Empty)
                {
                    vazio = true;
                }
                if (vazio)
                {
                    MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Filhos Filhos = new Filhos();
                    salvarFi(Filhos);
                    excluirrecF(Filhos);
                    PegarFER();
                }

            #endregion

            txt_id_filho.Text = string.Empty;
            txt_idM_F.Text = string.Empty;
            txt_nome_F.Text = string.Empty;
        }

        private void lk_salvarM_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_nomeM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_nbiM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_PaiM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_provinciaM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_naturalM.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_MaeM.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_sexoM.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_estadocivilM.Text == string.Empty)
            {
                vazio = true;
            }
            if (dt_nascimentoM.Text == string.Empty)
            {
                vazio = true;
            }
            if (dt_datadamorteM.Text == string.Empty)
            {
                vazio = true;
            }
            if (op == 2)
            {
                if (txt_esposo_a.Text == string.Empty)
                {
                    vazio = true;
                }
                
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime data = dt_nascimentoM.Value;
                DateTime datav = metroDateTime1.Value;
                DateTime data1 = dt_datadamorteM.Value;

                ano = data1.Year.ToString();
                mes = data1.Month.ToString();
                dia = data1.Day.ToString();

                if (data <= datav && data1 <= datav)
                {
                    dataMnas = data.Year + "-" + data.Month + "-" + data.Day;

                    dataMmor = data1.Year + "-" + data1.Month + "-" + data1.Day;

                    morto morto = new morto();
                    //Comfirmar Morto 
                    permiM(morto);
                    if (txt_nbiM.Text != DadosEditar.EditarDados.nbi_conf)
                    {
                        //Salvar Morto
                        salvarM(morto);
                        //Pegar ID morto
                        pegarIdM(morto);

                        //Salvar Pais
                        pais pais = new pais();
                        salvarP(pais);
                        
                        #region Salvar Esposo\a
                        if (op == 1)
                        {
                            return;
                        }
                        if (op == 2)
                        {
                            //Salvar Esposso\a
                            EstadoCivil EstadoCivil = new EstadoCivil();
                            salvarE(EstadoCivil);
                        }
                        limparcampoM();
                        #endregion
                    }
                    else
                    {
                        MessageBox.Show("O Morto já foi encontrado no Sistema com nome de " + DadosEditar.EditarDados.nome_conf, "O Morto ja Existe !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                       MessageBox.Show(this, "Ainda não estamos neste ano: " + data, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limparcampoM();
            }
            #endregion
        }

        private void btn_qtd_Filhos_Click(object sender, EventArgs e)
        {
            string n = txt_qtd_filhos.Text;
            qtdF = Convert.ToInt32(n);
            if (qtdF != 0)
            {
                btn_guarda.Enabled = true;
                btn_cancelar.Enabled = true;
                txt_nome_F.Enabled = true;
                txt_idM_F.Visible = true;
                txt_nome_F.Visible = true;
                btn_guarda.Visible = true;
                btn_cancelar.Visible = true;
                txt_id_filho.Visible = true;
                lk_id_filho.Visible = true;
            }

            txt_qtd_filhos.Enabled = false;
            btn_qtd_Filhos.Enabled = false;
            metroLabel1.Visible = false;
            txt_qtd_filhos.Visible = false;
            btn_qtd_Filhos.Visible = false;
        }

        private void btn_procurar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.Jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgM = dialog.FileName.ToString();
                picimgM.ImageLocation = imgM;
            }
        }
    }
}
