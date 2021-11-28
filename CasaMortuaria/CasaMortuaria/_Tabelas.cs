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
    public partial class _Tabelas : MetroFramework.Forms.MetroForm
    {
        public _Tabelas()
        {
            InitializeComponent();
            #region Dadso Familiares
            listarM();
            listarP();
            listarE();
            listarF();
            listarCM();
            listarFU();
            listarMs();
            #endregion
        }

        #region Dados familiares 
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
        private void listarP()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            gd_Pais.DataSource = pessoaBLL.listarP();
            #region Dados da colunas 
            gd_Pais.Columns[0].HeaderText = "NIP";
            gd_Pais.Columns[0].Width = 115;
            gd_Pais.Columns[1].HeaderText = "Nome do Pai";
            gd_Pais.Columns[1].Width = 290;
            gd_Pais.Columns[2].HeaderText = "Nome da Mãe";
            gd_Pais.Columns[2].Width = 290;
            gd_Pais.Columns[3].HeaderText = "NIM";
            gd_Pais.Columns[3].Width = 110;
            #endregion
        }
        private void listarE()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            gd_Esposo.DataSource = pessoaBLL.listarE();
            #region Dados da colunas 
            gd_Esposo.Columns[0].HeaderText = "NIE";
            gd_Esposo.Columns[0].Width = 150;
            gd_Esposo.Columns[1].HeaderText = "Nome";
            gd_Esposo.Columns[1].Width = 505;
            gd_Esposo.Columns[2].HeaderText = "NIM";
            gd_Esposo.Columns[2].Width = 150;
            #endregion
        }
        private void listarF()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            gd_Filho.DataSource = pessoaBLL.listarF();
            #region Dados da colunas 
            gd_Filho.Columns[0].HeaderText = "NIF";
            gd_Filho.Columns[0].Width = 150;
            gd_Filho.Columns[1].HeaderText = "Nome";
            gd_Filho.Columns[1].Width = 505;
            gd_Filho.Columns[2].HeaderText = "NIM";
            gd_Filho.Columns[2].Width = 150;
            #endregion
        }
        private void listarCM()
        {
            pessoaBLL pessoaBLL = new pessoaBLL();
            gd_CM.DataSource = pessoaBLL.listarCM();
            #region Dados da colunas 
            gd_CM.Columns[0].HeaderText = "NIC";
            gd_CM.Columns[0].Width = 105;
            gd_CM.Columns[1].HeaderText = "Local da Morte";
            gd_CM.Columns[1].Width = 200;
            gd_CM.Columns[2].HeaderText = "Causa da Morte";
            gd_CM.Columns[2].Width = 200;
            gd_CM.Columns[3].HeaderText = "Descrição da Morte";
            gd_CM.Columns[3].Width = 200;
            gd_CM.Columns[4].HeaderText = "NIM";
            gd_CM.Columns[4].Width = 100;
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
        private void listarFU()
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
        #endregion

        private void lk_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lk_Atualizar_Click(object sender, EventArgs e)
        {
            #region Dadso Familiares
            listarM();
            listarP();
            listarE();
            listarF();
            listarCM();
            listarFU();
            #endregion
        }
    }
}
