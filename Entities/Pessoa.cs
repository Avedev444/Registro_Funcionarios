using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Registro_Funcionarios.Entities
{

    public class Pessoa
    {
        //propriedades (setters e getters)
        //set -> entrada de dados (atribuição)
        //get -> saída de dados (retorno)
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
