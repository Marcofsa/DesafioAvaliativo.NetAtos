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
                string linha;
                string[] linhaDados;

                List<Aluno> listAlunos = new List<Aluno>();
                List<Pessoa> listPessoas = new List<Pessoa>();

                StreamReader leitor = new StreamReader(@"C:\DesafiosAvaliativosAcademia_Atos.Net\DesafioAvaliativo.NetAtos\desafio1 apoio.txt");
                List<string> listaLinhasArquivo = new List<string>();

                linha = leitor.ReadLine();
             
                while (linha != null)
                {
                    listaLinhasArquivo.Add(linha);  
                    linha = leitor.ReadLine();
                } 
                leitor.Close();

                for (int i = 0; i < listaLinhasArquivo.Count; i++)
                {
                    Pessoa pessoa = new Pessoa();
                    Aluno aluno = new Aluno();
                    if (listaLinhasArquivo[i] != null)
                    {
                        linhaDados = listaLinhasArquivo[i].Split("-"); 
                        if (!linhaDados[0].Equals("X"))
                        {
                            if (linhaDados[0].Equals("Z"))
                            {
                                if( i+1 < listaLinhasArquivo.Count)
                                {
                                    var linhaDadosProximo = listaLinhasArquivo[i+1].Split("-");
                                    if (linhaDadosProximo[0].Equals("Z"))
                                    {
                                        pessoa.nome = linhaDados[1];
                                        pessoa.Fone = linhaDados[2];
                                        pessoa.Cidade = linhaDados[3];
                                        pessoa.Rg = linhaDados[4];
                                        pessoa.Cpf = linhaDados[5];

                                        listPessoas.Add(pessoa);
                                    }
                                    else
                                    {
                                        aluno.nome = linhaDados[1];
                                        aluno.Fone = linhaDados[2];
                                        aluno.Cidade = linhaDados[3];
                                        aluno.Rg = linhaDados[4];
                                        aluno.Cpf = linhaDados[5];

                                        aluno.matricula = linhaDadosProximo[1];
                                        aluno.codCurso = linhaDadosProximo[2];
                                        aluno.nomeCurso = linhaDadosProximo[3];

                                        listAlunos.Add(aluno);          
                                    }
                                }
                                else
                                {
                                    pessoa.nome = linhaDados[1];
                                    pessoa.Fone = linhaDados[2];
                                    pessoa.Cidade = linhaDados[3];
                                    pessoa.Rg = linhaDados[4];
                                    pessoa.Cpf = linhaDados[5];

                                    listPessoas.Add(pessoa);
                                }
                            }
                        }
                    } 
                }
                Console.WriteLine("MOSTRANDO A QUANTIDADE DE PESSOAS SEM MATRÍCULA:\n " + listPessoas.Count);
                Console.WriteLine("MOSTRANDO ALUNOS MATRICULADOS:\n " + listAlunos.Count);

                foreach (var pessoa in listPessoas)
                {
                    pessoa.mostraDados();
                }
                Console.WriteLine("**----------------------------------------------------------------**");
                foreach(var aluno in listAlunos)
                {
                    aluno.mostraAlunos();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            
            finally
            {
                Console.WriteLine("Finalizando bloco!.");
            }
        }
    }
}