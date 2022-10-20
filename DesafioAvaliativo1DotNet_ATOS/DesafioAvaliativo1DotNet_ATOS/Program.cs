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
                    pessoa = new Pessoa(linhaDados[1], linhaDados[2], linhaDados[3], linhaDados[4], linhaDados[5]);
                    

                } while (!leitor.EndOfStream);
                leitor.Close();
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