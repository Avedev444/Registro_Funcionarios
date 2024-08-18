using Registro_Funcionarios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Funcionarios.Repositories
{
    /// Classe abstrata para repositorio de funcionários
    public abstract class FuncionarioRepositoryAbstract
    {
        //Método para exportar os dados de um funcionário
        /// <param name="funcionario">Objeto da entidade Funcionario</param>
        public abstract void ExportarDados(Funcionario funcionario);
    }
}
