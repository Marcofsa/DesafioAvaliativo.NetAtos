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
        public string nome { get; set; }
        public string Fone { get; set; }
        public string Cidade { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public void mostraDados()
        {
            Console.WriteLine("||------------------------------------------------------------------------------------------------------------||");
            Console.WriteLine(nome + " " + Fone + " " + Cidade + " "+ Rg + " " + Cpf);
            Console.WriteLine("||------------------------------------------------------------------------------------------------------------||");
        }
    }
}
