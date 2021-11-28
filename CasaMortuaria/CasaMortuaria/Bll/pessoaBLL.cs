using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasaMortuaria.Model;
using CasaMortuaria.Dao;
using System.Data;


namespace CasaMortuaria.Bll
{
    public class pessoaBLL  
    {
        pessoaDAO pessoaDAO = new pessoaDAO();
        #region Metodo do Funcionario

        #region Dados para o grafico

        public void contMF(morto Morto)
        {
            try
            {
                pessoaDAO.contMF(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void contMFs(mortoSem Morto)
        {
            try
            {
                pessoaDAO.contMFs(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion
        //========================================
        // Metodo para Excluir o Morto
        public void excluirM(morto pessoa)
        {
            try
            {
                pessoaDAO.excluirM(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void excluirMs(mortoSem pessoa)
        {
            try
            {
                pessoaDAO.excluirMs(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir os pais
        public void excluirP(pais pessoa)
        {
            try
            {
                pessoaDAO.excluirP(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir Esposo\a
        public void excluirE(EstadoCivil pessoa)
        {
            try
            {
                pessoaDAO.excluirE(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir Filhos
        public void excluirF(Filhos pessoa)
        {
            try
            {
                pessoaDAO.excluirF(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir Causa da Morte
        public void excluirCM(CausaMorte pessoa)
        {
            try
            {
                pessoaDAO.excluirCM(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        //========================================
        // Metodo para Funcionario iniciar sessão 
        public void IniciarF(Usuario pessoa)
        {
            try
            {
                pessoaDAO.IniciarF(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar Funcionario 
        public void salvarUsu(Usuario pessoa)
        {
            try
            {
                pessoaDAO.salvarUsuario(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Editar Funcionario
        public void EditarUs(Usuario pessoa)
        {
            try
            {
                pessoaDAO.EditarUs(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Editar Pass do Funcionario
        public void EditarUsPs(Usuario pessoa)
        {
            try
            {
                pessoaDAO.EditarUsPs(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Editar Pass do Funcionario
        public void EditarMorto(morto Morto)
        {
            try
            {
                pessoaDAO.EditarMorto(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void EditarMortos(mortoSem Morto)
        {
            try
            {
                pessoaDAO.EditarMortos(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Editar pais
        public void Editarpais(pais pais)
        {
            try
            {
                pessoaDAO.Editarpais(pais);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Editar espossa\a
        public void EditarEstadoCivil(EstadoCivil EstadoCivil)
        {
            try
            {
                pessoaDAO.EditarEstadoCivil(EstadoCivil);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Editar Filhos
        public void Editarfilho(Filhos Filhos)
        {
            try
            {
                pessoaDAO.Editarfilho(Filhos);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Editar CausaMorte
        public void EditarCausaMorte(CausaMorte CausaMorte)
        {
            try
            {
                pessoaDAO.EditarCausaMorte(CausaMorte);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Enviar Funcionario na reciclagem
        public void EnviarRec(Usuario pessoa)
        {
            try
            {
                pessoaDAO.EnviarRec(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Excluir um registro
        public void excluirUs(Usuario pessoa)
        {
            try
            {
                pessoaDAO.excluirUs(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Excluir um registro na reciclagem
        public void excluirRecUs(Usuario pessoa)
        {
            try
            {
                pessoaDAO.excluirRecUs(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para a listar Funcionario
        public DataTable listarUsu()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarUsuario();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para a listar Funcionario na Reciclagem
        public DataTable listarRecUsu()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarRecUsuario();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para consultar um registro
        public DataTable consultarF(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.consultarF(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Metodo para consultar um registro na reciclagem
        public DataTable consultarRecF(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.consultarRecF(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Metodo para pegar dados do Usuario
        public Usuario pegarUs(int valor)
        {
            try
            {
                Usuario Usuario = new Usuario();
                Usuario = pessoaDAO.pegarUs(valor);

                return Usuario;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados do Usuario na Reciclagem
        public Usuario PegarRecF(int valor)
        {
            try
            {
                Usuario Usuario = new Usuario();
                Usuario = pessoaDAO.PegarRecF(valor);

                return Usuario;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion
        #region dados do mortos
        // Metodo para pegar dados dos filhos 
        public DataTable PegarF(int valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.PegarF(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Metodo para pegar dados dos filhos pois guardar
        public DataTable PegarFG(int valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.PegarFG(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Meto para salvar Morto
        public void salvarMorto(morto Morto)
        {
            try
            {
                pessoaDAO.salvarMorto(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Meto para salvar Morto
        public void salvarSemMorto(mortoSem MortoSem)
        {
            try
            {
                pessoaDAO.salvarSemMorto(MortoSem);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable consultarM(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.consultarM(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        // Metodo para a listar Morto
        public DataTable listarMorto()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarMorto();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listarMortos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarMortos();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listarMortoUsu(string valor)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarMortoUsu(valor);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listarMortoUsuS(string valor)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarMortoUsuS(valor);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar pais
        public void salvarpais(pais pais)
        {
            try
            {
                pessoaDAO.salvarPais(pais);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar espossa\a
        public void salvarEstadoCivil(EstadoCivil EstadoCivil)
        {
            try
            {
                pessoaDAO.salvarEstadoCivil(EstadoCivil);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar Filhos 
        public void salvarFilhos(Filhos Filhos)
        {
            try
            {
                pessoaDAO.salvarFilhos(Filhos);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar Id do morto
        public void pegarIdM(morto morto)
        {
            try
            {
                pessoaDAO.pegarIdM(morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para permitir morto
        public void permiM(morto morto)
        {
            try
            {
                pessoaDAO.permiM(morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para permitir Funcionário
        public void permiF(Usuario Usuario)
        {
            try
            {
                pessoaDAO.permiF(Usuario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar Causa da Morte
        public void salvarCausaMorte(CausaMorte CausaMorte)
        {
            try
            {
                pessoaDAO.salvarCausaMorte(CausaMorte);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados do morto
        public morto pegarM(int valor)
        {
            try
            {
                morto morto = new morto();
                morto = pessoaDAO.pegarM(valor);

                return morto;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public mortoSem pegarMs(int valor)
        {
            try
            {
                mortoSem mortosem = new mortoSem();
                mortosem = pessoaDAO.pegarMs(valor);

                return mortosem;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados do morto
        public pais pegarP(int valor)
        {
            try
            {
                pais pais = new pais();
                pais = pessoaDAO.pegarP(valor);

                return pais;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados do Esposso \ a
        public EstadoCivil pegarE(int valor)
        {
            try
            {
                EstadoCivil EstadoCivil = new EstadoCivil();
                EstadoCivil = pessoaDAO.pegarE(valor);

                return EstadoCivil;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados da Causa da Morte
        public CausaMorte pegarCM(int valor)
        {
            try
            {
                CausaMorte CausaMorte = new CausaMorte();
                CausaMorte = pessoaDAO.pegarCM(valor);

                return CausaMorte;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        #endregion
        #region Salva morto na reciclagem
        // Metodo para salvar na reciclagem
        public void salvarMortoRec(morto Morto)
        {
            try
            {
                pessoaDAO.salvarMortoRec(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar pais na reciclagem
        public void salvarpaisRec(pais pais)
        {
            try
            {
                pessoaDAO.salvarPaisRec(pais);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar espossa\a na reciclagem
        public void salvarEstadoCivilRec(EstadoCivil EstadoCivil)
        {
            try
            {
                pessoaDAO.salvarEstadoCivilRec(EstadoCivil);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar Filhos na reciclagem
        public void salvarFilhosRec(Filhos Filhos)
        {
            try
            {
                pessoaDAO.salvarFilhosRec(Filhos);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para salvar Causa da Morte na reciclagem
        public void salvarCausaMorteRec(CausaMorte CausaMorte)
        {
            try
            {
                pessoaDAO.salvarCausaMorteRec(CausaMorte);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar Id do morto na reciclagem
        public void pegarIdMRec(morto morto)
        {
            try
            {
                pessoaDAO.pegarIdMRec(morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para a listar Morto
        public DataTable listarMortorec()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarMortorec();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }


        // Metodo para consultar um registro na reciclagem
        public DataTable consultarRecM(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.consultarRecM(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //====================================================================
        // Metodo para pegar dados do morto
        public morto pegarMrec(int valor)
        {
            try
            {
                morto morto = new morto();
                morto = pessoaDAO.pegarMrec(valor);

                return morto;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados do morto
        public pais pegarPrec(int valor)
        {
            try
            {
                pais pais = new pais();
                pais = pessoaDAO.pegarPrec(valor);

                return pais;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados do Esposso \ a na reciclagem
        public EstadoCivil pegarErec(int valor)
        {
            try
            {
                EstadoCivil EstadoCivil = new EstadoCivil();
                EstadoCivil = pessoaDAO.pegarErec(valor);

                return EstadoCivil;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados da Causa da Morte na reciclagem
        public CausaMorte pegarCMrec(int valor)
        {
            try
            {
                CausaMorte CausaMorte = new CausaMorte();
                CausaMorte = pessoaDAO.pegarCMrec(valor);

                return CausaMorte;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para pegar dados dos filhos na reciclagem
        public DataTable PegarFrec(int valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.PegarFrec(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //==========================================================

        // Metodo para Excluir o Morto
        public void excluirrecM(morto pessoa)
        {
            try
            {
                pessoaDAO.excluirrecM(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir os pais
        public void excluirrecP(pais pessoa)
        {
            try
            {
                pessoaDAO.excluirrecP(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir Esposo\a
        public void excluirrecE(EstadoCivil pessoa)
        {
            try
            {
                pessoaDAO.excluirrecE(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // Metodo para Excluir Filhos
        public void excluirrecF(Filhos pessoa)
        {
            try
            {
                pessoaDAO.excluirrecF(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluirFR(Filhos pessoa)
        {
            try
            {
                pessoaDAO.excluirFR(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // Metodo para Excluir Causa da Morte
        public void excluirrecCM(CausaMorte pessoa)
        {
            try
            {
                pessoaDAO.excluirrecCM(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion
        #region A listar Dados Familiares
        // Metodo para a listar Pais
        public DataTable listarP()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarP();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listarE()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarE();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listarF()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarF();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listarCM()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.listarCM();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        #endregion
        #region Dados para o Admin
        public void contano(morto Morto)
        {
            try
            {
                pessoaDAO.contano(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void contmes(morto Morto)
        {
            try
            {
                pessoaDAO.contmes(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void contdia(morto Morto)
        {
            try
            {
                pessoaDAO.contdia(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable mostrarano(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.mostrarano(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable mostrarmes(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.mostrarmes(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable mostrardia(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.mostrardia(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void contanos(mortoSem Morto)
        {
            try
            {
                pessoaDAO.contanos(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void contmess(mortoSem Morto)
        {
            try
            {
                pessoaDAO.contmess(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void contdias(mortoSem Morto)
        {
            try
            {
                pessoaDAO.contdias(Morto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable mostraranos(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.mostraranos(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable mostrarmess(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.mostrarmess(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable mostrardias(string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.mostrardias(valor);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion
    }
}
