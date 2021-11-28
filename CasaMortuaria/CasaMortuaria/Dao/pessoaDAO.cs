using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CasaMortuaria.Model;
using System.Data;
using System.Drawing;
using System.IO;

namespace CasaMortuaria.Dao
{
    public class pessoaDAO : Conexao
    {
        #region Metodo do Funcionario
        MySqlCommand comando = null;
        #region Dados para Grafico

        public void contMF(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    DadosEditar.EditarDados.totalM++;
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.nF++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.nM++;
                    }
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void contMFs(mortoSem pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_Morto", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.nFs++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.nMs++;
                    }

                    DadosEditar.EditarDados.totalMs++;
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        #endregion
        // Metodo para Usuário fazer long
        public void IniciarF(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_usuario", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_email"].ToString() == DadosEditar.EditarDados.emailflong && registro["_senha"].ToString() == DadosEditar.EditarDados.senhaFlong)
                    {
                        DadosEditar.EditarDados.id_flong = Convert.ToInt32(registro["id_usuario"]);
                        DadosEditar.EditarDados.nome_flong = registro["_nome"].ToString();
                        DadosEditar.EditarDados.papelflong = registro["_papel"].ToString();
                        DadosEditar.EditarDados.emailconf = registro["_email"].ToString();
                        DadosEditar.EditarDados.senhaconf = registro["_senha"].ToString();
                        DadosEditar.EditarDados.imgFlong = registro["_img"].ToString();
                        break;
                    }
                }

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Usuário 
        public void salvarUsuario(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_usuario (_nome, _nbi, _sexo, _data_nascimento, _email, _senha, _telefone, _papel, _img) VALUES (@_nome, @_nbi, @_sexo, @_data_nascimento, @_email, @_senha, @_telefone, @_papel, @_img)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@_nbi", pessoa._nbi);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_data_nascimento", pessoa._data_nascimento);
                comando.Parameters.AddWithValue("@_email", pessoa._email);
                comando.Parameters.AddWithValue("@_senha", pessoa._senha);
                comando.Parameters.AddWithValue("@_telefone", pessoa._telefone);
                comando.Parameters.AddWithValue("@_papel", pessoa._papel);
                comando.Parameters.AddWithValue("@_img", pessoa._img);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar Usuário
        public DataTable listarUsuario()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_usuario ORDER BY _nome", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar Usuário
        public DataTable listarRecUsuario()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_usuario ORDER BY _nome", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Editar Usuário 
        public void EditarUs(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_usuario SET  _nome = @_nome, _nbi = @_nbi, _sexo = @_sexo, _data_nascimento = @_data_nascimento, _email = @_email, _senha = @_senha, _telefone = @_telefone, _papel = @_papel, _img = @_img WHERE id_usuario = @id_usuario", conexao);

                comando.Parameters.AddWithValue("@id_usuario", pessoa.id_usuario);
                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@_nbi", pessoa._nbi);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_data_nascimento", pessoa._data_nascimento);
                comando.Parameters.AddWithValue("@_email", pessoa._email);
                comando.Parameters.AddWithValue("@_senha", pessoa._senha);
                comando.Parameters.AddWithValue("@_telefone", pessoa._telefone);
                comando.Parameters.AddWithValue("@_papel", pessoa._papel);
                comando.Parameters.AddWithValue("@_img", pessoa._img);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Editar Pass do Usuário 
        public void EditarUsPs(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_usuario SET  _senha = @_senha WHERE id_usuario = @id_usuario", conexao);

                comando.Parameters.AddWithValue("@id_usuario", pessoa.id_usuario);
                comando.Parameters.AddWithValue("@_senha", pessoa._senha);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Enviar Usuário na reciclagem
        public void EnviarRec(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_rec_usuario (_nome, _nbi, _sexo, _data_nascimento, _email, _senha, _telefone, _papel, _img) VALUES (@_nome, @_nbi, @_sexo, @_data_nascimento, @_email, @_senha, @_telefone, @_papel, @_img)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@_nbi", pessoa._nbi);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_data_nascimento", pessoa._data_nascimento);
                comando.Parameters.AddWithValue("@_email", pessoa._email);
                comando.Parameters.AddWithValue("@_senha", pessoa._senha);
                comando.Parameters.AddWithValue("@_telefone", pessoa._telefone);
                comando.Parameters.AddWithValue("@_papel", pessoa._papel);
                comando.Parameters.AddWithValue("@_img", pessoa._img);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir um Funcionario
        public void excluirUs(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_usuario WHERE id_usuario = @id_usuario", conexao);

                comando.Parameters.AddWithValue("@id_usuario", pessoa.id_usuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir um Funcionario na Reciclagem
        public void excluirRecUs(Usuario pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_rec_usuario WHERE id_usuario = @id_usuario", conexao);

                comando.Parameters.AddWithValue("@id_usuario", pessoa.id_usuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Usuario
        public Usuario pegarUs(int valor)
        {
            try
            {
                Usuario Usuario = new Usuario();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Usuario where id_usuario = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    Usuario.id_usuario = Convert.ToInt32(registro["id_usuario"]);
                    Usuario._nome = Convert.ToString(registro["_nome"]);
                    Usuario._nbi = Convert.ToString(registro["_nbi"]);
                    Usuario._sexo = Convert.ToString(registro["_sexo"]);
                    Usuario._data_nascimento = Convert.ToString(registro["_data_nascimento"]);
                    Usuario._email = Convert.ToString(registro["_email"]);
                    Usuario._senha = Convert.ToString(registro["_senha"]);
                    Usuario._telefone = Convert.ToString(registro["_telefone"]);
                    Usuario._papel = Convert.ToString(registro["_papel"]);
                    Usuario._img = Convert.ToString(registro["_img"]);
                }

                return Usuario;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Usuario
        public Usuario PegarRecF(int valor)
        {
            try
            {
                Usuario Usuario = new Usuario();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Usuario where id_usuario = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    Usuario.id_usuario = Convert.ToInt32(registro["id_usuario"]);
                    Usuario._nome = Convert.ToString(registro["_nome"]);
                    Usuario._nbi = Convert.ToString(registro["_nbi"]);
                    Usuario._sexo = Convert.ToString(registro["_sexo"]);
                    Usuario._data_nascimento = Convert.ToString(registro["_data_nascimento"]);
                    Usuario._email = Convert.ToString(registro["_email"]);
                    Usuario._senha = Convert.ToString(registro["_senha"]);
                    Usuario._telefone = Convert.ToString(registro["_telefone"]);
                    Usuario._papel = Convert.ToString(registro["_papel"]);
                    Usuario._img = Convert.ToString(registro["_img"]);
                }

                return Usuario;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Consultar um Funcionário
        public DataTable consultarF(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_usuario where _nome like '%" + valor + "%' or _nbi like '%" + valor + "%' ORDER BY _nome ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }


        // Metodo para Consultar um Funcionário na reciclagem
        public DataTable consultarRecF(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_usuario where _nome like '%" + valor + "%' or _nbi like '%" + valor + "%' ORDER BY _nome ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Permitir Mortos
        public void permiF(Usuario pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_usuario", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_nbi"].ToString() == DadosEditar.EditarDados.nbi_fun)
                    {
                        DadosEditar.EditarDados.nbi_conf_fu = Convert.ToString(registro["_nbi"]);
                        DadosEditar.EditarDados.nomeconf = Convert.ToString(registro["_nome"]);
                        break;
                    }
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        #endregion
        #region Salvar Morto
        // Metodo para salvar Morto
        public void salvarMorto(morto pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_Morto (_nome, _nbi, _natural, _provincia, _sexo, _esta_civil, _data_nascimento, _data_morte, _data_cadastro, _img_morto, ano, mes, dia, id_Usuario) VALUES (@_nome, @_nbi, @_natural, @_provincia, @_sexo, @_esta_civil, @_data_nascimento, @_data_morte,  Now(), @_img_morto, @ano, @mes, @dia, @id_Usuario)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@_nbi", pessoa._nbi);
                comando.Parameters.AddWithValue("@_natural", pessoa._natural);
                comando.Parameters.AddWithValue("@_provincia", pessoa._provincia);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_esta_civil", pessoa._esta_civil);
                comando.Parameters.AddWithValue("@_data_nascimento", pessoa._data_nascimento);
                comando.Parameters.AddWithValue("@_data_morte", pessoa._data_morte);
                comando.Parameters.AddWithValue("@_img_morto", pessoa._img_morto);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                comando.Parameters.AddWithValue("@dia", pessoa.dia);
                comando.Parameters.AddWithValue("@id_Usuario", pessoa.id_Usuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar morto sem identidade
        public void salvarSemMorto(mortoSem pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_sem_morto (_sexo, _data_morte, _data_cadastro, _local_morte, _causa_morte, _descr_morte, _img_morto, ano, mes, dia, id_Usuario) VALUES (@_sexo, @_data_morte,  Now(),@_local_morte,@_causa_morte,@_descr_morte,  @_img_morto, @ano, @mes, @dia, @id_Usuario)", conexao);

                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_data_morte", pessoa._data_morte);
                comando.Parameters.AddWithValue("@_local_morte", pessoa._local_morte);
                comando.Parameters.AddWithValue("@_causa_morte", pessoa._causa_morte);
                comando.Parameters.AddWithValue("@_descr_morte", pessoa._descr_morte);
                comando.Parameters.AddWithValue("@_img_morto", pessoa._img_morto);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                comando.Parameters.AddWithValue("@dia", pessoa.dia);
                comando.Parameters.AddWithValue("@id_Usuario", pessoa.id_Usuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        // Metodo para Pegar dados do Mortos
        public mortoSem pegarMs(int valor)
        {
            try
            {
                mortoSem mortosem = new mortoSem();

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_morto where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    mortosem.id_Morto = Convert.ToInt32(registro["id_Morto"]);
                    mortosem._sexo = Convert.ToString(registro["_sexo"]);
                    mortosem._data_morte = Convert.ToString(registro["_data_morte"]);
                    mortosem._local_morte = Convert.ToString(registro["_local_morte"]);
                    mortosem._causa_morte = Convert.ToString(registro["_causa_morte"]);
                    mortosem._descr_morte = Convert.ToString(registro["_descr_morte"]);
                    mortosem._img_morto = Convert.ToString(registro["_img_morto"]);
                    mortosem.ano = Convert.ToString(registro["ano"]);
                    mortosem.mes = Convert.ToString(registro["mes"]);
                    mortosem.dia = Convert.ToString(registro["dia"]);

                }
                return mortosem;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable consultarM(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_morto where _nome like '%" + valor + "%' or _nbi like '%" + valor + "%' ORDER BY _nome ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Editar Morto
        public void EditarMorto(morto pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_Morto SET _nome = @_nome, _nbi = @_nbi, _natural = @_natural, _provincia = @_provincia, _sexo = @_sexo, _esta_civil = @_esta_civil, _data_nascimento = @_data_nascimento, _data_morte = @_data_morte, _img_morto = @_img_morto, ano = @ano, mes = @mes, dia = @dia WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);
                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@_nbi", pessoa._nbi);
                comando.Parameters.AddWithValue("@_natural", pessoa._natural);
                comando.Parameters.AddWithValue("@_provincia", pessoa._provincia);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_esta_civil", pessoa._esta_civil);
                comando.Parameters.AddWithValue("@_data_nascimento", pessoa._data_nascimento);
                comando.Parameters.AddWithValue("@_data_morte", pessoa._data_morte);
                comando.Parameters.AddWithValue("@_img_morto", pessoa._img_morto);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                comando.Parameters.AddWithValue("@dia", pessoa.dia);
                comando.Parameters.AddWithValue("@id_Usuario", pessoa.id_Usuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void EditarMortos(mortoSem pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_sem_morto  SET _sexo = @_sexo, _data_morte = @_data_morte, _local_morte = @_local_morte, _causa_morte = @_causa_morte, _descr_morte = @_descr_morte, ano = @ano, mes = @mes, dia =@dia WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_data_morte", pessoa._data_morte);
                comando.Parameters.AddWithValue("@_local_morte", pessoa._local_morte);
                comando.Parameters.AddWithValue("@_causa_morte", pessoa._causa_morte);
                comando.Parameters.AddWithValue("@_descr_morte", pessoa._descr_morte);
                comando.Parameters.AddWithValue("@_img_morto", pessoa._img_morto);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                comando.Parameters.AddWithValue("@dia", pessoa.dia);
                comando.Parameters.AddWithValue("@id_Usuario", pessoa.id_Usuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void excluirMs(mortoSem pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_sem_morto WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //==================================================
        // Metodo Para Excluir um Morto
        public void excluirM(morto pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_Morto WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Pais do Morto
        public void excluirP(pais pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_Pais WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Esposo do Morto
        public void excluirE(EstadoCivil pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_estadocivil WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Esposo do Morto
        public void excluirF(Filhos pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_Filhos WHERE id_Filhos = @id_Filhos", conexao);

                comando.Parameters.AddWithValue("@id_Filhos", pessoa.id_Filhos);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Causa da Morte do Morto
        public void excluirCM(CausaMorte pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM  tbl_causamorte WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //===================================================


        // Metodo para Editar Pais
        public void Editarpais(pais pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_Pais SET _nome_pai = @_nome_pai, _nome_mae = @_nome_mae WHERE id_Pais = @id_Pais ", conexao);

                comando.Parameters.AddWithValue("@id_Pais", pessoa.id_Pais);
                comando.Parameters.AddWithValue("@_nome_pai", pessoa._nome_pai);
                comando.Parameters.AddWithValue("@_nome_mae", pessoa._nome_mae);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar esposso ou espossa
        public void EditarEstadoCivil(EstadoCivil pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_EstadoCivil SET _nome = @_nome WHERE id_EstadoCivil = @id_EstadoCivil", conexao);

                comando.Parameters.AddWithValue("@id_EstadoCivil", pessoa.id_EstadoCivil);
                comando.Parameters.AddWithValue("@_nome", pessoa._nome);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar Morto
        public DataTable listarMorto()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto ORDER BY _nome", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable listarMortos()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_morto", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listarMortoUsu(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto where id_Usuario like '%" + valor + "%' ORDER BY _nome ", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listarMortoUsuS(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_morto where id_Usuario like '%" + valor + "%' ", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Pais
        public void salvarPais(pais pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_Pais (_nome_pai, _nome_mae, id_Morto) VALUES (@_nome_pai, @_nome_mae, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_nome_pai", pessoa._nome_pai);
                comando.Parameters.AddWithValue("@_nome_mae", pessoa._nome_mae);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar esposso ou espossa
        public void salvarEstadoCivil(EstadoCivil pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_EstadoCivil (_nome, id_Morto) VALUES (@_nome, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Filhos
        public void salvarFilhos(Filhos pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_filhos (_nome, id_Morto) VALUES (@_nome, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        // Metodo Para Editar Filhos
        public void Editarfilho(Filhos pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE tbl_filhos SET _nome = @_nome WHERE id_Filhos = @id_Filhos", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@id_Filhos", pessoa.id_Filhos);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Causa da Morte
        public void salvarCausaMorte(CausaMorte pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_causamorte ( _local_morte, _causa_morte, _descr_morte, id_Morto) VALUES (@_local_morte, @_causa_morte, @_descr_morte, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_local_morte", pessoa._local_morte);
                comando.Parameters.AddWithValue("@_causa_morte", pessoa._causa_morte);
                comando.Parameters.AddWithValue("@_descr_morte", pessoa._descr_morte);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Editar Causa da Morte
        public void EditarCausaMorte(CausaMorte pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand(" _nome = @_nome ", conexao);

                comando = new MySqlCommand("UPDATE tbl_causamorte SET _local_morte = @_local_morte, _causa_morte = @_causa_morte, _descr_morte = @_descr_morte WHERE id_CausaMorte = @id_CausaMorte", conexao);

                comando.Parameters.AddWithValue("@id_CausaMorte", pessoa.id_CausaMorte);
                comando.Parameters.AddWithValue("@_local_morte", pessoa._local_morte);
                comando.Parameters.AddWithValue("@_causa_morte", pessoa._causa_morte);
                comando.Parameters.AddWithValue("@_descr_morte", pessoa._descr_morte);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar Id do Mortos
        public void pegarIdM(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_nbi"].ToString() == DadosEditar.EditarDados.nbi_morto)
                    {
                        DadosEditar.EditarDados.id_PEFC = Convert.ToInt32(registro["id_Morto"]);
                        break;
                    }
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Permitir Mortos
        public void permiM(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_nbi"].ToString() == DadosEditar.EditarDados.nbi_morto)
                    {
                        DadosEditar.EditarDados.nbi_conf = Convert.ToString(registro["_nbi"]);
                        DadosEditar.EditarDados.nome_conf = Convert.ToString(registro["_nome"]);
                        break;
                    }
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Mortos
        public morto pegarM(int valor)
        {
            try
            {
                morto morto = new morto();

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    morto.id_Morto = Convert.ToInt32(registro["id_morto"]);
                    morto._nome = Convert.ToString(registro["_nome"]);
                    morto._nbi = Convert.ToString(registro["_nbi"]);
                    morto._natural = Convert.ToString(registro["_natural"]);
                    morto._provincia = Convert.ToString(registro["_provincia"]);
                    morto._sexo = Convert.ToString(registro["_sexo"]);
                    morto._esta_civil = Convert.ToString(registro["_esta_civil"]);
                    morto._data_nascimento = Convert.ToString(registro["_data_nascimento"]);
                    morto._data_morte = Convert.ToString(registro["_data_morte"]);
                    morto._img_morto = Convert.ToString(registro["_img_morto"]);

                }
                return morto;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados dos Pais
        public pais pegarP(int valor)
        {
            try
            {
                pais pais = new pais();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Pais where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    DadosEditar.EditarDados.id_pais = Convert.ToInt32(registro["id_pais"]);
                    pais._nome_pai = Convert.ToString(registro["_nome_pai"]);
                    pais._nome_mae = Convert.ToString(registro["_nome_mae"]);
                }
                return pais;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Esposso \ a
        public EstadoCivil pegarE(int valor)
        {
            try
            {
                EstadoCivil EstadoCivil = new EstadoCivil();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_estadocivil where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    EstadoCivil._nome = Convert.ToString(registro["_nome"]);
                    DadosEditar.EditarDados.id_esposo1 = Convert.ToInt32(registro["id_EstadoCivil"]);
                }
                return EstadoCivil;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Filhos
        public DataTable PegarF(int valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_Filhos where id_Morto like '%" + valor + "%' ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Filhos pois guardar
        public DataTable PegarFG(int valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_Filhos where id_Morto like '%" + valor + "%' ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados da Causa da Morte
        public CausaMorte pegarCM(int valor)
        {
            try
            {
                CausaMorte CausaMorte = new CausaMorte();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_causamorte where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    DadosEditar.EditarDados.id_causamorte = Convert.ToInt32(registro["id_CausaMorte"]);
                    CausaMorte._local_morte = Convert.ToString(registro["_local_morte"]);
                    CausaMorte._causa_morte = Convert.ToString(registro["_causa_morte"]);
                    CausaMorte._descr_morte = Convert.ToString(registro["_descr_morte"]);
                    CausaMorte.id_Morto = Convert.ToString(registro["id_Morto"]);
                }
                return CausaMorte;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
        #region Salvar morto na reciclagem
        // Metodo para salvar Morto na Reciclagem
        public void salvarMortoRec(morto pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_rec_Morto (_nome, _nbi, _natural, _provincia, _sexo, _esta_civil, _data_nascimento, _data_morte, _data_cadastro, _img_morto) VALUES (@_nome, @_nbi, @_natural, @_provincia, @_sexo, @_esta_civil, @_data_nascimento, @_data_morte,  Now(), @_img_morto)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@_nbi", pessoa._nbi);
                comando.Parameters.AddWithValue("@_natural", pessoa._natural);
                comando.Parameters.AddWithValue("@_provincia", pessoa._provincia);
                comando.Parameters.AddWithValue("@_sexo", pessoa._sexo);
                comando.Parameters.AddWithValue("@_esta_civil", pessoa._esta_civil);
                comando.Parameters.AddWithValue("@_data_nascimento", pessoa._data_nascimento);
                comando.Parameters.AddWithValue("@_data_morte", pessoa._data_morte);
                comando.Parameters.AddWithValue("@_img_morto", pessoa._img_morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Pais na reciclagem
        public void salvarPaisRec(pais pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_rec_Pais (_nome_pai, _nome_mae, id_Morto) VALUES (@_nome_pai, @_nome_mae, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_nome_pai", pessoa._nome_pai);
                comando.Parameters.AddWithValue("@_nome_mae", pessoa._nome_mae);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar esposso ou espossa na reciclagem
        public void salvarEstadoCivilRec(EstadoCivil pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_rec_EstadoCivil (_nome, id_Morto) VALUES (@_nome, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Filhos na reciclagem
        public void salvarFilhosRec(Filhos pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_rec_filhos (_nome, id_Morto) VALUES (@_nome, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_nome", pessoa._nome);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para salvar Causa da Morte na reciclagem
        public void salvarCausaMorteRec(CausaMorte pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO tbl_rec_causamorte ( _local_morte, _causa_morte, _descr_morte, id_Morto) VALUES (@_local_morte, @_causa_morte, @_descr_morte, @id_Morto)", conexao);

                comando.Parameters.AddWithValue("@_local_morte", pessoa._local_morte);
                comando.Parameters.AddWithValue("@_causa_morte", pessoa._causa_morte);
                comando.Parameters.AddWithValue("@_descr_morte", pessoa._descr_morte);
                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar Id do Mortos na reciclagem
        public void pegarIdMRec(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Morto", conexao);

                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_nbi"].ToString() == DadosEditar.EditarDados.nbi_morto)
                    {
                        DadosEditar.EditarDados.IdMrec = Convert.ToInt32(registro["id_Morto"]);
                        break;
                    }
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar Morto na reciclagem
        public DataTable listarMortorec()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Morto", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Consultar um Morto na reciclagem
        public DataTable consultarRecM(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_morto where _nome like '%" + valor + "%' or _nbi like '%" + valor + "%' ORDER BY _nome ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //===================================================================
        // Metodo para Pegar dados do Mortos
        public morto pegarMrec(int valor)
        {
            try
            {
                morto morto = new morto();

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Morto where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    morto.id_Morto = Convert.ToInt32(registro["id_morto"]);
                    morto._nome = Convert.ToString(registro["_nome"]);
                    morto._nbi = Convert.ToString(registro["_nbi"]);
                    morto._natural = Convert.ToString(registro["_natural"]);
                    morto._provincia = Convert.ToString(registro["_provincia"]);
                    morto._sexo = Convert.ToString(registro["_sexo"]);
                    morto._esta_civil = Convert.ToString(registro["_esta_civil"]);
                    morto._data_nascimento = Convert.ToString(registro["_data_nascimento"]);
                    morto._data_morte = Convert.ToString(registro["_data_morte"]);
                    morto._img_morto = Convert.ToString(registro["_img_morto"]);

                }
                return morto;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados dos Pais
        public pais pegarPrec(int valor)
        {
            try
            {
                pais pais = new pais();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Pais where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    DadosEditar.EditarDados.id_pais = Convert.ToInt32(registro["id_pais"]);
                    pais._nome_pai = Convert.ToString(registro["_nome_pai"]);
                    pais._nome_mae = Convert.ToString(registro["_nome_mae"]);
                }
                return pais;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Esposso \ a
        public EstadoCivil pegarErec(int valor)
        {
            try
            {
                EstadoCivil EstadoCivil = new EstadoCivil();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_estadocivil where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    EstadoCivil._nome = Convert.ToString(registro["_nome"]);
                    DadosEditar.EditarDados.id_esposo1 = Convert.ToInt32(registro["id_EstadoCivil"]);
                }
                return EstadoCivil;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Filhos
        public DataTable PegarFrec(int valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Filhos where id_Morto like '%" + valor + "%' ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados do Filhos
        public DataTable PegarFER(int valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_Filhos where id_Morto like '%" + valor + "%' ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para Pegar dados da Causa da Morte
        public CausaMorte pegarCMrec(int valor)
        {
            try
            {
                CausaMorte CausaMorte = new CausaMorte();
                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_rec_causamorte where id_Morto = " + valor, conexao);

                var registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    DadosEditar.EditarDados.id_causamorte = Convert.ToInt32(registro["id_CausaMorte"]);
                    CausaMorte._local_morte = Convert.ToString(registro["_local_morte"]);
                    CausaMorte._causa_morte = Convert.ToString(registro["_causa_morte"]);
                    CausaMorte._descr_morte = Convert.ToString(registro["_descr_morte"]);
                    CausaMorte.id_Morto = Convert.ToString(registro["id_Morto"]);
                }
                return CausaMorte;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //====================================================
        // Metodo Para Excluir um Morto
        public void excluirrecM(morto pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_rec_Morto WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Pais do Morto
        public void excluirrecP(pais pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_rec_Pais WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Esposo do Morto
        public void excluirrecE(EstadoCivil pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_rec_estadocivil WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Esposo do Morto
        public void excluirrecF(Filhos pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_rec_Filhos WHERE id_Filhos = @id_Filhos", conexao);

                comando.Parameters.AddWithValue("@id_filhos", pessoa.id_Filhos);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluirFR(Filhos pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM tbl_rec_Filhos WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo Para Excluir Causa da Morte do Morto
        public void excluirrecCM(CausaMorte pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM  tbl_rec_causamorte WHERE id_Morto = @id_Morto", conexao);

                comando.Parameters.AddWithValue("@id_Morto", pessoa.id_Morto);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        #endregion
        #region Dados Familiares 
        public DataTable listarP()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_pais", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable listarE()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_estadocivil", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable listarF()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_filhos", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable listarCM()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_causamorte", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
        #region Dados para Admin
        public void contano(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto where ano = @ano", conexao);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.NMF++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.NMM++;
                    }


                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void contmes(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto where ano = @ano and mes = @mes", conexao);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.NMFm++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.NMMm++;
                    }


                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void contdia(morto pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_Morto where ano = @ano and mes = @mes and dia = @dia", conexao);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                comando.Parameters.AddWithValue("@dia", pessoa.dia);
                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.NMFd++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.NMMd++;
                    }


                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable mostrarano(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_morto where ano like '%" + valor + "%' ORDER BY _nome ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable mostrarmes(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_morto where ano = @ano and mes = @mes ORDER BY _nome", conexao);
                comando.Parameters.AddWithValue("@ano", DadosEditar.EditarDados.anom);
                comando.Parameters.AddWithValue("@mes", valor);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable mostrardia(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_morto where ano = @ano and mes = @mes and dia = @dia ORDER BY _nome", conexao);
                comando.Parameters.AddWithValue("@ano", DadosEditar.EditarDados.anom);
                comando.Parameters.AddWithValue("@mes", DadosEditar.EditarDados.mesm);
                comando.Parameters.AddWithValue("@dia", valor);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void contanos(mortoSem pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_Morto where ano = @ano", conexao);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.NMFs++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.NMMs++;
                    }


                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void contmess(mortoSem pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_Morto where ano = @ano and mes = @mes", conexao);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.NMFms++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.NMMms++;
                    }


                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void contdias(mortoSem pessoa)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_Morto where ano = @ano and mes = @mes and dia = @dia", conexao);
                comando.Parameters.AddWithValue("@ano", pessoa.ano);
                comando.Parameters.AddWithValue("@mes", pessoa.mes);
                comando.Parameters.AddWithValue("@dia", pessoa.dia);
                var registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    if (registro["_sexo"].ToString() == "Femenino")
                    {
                        DadosEditar.EditarDados.NMFds++;
                    }
                    if (registro["_sexo"].ToString() == "Masculino")
                    {
                        DadosEditar.EditarDados.NMMds++;
                    }


                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable mostraranos(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_morto where ano like '%" + valor + "%' ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable mostrarmess(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_morto where ano = @ano and mes = @mes ", conexao);
                comando.Parameters.AddWithValue("@ano", DadosEditar.EditarDados.anoms);
                comando.Parameters.AddWithValue("@mes", valor);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable mostrardias(string valor)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM tbl_sem_morto where ano = @ano and mes = @mes and dia = @dia ", conexao);
                comando.Parameters.AddWithValue("@ano", DadosEditar.EditarDados.anoms);
                comando.Parameters.AddWithValue("@mes", DadosEditar.EditarDados.mesms);
                comando.Parameters.AddWithValue("@dia", valor);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        #endregion
    }
}
