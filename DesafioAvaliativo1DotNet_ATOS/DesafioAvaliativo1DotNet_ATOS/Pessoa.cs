using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesafioAvaliativo1DotNet_ATOS
{
    internal class Pessoa
    {
        public string nomeAluno { get; set; }
        public string Fone { get; set; }
        public string Cidade { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public Pessoa(string nome, string telefone, string cidade, string id, string cpf)
        {   
            nomeAluno = nome;
            Fone = telefone;
            Cidade = cidade;
            Rg = id;
            Cpf = cpf;
        }
    }
}
