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
        internal static object mostraAluno;

        public string matricula { get; set; }
        public string codCurso { get; set; }
        public string nomeCurso { get; set; }
        public void mostraAlunos()
        {
            Console.WriteLine("||------------------------------------------------------------------------------------------------------------||");
            Console.WriteLine(nome + " " + Fone + " " + Cidade + " " + Rg + " " + Cpf);
            Console.WriteLine(matricula+ " " + codCurso+ " " + nomeCurso);
            Console.WriteLine("||------------------------------------------------------------------------------------------------------------||");
        }
    }

}

   

