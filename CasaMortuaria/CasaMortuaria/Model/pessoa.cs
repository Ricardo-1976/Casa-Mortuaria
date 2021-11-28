using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMortuaria.Model
{
    // Metodo para Salvar Usuario
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string _nome { get; set; }
        public string _nbi { get; set; }
        public string _sexo { get; set; }
        public string _data_nascimento { get; set; }
        public string _email { get; set; }
        public string _senha { get; set; }
        public string _telefone { get; set; }
        public string _papel { get; set; }
        public string _img { get; set; }
    }

    // Metodo para Salvar Morto
    public class morto
    {
        public int id_Morto { get; set; }
        public string _nome { get; set; }
        public string _nbi { get; set; }
        public string _natural { get; set; }
        public string _provincia { get; set; }
        public string _sexo { get; set; }
        public string _esta_civil { get; set; }
        public string _data_nascimento { get; set; }
        public string _data_morte { get; set; }
        public string _img_morto { get; set; }
        public string ano { get; set; }
        public string mes { get; set; }
        public string dia { get; set; }
        public string id_Usuario { get; set; }

    }

    // Metodo para Salvar Morto
    public class mortoSem
    {
        public int id_Morto { get; set; }
        public string _sexo { get; set; }
        public string _data_morte { get; set; }
        public string _img_morto { get; set; }
        public string _local_morte { get; set; }
        public string _causa_morte { get; set; }
        public string _descr_morte { get; set; }
        public string ano { get; set; }
        public string mes { get; set; }
        public string dia { get; set; }
        public string id_Usuario { get; set; }

    }

    // Metodo para Salvar os Pais
    public class pais
    {
        public int id_Pais { get; set; }
        public string _nome_pai { get; set; }
        public string _nome_mae { get; set; }
        public string id_Morto { get; set; }
    }

    // Metodo para Salvar Esposso\a
    public class EstadoCivil
    {
        public int id_EstadoCivil { get; set; }
        public string _nome { get; set; }
        public string id_Morto { get; set; }
    }

    // Metodo Para Salvar Filhos
    public class Filhos
    {
        public int id_Filhos { get; set; }
        public string _nome { get; set; }
        public string id_Morto { get; set; }
    }

    // Metodo para Salvar Causa Morte
    public class CausaMorte
    {
        public int id_CausaMorte { get; set; }
        public string _local_morte { get; set; }
        public string _causa_morte { get; set; }
        public string _descr_morte { get; set; }
        public string id_Morto { get; set; }
    }
}

