using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMortuaria.DadosEditar
{
    static class EditarDados
    {
        public static bool v;
        public static int v1;
        public static int v2;
        // Dados do Morto
        public static string id_morto;
        public static string _nomeM;
        public static string _nbiM;
        public static string _naturalM;
        public static string _provinciaM;
        public static string _sexoM;
        public static string _estadocivilM;
        public static string _datanascimentoM;
        public static string _datamorteM;
        public static string _imgmortoM;
        // Dados do Pais
        public static int id_pais;
        public static string _nomePai;
        public static string _nomeMae;
        // Dados da Esposa 
        public static string _nomeEs;
        public static int id_esposo1;
        // Dados dos filhos
        public static int _codigo;
        // Dados da Causa da Morte
        public static int id_causamorte;
        public static string _local_morte;
        public static string _causa_morte;
        public static string _descr_morte;
        public static string _id_morto;
        // Dados Funcionário
        public static string id_fun;
        public static string _nomeF;
        public static string _nbiF;
        public static string _emailF;
        public static string _telefoneF;
        public static string _senhaF;
        public static string _sexoF;
        public static string _dataF;
        public static string _papelF;
        public static string _imgF;
        // pegar morto 
        public static string nbi_morto;
        public static int id_PEFC;
        public static string nbi_conf;
        public static string nome_conf;
        // Comfirmar Funcionários
        public static string nbi_fun;
        public static string nbi_conf_fu;
        public static string nomeconf;
        //lOGIN Funcionário
        public static int id_flong;
        public static string nome_flong;
        public static string emailflong;
        public static string senhaFlong;
        public static string papelflong;
        public static string imgFlong;
        public static string emailconf;
        public static string senhaconf;
        //Dados do Graficos 
        public static int nF;
        public static int nM;
        public static int nFs;
        public static int nMs;
        //Reciclagem
        public static int IdMrec;
        public static int MostF;
        public static int id_MPE;
        public static int totalM;
        public static int totalMs;
        public static int NMM;
        public static int NMF;
        public static int NMMm;
        public static int NMFm;
        public static int NMMd;
        public static int NMFd;

        public static int NMMs;
        public static int NMFs;
        public static int NMMms;
        public static int NMFms;
        public static int NMMds;
        public static int NMFds;
        //tabela Para ADMin
        public static string anom;
        public static string mesm;

        public static string anoms;
        public static string mesms;

    }
}

