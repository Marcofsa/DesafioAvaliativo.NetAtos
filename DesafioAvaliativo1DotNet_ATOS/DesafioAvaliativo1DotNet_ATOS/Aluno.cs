using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesafioAvaliativo1DotNet_ATOS
{
    internal class Aluno : Pessoa
    {
        public Aluno(string aluno, string telefone, string cidade, string id, string cpf) : base(aluno, telefone, cidade, id, cpf)
        {

        }
    }
}
