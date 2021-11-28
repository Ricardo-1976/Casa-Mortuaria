using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CasaMortuaria.Dao
{
    public class Conexao
    {
        string conecta = " server=localhost; port=3306; User id=root; database = Bd_CasaMortuaria; password='' ";
        protected MySqlConnection conexao = null;

        // Metodo para conectar no banco de dados

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Metodo para desconectar no banco de dados

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


    }
}
