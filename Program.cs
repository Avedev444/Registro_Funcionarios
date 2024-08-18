using Registro_Funcionarios.Entities;
using Registro_Funcionarios.Repositories;

namespace Registro_Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n CADASTRO DE FUNCINÁRIOS\n");

            //criando uma variável de instância para Funcionario
            Funcionario funcionario = new Funcionario();
            funcionario.Departamento = new Departamento();

            //gerando um ID (chave única) para o funcionario
            funcionario.Id = Guid.NewGuid();

            Console.Write("Nome do funcionário..................:");
            funcionario.Nome = Console.ReadLine()!;

            Console.Write("Data de nascimento do funcionário....:");
            funcionario.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("CPF do funcionário...................:");
            funcionario.CPF = Console.ReadLine()!;

            Console.Write("Matrícula do funcionário.............:");
            funcionario.Matricula = Console.ReadLine()!;

            Console.Write("Dara de Admissão do funcionário......:");
            funcionario.DataAdmissao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\n DADOS DO FUNCIONÁRIO\n");

            Console.WriteLine($"Nome do funcionário..................: {funcionario.Nome}");
            Console.WriteLine($"Data de nascimento do funcionário....: {funcionario.DataNascimento}");
            Console.WriteLine($"CPF do funcionário...................: {funcionario.CPF}");
            Console.WriteLine($"Mátricula do funcionário..............: {funcionario.Matricula}");
            Console.WriteLine($"Data de admissão do funcionário......: {funcionario.DataAdmissao}");

            //criando um objeto da classe abstrata
            //e inicializando-o como vazio (null)
            FuncionarioRepositoryAbstract funcionarioRepository = null;

            Console.Write("\n\nINFORME (XML) ou (JSON).: ");
            var opcao = Console.ReadLine()!.ToUpper();
            switch (opcao)
            {
                case "XML":
                    //POLIMORFISMO
                    funcionarioRepository = new FuncionarioRepositoryXML();
                    break;
                case "JSON":
                    //POLIMORFISMO
                    funcionarioRepository = new FuncionarioRepositoryJSON();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            funcionarioRepository.ExportarDados(funcionario);
            Console.WriteLine("\nARQUIVO GERADO COM SUCESSO!");
            Console.ReadKey();

        }
    }
}
