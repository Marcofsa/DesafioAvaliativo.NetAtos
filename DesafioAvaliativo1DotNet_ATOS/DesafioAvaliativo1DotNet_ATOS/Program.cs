using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace DesafioAvaliativo1DotNet_ATOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nome, telefone;
                string cidade, id;
                string cpf;
                string linha;
                string[] linhaDados;
                Pessoa pessoa;

                List<string> alunos = new List<string>();
                StreamReader leitor = new StreamReader(@"C:\DesafiosAvaliativosAcademia_Atos.Net\DesafioAvaliativo.NetAtos\desafio1 apoio.txt");
                do
                {
                    linha = leitor.ReadLine();
                    linhaDados = linha.Split("-");
                   

                } while (!leitor.EndOfStream);                             
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            finally
            {
                Console.WriteLine("Finalizando bloco.");
            }
        }
    }
}