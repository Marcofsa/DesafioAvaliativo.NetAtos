using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace DesafioAvaliativo1DotNet_ATOS
{
    internal class Aluno : Pessoa
    {
        public string matricula { get; set; }
        public string codCurso { get; set; }
        public string nomeCurso { get; set; }
    }

    //List<Aluno> listAlunos = new List<Aluno>();

   
}